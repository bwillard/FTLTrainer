using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data
{
    public abstract class FTLVlaue<T> : IFTLVlaue
    {
        protected FTLVlaue(String name)
        {
            Name = name;
        }
        public T Value { get; set; }

        public String Name { get; private set; }

        public abstract byte[] GetBytes();
        public abstract int InitFromBytes(byte[] data, int offset);
    }
}
