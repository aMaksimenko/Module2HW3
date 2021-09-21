using System;
using HomeWork.Helpers;
using HomeWork.Models;

namespace HomeWork.Services
{
    public class GiftBoxService
    {
        public Sweets[] Gifts { get; private set; }

        public void Put(Sweets[] gifts)
        {
            Gifts = gifts;
        }

        public int GetTotalWeight()
        {
            var result = 0;

            foreach (var item in Gifts)
            {
                result += item.Weight;
            }

            return result;
        }

        public void SortByWeight()
        {
            Array.Sort(Gifts, new GiftsComparer());
        }

        public Sweets FindBy(int weight, Taste taste)
        {
            return Gifts.FindBy(weight, taste);
        }
    }
}