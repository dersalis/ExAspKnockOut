using System.Collections.Generic;
using AspKnockOut.Models;

namespace AspKnockOut.Repository
{
  public class AddressRepository : IAddressRepository
  {
    private readonly AddressContext _context;

    public AddressRepository(AddressContext context)
    {
        _context = context;
    }

    public void Add(Address address)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Address> GetAll()
    {
      return _context.Addresses;
    }

    public void Remove(int id)
    {
      throw new System.NotImplementedException();
    }

    public void Update(int id, Address address)
    {
      throw new System.NotImplementedException();
    }
  }
}