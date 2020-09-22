using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5WithDIAndAuthontication.Models
{
    public interface IEmployeeRepository
    {
        EmployeeModel Add(EmployeeModel model);
        List<EmployeeModel> GetAll();
    }
}
