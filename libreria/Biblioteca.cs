using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    internal class Biblioteca
    {
        //il nome, l’indirizzo e gli orari di apertura e chiusura giornaliera, che contenga l’elenco dei libri
        internal string nome { get; set; }
        internal double orarioDiApertura { get; set; }
        internal double orarioDiChiusura { get; set; }
        internal List<libro> listaDeiLibri = new List<libro>();

        //costruttore della biblioteca
        internal Biblioteca(string nome, double orarioDiApertura, double orarioDiChiusura, List<libro> listaDeiLibri){
            this.nome = nome;
            this.orarioDiApertura = orarioDiApertura;
            this.orarioDiChiusura = orarioDiChiusura;
            this.listaDeiLibri = listaDeiLibri;
        }
        libro Libro { get; set; }
        
    }
}
