using System;
using System.Linq;
using SpecificationPattern.Extensions;
using SpecificationPattern.Implementations.Repositories;
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
            new UserRepository()
                .Find(Administrators.New())
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            new UserRepository()
                .Find(new Administrators())
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            new UserRepository()
                .Find(Administrators.New().Not())
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            new UserRepository()
                .Find(!Administrators.New())
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static void Example_02()
        {
            new UserRepository()
                .Find(WithName.New("Виктор"))
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            new UserRepository()
                .Find(WithName.New("Виктор").Not())
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            new UserRepository()
                .Find(new WithName("Виктор"))
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            new UserRepository()
                .Find(!WithName.New("Виктор"))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static void Example_03()
        {
            new UserRepository()
                .Find(WithName.New("Виктор") & Administrators.New())
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            new UserRepository()
                .Find(WithName.New("Виктор").And(new Administrators()))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static void Example_04()
        {
            new UserRepository()
                .Find(WithName.New("Денис") | Administrators.New())
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine();

            new UserRepository()
                .Find(WithName.New("Денис").Or(new Administrators()))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}