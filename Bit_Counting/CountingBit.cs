using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Counting;

public class CountingBit
{
    public static int CountBits(int n)
    {
        int counter = 0;
        string BinaryCode = Convert.ToString(n, 2);
        for (int i = 0; i < BinaryCode.Length; i++)
        {
            if (BinaryCode[i] == '1')
            {
                counter++;
            }
        }
        return counter;
    }
}

