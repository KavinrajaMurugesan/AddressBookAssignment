using AddressBookApi.Data;
using AddressBookApi.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Data
{
    public static class SeedData
    {

        /// <summary>
        /// Thids method is used to Seed data in database
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static AddressBookDbContext ToSeed(AddressBookDbContext context)
        {
            context.Types.AddRange(new RefTerm()
            {
                Id = Guid.Parse("ab3cb142-52cd-402b-b142-5c64cacbb048"),
                Key = "Personnel"
            },
            new RefTerm()
            {
                Id = Guid.Parse("4703fe06-cfc0-4272-b34c-792b806bc3b2"),
                Key = "Work"
            },
            new RefTerm()
            {
                Id = Guid.Parse("6003A954-578C-43D1-AAC9-C97C5152A565"),
                Key = "Alternate"
            },
            new RefTerm()
            {
                Id = Guid.Parse("5DAF1F9D-9128-456B-A242-7E5B83BEC49C"),
                Key = "India"
            },
            new RefTerm()
            {
                Id = Guid.Parse("EAA7D815-1798-4846-932C-B5D7D8211DA6"),
                Key = "UnitedStates"
            }
            );
            context.UserList.Add(new UserDetails()
            {
                UserId = Guid.Parse("80006E81-80F8-4378-9CC1-FF022C3C4AF4"),
                FirstName = "santhosh",
                LastName = "P",
                Addresses = new List<Address>()
                {
                    new Address()
                    {
                        AddressId=new Guid(),
                        Line1 = "46-A",
                        Line2 = "Oodayam",
                        City = "kaur", CreatedOn = DateTime.Now,
                        ZipCode = 433,
                        StateName = "karur",
                        RefTermAddressId=Guid.Parse("ab3cb142-52cd-402b-b142-5c64cacbb048"),
                        RefTermCountryId=Guid.Parse("5DAF1F9D-9128-456B-A242-7E5B83BEC49C")
                    }
                },
                Emails = new List<Email>()
                {
                    new Email()
                    {
                        EmailId=new Guid(),
                        EmailAddress="Kavin123@gmail.com",
                        RefTermEmailId=Guid.Parse("EAA7D815-1798-4846-932C-B5D7D8211DA6")
                    }
                },
                Phones = new List<Phone>()
                {
                    new Phone()
                    {
                        PhoneId=new Guid(),
                        PhoneNumber=9965992497,
                        RefTermPhoneId=Guid.Parse("4703fe06-cfc0-4272-b34c-792b806bc3b2")
                    }
                }

            });
            context.LoginCredential.Add(new LoginCredential()
            {
                Id = Guid.Parse("80006E81-80F8-4378-9CC1-FF022C3C4AF4"),
                UserName = "Santhosh",
                Password = "Sant0sh@123"
            });
            context.RefSets.AddRange(new RefSet()
            {
                RefSetId = Guid.Parse("EC99373A-55AA-4BD6-B539-BA166E179915"),
                Name = "Address_Type",
                Description = "This Stores the AddressType of the Field"
            },
            new RefSet()
            {
                RefSetId = Guid.Parse("2814B405-8632-44A7-899D-DF02DEBD6669"),
                Name = "Email_Address_Type",
                Description = "This Stores the EmailAddress of the Field"
            },
            new RefSet()
            {
                RefSetId = Guid.Parse("571F78DE-39D5-4314-8674-BCAEAE10D2C6"),
                Name = "Phone_Number_Type",
                Description = "This Stores the PhoneNumber of the Field"
            },
            new RefSet()
            {
                RefSetId = Guid.Parse("7203EC52-E27C-403C-BB8B-56C15213E164"),
                Name = "Country",
                Description = "This Stores the Country of the Field"
            });
            context.SaveChanges();
            return context;
        }
    }
}
