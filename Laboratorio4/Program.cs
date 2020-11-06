using System;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "FACADE Sample";
            PrinterFacade facade = new PrinterFacade();


            string res = "";
            do
            {
                Console.WriteLine("====== Imprimir ======");
                Console.WriteLine("Seleccionar Tamano de pagina");
                Console.WriteLine("1. A4");
                Console.WriteLine("2. CARTA");
                Console.WriteLine("3. OFICIO");
                Console.WriteLine("Elegir Operacion: ");
                res = Console.ReadLine();
                string eleccion = Convert.ToString(res);
                PageSize size = new PageSize();

                switch (eleccion)
                {
                    case "1":
                        size.SetSize("A4");
                        break;
                    case "2":
                        size.SetSize("CARTA");
                        break;
                    case "3":
                        size.SetSize("OFICIO");
                        break;
                }
                res = null;
            }
            while (res != null);


            string res1 = "";
            do
            {
                Console.WriteLine("Seleccionar Formato de Doc.");
                Console.WriteLine("1. PDF");
                Console.WriteLine("2. DOCX");
                Console.WriteLine("3. CSV");
                Console.WriteLine("Elegir Operacion: ");
                res1 = Console.ReadLine();
                string eleccion = Convert.ToString(res1);
                DocumentFormat format = new DocumentFormat();

                switch (eleccion)
                {
                    case "1":
                        format.SetFormat("PDF");
                        break;
                    case "2":
                        format.SetFormat("DOCX");
                        break;
                    case "3":
                        format.SetFormat("CSV");
                        break;
                }
                res1 = null;
            }
            while (res1 != null);

            facade.Print();
            Console.ReadKey();

        }
    }
}
