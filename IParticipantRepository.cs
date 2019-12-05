using Donation.Domain.Entities;
using System.Collections.Generic;
using Donation.Domain.Interfaces.Repositories;

namespace Donation.Domain.Interfaces
{
    public interface IParticipantRepository : IRepositoryBase<Participant>
    {
        IEnumerable<Participant> FindById(string Id);
    }
}
