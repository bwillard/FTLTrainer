using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTLTrainer.Data.DataTypes;

namespace FTLTrainer.Data.DataTypes
{
    class FTLArray : FTLVlaue<List<IFTLVlaue>>
    {
        private Func<IFTLVlaue> creationFunction;
        public FTLArray(String name, Func<IFTLVlaue> creationFunction) : base(name)
        {
            this.creationFunction = creationFunction;
        }

        public int length {get;set;}
        public List<IFTLVlaue> Values { get; set; }

        public override byte[] GetBytes()
        {
            List<byte> data = new List<byte>();
            data.AddRange(BitConverter.GetBytes(length));
            foreach (IFTLVlaue value in Values)
            {
                data.AddRange(value.GetBytes());
            }

            return data.ToArray();
        }

        public override int InitFromBytes(byte[] data, int offset)
        {
            int bytesRead = 4;
            length = BitConverter.ToInt32(data, offset);
            Values = new List<IFTLVlaue>(length);
            for (int i = 0; i < length; i++)
            {
                IFTLVlaue value = creationFunction();
                bytesRead += value.InitFromBytes(data, offset + bytesRead);
                Values.Add(value);
            }
            return bytesRead;
        }
    }
}
