using GameBackendSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendSystem.Abstract
{
    public interface ICampaigningService
    {
        void Add(Campaigning campaigning);
        void Delete(Campaigning campaigning);
        void Update(Campaigning campaigning);
    }
}
