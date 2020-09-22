using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5WithDIAndAuthontication.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<EmployeeModel> _Employees;

        public MockEmployeeRepository()
        {
            _Employees = new List<EmployeeModel>() {
                new EmployeeModel() { Code = "NXT001", Name = "Anil Kumar" },
                new EmployeeModel() { Code = "NXT002", Name = "Anil Verma" }
            };
        }
        public EmployeeModel Add(EmployeeModel model)
        {
            _Employees.Add(model);
            return model;
        }

        public List<EmployeeModel> GetAll()
        {
            return _Employees;
        }
    }
}