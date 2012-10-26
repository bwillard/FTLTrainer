using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data
{
    class FTLByteArray : FTLVlaue<byte[]>
    {
        private int length;
        public FTLByteArray(String name, int length) : base(name)
        {
            this.length = length;
            Value = new byte[length];
        }

        public override byte[] GetBytes()
        {
            return Value;
        }

        public override int InitFromBytes(byte[] data, int offset)
        {
            Buffer.BlockCopy(data, offset, Value, 0, length);
            return length;
        }
    }
}
