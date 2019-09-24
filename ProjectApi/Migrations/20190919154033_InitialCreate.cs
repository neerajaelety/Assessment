using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Intrests = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "Age", "FirstName", "Intrests", "LastName" },
                values: new object[] { 1, "Address", 30, "John", "Singing", "Robert" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "Age", "FirstName", "Intrests", "LastName" },
                values: new object[] { 2, "Address", 40, "Richard", "Browsing", "Dennis" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "Age", "FirstName", "Intrests", "LastName" },
                values: new object[] { 3, "Address", 44, "Richard", "Rafting", "Joe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
