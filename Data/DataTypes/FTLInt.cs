using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace FTLTrainer.Data
{
    class FTLInt : FTLVlaue<Int32>
    {
        public override byte[] GetBytes()
        {
            return BitConverter.GetBytes(Value);
        }
        
        public override int InitFromBytes(byte[] data, int offset)
        {
            Value = BitConverter.ToInt32(data, offset);
            Console.Out.WriteLine("Read int: " + Value);
            return 4;
        }
    }
}
