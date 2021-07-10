using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
    UNIVERSIDAD ESTATAL A DISTANCIA
    Asignatura: Programación Avanzada 
    Profesor: Juan Pablo Navarro Fennell
    Estudiante: Sharmey Joheily Fallas Calvo 
    Cédula: 3 0518 0583 
    Código: 00830
    Año: 2021

    Tarea #1: Esta tarea consiste en la elaboración de un programa para que la Universidad Educa 
    pueda llevar un registro más limpio y ordenado de los cursos, sedes, profesores y estudiantes. 

 */


namespace Universidad
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            //Creación de variables 
            int opcionMenu;
            Datos datos = new Datos();

            //Mensaje de bienvenida 
            Console.WriteLine("\t Hola, bienvenid@ a la Univerdad Educa ");
            Console.WriteLine("\nPor favor, seleccione una opción: ");

            //Menú principal
            do
            {
                Console.WriteLine("\n\t1-Registrar sedes de la universidad" +
                    "\n\t2-Registrar profesores" +
                    "\n\t3-Registrar estudiantes" +
                    "\n\t4-Registrar cursos" +
                    "\n\t5-Matricular estudiante en curso" +
                    "\n\t6-Asignar curso a profesor" +
                    "\n\t7-Mostrar estudiantes" +
                    "\n\t8-Mostrar profesores" +
                    "\n\t9-Salir");

                Console.Write("\nOpción del menú: ");
                opcionMenu = Convert.ToInt32(Console.ReadLine());
                Console.Clear(); //Limpiar pantalla

                //Opciones del menú 
                switch (opcionMenu)
                {
                    case 1:  
                        //Almacenar datos del registro las sedes
                        Console.WriteLine("\t\tREGISTRAR SEDE");
                        Console.WriteLine("");
                        datos.Guardar_Sedes(); //Llamada al método para registrar una sede
                        break;

                    case 2:
                        //Almacenar datos del registro de los profesores
                        Console.WriteLine("\t\tREGISTRAR PROFESOR");
                        Console.WriteLine("");
                        datos.Guardar_Profesores(); //Llamada al método para registrar un profesor
                        break;

                    case 3:
                        //Almacenar datos del registro de los estudiantes
                        Console.WriteLine("\t\tREGISTRAR ESTUDIANTE");
                        Console.WriteLine("");
                        datos.Guardar_Estudiante(); //Llamada al método para registrar un estudiante
                        break;


                    case 4:
                        //Almacenar datos del registro de los cursos
                        Console.WriteLine("\t\tREGISTRAR CURSO");
                        Console.WriteLine("");
                        datos.Guardar_Cursos(); //Llamada al método para registrar un curso
                        break;

                    case 5:
                        //Matricular estudiante en curso
                        Console.WriteLine("\t\tMATRICULAR ESTUDIANTE");
                        Console.WriteLine("");
                        datos.Matricular_Estudiantes(); //Llamada al método para matricular estudiante
                        break;

                    case 6:
                        //Asignar curso a profesor
                        Console.WriteLine("\t\tASIGNAR CURSO A PROFESOR");
                        Console.WriteLine("");
                        datos.Asignar_Profesor(); //Llamada al método para asignar profesor 
                        break;
                       
                    case 7: 
                        //Imprimir registro de estudiantes 
                        Console.WriteLine("\n\n-----------------------------  INICIO DE REGISTRO  -------------------------------------\n");
                        datos.Imprimir_Estudiantes();
                        Console.WriteLine("\n\n-------------------------------  FIN DE REGISTRO  -------------------------------------\n\n\n");
                        break;

                    case 8:
                        //Imprimir registro de profesores 
                        Console.WriteLine("\n\n-----------------------------  INICIO DE REGISTRO  -------------------------------------\n");
                        datos.Imprimir_Profesores();
                        Console.WriteLine("\n\n-------------------------------  FIN DE REGISTRO  -------------------------------------\n\n\n");
                        break;

                    case 9:
                        //Opción de salir 
                        break; 

                        
                    default: 
                        //Opción equivocada o inexistente
                        Console.WriteLine("La opción digitada no existe...");
                        break;

                }

                //Confirmar si desea realmente salir 
                if (opcionMenu == 9)
                {
                    Console.WriteLine("¿Está realmente seguro de que desea salir (1=Sí / 9=No)?");
                    Console.Write("Opción: ");
                    opcionMenu = Convert.ToInt32(Console.ReadLine());

                    if (opcionMenu == 1)
                    {
                        break;
                    }
                }

            } while (opcionMenu > 0 && opcionMenu < 10);


            Console.Clear(); //Limpiar pantalla
            Console.WriteLine("\n\n\n\t\tGRACIAS POR INGRESAR A LA UNIVERSIDAD EDUCA :)"); //Despedida
            Console.ReadKey(); //No permite que el programa cierre

        }
    }
}
