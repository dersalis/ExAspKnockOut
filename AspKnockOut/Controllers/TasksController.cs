using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspKnockOut.Models;
using AspKnockOut.Repository;

namespace AspKnockOut.Controllers
{
    [Route("api/[controller]")]
    public class TasksController : Controller
    {
        private readonly IAddressRepository _repository;
        public TasksController(IAddressRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Address> Get()
        {
            return _repository.GetAll();
        }

    }
}
