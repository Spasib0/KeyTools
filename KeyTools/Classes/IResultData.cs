using System;
using System.Collections.Generic;

namespace KeyTools.Classes
{
    public interface IResultData
    {
        public Dictionary<string, IResultItem[]> Result { get; }
    }
}