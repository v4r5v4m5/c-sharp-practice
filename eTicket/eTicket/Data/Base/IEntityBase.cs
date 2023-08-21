using eTicket.Models;

namespace eTicket.Data.Base
{
    public interface IEntityBaseRepository
    {
        int Id { get; set; }
        /*Task<IEnumerable<Actor>> GetAllAsync();

        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        Task DeleteAsync(int id);*/
    }
}
