using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
            set { inizio = value; }
        }

        public Nodo Fine
        {
            get { return fine; }
            set { fine = value; }
        }

        public virtual void serializza()
        {
            File.WriteAllText("lista.json", JsonConvert.SerializeObject(this));
        }
        public static Lista Deserializza()
        {
            Lista x;
            x = JsonConvert.DeserializeObject<Lista>(File.ReadAllText("lista.json"));
            return x;
        }



    }
}
