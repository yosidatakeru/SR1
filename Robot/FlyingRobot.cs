using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class FlyingRobot : Robot
    {
        public FlyingRobot(string name)
        {
            this.name = name;
        }
        public void DropBomb()
        {
            if (powerStatus)
            {
                Console.WriteLine("{0}は,爆弾を落とした!", name);
            }
            else
            {
                Console.WriteLine("{0}は、電源をoffなので爆弾投下は使えない",name);
            }

        }
    }
}
