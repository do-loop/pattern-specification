using System.Collections.Generic;
using SpecificationPattern.Implementations;
using SpecificationPattern.Models;

namespace SpecificationPattern.Interfaces.Repositories
{
    public interface IUserRepository
    {
        List<User> Find(Specification<User> specification);
    }
}