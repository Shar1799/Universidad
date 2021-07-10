using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//En esta clase se declaran las variables para cursos

namespace Universidad
{
    public class Cursos
    {
        //Declaración de las variables 
        private int id_Cursos;
        private string nombre_Curso;
        private string descripcion_Curso;

        //Propiedades para obtener y establecer variables 
        public int Id_Cursos
        {
            get
            {
                return id_Cursos;
            }
            set
            {
                id_Cursos = value;
            }
        }

        public string Nombre_Curso
        {
            get
            {
                return nombre_Curso;
            }
            set
            {
                nombre_Curso = value;
            }
        }

        public string Descripcion_Curso
        {
            get
            {
                return descripcion_Curso;
            }
            set
            {
                descripcion_Curso = value;
            }
        }

    }
}

