using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Nodo x = new Nodo(Elemento);
            fine = findLast(); //ci si assicura che il puntato da fine sia proprio l'ultimo nodo
            fine.Successivo = x;
            fine = x;
        }



        public Nodo Inizio
        {
            get { return inizio; }
            set { inizio = value; }
        }

        public Nodo Fine
        {
            get {
                
                return fine;
            }
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
        /// <summary>
        /// trova il nodo che successivo = null
        /// ovvero l'ultimo
        /// </summary>
        /// <returns></returns>
        private Nodo findLast()
        {
            Nodo x = inizio;            
            while (x.Successivo != null)
            {
                x = x.Successivo;                
            }
            return x;
        }



    }
}
