using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Clase en donde se realizan los métodos para almacenar los datos y también imprimirlos en consola 

namespace Universidad
{
    public class Datos
    {
        //Creación de arreglos de las clases
        Sedes[] arreglo_Sedes = new Sedes[20];
        Estudiantes[] arreglo_Estudiantes = new Estudiantes[20];
        Profesores[] arreglo_Profesores = new Profesores[20];
        Cursos[] arreglo_Cursos = new Cursos[20];

        //Creación de objetos de las clases
        Sedes sedes;
        Estudiantes estudiantes;
        Profesores profesores;
        Cursos cursos;

        //Declaración de variables 
        int respuesta;


        /*                           Métodos de almacenamiento de los datos                          */


        //Método que almacena los datos del estudiante 
        public void Guardar_Estudiante()
        {
            try
            {
                for (int i = 0; i < arreglo_Estudiantes.Length; i++)
                {
                    //Inicialización del objeto 
                    estudiantes = new Estudiantes();

                    Console.WriteLine(); //Línea en blanco 
                    Console.Write("Identificación del estudiante: ");
                    estudiantes.Id_Estudiante = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nombre: ");
                    estudiantes.Nombre = Console.ReadLine();
                    Console.Write("Primer apellido: ");
                    estudiantes.Primer_Apellido = Console.ReadLine();
                    Console.Write("Segundo apellido: ");
                    estudiantes.Segundo_Apellido = Console.ReadLine();
                    Console.Write("Fecha de nacimiento: ");
                    estudiantes.Nacimiento_Estudiante = Console.ReadLine();
                    Console.Write("Genero (f / m): ");
                    estudiantes.Genero_Estudiante = Convert.ToChar(Console.ReadLine());
                    Console.Write("Sede: ");
                    estudiantes.Sede_Estudiante = Console.ReadLine();

                    //Asignamos los objetos de las clases al arreglo de objetos 
                    arreglo_Estudiantes[i] = estudiantes;

                    //Consulta si hay más estudiantes por agregar 
                    Console.WriteLine("");
                    Console.Write("¿Desea agregar otro estudiante? (1=Sí / 2=No): ");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    if (respuesta != 1)
                    {
                        Console.Clear(); //Limpiar pantalla
                        break;
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nError: " + e.Message);
                Console.WriteLine("");
            }
        }

        //Método que almacena los datos de los profesores 
        public void Guardar_Profesores()
        {
            try
            {
                for (int i = 0; i < arreglo_Profesores.Length; i++)
                {
                    //Inicialización del objeto 
                    profesores = new Profesores();

                    Console.WriteLine(); //Línea en blanco 
                    Console.Write("Identificación del profesor: ");
                    profesores.Id_Profesor = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nombre: ");
                    profesores.Nombre = Console.ReadLine();
                    Console.Write("Primer apellido: ");
                    profesores.Primer_Apellido = Console.ReadLine();
                    Console.Write("Segundo apellido: ");
                    profesores.Segundo_Apellido = Console.ReadLine();
                    Console.Write("Sueldo: ");
                    profesores.Sueldo_Profesor = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Usuario: ");
                    profesores.Usuario_Profesor = Console.ReadLine();
                    Console.Write("Contraseña: ");
                    profesores.Contrasenia_Profesor = Console.ReadLine();
                    Console.Write("Sede: ");
                    profesores.Sede_Profesor = Console.ReadLine();

                    //Asignamos los objetos de las clases al arreglo de objetos 
                    arreglo_Profesores[i] = profesores;

                    //Consulta si hay más profesores por agregar 
                    Console.WriteLine("");
                    Console.Write("¿Desea agregar otro profesor? (1=Sí / 2=No): ");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    if (respuesta != 1)
                    {
                        Console.Clear(); //Limpiar pantalla
                        break;
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nError: " + e.Message);
                Console.WriteLine("");
            }
        }

        //Método que almacena los datos del curso
        public void Guardar_Cursos()
        {
            try
            {
                for (int i = 0; i < arreglo_Cursos.Length; i++)
                {
                    //Inicialización del objeto 
                    cursos = new Cursos();

                    Console.WriteLine(); //Línea en blanco 
                    Console.Write("Identificación del curso: ");
                    cursos.Id_Cursos = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nombre: ");
                    cursos.Nombre_Curso = Console.ReadLine();
                    Console.Write("Descripción: ");
                    cursos.Descripcion_Curso = Console.ReadLine();

                    //Asignamos los objetos de las clases al arreglo de objetos 
                    arreglo_Cursos[i] = cursos;

                    //Consulta si hay más cursos por agregar 
                    Console.WriteLine("");
                    Console.Write("¿Desea agregar otro curso? (1=Sí / 2=No): ");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    if (respuesta != 1)
                    {
                        Console.Clear(); //Limpiar pantalla
                        break;
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nError: " + e.Message);
                Console.WriteLine("");
            }
        }

        //Método que almacena los datos de las sedes
        public void Guardar_Sedes()
        {
            try
            {
                for (int i = 0; i < arreglo_Sedes.Length; i++)
                {
                    //Inicialización del objeto 
                    sedes = new Sedes();

                    Console.WriteLine(); //Línea en blanco 
                    Console.Write("Identificación de la sede: ");
                    sedes.Id_Sede = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nombre: ");
                    sedes.Descripcion_Sede = Console.ReadLine();

                    //Asignamos los objetos de las clases al arreglo de objetos 
                    arreglo_Sedes[i] = sedes;

                    //Consulta si hay más sedes por agregar 
                    Console.WriteLine("");
                    Console.Write("¿Desea agregar otra sede? (1=Sí / 2=No): ");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    if (respuesta != 1)
                    {
                        Console.Clear(); //Limpiar pantalla
                        break;
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nError: " + e.Message);
                Console.WriteLine("");
            }
        }

        //Método que matricula a un estudiante 
        public void Matricular_Estudiantes()
        {
            Console.Write("Id de la sede: ");
            sedes.Id_Sede = Convert.ToInt32(Console.ReadLine());
            Console.Write("Identificación del estudiante: ");
            estudiantes.Id_Estudiante = Convert.ToInt32(Console.ReadLine());
            Console.Write("Identificación del curso: ");
            cursos.Id_Cursos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEstudiante matriculado exitosamente!!!"); //Mensaje de estado del estudiante 

        }

        //Método que asigna un curso a un profesor  
        public void Asignar_Profesor()
        {
            Console.Write("Id de la sede: ");
            sedes.Id_Sede = Convert.ToInt32(Console.ReadLine());
            Console.Write("Identificación del profesor: ");
            profesores.Id_Profesor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Identificación del curso: ");
            cursos.Id_Cursos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nProfesor asignado a curso exitosamente!!!"); //Mensaje de la asignación del profesor

        }

        /*                           Métodos de impresión de los datos                          */


        //Imprimir el registro de los estudiantes
        public void Imprimir_Estudiantes()
        {

            for (int j = 0; j < arreglo_Estudiantes.Length; j++)
            {
                Console.WriteLine("\n\nIdentificación: " + arreglo_Estudiantes[j].Id_Estudiante + "\nNombre: " + arreglo_Estudiantes[j].Nombre +
                   "\nPrimer apellido: " + arreglo_Estudiantes[j].Primer_Apellido + "\nSegundo apellido: " + arreglo_Estudiantes[j].Segundo_Apellido +
                   "\nFecha de nacimiento: " + arreglo_Estudiantes[j].Nacimiento_Estudiante + "\nGénero: " + arreglo_Estudiantes[j].Genero_Estudiante +
                   "\nSede: " + arreglo_Estudiantes[j].Sede_Estudiante);
            }

        }

        //Imprimir el registro de los profesores
        public void Imprimir_Profesores()
        {

            for (int j = 0; j < arreglo_Profesores.Length; j++)
            {
                Console.WriteLine("\n\nIdentificación: " + arreglo_Profesores[j].Id_Profesor + "\nNombre: " + arreglo_Profesores[j].Nombre +
                   "\nPrimer apellido: " + arreglo_Profesores[j].Primer_Apellido + "\nSegundo apellido: " + arreglo_Profesores[j].Segundo_Apellido +
                   "\nSueldo: " + arreglo_Profesores[j].Sueldo_Profesor + "\nUsuario: " + arreglo_Profesores[j].Usuario_Profesor +
                   "\nContraseña: " + arreglo_Profesores[j].Contrasenia_Profesor + "\nSede: " + arreglo_Profesores[j].Sede_Profesor);
            }

        }

    }
}
