using GameBackendSystem.Abstract;
using GameBackendSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendSystem.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine($"{game.Id} {game.CategoryId} {game.BarcodeNumber} {game.GameName} {game.Price} oyun eklendi. ");
        }

        public void Delete(Game game)
        {
            Console.WriteLine($"{game.Id} {game.CategoryId} {game.BarcodeNumber} {game.GameName} {game.Price} silindi. ");
        }

        public void Update(Game game)
        {
            Console.WriteLine($"{game.Id} {game.CategoryId} {game.BarcodeNumber} {game.GameName} {game.Price} güncellendi. ");

        }
    }
}
