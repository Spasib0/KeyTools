using System.Windows.Forms;

namespace KeyCheckGui
{
    public class ResultItem : IResultItem
    {
        public string Id => id;
        private readonly string id;
        public ResultItem(string id)
        {
            this.id = id;
        }

        public void SetViewData(Form view)
        {
            view.Text = Id;
        }

        public override string ToString()
        {
            return Id;
        }
    }
}