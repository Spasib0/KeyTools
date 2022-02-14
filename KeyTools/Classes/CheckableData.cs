using System;
using System.Windows.Forms;

namespace KeyCheckGui
{
    abstract class CheckableData : ICheckableData
    {
        protected KeyTools DataView => dataView;

        private KeyTools dataView;
        protected CheckableData(KeyTools dataView)
        {
            this.dataView = dataView;
            SetViewData();
        }


        public abstract void SetViewData();


        public abstract void Check();
    }

    public enum CheckableDataType
    {
        ImageId = 1
    }
}