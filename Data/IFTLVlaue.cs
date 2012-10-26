using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data
{
    public interface IFTLVlaue
    {
        byte[] GetBytes();
        int InitFromBytes(byte[] data, int offset);
        String Name { get;}
    }
}
