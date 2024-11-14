using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj06_2
{
    internal class FlyingRobot : Robot
    {
        //メソッド
        //コンストラクタ
        public FlyingRobot(string name) : base(name)
        { 
        
        }

        //爆弾を落とす
        //public void DropBom()
        //{
        //    Console.WriteLine("{0}は,爆弾を落とした!", name);
        //}

        //override派生クラスのメソッドにつける
        //override して利用する
        public override void Attack()
        {
            Console.WriteLine("{0}は,爆弾を落とした!", name);
        }

    }
}
