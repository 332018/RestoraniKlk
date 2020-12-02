using RestoranDataLayer;
using RestoranDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranBussiessLayer
{
    public class RestoranBussiness
    {
        private readonly RestoranRepository restoranRepository;

        public RestoranBussiness()
        {
            this.restoranRepository = new RestoranRepository();
        }

        public List<Restoran> GetAllRestorans()
        {
            return this.restoranRepository.GetAllRestorans();
        }

        public bool Insertrestoran(Restoran r)
        {
            if(this.restoranRepository.InsertRestoran(r) > 0)
            {
                return true;
            }
            return false;
        }

        public List<Restoran> GetRestoransWith(decimal min, decimal max)
        {
            return this.restoranRepository.GetAllRestorans().Where(r => r.Cena > min && r.Cena < max).ToList();
        }
    }
}
