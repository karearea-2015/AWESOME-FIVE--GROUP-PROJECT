﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketCrickey_
{
    class View
    {
        
        public void PlayerInstructions()
        {

            Console.WriteLine("Please read the instructions below to understand how this game works, hit enter to flow through");
            Console.ReadLine();
            Console.WriteLine("You, the player have flipped and are now batting");
            Console.ReadLine();
            Console.WriteLine("You will enter a number between 1 and 4, this will correspond to the type of shot you produce");
            Console.Clear();
            Console.WriteLine("A 1 will produce a straight drive, hitting down the ground with power");
            Console.ReadLine();
            Console.WriteLine("A 2 will produce a cover drive, a classy cricket shot, Hit it BRUDDAA!!!");
            Console.ReadLine();
            Console.WriteLine("A 3 will produce a reverse sweep, a risky shot, but one that gets the crowd going");
            Console.ReadLine();
            Console.WriteLine("A 4 will produce a slog, who do you you think you are, Brendon McCullum?");

        }

    }
}