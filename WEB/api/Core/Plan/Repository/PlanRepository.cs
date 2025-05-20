using Genesis.Core.Repositories;
using api.Domain.Repositories;
using api.Domain.Models;

namespace api.Core.Repositories;
public class PlanRepository(ParkFlowContext context) 
    : BaseRepository<Plan> (context), IPlanRepository
{}
