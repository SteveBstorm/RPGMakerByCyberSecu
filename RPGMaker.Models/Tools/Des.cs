﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Tools
{
    public class Des
    {
        public static int Jet(int nbFace)
        {
            Random rnd = new Random();
            return rnd.Next(1, nbFace + 1);
        }
    }
}
