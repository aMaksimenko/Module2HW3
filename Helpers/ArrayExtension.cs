using HomeWork.Models;

namespace HomeWork.Helpers
{
    public static class ArrayExtension
    {
        public static object FindBy(this object[] sourceArray, int weight, Taste taste)
        {
            Sweets result = null;
            foreach (var item in sourceArray)
            {
                var sweets = item as Sweets;

                if (sweets?.Weight == weight && sweets?.Taste == taste)
                {
                    result = sweets;
                    break;
                }
            }

            return result;
        }
    }
}