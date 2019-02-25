using System.Collections.Generic;
using System.Linq;
using SpecificationPattern.Extensions;
using SpecificationPattern.Implementations.Specifications;
using SpecificationPattern.Models;
using Xunit;

namespace SpecificationPattern.Tests.Source
{
    public class SpecificationTests
    {
        public static IReadOnlyList<User> Users = new List<User>
        {
            User.Student(4, 16, "Денис"),
            User.Student(5, 23, "Евгений"),
            User.Student(2, 21, "Дмитрий"),
            User.Student(3, 20, "Максим"),
            User.Student(6, 16, "Семён"),
            User.Student(7, 18, "Алексей"),
            User.Student(8, 13, "Михаил"),
            User.Student(9, 27, "Виктор"),
            User.Administrator(1, 18, "Виктор")
        };

        [Fact]
        public void Test_1()
        {
            var users = Users.AsQueryable()
                .Where(new Administrators())
                .ToList();

            Assert.Single(users);
            Assert.Equal(1, users.Single().Id);
            Assert.Equal(18, users.Single().Age);

            users = Users.AsQueryable()
                .Where(Administrators.New())
                .ToList();

            Assert.Single(users);
            Assert.Equal(1, users.Single().Id);
            Assert.Equal(18, users.Single().Age);

            users = Users.AsQueryable()
                .Where(WithName.New("Виктор"))
                .ToList();

            Assert.Equal(2, users.Count);
            Assert.Equal(27, users.First().Age);
            Assert.Equal(18, users.Last().Age);
        }

        [Fact]
        public void Test_2()
        {
            var users = Users.AsQueryable()
                .Where(Administrators.New() & WithName.New("Виктор"))
                .ToList();

            Assert.Single(users);
            Assert.Equal(1, users.Single().Id);
            Assert.Equal(18, users.Single().Age);

            users = Users.AsQueryable()
                .Where(Administrators.New().And(WithName.New("Алексей")))
                .ToList();

            Assert.Empty(users);
        }

        [Fact]
        public void Test_3()
        {
            var users = Users.AsQueryable()
                .Where(Administrators.New() | WithName.New("Виктор"))
                .ToList();

            Assert.Equal(2, users.Count);
            Assert.Equal(27, users.First().Age);
            Assert.Equal(18, users.Last().Age);

            users = Users.AsQueryable()
                .Where(Administrators.New().Or(WithName.New("Алексей")).Not())
                .ToList();

            Assert.Equal(7, users.Count);
        }
    }
}