using AgendarConsultas.Model;
using Bogus;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendarConsultas.Data.Migrations
{
    /// <inheritdoc />
    public partial class MockEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            new Faker<Client>("pt_BR")
                .RuleFor(x => x.Name, f => f.Person.FullName)
                .RuleFor(x => x.Cell, f => f.Phone.PhoneNumber())
                .RuleFor(x => x.Email, (f, u) => f.Internet.Email(u.Name))
                .RuleFor(x => x.ClinicId, f => f.Random.Int(1,5))
                .Generate(15)
                .ForEach(c =>
                {
                    migrationBuilder.InsertData(
                        schema: "schedule",
                        table: "client",
                        columns: ["uuid", "name", "email", "cell", "clinic_id"],
                        values: new object[,] { { Guid.NewGuid(), c.Name, c.Email, c.Cell, c.ClinicId } });
                });

            new Faker<Clinic>("pt_BR")
               .RuleFor(x => x.Name, f => f.Company.CompanyName())
               .RuleFor(x => x.Cell, f => f.Phone.PhoneNumber())
               .RuleFor(x => x.Email, (f, u) => f.Internet.Email(u.Name))
               .Generate(5)
               .ForEach(c =>
               {
                   migrationBuilder.InsertData(
                       schema: "schedule",
                       table: "clinic",
                       columns: ["uuid", "name", "email", "cell"],
                       values: new object[,] { { Guid.NewGuid(), c.Name, c.Email, c.Cell } });
               });

            new Faker<Pet>("pt_BR")
                .RuleFor(x => x.Name, f => f.Name.FirstName())
                .RuleFor(x => x.Race, f => f.Name.Suffix())
                .RuleFor(x => x.Year, f => f.Random.Int(1, 10))
                .RuleFor(x => x.ClientId, f => f.Random.Int(1, 15))
                .Generate(20)
                .ForEach(c =>
                {
                    migrationBuilder.InsertData(
                        schema: "schedule",
                        table: "pet",
                        columns: ["uuid", "name", "race", "year", "client_id"],
                        values: new object[,] { { Guid.NewGuid(), c.Name, c.Race, c.Year, c.ClientId } });
                });

            new Faker<Secretary>("pt_BR")
                .RuleFor(x => x.Name, f => f.Person.FullName)
                .RuleFor(x => x.Cell, f => f.Phone.PhoneNumber())
                .RuleFor(x => x.Email, (f, u) => f.Internet.Email(u.Name))
                .RuleFor(x => x.ClinicId, f => f.Random.Int(1, 5))
                .Generate(3)
                .ForEach(c =>
                {
                    migrationBuilder.InsertData(
                        schema: "schedule",
                        table: "client",
                        columns: ["uuid", "name", "email", "cell", "clinic_id"],
                        values: new object[,] { { Guid.NewGuid(), c.Name, c.Email, c.Cell, c.ClinicId } });
                });

            new Faker<Veterinary>("pt_BR")
                .RuleFor(x => x.Name, f => f.Person.FullName)
                .RuleFor(x => x.Cell, f => f.Phone.PhoneNumber())
                .RuleFor(x => x.Email, (f, u) => f.Internet.Email(u.Name))
                .RuleFor(x => x.ClinicId, f => f.Random.Int(1, 5))
                .Generate(5)
                .ForEach(c =>
                {
                    migrationBuilder.InsertData(
                        schema: "schedule",
                        table: "client",
                        columns: ["uuid", "name", "email", "cell", "clinic_id"],
                        values: new object[,] { { Guid.NewGuid(), c.Name, c.Email, c.Cell, c.ClinicId } });
                });

            
        }

      
    }
}
