﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lottery
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Some Comments
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Lottery());
        }
    }
}
