using Genesis.Core.Repositories;
using api.Domain.Repositories;
using api.Domain.Models;

namespace api.Core.Repositories;
public class RoleRepository(ParkFlowContext context) 
    : BaseRepository<Role> (context), IRoleRepository
{}
