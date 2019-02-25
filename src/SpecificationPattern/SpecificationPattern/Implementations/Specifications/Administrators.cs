using System;
using System.Linq.Expressions;
using SpecificationPattern.Constants;
using SpecificationPattern.Models;

namespace SpecificationPattern.Implementations.Specifications
{
    public class Administrators : Specification<User>
    {
        public override Expression<Func<User, bool>> ToExpression()
        {
            return x => x.Role.Name == UserRoles.Administrator;
        }

        public static Administrators New() => new Administrators();
    }
}