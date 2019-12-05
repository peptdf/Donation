using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Donation.Domain.Interfaces.Repositories;

namespace Donation.Domain.Interfaces
{
    public interface IDonationRepository : IRepositoryBase<Donations>
    {
    }
}
