using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvek_dolgozat
{
    internal class Author
    {
        public string KeresztNev { get; set; }
        public string VezetekNev { get; set; }
        public Guid ID { get; set; }


        public Author(string nev)
        {
            var db = nev.Split(' ');
            VezetekNev = db[0];
            KeresztNev = db[1];

            ID = Guid.NewGuid();
        }
    }
}