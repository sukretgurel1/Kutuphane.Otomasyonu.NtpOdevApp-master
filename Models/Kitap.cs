using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kitap
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public int KitapID { get; set; }
        public int TurID { get; set; }
        public int VerildiMi { get; set; }
    }
}
