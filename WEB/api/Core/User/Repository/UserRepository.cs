using Genesis.Core.Repositories;
using api.Domain.Repositories;
using api.Domain.Models;

namespace api.Core.Repositories;
public class UserRepository(ParkFlowContext context) 
    : BaseRepository<User> (context), IUserRepository
{}
