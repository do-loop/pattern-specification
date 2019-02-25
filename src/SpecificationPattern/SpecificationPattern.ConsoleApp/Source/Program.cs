using System;
using System.Linq;
using SpecificationPattern.Data;
using SpecificationPattern.Extensions;
using SpecificationPattern.Implementations.Specifications;

namespace SpecificationPattern.ConsoleApp.Source
{
    internal class Program
    {
        private static void Main()
        {
            Example_01();

            Console.WriteLine();

            Example_02();

            Console.WriteLine();

            Example_03();

            Console.WriteLine();

            Example_04();

            Console.ReadKey();
        }

        private static void Example_01()
        {
            DataStorage.Users
                .Where(Administrators.New())
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            DataStorage.Users
                .Where(new Administrators())
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            DataStorage.Users
                .Where(Administrators.New().Not())
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            DataStorage.Users
                .Where(!Administrators.New())
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static void Example_02()
        {
            DataStorage.Users
                .Where(WithName.New("Виктор"))
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            DataStorage.Users
                .Where(WithName.New("Виктор").Not())
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            DataStorage.Users
                .Where(new WithName("Виктор"))
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            DataStorage.Users
                .Where(!WithName.New("Виктор"))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static void Example_03()
        {
            DataStorage.Users
                .Where(WithName.New("Виктор") & Administrators.New())
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            DataStorage.Users
                .Where(WithName.New("Виктор").And(new Administrators()))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static void Example_04()
        {
            DataStorage.Users
                .Where(WithName.New("Денис") | Administrators.New())
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            DataStorage.Users
                .Where(WithName.New("Денис").Or(new Administrators()))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}