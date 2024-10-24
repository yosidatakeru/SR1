using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ここで引数に値を入れる
            Player player = new Player("ロト",1);

            Console.WriteLine("名前 : {0}", player.GetName());
            Console.WriteLine("レベル : {0}", player.GetLevel());

            player.Attac();
            
            player.Defense();
            
            player.LevelUp();
            Console.WriteLine("レベル : {0}", player.GetLevel());



            //閉じないようににする
            Console.ReadLine();
        }
    }
}
