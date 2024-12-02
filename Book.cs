using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Konyvek_dolgozat
{
    internal class Book
    {
        Random rnd = new Random();

        public long ISBN { get; set; }
        public List<Author> Szerzok { get; set; }
        public string Cim { get; set; }
        public int KiadasEve { get; set; }
        public string Nyelv {  get; set; }
        public int Keszlet { get; set; }
        public int Ar { get; set; }
        
        
        public Book() { }
        
        
        private Book(long isbn, string cim, int kiadaseve, string nyelv, int keszlet, int ar, params string[] szerzo) : this(cim, szerzo)
        {
            ISBN = isbn;
            Cim = cim;
            KiadasEve = kiadaseve;
            Nyelv = nyelv;
            Ar = ar;

            Szerzok = [];

            foreach (var s in szerzo) {
                Szerzok.Add(new Author(s));
            }
        }

        private Book(string cim, string szerzo) : this(isbn: rnd.Next(1, 10000), cim: cim, kiadaseve: 2024, nyelv: "magyar", keszlet: 0, ar: 4500, szerzo: szerzo)
        {
            Cim = cim;
            Szerzok.Add(new Author (szerzo));
        }
    }

}
