using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp13
{
    public class Lista
    {
        Nodo inizio;
        Nodo fine;
        public Lista(string Elemento)
        {
            Nodo x = new Nodo(Elemento);
            inizio = x;
            fine = x;               
        }

        public void Push(string Elemento)
        {
            Nodo x= new Nodo(Elemento);
            fine.Successivo = x;
            fine= x;
        }

        

        public Nodo Inizio
        {
            get { return inizio; }            
        }

        public Nodo Fine
        {
            get { return fine; }
        }

    }
}
