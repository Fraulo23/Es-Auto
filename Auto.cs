using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Auto
{
    internal class Auto
    {
        public string Modello { get; set; }
        public Auto(string modello)
        {
            Modello = modello;
        }   
        public void CambioModello(string modello)
        {
            Modello = modello;
        }
    }
}
