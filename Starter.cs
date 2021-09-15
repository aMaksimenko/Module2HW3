using System;
using HomeWork.Models;
using HomeWork.Services;

namespace HomeWork
{
    public class Starter
    {
        public void Run()
        {
            var giftBoxService = new GiftBoxService();

            giftBoxService.Put(new object[]
            {
                new ChupaChups() { Taste = Taste.Chocolate },
                new SugarDaddy() { Taste = Taste.Fruit },
                new LifeSaver() { Taste = Taste.Chocolate },
                new JollyRancher() { Taste = Taste.Mint },
                new Stimorol() { Taste = Taste.Mint },
                new Orbit() { Taste = Taste.Fruit },
                new GummiBear() { Taste = Taste.Chocolate },
                new GummiWorm() { Taste = Taste.Fruit },
            });

            Console.WriteLine(giftBoxService.GetTotalWeight());
            giftBoxService.SortByWeight();
            Console.WriteLine(giftBoxService.FindBy(1200, Taste.Chocolate));
        }
    }
}