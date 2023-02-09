using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.domain.Model
{
    public class HistoriaProduktow
    {
        public int IdZmiany { get; set; }
        public string Produkt { get; set; }
        
        public string StaryKod { get; set; }

        public DateTime DataZmiany { get; set; }


    }
}
