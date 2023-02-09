using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.domain.Model
{
    public class ListaProduktow
    {
        public int IdProduktu { get; set; }
        public string Produkt { get; set; }
        public string Kod { get; set; }
        public DateTime DataUtworzenia { get; set; }

        public int IloscZmian { get; set; }
    }
}
