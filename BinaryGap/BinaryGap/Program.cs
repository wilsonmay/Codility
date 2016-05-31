using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Interger (1 to 2147483647):");
            int value = int.Parse(Console.ReadLine());
            int loop = 0;
            if (value > 0 || value < 2147483647)
            {
                Program p = new Program();
                Console.WriteLine(value + " convert to binary => " + Convert.ToString(value, 2));
                Console.WriteLine(p.BinaryGapLength(value,out loop));
                Console.WriteLine("No of Loops: " + loop);
            }
            else
            {
                Console.WriteLine("Value out of the range of Integer!!!");
            }
            
        }

        //private int BinaryGapLength(int value,out int loop)
        //{
        //    int index = 0;
        //    int BinaryGapLength=0;
        //    int BinaryGapMax = 0;
        //    loop = 0;
        //    string conValue = Convert.ToString(value,2);

        //    do
        //    {
        //        index = conValue.IndexOf("10");
        //        conValue = conValue.Remove(0, index + 1);
        //        BinaryGapLength = conValue.IndexOf("01")+1;
        //        conValue = conValue.Remove(0, BinaryGapLength);
        //        BinaryGapMax = Math.Max(BinaryGapMax, BinaryGapLength);
        //        loop++;
        //    } while (conValue.IndexOf("10") != -1);

        //    return BinaryGapMax;
        //}
        private int BinaryGapLength(int value, out int loop)
        {
            int index = 0;
            int BinaryGapLength = 0;
            int BinaryGapMax = 0;
            loop = 0;
            string conValue = Convert.ToString(value, 2);

            for (;conValue.IndexOf("10") != -1;)
            {
                index = conValue.IndexOf("10");
                conValue = conValue.Remove(0, index + 1);
                BinaryGapLength = conValue.IndexOf("01") + 1;
                BinaryGapMax = Math.Max(BinaryGapMax, BinaryGapLength);

            }

            return BinaryGapMax;
        }
    }
}
