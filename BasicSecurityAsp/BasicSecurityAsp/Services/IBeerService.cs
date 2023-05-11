using BasicSecurityAsp.Models;

namespace BasicSecurityAsp.Services
{
    public interface IBeerService
    {
        public Task<List<Beer>> Get();
    }
}
