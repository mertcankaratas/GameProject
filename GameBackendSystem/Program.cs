using GameBackendSystem.Abstract;
using System;
using GameBackendSystem.Concrete;
using GameBackendSystem.Entities;

namespace GameBackendSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { DateOfBirth = new DateTime(1997, 10, 17), Id = 1, FirstName = "Mertcan", LastName = "Karataş", NationalitId = "34" };
            Customer customer2 = new Customer { DateOfBirth = new DateTime(1997, 10, 17), Id = 1, FirstName = "can", LastName = "Karataş", NationalitId = "34" };
            BaseCustomerManager customerManager = new CustomerManager();
            customerManager.SaveUser(customer);
            BaseCustomerManager customerManager2 = new CustomerManager();
            customerManager2.SaveUser(customer2);


            Game game = new Game { Id = 1, CategoryId = 1, BarcodeNumber = "123", GameName = "NBA 2K21", Price = 350 };
            Game game2 = new Game { Id = 2, CategoryId = 2, BarcodeNumber = "12344", GameName = "FİFA 21", Price = 370 };

            Campaigning campaigning = new Campaigning { Id = 101, Name = "Yaz indirimi", DiscountAmount = 25 };
            Campaigning campaigning2 = new Campaigning { Id = 105, Name = "Sonbahar indirimi", DiscountAmount = 45 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Add(game2);

            CampaigningManager campaigningManager = new CampaigningManager();
            campaigningManager.Add(campaigning);
            campaigningManager.Add(campaigning2);

            GameSallaryManager gameSallaryManager = new GameSallaryManager();
            gameSallaryManager.Sale(customer, game, campaigning);
            gameSallaryManager.Sale(customer2, game2, campaigning2);

        }
    }
}
