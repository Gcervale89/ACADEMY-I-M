﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_01_GestioneVeicolo.Classes
{
    internal class Macchina : Veicolo
    {
        public Macchina()
        {

        }

        public Macchina(string? marca, int cilindrata)
        {
            Marca = marca;
            Cilindrata = cilindrata;
        }

        public override void stampaDettagli()
        {
            Console.WriteLine($"{Marca} e {Cilindrata}");
        }
    }
}
