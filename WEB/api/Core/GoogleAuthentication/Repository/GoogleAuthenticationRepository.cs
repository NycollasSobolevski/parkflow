using Genesis.Core.Repositories;
using api.Domain.Repositories;
using api.Domain.Models;

namespace api.Core.Repositories;
public class GoogleAuthenticationRepository(ParkFlowContext context) 
    : BaseRepository<GoogleAuthentication> (context), IGoogleAuthenticationRepository
{}
