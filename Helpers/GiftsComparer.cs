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

            switch (xSweets?.Weight - ySweets?.Weight)
            {
                case > 0:
                    return 1;
                case < 0:
                    return -1;
                default:
                    return 0;
            }
        }
    }
}