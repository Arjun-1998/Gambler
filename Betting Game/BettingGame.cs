﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gambler
{
    public class Class1
    {
        public void start()
        {
            int money = 100;
            int bet = 1;
            Console.WriteLine("Total money : + money ");
        }
        public void FinalStake()
        {
            int stake = 100;
            int bet = 1;
            stake = stake + bet;
            if (stake > 100)
            {
                Console.WriteLine("Gamber wins");
            }
            else
            {
                Console.WriteLine("Gamber loose");

            }
        }
    }
}



