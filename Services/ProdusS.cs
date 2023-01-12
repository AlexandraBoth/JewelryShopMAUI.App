
using System.Collections.Generic;
using JewelryShopMAUI.Models;

namespace JewelryShopMAUI.Services
{

    public class ProdusS
    {
        static ProdusS _instance;

        public static ProdusS Instance
        {
            get { return _instance ?? (_instance = new ProdusS()); }
        }

        public List<Produs> GetProdus()
        {
            return new List<Produs> {
              new Produs {
                  Nume = "CALYPSO",
                  Imagine = "inel1.jpg",
                  Descriere = "INEL CALYPSO • AUR 18K",
                  Pret = 1700,
              },
              new Produs {
                  Nume = "ASTRA",
                  Imagine = "bratara2.jpg",
                  Descriere = "BRĂȚARĂ ASTRA • AUR 14K",
                  Pret = 1550,
              },
              new Produs {
                  Nume = "PEARL",
                  Imagine = "bratara3.jpg",
                  Descriere = "BRĂȚARĂ PEARL GRADIENT • AUR 14K",
                  Pret = 2000,
              },
              new Produs {
                  Nume = "PAPILLON",
                  Imagine = "cercei1.jpg",
                  Descriere = "CERCEI PAPILLON",
                  Pret = 860,
              },
              new Produs {
                  Nume = "DIAMOND",
                  Imagine = "lantisor1.jpg",
                  Descriere = "LANT FLOATING DIAMOND",
                  Pret = 1000,
              },
           };
        }
    }
}
