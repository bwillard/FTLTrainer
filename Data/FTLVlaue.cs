using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data
{
    abstract class FTLVlaue<T> : IFTLVlaue
    {
        public T Value { get; protected set; }

        public abstract byte[] GetBytes();
        public abstract int InitFromBytes(byte[] data, int offset);
    }
}
