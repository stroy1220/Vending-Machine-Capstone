﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;

namespace Capstone
{
   public class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendomatic = new VendingMachine();
            MainMenu vendo = new MainMenu();
            
            vendo.Display();

        }
    }
}
