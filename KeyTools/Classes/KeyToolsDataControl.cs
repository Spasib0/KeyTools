using KeyCheckGui.Dialogs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KeyCheckGui
{
    public class KeyToolsDataControl
    {
        public UserHardware SelectedHardware => gridAdapter.Selected;
        public Content Content { get => content; }
        private readonly KeyTools controlData;
        private UserHardware[] hardwares;
        private readonly HardwareGridAdapter gridAdapter;
        private ICheckableData dataForCheck;
        private Content content;

        private string devicesCountText => string.Format("Devices  [{0}]", controlData.devicesGridView.RowCount);
        private string serverTestsCountText => string.Format("Tests count: {0}", content.TestsCount);
        private string serverFactsCountText => string.Format("Facts count: {0}", content.FactsCount);
        private string serverImagesCountText => string.Format("Images count: {0}", content.ImagesCount);
        private string deviceDataText => string.Format("Data [{1}]", SelectedHardware.id, content.DataCount);

        public KeyToolsDataControl(KeyTools data)
        {
            controlData = data;
            gridAdapter = new HardwareGridAdapter(controlData.devicesGridView);
            SetEvents();
        }

        public void UpdateDevices(UserHardware[] hardwares)
        {
            this.hardwares = hardwares;
            FillDevices();
            SetEnabled(true);
        }

        public void Clear()
        {
            SetEnabled(false);
        }

        public void ClearDevices()
        {
            gridAdapter.Clear();
        }

        private void SetEnabled(bool state)
        {
            controlData.tabControl.TabPages[0].Text = devicesCountText;
            controlData.tabControl.Enabled = state;
            SetCheckableDataTabState(state);
        }

        private void SetCheckableDataTabState(bool state)
        {
            (controlData.tabControl.TabPages[2] as Control).Enabled = state;
            controlData.checkDataTypeBox.DataSource = Enum.GetValues(typeof(CheckableDataType));
        }

        private void FillDevices()
        {
            gridAdapter.SetData(hardwares, SetDeviceInfo);
        }

        private void SetDeviceInfo(UserHardware hardware)
        {
            controlData.elementInfo.Text = "ID:" + hardware.deviceId.ToString();
            controlData.deviceIdInfo.Text = hardware.id;
            controlData.modelInfo.Text = hardware.deviceModel;
            controlData.deviceNameInfo.Text = hardware.deviceName;
            controlData.deviceTypeInfo.Text = hardware.deviceType;
            controlData.osInfo.Text = hardware.operatingSystem;
            controlData.ramInfo.Text = hardware.systemMemorySize;
            controlData.processorInfo.Text = hardware.processorType;
            controlData.graphicsNameInfo.Text = hardware.graphicsDeviceName;
            controlData.graphicsSizeInfo.Text = hardware.graphicsMemorySize;
            controlData.graphicsVersionInfo.Text = hardware.graphicsDeviceVersion;
            //controlData.productBox.SelectedIndex = controlData.productBox.FindString(hardware.product);
            controlData.productBox.SelectedIndex = controlData.productBox.Items.IndexOf(SelectedHardware.product);
        }

        private void UpdateLabels()
        {
            controlData.serverTestsLabel.Text = serverTestsCountText;
            controlData.serverFactsLabel.Text = serverFactsCountText;
            controlData.imagesCountLabel.Text = serverImagesCountText;
            controlData.tabControl.TabPages[2].Text = deviceDataText;
        }

        private void SetEvents()
        {
            controlData.loadDataButton.Click += OnLoadDataButton_Click;
            controlData.checkDataButton.Click += OnCheckData_Click;
            controlData.checkDataTypeBox.SelectedIndexChanged += OnChekDataTypeBox_SelectedIndexChanged;
        }



        private void OnLoadDataButton_Click(object sender, EventArgs e)
        {
            StatisticsProduct[] products = new StatisticsProduct[] { StatisticsProduct.cards_app_school, StatisticsProduct.logopedia }; //Enum.GetValues(typeof(StatisticsProduct)).Cast<StatisticsProduct>().ToArray();
            controlData.SetSelectedDeviceToken();
            content = new Content(products, controlData.GetRequest);
            //Dictionary<StatisticsProduct, Content.ProductContent> keyValuePairs = content.items; //todo вкл/выкл доступные продукты (а потом объеденение)
            UpdateLabels();
        }

        private void OnChekDataTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataForCheck = Setup(controlData, (CheckableDataType) controlData.checkDataTypeBox.SelectedItem);
        }


        public ICheckableData Setup(KeyTools dataView, CheckableDataType type) { 
            switch (type)
            {
                case CheckableDataType.ImageId:
                    return new ImageIdCheckableData(dataView);                    
                default:
                    return null;
            }
        }


        private void OnCheckData_Click(object sender, EventArgs e)
        {

            //todo ???

            dataForCheck.Check();
            //var checkedDialog = new CheckedImagesDialog(result, content.GetImageLink, content.GetPngImage);
            //checkedDialog.Show();
            //controlData.resultList.Lines = result.Result["Used images"];
            //controlData.resultGroup.Enabled = true;
            //controlData.SetSelectedDeviceToken(gridAdapter.Selected.token);
        }
    }
}