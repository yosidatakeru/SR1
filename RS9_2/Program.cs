﻿using RS9_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(new Item("こん棒"));

            player.UseItem();
            //閉じないようににする
            Console.ReadLine();
        }
    }
}
