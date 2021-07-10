using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//En esta clase se declaran las variables para sede

namespace Universidad
{
    public class Sedes
    {
        //Declaración de las variables 
        private int id_Sede;
        private string descripcion_Sede;

        //Propiedades para obtener y establecer variables 
        public int Id_Sede
        {
            get
            {
                return id_Sede;
            }
            set
            {
                id_Sede = value;
            }
        }

        public string Descripcion_Sede
        {
            get
            {
                return descripcion_Sede;
            }
            set
            {
                descripcion_Sede = value;
            }
        }
    }
}
