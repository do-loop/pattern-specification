using System;
using System.Linq.Expressions;

namespace SpecificationPattern.Interfaces
{
    public interface ISpecification<TEntity>
    {
        Expression<Func<TEntity, bool>> ToExpression();

        bool IsSatisfiedBy(TEntity entity);
    }
}