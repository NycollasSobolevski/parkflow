using Genesis.Core.Repositories;
using api.Domain.Repositories;
using api.Domain.Models;

namespace api.Core.Repositories;
public class CompanySettingsRepository(ParkFlowContext context) 
    : BaseRepository<CompanySettings> (context), ICompanySettingsRepository
{}
