using System;
using System.Collections.Generic;
using System.Text;

namespace ApliEmpleados
{
    class Gerencial : BaseAtri
    {
        private static Gerencial gerente;


        private static int Cedula;
        private static string letra;

        private Gerencial(int cedu)
        {
            Cedula = cedu;
        }
        public static Gerencial GetGerencial(int cedu)
        {
            if (gerente == null)
            {
                gerente = new Gerencial(cedu);

            }
            return gerente;
        }


        private Gerencial(string letr)
        {
            letra = letr;
        }

      
        public static Gerencial GetGerencial1(string letr)
        {
            if (gerente == null)
            {

                gerente = new Gerencial(letr);
            }
            return gerente;
        }
    }
}
