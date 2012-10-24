using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data
{
    class FTLRemainder : FTLVlaue<byte[]>
    {
        public override byte[] GetBytes()
        {
            return Value;
        }

        public override int InitFromBytes(byte[] data, int offset)
        {
            int length = data.Length - offset;
            Value = new byte[length];
            Buffer.BlockCopy(data, offset, Value, 0, length);
            return length;
        }
    }
}
