using System;

namespace TDD_Day2_HW
{
    internal class Calculater
    {
        internal int Sum(Potter order)
        {
            int SetSum = 0;

            while (order.First != 0 || order.Second != 0 || order.Third != 0 || order.Fourth != 0 || order.Fifth != 0)
            {
                if (order.First != 0)
                {
                    order.First--;
                }
                if (order.Second != 0)
                {
                    order.Second--;
                }
                if (order.Third != 0)
                {
                    order.Third--;
                }
                if (order.Fourth != 0)
                {
                    order.Fourth--;
                }
                if (order.Fifth != 0)
                {
                    order.Fifth--;
                }

                SetSum++;
            }
            return SetSum * 100;
        }
    }
}