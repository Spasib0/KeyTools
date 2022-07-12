using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KeyCheckGui
{
    public class HardwareGridAdapter
    {
        private DataGridView gridView;
        private UserHardware[] hardwares;
        //private GridHardware[] gridHardwares;
        private Action<UserHardware> onSelect;

        public UserHardware Selected => hardwares.FirstOrDefault(item => item.id.Equals(gridView.SelectedRows[0].Cells[0].Value));

        public HardwareGridAdapter(DataGridView gridView)
        {
            this.gridView = gridView;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "HardwareId";
            idColumn.Width = 280;
            idColumn.ReadOnly = true;

            DataGridViewComboBoxColumn productsColumn = new DataGridViewComboBoxColumn();
            productsColumn.Name = "Products";
            productsColumn.Width = 130;

            gridView.Columns.AddRange(idColumn, productsColumn);
        }

        public void SetData(UserHardware[] hardwares, Action<UserHardware> onSelect)
        {
            this.onSelect = onSelect;
            this.hardwares = hardwares;
            SetGridView(hardwares);
        }

        private void SetGridView(UserHardware[] data)
        {
            
            SetHardwaresData(data);



            gridView.CellClick += new DataGridViewCellEventHandler(OnClickCell);
            gridView.RowStateChanged += GridView_RowStateChanged;
            onSelect(Selected);
        }

        private void SetHardwaresData(UserHardware[] data)
        {
            foreach(var hardware in GetGridHardwares(data))
            {
                int row = gridView.Rows.Add(hardware.Id, hardware.Product);
                (gridView[1, row] as DataGridViewComboBoxCell).Items.AddRange(hardware.GetProducts());
            }
        }

        public void Clear()
        {
            gridView.Rows.Clear();
        }

        private void ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            var curentCell = gridView.CurrentCell as DataGridViewComboBoxCell;
            int index = gridView.CurrentCell.RowIndex;

            if(curentCell != null)
                curentCell.Value = curentCell.EditedFormattedValue;

            gridView.ClearSelection();
            gridView[0, index].Selected = true;
        }

        private void GridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if(e.StateChanged == DataGridViewElementStates.Selected && e.Row.Index > 0)
            {
                SelectHardware(e.Row.Index);
            }
        }

        private void SelectHardware(int rowIndex)
        {
            var product = gridView.Rows[rowIndex].Cells["Products"].FormattedValue;
            var hardwareId = gridView.Rows[rowIndex].Cells["HardwareId"].Value;
            UserHardware hardware = hardwares.FirstOrDefault(item => item.id.Equals(hardwareId) && item.product.Equals(product));
            onSelect(hardware);
        }

        private void OnClickCell(object sender, DataGridViewCellEventArgs e)
        {
            if (gridView.EditingControl is DataGridViewComboBoxEditingControl editingControl)
            {
                editingControl.DroppedDown = true;
                editingControl.DropDownClosed += ComboBox_DropDownClosed;
            }
        }

        private GridHardware[] GetGridHardwares(UserHardware[] data)
        {
            var ids = data.Select(item => item.id).Distinct().ToArray();
            return ids.Select(id => new GridHardware(id, data.Where(item => item.id == id).Select(item => item.product).ToArray())).ToArray();
        }

        private class GridHardware
        {
            public string Id;
            public string Product => products[0];
            private string[] products;

            public GridHardware(string hardwareId, string[] products)
            {
                Id = hardwareId;
                this.products = products;
            }

            public string[] GetProducts()
            {
                return products;
            }
        }
    }
}

