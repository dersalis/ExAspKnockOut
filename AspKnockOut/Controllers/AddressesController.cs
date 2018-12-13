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
    public class AddressesController : Controller
    {
        private IAddressRepository _repository;
        public AddressesController(IAddressRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Address> Get()
        {
            return _repository.GetAll();
        }

        [HttpPost]
        public IActionResult Post([FromBody]Address address)
        {
            if(address != null)
            {
                _repository.Add(address);
                return CreatedAtAction("GetAddres", new { id = address.Id }, address);
                // return new OkResult();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
