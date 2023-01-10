using AddressBookApi.Contract;
using AddressBookApi.Controllers;
using AddressBookApi.Data;
using AddressBookApi.Entities.DTO;
using AddressBookApi.Filters;
using AddressBookApi.Repository;
using AddressBookApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using TestProject1.Data;

namespace TestProject1
{
    public class UnitTest1
    {
        AssetController _asset;
        Meta_DataController _metadata;
        AccountController _account;
        AddressBookDbContext context = AddressBookDbTests.addressBookDbContext();
        IAddressService addressService;
        IUser userrepo;
        ILogin login;
        IRefTerm termrepo;
        IEmail email;
        IRefSet refSet;
        IAddress address;
        IPhone phone;
        IFile file;
        public UnitTest1()
        {
            context = SeedData.ToSeed(context);
            userrepo = new UserRepository(context);
            login = new LoginRepository(context);
            termrepo = new ReftermRepository(context);
            email = new EmailRepository(context);
            refSet=new RefSetRepository(context);
            address=new AddressRepository(context);
            phone=new PhoneRepository(context);
            file=new FileRepository(context);
            addressService = new AddressService(userrepo,login,termrepo,email,refSet,address,phone);
            _account = new AccountController(addressService);
            _metadata = new Meta_DataController(addressService);
            _asset = new AssetController(addressService);
        }
        /// <summary>
        ///   To test the create method in the user
        /// </summary>
        [Fact]
        public void Create_ToCreateUser_ReturnOkResponses()
        {
            UserDetailsCreateDto user = new UserDetailsCreateDto()
            {
                FirstName = "kavinraja",
                LastName = "M",
                UserName = "Kavinraja",
                Password = "Kavin@77",
                Addresses = new List<AddressDto>(),
                Emails = new List<EmailDto>(),
                Phones = new List<PhoneDto>(),
            };
            user.Addresses.Add(new AddressDto()
            {
                Line1 = "46-A",
                Line2 = "Oodayam",
                City = "kaur",
                ZipCode = 433,
                StateName = "karur",
                Type = new Types()
                {
                    Key = "Alternate"
                },
                Country = new Types()
                {
                    Key = "Alternate"
                }
            });
            user.Emails.Add(new EmailDto()
            {
                EmailAddress = "Kavinraja1602@gmail.com",
                Type = new Types()
                {
                    Key = "Alternate"
                }
            });
            user.Phones.Add(new PhoneDto()
            {
                PhoneNumber = 9965992497,
                Type = new Types()
                {
                    Key = "Alternate"
                }
            });
            var account = _account.Post(user);
            Assert.IsType<OkObjectResult>(account);

            // If the userName is already exist
        
            account = _account.Post(user);
            Assert.IsType<ConflictObjectResult>(account);


            // If the email address is already exist
            user.UserName = "KavinKumar";
            Assert.IsType<ConflictObjectResult>(account);


            //If the RefTerm Not Found
            user.Emails[0].EmailAddress = "Kavinraja16021@gmail.com";
            user.Addresses[0].Type.Key = "aternat";
            account = _account.Post(user);
            Assert.IsType<NotFoundObjectResult>(account);
        }
        /// <summary>
        /// To test the Get all the user
        /// </summary>
        [Fact]
        public void GetAll()
        {
            Pagination page =new Pagination();
            var user=_account.Get(page);
            Assert.IsType<OkObjectResult>(user);
        }
        /// <summary>
        ///  To test the GetById
        /// </summary>
        /// <param name="Guid1"></param>
        /// <param name="Guid2"></param>
        [Theory]
        [InlineData("80006E81-80F8-4378-9CC1-FF022C3C4AF4", "80006E81-80F8-4378-9CC1-FF022C3C4AF7")]
        public void GetById(string Guid1,string Guid2)
        {
            Guid guid1 = new Guid(Guid1);
            var User = _account.GetById(guid1);
            Assert.NotNull(User);
            Assert.IsType<OkObjectResult>(User);
            var userdetails=User as OkObjectResult;
            UserDetailsDto check = userdetails.Value as UserDetailsDto;
            Assert.Equal("santhosh", check.FirstName);


            Guid guid2 = new Guid(Guid2);
            var User2 = _account.GetById(guid2);
            Assert.IsType<NotFoundResult>(User2);
        }


