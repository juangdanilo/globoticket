using GloboTicket.TicketManagement.Domain.Entities;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        //Task<List<Event>> GetEventsByCategory(Guid categoryId);
        Task<bool> IsEventNameAndDateUnique(string eventName, DateTime date);
    }
}
