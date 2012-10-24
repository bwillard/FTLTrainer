using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data
{
    class FTLString : FTLVlaue<String>
    {
        public override byte[] GetBytes()
        {
            byte[] data = new byte[Value.Length + 4];
            Buffer.BlockCopy(BitConverter.GetBytes(Value.Length), 0, data, 0, 4);
            Buffer.BlockCopy(Encoding.UTF8.GetBytes(Value), 0, data, 4, Value.Length);
            return data;
        }

        public override int InitFromBytes(byte[] data, int offset)
        {
            Int32 length = BitConverter.ToInt32(data, offset);
            char[] chars = new char[length];
            Value = Encoding.UTF8.GetString(data, offset + 4, length);
            Console.Out.WriteLine("Read String length: " + length + " Value: "+Value);
            return 4 + length;
        }
    }
}
