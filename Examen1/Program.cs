using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            bool continuar=true;

            while (continuar)
            {
                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("1- Ingresar informacion de canciones");
                Console.WriteLine("2- Ingresar informacion de alumnos");
                Console.WriteLine("3- Salir del sistema");
                Console.Write("Opcion: ");
                opcion=int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        InformacionCanciones();
                        break;

                    case 2:
                        InformacionAlumnos();
                        break;

                    case 3:
                        Console.WriteLine("Gracias por utilizar el sistema de almacemaiento de datos.");
                        Console.WriteLine("Pase un buen dia!!!");
                        continuar = false;
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("**La opcion no es validad**");
                        break;
                }
            }

        }

        static void InformacionCanciones()
        {
            bool continuar = true;
            int cantidad;
            while (continuar)
            {
                Console.Write("Ingrese la canitdad de canciones que desea ingresar: ");
                cantidad = int.Parse(Console.ReadLine());
                String[] artista = new String[cantidad];
                String[] titulo = new String[cantidad];
                Double[] duracion = new Double[cantidad];
                long[] tamfichero = new long[cantidad];

                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("Ingrese la informacion de la cancion: " + (i + 1) + " : ");
                    Console.WriteLine("");

                    Console.Write("Artista: ");
                    artista[i] = Console.ReadLine();

                    Console.Write("Titulo: ");
                    titulo[i] = Console.ReadLine();

                    Console.Write("Duracion: ");
                    duracion[i] = double.Parse(Console.ReadLine());

                    Console.Write("Tamaño de fichero: ");
                    tamfichero[i] = long.Parse(Console.ReadLine());
                }
                Console.WriteLine("");
                Console.WriteLine("Informacion de las canciones: ");

                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Cancion: #" + (i + 1));
                    Console.WriteLine("Artista: " + artista[i]);
                    Console.WriteLine("Titulo: " + titulo[i]);
                    Console.WriteLine("Duracion: " + duracion[i] + " Minutos");
                    Console.WriteLine("Tamaño del fichero: " + tamfichero[i]);
                }

                Console.WriteLine("");
                Console.Write("Desea continuar ingresando mas canciones? (S/N):");
                String respuesta = Console.ReadLine().Trim().ToUpper();

                continuar = (respuesta == "S");

            }

            Console.ReadLine();
        }

        static void InformacionAlumnos()
        {

            bool continuar = true;

            int[] ids = new int[100];
            String[] nombre = new string[100];
            DateTime[] fechaNacimiento = new DateTime[100];
            String[] grado = new string[100];
            int[] añoRegistro = new int[100];

            int ultimoId = 0;

            while (continuar)
            {
                Console.WriteLine("");
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1- Agregar un alumno");
                Console.WriteLine("2- Buscar un alumno por id");
                Console.WriteLine("3- Modificar un alumno por id");
                Console.WriteLine("4- Mostrar todos los alumnos");
                Console.WriteLine("5- Regresar al menú principal");
                Console.Write("Opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {

                    case 1:

                        ultimoId++;
                        ids[ultimoId] = ultimoId;

                        Console.WriteLine("");
                        Console.Write("Ingrese el nombre completo del alumno: ");
                        nombre[ultimoId] = Console.ReadLine();

                        Console.Write("Ingrese la fecha de nacimiento del alumno (DD-MM-AAAA): ");
                        fechaNacimiento[ultimoId] = DateTime.Parse(Console.ReadLine());

                        Console.Write("Ingrese el grado del alumno: ");
                        grado[ultimoId] = Console.ReadLine();

                        Console.Write("Ingrese el año de registro del alumno: ");
                        añoRegistro[ultimoId] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Alumno agregado exitosamente con ID " + ultimoId);
                        break;

                    case 2:

                        Console.WriteLine("");
                        Console.Write("Ingrese el ID del alumno que desea buscar: ");
                        int codigoBuscado = int.Parse(Console.ReadLine());

                        if (codigoBuscado > 0 && codigoBuscado <= ultimoId)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"Alumno encontrado con ID {codigoBuscado}:");
                            Console.WriteLine($"Nombre completo: {nombre[codigoBuscado]}");
                            Console.WriteLine($"Fecha de nacimiento: {fechaNacimiento[codigoBuscado]:dd-MM-yyyy}");
                            Console.WriteLine($"Grado: {grado[codigoBuscado]}");
                            Console.WriteLine($"Año de registro: {añoRegistro[codigoBuscado]}");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("No se encontró ningún alumno con ese código.");
                        }
                        break;

                    case 3:

                        Console.WriteLine("");
                        Console.Write("Ingrese el código del alumno que desea modificar: ");
                        int codigoModificar = int.Parse(Console.ReadLine());

                        if (codigoModificar > 0 && codigoModificar <= ultimoId)
                        {
                            Console.WriteLine("");
                            Console.Write("Nuevo nombre completo: ");
                            nombre[codigoModificar] = Console.ReadLine();

                            Console.Write("Nueva fecha de nacimiento (DD-MM-AAAA): ");
                            fechaNacimiento[codigoModificar] = DateTime.Parse(Console.ReadLine());

                            Console.Write("Nuevo grado: ");
                            grado[codigoModificar] = Console.ReadLine();

                            Console.Write("Nuevo año de registro: ");
                            añoRegistro[codigoModificar] = int.Parse(Console.ReadLine());

                            Console.WriteLine("");
                            Console.WriteLine("Alumno modificado exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("No se encontró ningún alumno con ese código.");
                        }
                        break;

                    case 4:

                        Console.WriteLine("");
                        Console.WriteLine("Información de todos los alumnos:");
                        for (int i = 1; i <= ultimoId; i++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"Código: {ids[i]}");
                            Console.WriteLine($"Nombre completo: {nombre[i]}");
                            Console.WriteLine($"Fecha de nacimiento: {fechaNacimiento[i]:yyyy-MM-dd}");
                            Console.WriteLine($"Grado: {grado[i]}");
                            Console.WriteLine($"Año de registro: {añoRegistro[i]}");
                            Console.WriteLine();
                        }
                        break;

                    case 5:
                        Console.WriteLine("");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("**La opción no es válida**");
                        break;
                }
            }

        }
    }
}
