using Genesis.Core.Repositories;
using api.Domain.Repositories;
using api.Domain.Models;

namespace api.Core.Repositories;
public class VehicleAccessLogRepository(ParkFlowContext context) 
    : BaseRepository<VehicleAccessLog> (context), IVehicleAccessLogRepository
{}
