// <auto-generated />
using System;
using AddressBookApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AddressBookApi.Migrations
{
    [DbContext(typeof(AddressBookDbContext))]
    partial class AddressBookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AddressBookApi.Entities.Model.Address", b =>
                {
                    b.Property<Guid>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Line1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RefTermAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RefTermCountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("ZipCode")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("AddressBookApi.Entities.Model.Email", b =>
                {
                    b.Property<Guid>("EmailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("RefTermEmailId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EmailId");

                    b.HasIndex("UserId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("AddressBookApi.Entities.Model.Files", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("FileContent")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("files");
                });

            modelBuilder.Entity("AddressBookApi.Entities.Model.LoginCredential", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoginCredential");
                });

            modelBuilder.Entity("AddressBookApi.Entities.Model.Phone", b =>
                {
                    b.Property<Guid>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<Guid>("RefTermPhoneId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PhoneId");

                    b.HasIndex("UserId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("AddressBookApi.Entities.Model.RefSet", b =>
                {
                    b.Property<Guid>("RefSetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("RefSetId");

                    b.ToTable("RefSets");

                    b.HasData(
                        new
                        {
                            RefSetId = new Guid("ec99373a-55aa-4bd6-b539-ba166e179915"),
                            CreatedOn = new DateTime(2022, 11, 9, 21, 29, 15, 644, DateTimeKind.Local).AddTicks(7990),
                            Description = "This Stores the AddressType of the Field",
                            IsActive = true,
                            Name = "Address_Type",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RefSetId = new Guid("2814b405-8632-44a7-899d-df02debd6669"),
                            CreatedOn = new DateTime(2022, 11, 9, 21, 29, 15, 644, DateTimeKind.Local).AddTicks(7994),
                            Description = "This Stores the EmailAddress of the Field",
                            IsActive = true,
                            Name = "Email_Address_Type",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RefSetId = new Guid("571f78de-39d5-4314-8674-bcaeae10d2c6"),
                            CreatedOn = new DateTime(2022, 11, 9, 21, 29, 15, 644, DateTimeKind.Local).AddTicks(7997),
                            Description = "This Stores the PhoneNumber of the Field",
                            IsActive = true,
                            Name = "Phone_Number_Type",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RefSetId = new Guid("7203ec52-e27c-403c-bb8b-56c15213e164"),
                            CreatedOn = new DateTime(2022, 11, 9, 21, 29, 15, 644, DateTimeKind.Local).AddTicks(8000),
                            Description = "This Stores the Country of the Field",
                            IsActive = true,
                            Name = "Country",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AddressBookApi.Entities.Model.RefTerm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ab3cb142-52cd-402b-b142-5c64cacbb048"),
                            CreatedOn = new DateTime(2022, 11, 9, 21, 29, 15, 644, DateTimeKind.Local).AddTicks(7798),
                            IsActive = true,
                            Key = "Personnel",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("4703fe06-cfc0-4272-b34c-792b806bc3b2"),
                            CreatedOn = new DateTime(2022, 11, 9, 21, 29, 15, 644, DateTimeKind.Local).AddTicks(7830),
                            IsActive = true,
                            Key = "Work",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("6003a954-578c-43d1-aac9-c97c5152a565"),
                            CreatedOn = new DateTime(2022, 11, 9, 21, 29, 15, 644, DateTimeKind.Local).AddTicks(7835),
                            IsActive = true,
                            Key = "Alternate",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("5daf1f9d-9128-456b-a242-7e5b83bec49c"),
                            CreatedOn = new DateTime(2022, 11, 9, 21, 29, 15, 644, DateTimeKind.Local).AddTicks(7838),
                            IsActive = true,
                            Key = "India",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("eaa7d815-1798-4846-932c-b5d7d8211da6"),
                            CreatedOn = new DateTime(2022, 11, 9, 21, 29, 15, 644, DateTimeKind.Local).AddTicks(7841),
                            IsActive = true,
                            Key = "UnitedStates",
                            UpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AddressBookApi.Entities.Model.SetRef", b =>
                {
                    b.Property<Guid>("SetRefId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("RefSetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RefTermId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("SetRefId");

                    b.ToTable("Sets");
                });

            modelBuilder.Entity("AddressBookApi.Entities.Model.UserDetails", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.ToTable("UserList");
                });

            modelBuilder.Entity("AddressBookApi.Entities.Model.Address", b =>
                {
                    b.HasOne("AddressBookApi.Entities.Model.UserDetails", "UserDetails")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDetails");
                });

            modelBuilder.Entity("AddressBookApi.Entities.Model.Email", b =>
                {
                    b.HasOne("AddressBookApi.Entities.Model.UserDetails", "UserDetails")
                        .WithMany("Emails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDetails");
                });

            modelBuilder.Entity("AddressBookApi.Entities.Model.Phone", b =>
                {
                    b.HasOne("AddressBookApi.Entities.Model.UserDetails", "UserDetails")
                        .WithMany("Phones")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDetails");
                });

            modelBuilder.Entity("AddressBookApi.Entities.Model.UserDetails", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Emails");

                    b.Navigation("Phones");
                });
#pragma warning restore 612, 618
        }
    }
}
