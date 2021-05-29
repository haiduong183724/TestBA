using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmistServer.Object;
using CustomerCors.Interface;

namespace AmistServer.API
{
    public class EmployeeController: MISAEntityController<Employee>
    {
        ICustomerFilterData _customerService;
        ICustomerExcute _customerExcute;
        public EmployeeController(ICustomerFilterData customerService,
             ICustomerExcute customerExcute):base(customerService, customerExcute)
        {
            _customerService = customerService;
            _customerExcute = customerExcute;
        }
        [HttpGet("Pagging")]
        public IActionResult Get(int index)
        {
            var employees = _customerExcute.GetPageTen(index);
            return Ok(employees);
        }
    }
}
