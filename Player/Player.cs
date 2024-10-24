using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    internal class Player
    {
        private string name;
        private int level;

        //コンストラクタ
        public Player(string name, int lever)
        {
            this.name = name;
            this.level = lever;
        }
        //攻撃
        public void Attac()
        {
            Console.WriteLine("攻撃");
        }
      
        //防御
        public void Defense()
        {
            Console.WriteLine("防御した");
        }

        //レベルアップ
        public void LevelUp()
        {
            level++;
        }

        //名前を聞く
        public string GetName()
        {
            return name;
        }

        //レベルを聞く
        public int GetLevel()
        {
            return level;
        }
    }
}
