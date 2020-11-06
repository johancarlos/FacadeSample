using System;
namespace Laboratorio4
{
    public class PrinterFacade
    {
        private PageSize pageSize;
        private DocumentFormat documentFormat;

        public PrinterFacade()
        {
            pageSize = new PageSize();
            documentFormat = new DocumentFormat();
        }

        public void Print()
        {
            Console.WriteLine("******** Printing a Document **********\n");
            Console.WriteLine("tamano del papel de impresion: ");
            pageSize.GetSize();
            Console.WriteLine("Formato documento a impresion: ");
            documentFormat.GetFormat();
            Console.WriteLine("\n******** Printed Succesfull **********");
        }
    }
}
