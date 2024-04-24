using Microsoft.EntityFrameworkCore;
using MiniFootballApp.Infrastucture.Data;
using Microsoft.EntityFrameworkCore.InMemory;

namespace MiniFootballApp.Tests.Mocks
{
    public static class DatabaseMock
    {
        public static MiniFootballDbContext Instsance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<MiniFootballDbContext>()
                    .UseInMemoryDatabase("MiniFootballInMemoryDb" 
                        + DateTime.Now.Ticks.ToString())
                    .Options;

                return new MiniFootballDbContext(dbContextOptions, false);
            }
        }
    }
}
