using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryShopMAUI.Models
{
    public class Produs
    {
        public string Nume { get; set; }
        public string Imagine { get; set; }
        public string Descriere { get; set; }
        public double Pret { get; set; }

        public bool IsEmpty()
        {
            return Nume == null && Imagine == null && Descriere == null;
        }
    }
}
