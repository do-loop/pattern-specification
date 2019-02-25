using System;
using System.Linq.Expressions;
using SpecificationPattern.Models;

namespace SpecificationPattern.Implementations.Specifications
{
    public class WithAge : Specification<User>
    {
        protected int Age { get; }

        public WithAge(int age)
        {
            Age = age;
        }

        public override Expression<Func<User, bool>> ToExpression()
        {
            return x => x.Age == Age;
        }

        public static WithAge New(int age) => new WithAge(age);
    }
}