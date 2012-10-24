using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data
{
    class FTLArray<T> : FTLVlaue<List<T>> where T : IFTLVlaue, new()
    {
        public int length {get;set;}
        public List<T> values { get; set; }

        public override byte[] GetBytes()
        {
            List<byte> data = new List<byte>();
            data.AddRange(BitConverter.GetBytes(length));
            foreach(T value in values)
            {
                data.AddRange(value.GetBytes());
            }

            return data.ToArray();
        }

        public override int InitFromBytes(byte[] data, int offset)
        {
            int bytesRead = 4;
            length = BitConverter.ToInt32(data, offset);
            values = new List<T>(length);
            for (int i = 0; i < length; i++)
            {
                T value = new T();
                bytesRead += value.InitFromBytes(data, offset + bytesRead);
                values.Add(value);
            }
            return bytesRead;
        }
    }
}
