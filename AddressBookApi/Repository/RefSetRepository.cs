using AddressBookApi.Contract;
using AddressBookApi.Data;
using AddressBookApi.Entities.Model;

namespace AddressBookApi.Repository
{
    public class RefSetRepository : IRefSet
    {
        private readonly AddressBookDbContext context;
        public RefSetRepository(AddressBookDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// To get all the Refset
        /// </summary>
        /// <returns>List of RefSet</returns>
        public List<RefSet> GetAll()
        {
            return context.RefSets.ToList();
        }
    }
}
