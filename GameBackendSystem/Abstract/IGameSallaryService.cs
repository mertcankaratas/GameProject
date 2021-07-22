using GameBackendSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendSystem.Abstract
{
    public interface IGameSallaryService
    {
        void Sale(Customer customer, Game game, Campaigning campaigning);
    }
}
