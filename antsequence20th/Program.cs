using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            String start = "1";
            int count = 0;
            Console.WriteLine("1번째 수열 : 1");
            for (int i = 2; i <= 20; i++)
            {
                Console.Write(i + "번째 수열 : ");
                String temp = start;
                start = "";
                char num = temp[0];
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] == num)
                    {
                        count++;
                    }
                    else
                    {
                        start += num + "" + count;
                        count = 1;
                        num = temp[j];
                    }
                }
                start += num + "" + count;
                count = 0;
                Console.WriteLine(start);
            }
        }
    }
}
