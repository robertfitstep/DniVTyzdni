using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypisDniVTyzdni
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Deň 1 = {0}",DniVTyzdni.VypisDenVTyzdni("1"));
            Console.WriteLine("Deň 2 = {0}", DniVTyzdni.VypisDenVTyzdni("2"));
            Console.WriteLine("Deň 3 = {0}", DniVTyzdni.VypisDenVTyzdni("3"));
            Console.WriteLine("Deň 4 = {0}", DniVTyzdni.VypisDenVTyzdni("4"));
            Console.WriteLine("Deň 5 = {0}", DniVTyzdni.VypisDenVTyzdni("5"));
            Console.WriteLine("Deň 6 = {0}", DniVTyzdni.VypisDenVTyzdni("6"));
            Console.WriteLine("Deň 7 = {0}", DniVTyzdni.VypisDenVTyzdni("7"));
            Console.WriteLine("\n");
            Console.WriteLine("Deň 1 = {0} (Nedela prvá = true)", DniVTyzdni.VypisDenVTyzdni("1",true));
            Console.WriteLine("Deň 2 = {0}", DniVTyzdni.VypisDenVTyzdni("2", true));
            Console.WriteLine("Deň 3 = {0}", DniVTyzdni.VypisDenVTyzdni("3", true));
            Console.WriteLine("Deň 4 = {0}", DniVTyzdni.VypisDenVTyzdni("4", true));
            Console.WriteLine("Deň 5 = {0}", DniVTyzdni.VypisDenVTyzdni("5", true));
            Console.WriteLine("Deň 6 = {0}", DniVTyzdni.VypisDenVTyzdni("6", true));
            Console.WriteLine("Deň 7 = {0}", DniVTyzdni.VypisDenVTyzdni("7", true));
            Console.ReadLine();
            
        }
            

    }
}
