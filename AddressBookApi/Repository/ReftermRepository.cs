using AddressBookApi.Contract;
using AddressBookApi.Data;
using AddressBookApi.Entities.Model;

namespace AddressBookApi.Repository
{
    public class ReftermRepository:IRefTerm
    {
        private readonly AddressBookDbContext context;
        public ReftermRepository(AddressBookDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// To get the Key by using the Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>RefTerm</returns>

        public RefTerm GetById(Guid Id)
        {
            return context.Types.FirstOrDefault(x => x.Id == Id && x.IsActive == true);
        }
        /// <summary>
        /// To get the id by using the kay
        /// </summary>
        /// <param name="Key"></param>
        /// <returns>RefTerm</returns>
        public RefTerm GetByKey(string Key)
        {
            return context.Types.Where(x=>x.Key==Key).FirstOrDefault();
        }
    }
}
