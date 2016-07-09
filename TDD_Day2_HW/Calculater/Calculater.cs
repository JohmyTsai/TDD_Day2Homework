using Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    public class Calculater
    {
        public int Sum(Potter order)
        {
            int total = 0;
            int setType = 0;

            while (order.First != 0 || order.Second != 0 || order.Third != 0 || order.Fourth != 0 || order.Fifth != 0)
            {
                if (order.First != 0)
                {
                    order.First--;
                    setType++;
                }
                if (order.Second != 0)
                {
                    order.Second--;
                    setType++;
                }
                if (order.Third != 0)
                {
                    order.Third--;
                    setType++;
                }
                if (order.Fourth != 0)
                {
                    order.Fourth--;
                    setType++;
                }
                if (order.Fifth != 0)
                {
                    order.Fifth--;
                    setType++;
                }

                total += GetSetSum(setType);
                setType = 0;
            }

            return total;
        }

        private int GetSetSum(int setType)
        {
            switch (setType)
            {
                case 1:
                    // Set1 100 * 1 = 100
                    return 100;

                case 2:
                    // Set2 100 * 2 * 0.95 = 190
                    return 190;

                case 3:
                    // Set3 100 * 3 * 0.9 = 270
                    return 270;

                case 4:
                    // Set4 100 * 4 * 0.8 = 320
                    return 320;

                case 5:
                    // Set5 100 * 5 * 0.75 = 375
                    return 375;

                default:
                    return 0;
            }
        }
    }
}