using Eaigle.SmokeEvent.API.Model;
using Eaigle.SmokeEvent.API.Repositories.Interfaces;
using EaigleWebService.Repository;

namespace Eaigle.SmokeEvent.API.Repositories;

public class SmokeEventRepository : RepositoryBaseAsync<TbSmokeEvent>, ISmokeEventRepository
{
    private readonly ApplicationDbContext _context;

    public SmokeEventRepository(ApplicationDbContext context)
     : base(context)
    {
        _context = context;
    }
}
