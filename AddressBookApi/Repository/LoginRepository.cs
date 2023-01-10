using AddressBookApi.Contract;
using AddressBookApi.Data;
using AddressBookApi.Entities.Model;
using Microsoft.EntityFrameworkCore;

namespace AddressBookApi.Repository
{
    public class LoginRepository : ILogin
    {
        private readonly AddressBookDbContext context;
        public LoginRepository(AddressBookDbContext context)
        {
            this.context = context;
        }
        /// <summary>
        /// This methods is used to create a userlogin.
        /// </summary>
        /// <param name="credential"></param>
        public void CreateLogin(LoginCredential credential)
        {
            context.LoginCredential.Add(credential);
        }

        /// <summary>
        /// This methods used to have a login.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>boolean</returns>
        public bool IdIsPresent(Guid Id)
        {
            return context.LoginCredential.Any(x => x.Id == Id);
        }
        /// <summary>
        ///  This methods returns the list of the logincredentials of the user.
        /// </summary>
        /// <returns>List of LoginCredential</returns>
        public List<LoginCredential> GetAll()
        {
            return context.LoginCredential.ToList();
        }

        /// <summary>
        /// This methods is used update the login of the user
        /// </summary>
        /// <param name="newlogin"></param>
        public void Update(LoginCredential newlogin)
        {
            context.LoginCredential.Update(newlogin);
        }
    }
}
