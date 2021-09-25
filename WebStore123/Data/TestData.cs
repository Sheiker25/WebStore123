using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore123.Models;

namespace WebStore123.Data
{
    public static class TestData
    {
        public static List<Employee> Employees { get; } = new()
        {
            new Employee { Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 27 },
            new Employee { Id = 2, LastName = "Сергеев", FirstName = "Сергей", Patronymic = "Сергеевич", Age = 17 },
            new Employee { Id = 3, LastName = "Денисов", FirstName = "Денис", Patronymic = "Денисович", Age = 27 },
        };
    }
}
