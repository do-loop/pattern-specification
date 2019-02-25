using System;
using System.Linq.Expressions;
using SpecificationPattern.Models;

namespace SpecificationPattern.Implementations.Specifications
{
    public class WithName : Specification<User>
    {
        protected string Name { get; }

        public WithName(string name)
        {
            Name = name;
        }

        public override Expression<Func<User, bool>> ToExpression()
        {
            return x => string.Equals(x.Name, Name, StringComparison.CurrentCultureIgnoreCase);
        }

        public static WithName New(string name) => new WithName(name);
    }
}