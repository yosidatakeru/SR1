using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj08
{
    internal class TankRobot : Robot
    {
        //メソッド
        //コンストラクタ
        public TankRobot(string name) : base(name)
        { 
        
        }

        //public void ShoootCannon()
        //{
        //    Console.WriteLine("{0}は,キャノン砲を撃った!", name);
        //}

        //override派生クラスのメソッドにつける
        //override して利用する
        public override void Attack()
        {
            Console.WriteLine("{0}は,キャノン砲を撃った!", name);
        }

    }
}
