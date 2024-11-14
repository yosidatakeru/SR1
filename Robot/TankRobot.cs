using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    
    internal class TankRobot : Robot
    {
        public TankRobot(string name)
        {
            this.name = name;
        }
        public void ShootCannon()
        {
            if (powerStatus)
            {
                Console.WriteLine("{0}は,キャノン砲を打った!", name);
            }
            else
            {
                Console.WriteLine("{0}は、電源をoffなのでキャノン砲は使えません", name);
            }

        }
    }
}
