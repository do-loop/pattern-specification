namespace SpecificationPattern.Models
{
    public class User
    {
        public int Id { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public UserRole Role { get; set; }

        public User(int id, int age, string name)
        {
            Id = id;
            Age = age;
            Name = name;
        }

        public override string ToString() =>
            $"Id: {Id}, Age: {Age}, Name: {Name}, Role: {Role.Name}.";

        public static User Administrator(int id, int age, string name)
            => new User(id, age, name) { Role = UserRole.Administrator };

        public static User Student(int id, int age, string name)
            => new User(id, age, name) { Role = UserRole.Student };
    }
}