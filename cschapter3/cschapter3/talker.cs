﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cschapter3
{
    class talker
    {
        public static int BlahBlahBlah(string thingToSay, int numberOfTime)
        {
            string finalString = "";
            for (int count = 0; count < numberOfTime; count++)
            {
                finalString = finalString + thingToSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }

    }
}
