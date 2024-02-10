using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp13
{
    public class Nodo
    {
        string valore;
        Nodo successivo;
        
        public Nodo(string Valore)
        {
            valore = Valore;            
        }        

        public string Valore
        {
            get { return valore; } 
            set { valore = value; }
        }   

        public Nodo Successivo
        {
            get { return successivo; }
            set { successivo = value; }
        }



    }
}
