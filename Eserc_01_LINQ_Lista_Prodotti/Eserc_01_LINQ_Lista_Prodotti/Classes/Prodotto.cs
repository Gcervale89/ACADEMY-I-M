﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eserc_01_LINQ_Lista_Prodotti.Classes
{
    internal class Prodotto
    {
        public string? Nome { get; set; }
        public string? Descrizione { get; set; }
        public float Prezzo { get; set; }
        public string? Categoria { get; set; }
        public int Quantita { get; set; }

        public Prodotto(string? nome, string? descrizione, float prezzo, string? categoria, int quantita)
        {
            Nome = nome;
            Descrizione = descrizione; 
            Prezzo = prezzo;
            Categoria = categoria;
            Quantita = quantita;
        }
        public override string ToString()
        {
            return $"{Nome} {Descrizione} {Prezzo} {Categoria} {Quantita}";
        }
    }
}
