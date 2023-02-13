using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainnePortal.Migrations
{
    /// <inheritdoc />
    public partial class reg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrainneDetails",
                columns: table => new
                {
                    EmployeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fatherName = table.Column<string>(name: "father_Name", type: "nvarchar(max)", nullable: false),
                    birthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passOutYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    college = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pincode = table.Column<int>(type: "int", nullable: false),
                    mobilenumber = table.Column<string>(name: "mobile_number", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainneDetails", x => x.EmployeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainneDetails");
        }
    }
}
