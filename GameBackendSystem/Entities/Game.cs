using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendSystem.Entities
{
   public class Game
    {
        public int Id{ get; set; }
        public int CategoryId { get; set; }
        public string GameName { get; set; }
        public string BarcodeNumber{ get; set; }
        public int Price { get; set; }
    }
}
