using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEstructuraDeDatos
{
    class ClsNodo
    {
        //campos
        private Int32 cod;
        private string nom;
        private string tra;
        private ClsNodo sig; //Puntero

        //Propiedades
        public Int32 codigo
        {
            get { return cod; }
            set { cod = value; }
        }
        public string nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public string tramite
        {
            get { return tra; }
            set { tra = value; }
        }
        public ClsNodo siguiente
        {
            get { return sig; }
            set { sig = value; }
        }



    }
}