        /// <summary>
        /// To test the Metadata
        /// </summary>
        /// <param name="Key1"></param>
        /// <param name="Key2"></param>
        [Theory]
        [InlineData("AddressType", "EmailAddressType")]
        public void MetaData_MetadataType_ReturnOkresponse(string Key1, string Key2)
        {
            var metadata = _metadata.GetByKey(Key1);
            Assert.NotNull(metadata);
            Assert.IsType<OkObjectResult>(metadata);

            metadata = _metadata.GetByKey(Key2);
            Assert.NotNull(metadata);
            Assert.IsType<OkObjectResult>(metadata);
        }



        /// <summary>
        /// To test the Metadata
        /// </summary>
        /// <param name="Key1"></param>
        /// <param name="Key2"></param>
        [Theory]
        [InlineData("UserType")]
        public void MetaData_KeyNotFound_NotFound(string Key)
        {
            var metadata = _metadata.GetByKey(Key);
            Assert.NotNull(metadata);
            Assert.IsType<NotFoundObjectResult>(metadata);
        }


        /// <summary>
        ///  To test the Delete method
        /// </summary>
        /// <param name="guid1"></param>
        [Theory]
        [InlineData("80006E81-80F8-4378-9CC1-FF022C3C4AF4")]
        public void Delete_DeleteUser_ReturnOkResponse(string guid1)
        {
            Guid Guid1 = new Guid(guid1);
            Assert.IsType<OkResult>(_account.Delete(Guid1));
        }


        /// <summary>
        ///  To test the Delete method
        /// </summary>
        /// <param name="guid1"></param>
        [Theory]
        [InlineData("57CF03AE-9CA6-493F-8D51-2B469FCB45F9")]
        public void Delete_IdNotFound_ReturnNotFound(string guid2) { 

            Guid Guid2=new Guid(guid2);
            Assert.IsType<NotFoundObjectResult>(_account.Delete(Guid2));
        }


        /// <summary>
        /// To Test the Update method
        /// </summary>
        [Fact]
        public void Update_ToUpdateUser_OkResponses()
        {
            UserDetailsCreateDto user = new UserDetailsCreateDto()
            {
                FirstName = "kavin",
                LastName = "M",
                UserName = "Kavin",
                Password = "Kavin@77",
                Addresses = new List<AddressDto>(),
                Emails = new List<EmailDto>(),
                Phones = new List<PhoneDto>(),
            };
            user.Addresses.Add(new AddressDto()
            {
                Line1 = "46-A",
                Line2 = "Oodayam",
                City = "kaur",
                ZipCode = 433,
                StateName = "karur",
                Type = new Types()
                {
                    Key = "Alternate"
                },
                Country = new Types()
                {
                    Key = "Alternate"
                }
            });
            user.Emails.Add(new EmailDto()
            {
                EmailAddress = "Kavinraja1302@gmail.com",
                Type = new Types()
                {
                    Key = "Alternate"
                }
            });
            user.Phones.Add(new PhoneDto()
            {
                PhoneNumber = 9965992498,
                Type = new Types()
                {
                    Key = "Alternate"
                }
            });
            Guid Id = new Guid("80006E81-80F8-4378-9CC1-FF022C3C4AF4");
            var update = _account.Update(user, Id);
            Assert.IsType<OkObjectResult>(update);
            var OkResponse=update as OkObjectResult;
            var updatedUser = OkResponse.Value as UserDetailsDto;
            Assert.Equal("kavin", updatedUser.FirstName);



            // To check the userId does not in the database and return not found

            Id = new Guid("80006E81-80F8-4378-9CC1-FF022C3C4AF7");
            update = _account.Update(user, Id);
            Assert.IsType<NotFoundObjectResult>(update);
        }


        /// <summary>
        ///  To test the Count method
        /// </summary>
        [Fact]
        public void CountUser_Count_ReturnOkResponses()
        {
            var actionResult = _account.GetCount();
            OkObjectResult result=actionResult as OkObjectResult;
            var count = (int)result.Value;
            Assert.Equal(1, count);
        }

        [Fact]
        public void UploadFie_ReturnOkResponse()
        {
            string content = "It is a fake file";
            string FileName = "Test.Pdf";
            MemoryStream stream =new MemoryStream();
            var writer=new StreamWriter(stream);
            writer.Write(content);
            writer.Flush();
            stream.Position = 0;
            IFormFile file=new FormFile(stream,0,stream.Length,"Id",FileName);

            var response=_asset.Post(file);
            Assert.NotNull(response);
            Assert.IsType<OkObjectResult>(response);

        }
    }
}