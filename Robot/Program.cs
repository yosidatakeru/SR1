using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlyingRobot flyingRobot = new FlyingRobot("空飛ぶロボ");

            Console.WriteLine("名前:{0}", flyingRobot.GetName());
            Console.WriteLine("電源：{0}", flyingRobot.GetPowerStatus());

            flyingRobot.DropBomb();

            flyingRobot.PowerOn();

            flyingRobot.DropBomb();

            flyingRobot.PowerOff();

            Console.WriteLine("___________________");

            TankRobot tankRobot = new TankRobot("タンクロボ");

            Console.WriteLine("名前:{0}", tankRobot.GetName());
            Console.WriteLine("電源：{0}", tankRobot.GetPowerStatus());

            tankRobot.ShootCannon();

            tankRobot.PowerOn();

            tankRobot.ShootCannon();

            tankRobot.PowerOff();

            Console.WriteLine("___________________");

            TankRobot[] tanks = new TankRobot[5];//配列を作る

            //タンク5タイ分作る
            for (int i = 0; i < tanks.Length; i++)
            {
                tanks[i] = new TankRobot("タンクNo." + i);
            }

            for (int i = 0; i < tanks.Length; i++)
            {
                tanks[i].PowerOn();
            }

            foreach(TankRobot tank in tanks)
            {
                tank.ShootCannon();
            }

            Console.ReadLine();
        }

    }


}