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
        private ClsNodo ant;
        private ClsNodo pri;
        private ClsNodo ult;

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
        public ClsNodo anterior
        {
            get { return ant; }
            set { ant = value; }
        }
        public ClsNodo primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public ClsNodo ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        public ClsNodo izquierdo
        {
            get { return ant; }
            set { ant = value; }
        }
        public ClsNodo derecho
        {
            get { return sig; }
            set { sig = value; }
        }
    }
}
