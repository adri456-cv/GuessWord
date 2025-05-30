using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessWord.Clases
{
    public class Juego
    {
        public char[] SecretWord {get; set; }
        public int Attempts { get; set; }
        public int MaxAttempts { get; set; }
        public Juego()
        {
            string palabra = Recursos.listadepalabras[new Random().Next(Recursos.listadepalabras.Count)];
            SecretWord = palabra.ToCharArray();
            MaxAttempts = 5;
            Attempts = 0;
            Recursos.Historial.Add(palabra);
        }

        public bool IsGameOver()
        {
            return Attempts >= MaxAttempts;
        }
    }
}
