using NorthwindLibrary;
using System.Collections.Generic;

namespace CachingSolutionsSamples.Employees
{
    public interface IEmployeeCache
    {
        IEnumerable<Employee> Get(string forUser);
        void Set(string forUser, IEnumerable<Employee> employees);
    }
}
