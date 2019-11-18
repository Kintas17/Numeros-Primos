using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_ou_Impar
{
    class Par
    {
        private int valor;
        public string recebe
        { 
            set
            {
                valor = Convert.ToInt32(value);
            }
        }

        public string envia
        {
            get
            {
                bool primo = true;
                for (int i = 2; i < valor; i++) 
                {
                    if (valor % i == 0) primo = false;
                }
                if (primo) return "O número " + valor + " é Primo";
                else return "O número " + valor + " não é Primo";

            }
        }
    }
}
