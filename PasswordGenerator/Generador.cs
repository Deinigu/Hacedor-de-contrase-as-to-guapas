using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Generador
    {
        private char[] VOCABULARIO = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','ñ','o','p','q','r','s','t','u','v','w','x','y','z',
                                      'A','B','C','D','E','F','G','H','I','J','K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                                      '@','#','|','~','€','$'};
        private int nCaracteres = 10;
        private String contrasenya;
        public Generador()
        {
            this.contrasenya = "No";
        }

        public String generarcontrasenya()
        {
            Random generadorAleatorio = new Random();
            String res = VOCABULARIO[generadorAleatorio.Next(VOCABULARIO.Length)].ToString() ;
            for (int i = 0; i < nCaracteres-1; i++)
            {
                res += VOCABULARIO[generadorAleatorio.Next(VOCABULARIO.Length)];
            }
            this.contrasenya = res;
            return this.contrasenya;
        }

        public void setNumCaracteres(int nCaracteres)
        {
            this.nCaracteres = nCaracteres;
        }
    }
}
