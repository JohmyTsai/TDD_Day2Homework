using System;

namespace TDD_Day2_HW
{
    internal class Calculater
    {
        internal int Sum(Potter order)
        {
            int Total = 0;
            int SetType = 0;

            while (order.First != 0 || order.Second != 0 || order.Third != 0 || order.Fourth != 0 || order.Fifth != 0)
            {
                if (order.First != 0)
                {
                    order.First--;
                    SetType++;
                }
                if (order.Second != 0)
                {
                    order.Second--;
                    SetType++;
                }
                if (order.Third != 0)
                {
                    order.Third--;
                    SetType++;
                }
                if (order.Fourth != 0)
                {
                    order.Fourth--;
                    SetType++;
                }
                if (order.Fifth != 0)
                {
                    order.Fifth--;
                    SetType++;
                }

                Total += GetSetSum(SetType);
                SetType++;
            }

            return Total;
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

                default:
                    return 0;
            }
        }
    }
}