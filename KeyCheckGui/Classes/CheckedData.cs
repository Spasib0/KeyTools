using System;
using System.Collections.Generic;

namespace KeyCheckGui
{
    public abstract class CheckedData : IResultData
    {
        public abstract Dictionary<string, IResultItem[]> Result { get; }
    }
}