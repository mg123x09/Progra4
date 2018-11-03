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

            if(elResultado)


        }
    }
}
