using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator
{
    public class Tipper
    {
        public decimal CalculateTip(decimal amountOfCheck)
        {
            decimal tipAmount = amountOfCheck * 0.15m;

            if (tipAmount < 1)
            {
                return 1;
            }
            else
            {
                return tipAmount;
            }
        }
    }
}
