using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int robotGeneration = 15;

            List<Robot> robots = new List<Robot>();
            //乱数発生器の生成
            Random random = new Random(Environment.TickCount);

            for (int i = 0; i < robotGeneration; i++)
            {
                int robtoSpawn = random.Next(1, 2 + 1);

                if (robtoSpawn == 1)
                {
                    robots.Add(new TankRobot("タンクロボ"));
                }
                else
                {
                    robots.Add(new FlyingRobot("空中ロボ"));
                }
            }

            //攻撃しまくる
            foreach(Robot robot in robots)
            {
                robot.Attack();
            }
            //閉じないようににする
            Console.ReadLine();


          

        }
    }
}
