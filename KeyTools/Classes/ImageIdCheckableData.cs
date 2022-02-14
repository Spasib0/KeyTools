using KeyCheckGui.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace KeyCheckGui
{
    internal class ImageIdCheckableData : CheckableData
    {
        private string checkButtonText => string.Format("Id's for check. Count: {0}", DataView.checkableDataList.Lines.Length);
        private string dataListPlaceholderText => "example_0\nexample_1.svg\nexample_2.png";

        private IResultData data;


        public ImageIdCheckableData(KeyTools dataView) : base(dataView) { }

        public override void SetViewData()
        {
            UpdateCheckableGroup();
        }

        public override void Check()
        {
            data = DataView.Content.GetImagesUsage(DataView.checkableDataList.Lines);
            var checkedImagesIdsDialog = new CheckedImagesIdsDialog(data);
            checkedImagesIdsDialog.Show();
            //DataView.resultTypeBox.DataSource = data.Result.Keys.ToList();
            //DataView.resultTypeBox.SelectedIndexChanged += UpdateResultList;
        }

        private void UpdateCheckableGroup()
        {
            DataView.checkableDataList.PlaceholderText = dataListPlaceholderText;
            DataView.checkableDataList.TextChanged += OnCheckableDataChanged;
            DataView.loadFromJsonButton.Click += LoadFromJsonButton_Click;
        }

        private void LoadFromJsonButton_Click(object sender, EventArgs e)
        {
            GetDataFromJson();
        }


        internal void UpdateCheckButton()
        {
            DataView.checkDataButton.Text = checkButtonText;
        }

        private void OnCheckableDataChanged(object sender, EventArgs e)
        {
            UpdateCheckButton();
        }





        private void GetDataFromJson()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\Buka12\\AppData\\LocalLow\\Scientific Entertainment\\SchoolDrozdovMaster\\image";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        DataView.checkableDataList.Lines = JsonSerializer.Deserialize<PicturesJson>(fileContent).Dictionary.Keys.ToArray();
                    }
                }
            }
        }

        private class PicturesJson
        {
            public Dictionary<string, int> Dictionary { get; set; }
        }
    }
}