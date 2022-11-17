using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    internal class libro
    {
        //l’autore, il titolo, l’anno di pubblicazione, l’editore e il numero di pagine.
        internal string autore { get; set; }
        internal string titolo { get; set; }
        internal int anno { get; set; }
        internal string editore { get; set; }
        internal int numeroDiPagine { get; set; }

        internal libro(string autore, string titolo, int anno, string editore, int numeroDiPagine)
        {
            this.autore = autore;
            this.titolo = titolo;
            this.anno = anno;
            this.editore = editore;
            this.numeroDiPagine = numeroDiPagine;
        }

        //metodo reading time
        static int readingTime(int numeroDiPagine)
        {
            int tempo = 0;
            if(numeroDiPagine < 100)
            {
                tempo = 1;

            }else if(numeroDiPagine > 100 && numeroDiPagine < 200)
            {
                tempo = 2;
            }
            else
            {
                tempo = 3;
            }

            return tempo;
        }

        static string toString(string autore, string titolo, int anno, string editore, int numeroDiPagine)
        {
            string stringaDiDati= "";
            stringaDiDati += autore;
            stringaDiDati += titolo;
            stringaDiDati += anno;
            stringaDiDati += editore;
            stringaDiDati += numeroDiPagine;

            return stringaDiDati;
        }

    }
}
