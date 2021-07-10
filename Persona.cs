using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Esta clase Persona extiende a las clases Estudiante y Profesor 

namespace Universidad
{
    public class Persona
    {
        public Persona() //Constructor
        {
            nombre = "";
            primer_Apellido = "";
            segundo_Apellido = "";
        }

        ~Persona() { } //Destructor
        private string nombre;
        private string primer_Apellido;
        private string segundo_Apellido;



        //Propiedades para obtener y establecer variables 
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Primer_Apellido
        {
            get
            {
                return primer_Apellido;
            }
            set
            {
                primer_Apellido = value;
            }
        }

        public string Segundo_Apellido
        {
            get
            {
                return segundo_Apellido;
            }
            set
            {
                segundo_Apellido = value;
            }
        }

    }
}
