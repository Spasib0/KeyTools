using System.Windows.Forms;

namespace KeyTools.Classes
{
    public interface IResultItem
    {
        public void SetViewData(Form view);
        public string ToString();
    }
}