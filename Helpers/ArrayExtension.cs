using HomeWork.Models;

namespace HomeWork.Helpers
{
    public static class ArrayExtension
    {
        public static Sweets FindBy(this Sweets[] sourceArray, int weight, Taste taste)
        {
            Sweets result = null;
            foreach (var item in sourceArray)
            {
                if (item != null && item.Weight == weight && item.Taste == taste)
                {
                    result = item;
                    break;
                }
            }

            return result;
        }
    }
}