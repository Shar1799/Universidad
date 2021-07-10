using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Clase que declara las variables para la clase Profesor y hereda de la clase Persona

namespace Universidad
{
    public class Profesores : Persona
    {
        //Declaración de las variables 
        private int id_Profesor;
        private decimal sueldo_Profesor;
        private string usuario_Profesor;
        private string contrasenia_Profesor;
        private string sede_Profesor; 

        //Propiedades para obtener y establecer variables 
        public int Id_Profesor
        {
            get
            {
                return id_Profesor;
            }
            set
            {
                id_Profesor = value;
            }
        }

        public decimal Sueldo_Profesor
        {
            get
            {
                return sueldo_Profesor;
            }
            set
            {
                sueldo_Profesor = value;
            }
        }

        public string Usuario_Profesor
        {
            get
            {
                return usuario_Profesor;
            }
            set
            {
                usuario_Profesor = value;
            }
        }

        public string Contrasenia_Profesor
        {
            get
            {
                return contrasenia_Profesor;
            }
            set
            {
                contrasenia_Profesor = value;
            }
        }

        public string Sede_Profesor
        {
            get
            {
                return sede_Profesor;
            }
            set
            {
                sede_Profesor = value;
            }
        }

    }
}