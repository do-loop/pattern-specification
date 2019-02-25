using SpecificationPattern.Constants;

namespace SpecificationPattern.Models
{
    public class UserRole
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public UserRole(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() =>
            $"Id: {Id}, Name: {Name}.";

        public static UserRole Administrator =>
            new UserRole(1, UserRoles.Administrator);

        public static UserRole Student =>
            new UserRole(2, UserRoles.Student);
    }
}