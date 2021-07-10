using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Clase que declara las variables para la clase Estudiante y hereda de la clase Persona

namespace Universidad
{
    public class Estudiantes : Persona
    {
        //Declaración de las variables 
        private int id_Estudiante;
        private string nacimiento_Estudiante;
        private char genero_Estudiante;
        private string sede_Estudiante;

        //Propiedades para obtener y establecer variables 
        public int Id_Estudiante
        {
            get
            {
                return id_Estudiante;
            }
            set
            {
                id_Estudiante = value;
            }
        }

        public string Nacimiento_Estudiante
        {
            get
            {
                return nacimiento_Estudiante;
            }
            set
            {
                nacimiento_Estudiante = value;
            }
        }

        public char Genero_Estudiante
        {
            get
            {
                return genero_Estudiante;
            }
            set
            {
                genero_Estudiante = value;
            }
        }

        public string Sede_Estudiante
        {
            get
            {
                return sede_Estudiante;
            }
            set
            {
                sede_Estudiante = value;
            }
        }

    }
}
