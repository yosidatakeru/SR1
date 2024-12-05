using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj08
{
    internal class Robot
    {
        //フィールド
        protected string name;

        //メソッド
        //コンストラクタ
        public Robot(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        //virtual 基本クラスのメソッドにつける
        //必要ならoverrideしていい
        public virtual void Attack()
        {
            Console.WriteLine("{0}は,攻撃した!", name);
        }
    }
}
