using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj06_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ロボットクラス
            Robot robot = new Robot("ロボット");
            Console.WriteLine("名前:{0},", robot.GetName());
            robot.Attack();

            ////フライングロボットクラス
            //FlyingRobot flyingRobot = new FlyingRobot("空を飛ぶロボ");
            //Console.WriteLine("名前:{0}", flyingRobot.GetName());
            //flyingRobot.DropBomb();

            FlyingRobot flyingRobot = new FlyingRobot("空を飛ぶロボ");
            Console.WriteLine("名前:{0}", flyingRobot.GetName());
            flyingRobot.Attack();



            //タンクロボット
            //TankRobot tankRobot = new TankRobot("タンクロボット");
            //Console.WriteLine("名前:{0}", tankRobot.GetName());
            //tankRobot.ShoootCannon();

            TankRobot tankRobot = new TankRobot("タンクロボット");
            Console.WriteLine("名前:{0}", tankRobot.GetName());
            tankRobot.Attack();

            Console.ReadLine();
        }
    }
}
