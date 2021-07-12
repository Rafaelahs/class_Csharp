using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes { 

   public class pessoa
    {
        public string apelido;
        public string nome; 

        public void identificar()
        {
            System.Windows.Forms.MessageBox.Show(construirnome());
        }

        private string construirnome()
        {
            string nomeCompleto = nome + " " + apelido;
            return nomeCompleto;
        }
             
    }

}