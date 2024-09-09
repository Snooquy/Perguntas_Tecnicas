using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perguntas_Técnicas.Verificar_String
{
    internal class Desafio_String
    {
        public void ContarLetras(string PalavraOuFrase) {
            int x = 0;
            foreach (char letras in PalavraOuFrase.ToLower())
            {
                if (letras == 'a') 
                {                
                    x++;
                }
            }
            string Existe;
            if (x <= 0)
            {
                Existe = "Letra 'A' não existe na frase";
            }
            else
            {
                Existe = "Letra 'A' está presente na frase!, quantidade: ";
            }
            Console.WriteLine(Existe + x);
        }
    }
}
