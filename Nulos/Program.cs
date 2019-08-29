using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulos
{
    class Program
    {
        static Alumno alumno;
        static void Main(string[] args)
        {
            alumno = new Alumno();
            imprimirAlumno();
            Console.Read();
        }

        static void imprimirAlumno()
            {
                alumno.Nombre = "Jose";

            Console.WriteLine("Nombre" + alumno.Nombre);
            }
       
       
    }
}
