using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerCors.Entity;
using CustomerCors.Interface;

namespace AmistServer.API
{
    public class CustomerController : MISAEntityController<Customer>
    {
        IBaseService<Customer> _customerService;
        IBaseRepo<Customer> _customerRepo;
        public CustomerController(IBaseService<Customer> customerService,
             IBaseRepo<Customer> customerExcute) : base(customerService, customerExcute)
        {
            _customerService = customerService;
            _customerRepo = customerExcute;
        }
    }
}
