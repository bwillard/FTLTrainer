using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data
{
    abstract class FTLContainer : IFTLVlaue
    {
        protected abstract IEnumerable<IFTLVlaue> GetValues();

        public byte[] GetBytes() 
        {
            List<byte> data = new List<byte>();
            foreach (IFTLVlaue value in GetValues())
            {
                data.AddRange(value.GetBytes());
            }
            return data.ToArray();
        }
        public int InitFromBytes(byte[] data, int offset)
        {
            int consumed = 0;
            foreach (IFTLVlaue value in GetValues())
            {
                consumed += value.InitFromBytes(data, offset + consumed);
            }
            return consumed;
        }
    }
}
