using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Robot
    {
        protected string name = "";//初期値は""
        protected bool powerStatus = false;//初期値はfalse

        //メソッド
        //電源をOn にする
        public void PowerOn()
        {
            powerStatus = true;
            Console.WriteLine("{0}は、起動した!!", name);
        }

        //電源をOffにする
        public void PowerOff()
        {
            powerStatus = false;
            Console.WriteLine("{0}は、停止した,,", name);

        }

        //名前を取得
        public string GetName()
        {
            return name;
        }

        //電源On様態を取得する
        public bool GetPowerStatus()
        {
            return powerStatus;
        }
    }
}
