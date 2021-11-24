using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperations
{
    internal class Memoria
    {
        int x, y;
        int total = 0;
        byte a, b, totalB;

        public string AND (string input1, string input2)
        {
            x = Convert.ToInt32(input1);
            y = Convert.ToInt32(input2);
            total = x & y;
            return total.ToString();
        }
        public string OR(string input1, string input2)
        {
            x = Convert.ToInt32(input1);
            y = Convert.ToInt32(input2);
            total = x | y;
            return total.ToString();
        }
        public string XOR(string input1, string input2)
        {
            x = Convert.ToInt32(input1);
            y = Convert.ToInt32(input2);
            total = x ^ y;
            return total.ToString();
        }
        public string NOT(string input1, string input2)
        {
            a = Convert.ToByte(input1);
            b = Convert.ToByte(input2);
            totalB = (byte)~b;
            return totalB.ToString();
        }
        public string RShift(string input1, string input2)
        {

            a = Convert.ToByte(input1);
            b = Convert.ToByte(input2);
            totalB = (byte)(a >> y);
            return total.ToString();
        }

        public string LShift(string input1, string input2)
        {
            a = Convert.ToByte(input1);
            b = Convert.ToByte(input2);
            totalB = (byte)(a << b);
            return totalB.ToString();
        }

    }
}
