using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //  App need to support multiple database type:
            //      + SQL Server, MySQL, PostgreSQL
            //      + Isolate database type from application
            
            //  Need to create different report type
            //      + PDF, Word, Excel, etc


            //  Provides an abstract class
            //      - Generalized interface
            //      - Hides details from the rest of application
            //      - Factory class creates an instance of a class that inherits or implements the abstract class
            //      - In conjunction with Factory Method pattern
            Console.WriteLine("Hello World!");
        }
    }
}
