using System.Collections;
using HomeWork.Models;

namespace HomeWork.Helpers
{
    public class GiftsComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var xSweets = x as Sweets;
            var ySweets = y as Sweets;

            if (xSweets == null || ySweets == null)
            {
                return 0;
            }

            if (xSweets.Weight > ySweets.Weight)
            {
                return 1;
            }
            else if (xSweets.Weight < ySweets.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}