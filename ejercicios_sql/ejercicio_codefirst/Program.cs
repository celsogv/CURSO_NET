using System;

namespace ejercicio_codefirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado ObjEmpleado = new Empleado();

            Console.WriteLine("Mete el nombre");
            ObjEmpleado.Empname =Console.ReadLine();
            Console.WriteLine("Mete la direccion");
            ObjEmpleado.Address = Console.ReadLine();
            Console.WriteLine("Introduce un email");
            ObjEmpleado.EmaIId =Console.ReadLine();
            Console.WriteLine("Mete el Movil");
            ObjEmpleado.ToString = Console.ReadLine();
            Console.WriteLine("Meta nombre de departamento");
            objEmpleado.DeptName = Console.ReadLine();
            objContext.Empleados.Add(ObjEmpleado);
            objContext.SaveChanges();

            
            





        }
    }
}
