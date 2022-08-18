using System;
using System.Collections.Generic;

namespace KeyTools.Classes
{
    public abstract class CheckedData : IResultData
    {
        public abstract Dictionary<string, IResultItem[]> Result { get; }
    }
}