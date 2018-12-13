using System.Collections.Generic;
using AspKnockOut.Models;

namespace AspKnockOut.Repository
{
    public interface IAddressRepository
    {
         IEnumerable<Address> GetAll();
         void Add(Address address);
         void Remove(int id);
         void Update(int id, Address address);

    }
}