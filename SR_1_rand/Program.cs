using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberGeneration = 10;
            //Listコレクション(入れ物)を作成
            List<int> numbers = new List<int>();
            //乱数発生器の生成
            Random random = new Random(Environment.TickCount);
            

            //中身を10個生成
            for (int i = 0; i < numberGeneration; i++)
            {
                numbers.Add(random.Next(-5, 5+1));
            }
            //中身を確認する
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

          
            Console.ReadLine();
        }
    }
}
