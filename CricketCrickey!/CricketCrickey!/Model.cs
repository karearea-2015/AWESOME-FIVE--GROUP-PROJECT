﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketCrickey_
{
    internal class Model
    {
        int TotalScore = 0;

        private Random rnd = new Random();

       
        
        public int StraightDrive()
        {
            int X = rnd.Next(0, 11);

            if (X == 1)
            {
                return 6;
            }

            if (X > 1 && X < 4)
            {
                return 4;
            }

            return 1;
            

        }

    }
}
