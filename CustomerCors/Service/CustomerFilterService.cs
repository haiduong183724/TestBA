using AmistServer.Object;
using CustomerCors.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerCors.Service
{
    public class CustomerFilterService :MISABaseService<Employee>, ICustomerFilterData
    {
        public ICustomerExcute _icustomer;
        public CustomerFilterService(ICustomerExcute _excute):base(_excute)
        {
            _icustomer = _excute;
        }

        public bool ValidateEmployee(Employee employee)
        {
            return _icustomer.CheckCodeExits(employee.EmployeeCode);
        }
        protected override bool ValidateData(Employee employee)
        {
            //kiểm tra mã nhân viên có hay chưa
            return _icustomer.CheckCodeExits(employee.EmployeeCode);
        }
    }
}
