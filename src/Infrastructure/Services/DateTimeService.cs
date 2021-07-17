using Matrix.Application.Common.Interfaces;
using System;

namespace Matrix.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
