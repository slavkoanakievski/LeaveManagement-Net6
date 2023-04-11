using LeaveManagement.Net.Contracts;
using LeaveManagement.Net.Data;

namespace LeaveManagement.Net.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
