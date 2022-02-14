using System;
using System.Collections.Generic;

namespace KeyCheckGui
{
    public interface IResultData
    {
        public Dictionary<string, IResultItem[]> Result { get; }
    }
}