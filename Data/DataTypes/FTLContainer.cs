using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data.DataTypes
{
    public abstract class FTLContainer : IFTLVlaue
    {
        protected FTLContainer()
        {
            Name = this.GetType().Name;
        }

        protected FTLContainer(String name)
        {
            Name = name;
        }

        protected abstract IEnumerable<IFTLVlaue> GetValues();

        public IEnumerable<IFTLVlaue> Values
        {
            get
            {
                return GetValues();
            }
        }

        public String Name { get; private set; }

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
