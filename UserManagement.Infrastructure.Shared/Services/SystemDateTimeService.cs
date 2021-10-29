using UserManagement.Application.Interfaces.Shared;
using System;

namespace UserManagement.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}