using Genesis.Core.Repositories;
using api.Domain.Repositories;
using api.Domain.Models;

namespace api.Core.Repositories;
public class VehicleRepository(ParkFlowContext context) 
    : BaseRepository<Vehicle> (context), IVehicleRepository
{}
