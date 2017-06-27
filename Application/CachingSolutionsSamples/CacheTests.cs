using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading;
using CachingSolutionsSamples.Employees;
using CachingSolutionsSamples.Order;

namespace CachingSolutionsSamples
{


    [TestClass]
    public class CacheTests
    {
        [TestMethod]
        public void MemoryCache()
        {
            var categoryManager = new CategoriesManager(new CategoriesMemoryCache());

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(categoryManager.GetCategories().Count());
                Thread.Sleep(100);
            }

            var employeeManager = new EmployeesManager(new EmployeesMemoryCache());

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(employeeManager.GetEmployee().Count());
                Thread.Sleep(100);
            }

            var ordersManager = new OrderManager(new OrdersMemoryCache());

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(ordersManager.GetOrders().Count());
                Thread.Sleep(100);
            }
        }

        [TestMethod]
        public void RedisCache()
        {
            var categoryManager = new CategoriesManager(new CategoriesRedisCache("localhost"));

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(categoryManager.GetCategories().Count());
                Thread.Sleep(100);
            }

            var employeeManager = new EmployeesManager(new EmployeesRedisCache("localhost"));

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(employeeManager.GetEmployee().Count());
                Thread.Sleep(100);
            }

            var ordersManager = new OrderManager(new OrdersRedisCache("localhost"));

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(ordersManager.GetOrders().Count());
                Thread.Sleep(100);
            }
        }
    }
}