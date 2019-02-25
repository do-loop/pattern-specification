using System.Collections.Generic;
using SpecificationPattern.Models;

namespace SpecificationPattern.Data
{
    public static class DataStorage
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
    }
}