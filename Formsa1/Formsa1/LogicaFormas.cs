using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formsa1
{
        public  class LogicaFormas
        {
        public string RealizarOperacion (string LadoOne, string LadoTwo, string LadoThree, string elOperador)
        {
            double LadoUno = Convert.ToDouble(LadoOne);
            double LadoDos = Convert.ToDouble(LadoThree);
            double LadoTres = Convert.ToDouble(LadoThree);
            Enumerado elOperadorEnumerado = ConvertirElOperadorEnumeradoEnString(elOperador);
            double? elResultado = RealizarOperacion(LadoUno, LadoDos, LadoTres, elOperadorEnumerado);
            string elResultadoConvertido;

            if (elResultado != null)
            {
                elResultadoConvertido = elResultado.ToString();
            }else
                elResultadoConvertido = "error";

            return elResultadoConvertido;

        }

        private Enumerado ConvertirElOperadorEnumeradoEnString (string elOperador)
        {
            Enumerado elResultado;
            switch (elOperador)
            {
                case "area":
                case "areas":
                case "are":
                    elResultado = Enumerado.area; 
                    break;
                case "perimetro":
                case "peri":
                    elResultado = Enumerado.perimetro;
                    break;
                default:
                    elResultado = Enumerado.desconocido;
                    break;

            }
            return elResultado;
        }

        private double? RealizarOperacion (double LadoOne, double LadoTwo, double LadoThree, Enumerado elOperador)
        {
            double? elResultado = 0.0; 
            switch (elOperador)
            {
                case Enumerado.area:
                    {
                        elResultado = (LadoOne*LadoTwo);
                        break;
                    }
                case Enumerado.perimetro:
                    {
                        elResultado = (LadoOne + LadoOne + LadoTwo + LadoThree);
                        break; 
                    }
                case Enumerado.desconocido:
                    {
                        elResultado = null;
                        break; 
                    }
            }
            return elResultado;
        }
    }
}
