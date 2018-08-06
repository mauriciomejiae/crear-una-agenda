using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //LIbreria I and Output
namespace crear_una_agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TextWriter texto = new StreamWriter("prueba.txt");
            texto.WriteLine("Hola mundo");
            texto.Close(); */

            Console.WriteLine("Introduce contacto");
            Console.Write("Nombre:");
            string nombre = Console.ReadLine();
            Console.Write("Celular:");
            string celular = Console.ReadLine();


            //Añadir texto
            StreamWriter texto = File.AppendText("prueba.txt");
            texto.WriteLine(nombre + "," + celular);
            texto.Close();
            Console.WriteLine("Registro OK");
            Console.ReadKey();


            //Leer texto
            /*
            TextReader texto2 = new StreamReader("prueba.txt");
            Console.WriteLine(texto2.ReadLine());
            texto2.Close();
            Console.ReadKey(); */
        }
    }
}