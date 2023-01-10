using AddressBookApi.Entities.Model;
namespace AddressBookApi.Contract
{
    public interface ILogin
    {
        /// <summary>
        ///  This methods returns the list of the logincredentials of the user.
        /// </summary>
        /// <returns>List of LoginCredential</returns>
        public List<LoginCredential> GetAll();

        /// <summary>
        /// This methods is used to create a userlogin.
        /// </summary>
        /// <param name="credential"></param>
        public void CreateLogin(LoginCredential credential);

        /// <summary>
        /// This methods is used update the login of the user
        /// </summary>
        /// <param name="newlogin"></param>
        public void Update(LoginCredential newlogin);

        /// <summary>
        /// This methods used to have a login.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>boolean</returns>
        public bool IdIsPresent(Guid Id);
    }
}
