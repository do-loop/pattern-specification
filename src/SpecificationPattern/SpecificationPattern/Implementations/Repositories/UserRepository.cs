using System.Collections.Generic;
using System.Linq;
using SpecificationPattern.Data;
using SpecificationPattern.Interfaces.Repositories;
using SpecificationPattern.Models;

namespace SpecificationPattern.Implementations.Repositories
{
    public class UserRepository : IUserRepository
    {
        protected IReadOnlyList<User> Users = DataStorage.Users;

        public List<User> Find(Specification<User> specification)
        {
            return Users.AsQueryable()
                .Where(specification)
                .ToList();
        }
    }
}