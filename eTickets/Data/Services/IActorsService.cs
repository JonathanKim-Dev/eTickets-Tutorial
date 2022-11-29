using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        //These are the return types
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        Task DeleteAsync(int id);


    }
}
