using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data
{
    interface IFTLVlaue
    {
        byte[] GetBytes();
        int InitFromBytes(byte[] data, int offset);
    }
}
