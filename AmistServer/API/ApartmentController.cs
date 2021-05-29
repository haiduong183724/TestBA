using CustomerCors.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerCors.Entity;
namespace AmistServer.API
{
    
    public class ApartmentController : MISAEntityController<Apartment>
    {
        IBaseService<Apartment> _apartmentService;
        IBaseRepo<Apartment> _apartmentRepo;
        #region Instructor
        public ApartmentController(IBaseService<Apartment> apartmentService,
        IBaseRepo<Apartment> apartmentRepo):base(apartmentService,apartmentRepo)
        {
            _apartmentService = apartmentService;
            _apartmentRepo = apartmentRepo;
        }
        #endregion

    }
}
