using GameBackendSystem.Abstract;
using GameBackendSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendSystem.Concrete
{
    class CampaigningManager : ICampaigningService
    {
        

        public void Add(Campaigning campaigning)
        {
            Console.WriteLine($"{campaigning.Name} kampanyası ile {campaigning.DiscountAmount} indirim başladı");
        }

        

        public void Delete(Campaigning campaigning)
        {
            Console.WriteLine($"{campaigning.Name} kampanyası sona erdi");
        }

        

        public void Update(Campaigning campaigning)
        {
            Console.WriteLine($"{campaigning.Name} kampanyası {campaigning.DiscountAmount} indirim güncellendi");
        }
    }
}
