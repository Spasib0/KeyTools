using System.Diagnostics;
using System.IO;


namespace KeyTools.Classes
{
    public class Logger
    {
        private string _data;
        private string _path;
        public Logger(string name)
        {
            _path = $"{Directory.GetCurrentDirectory()}\\{name}.txt";
            _data = "";
        }

        public void Add(string data)
        {
            _data += data;
        }

        public void Save()
        {
            using (StreamWriter sw = File.CreateText(_path))
            {
                sw.Write(_data);
            }

            _data = "";
        }

        public void Open()
        {
            Process.Start("notepad.exe", _path);
        }
    }
}
