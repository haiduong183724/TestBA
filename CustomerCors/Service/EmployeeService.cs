using AmistServer.Object;
using CustomerCors.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerCors.Service
{
    public class EmployeeService :MISABaseService<Employee>, IEmployeeService
    {
        public IEmployeeRepo _icustomer;
        public EmployeeService(IEmployeeRepo _excute):base(_excute)
        {
            _icustomer = _excute;
        }

    }
}
