using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 不重複樂透
{
    class Program
    {
        static void Main(string[] args)
        {
            //改字的顏色
            Console.ForegroundColor = ConsoleColor.Green;
            // 建立一個空的List
            List<int> number = new List<int>();

            // 在List裡放入1~42的數字       
            for (int i = 1; i < 43; i++)
            {
                number.Add(i);
            }

            // 產生亂數物件
            Random rand = new Random();
            Console.WriteLine("┌──── 大樂透開獎時間────┐");
            for (int i = 0; i < 6; i++)
            {
                // 挑選"剩下的"其中一個印出
                int r = rand.Next(1, number.Count);
                Console.Write("│           " + number[r] + " "+ "         │" + "\n");

                // 從List中刪除
                number.RemoveAt(r);
            }
            Console.WriteLine("\n" + "└───────────────────────┘");
            Console.WriteLine("[請按Enter進行下一次開獎]          靠北工程師");

            // 暫停畫面
            Console.Read();
        }
    }
}
