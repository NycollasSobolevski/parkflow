using Genesis.Core.Repositories;
using api.Domain.Repositories;
using api.Domain.Models;

namespace api.Core.Repositories;
public class AddressRepository(ParkFlowContext context) 
    : BaseRepository<Address> (context), IAddressRepository
{}
