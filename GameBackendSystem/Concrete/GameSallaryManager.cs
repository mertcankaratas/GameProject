using GameBackendSystem.Abstract;
using GameBackendSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendSystem.Concrete
{
    public class GameSallaryManager : IGameSallaryService
    {
        public void Sale(Customer customer, Game game, Campaigning campaigning)
        {
            Console.WriteLine($"{customer.Id} {customer.FirstName} adlı kişiye  {game.Id} {game.CategoryId}  {game.GameName} adlı oyun  {campaigning.Id} {campaigning.Name} " +
                $"{campaigning.DiscountAmount} kampanyası neticesinde {game.Price-campaigning.DiscountAmount} satılmıştır");
        } 
    }
}
