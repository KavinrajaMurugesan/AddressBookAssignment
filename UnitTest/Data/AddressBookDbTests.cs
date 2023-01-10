using AddressBookApi.Data;
using Microsoft.EntityFrameworkCore;

namespace TestProject1.Data
{
    public static class AddressBookDbTests
    {
        /// <summary>
        /// This method is used to create the InMemeorydatabase
        /// </summary>
        /// <returns></returns>
        public static  AddressBookDbContext addressBookDbContext()
        {
            var options = new DbContextOptionsBuilder<AddressBookDbContext>()
                .UseInMemoryDatabase(databaseName:Guid.NewGuid().ToString()).Options;
            var context = new AddressBookDbContext(options);
            return context;
        }
    }
}
