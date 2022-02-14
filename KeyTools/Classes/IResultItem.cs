using System.Windows.Forms;

namespace KeyCheckGui
{
    public interface IResultItem
    {
        public void SetViewData(Form view);
        public string ToString();
    }
}