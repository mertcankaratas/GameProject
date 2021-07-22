using GameBackendSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendSystem.Abstract
{
   public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);

    }
}
