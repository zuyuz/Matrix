using Matrix.Domain.Common;
using System.Threading.Tasks;

namespace Matrix.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
