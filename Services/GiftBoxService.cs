using System;
using HomeWork.Helpers;
using HomeWork.Models;

namespace HomeWork.Services
{
    public class GiftBoxService
    {
        public object[] Gifts { get; private set; }

        public void Put(object[] gifts)
        {
            Gifts = gifts;
        }

        public int GetTotalWeight()
        {
            var result = 0;

            foreach (var item in Gifts)
            {
                var gift = item as Sweets;

                if (gift != null)
                {
                    result += gift.Weight;
                }
            }

            return result;
        }

        public void SortByWeight()
        {
            Array.Sort(Gifts, new GiftsComparer());
        }

        public object FindBy(int weight, Taste taste)
        {
            return Gifts.FindBy(weight, taste);
        }
    }
}