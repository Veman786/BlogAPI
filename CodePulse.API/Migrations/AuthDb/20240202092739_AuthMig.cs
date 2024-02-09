using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodePulse.API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class AuthMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc267ec-d43c-4e3b-8108-a1a1f819906d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "379233d5-0782-4c0e-b40b-690fba55c40b", "AQAAAAIAAYagAAAAEKlOAieRIVsfIw2syt++e60fy793vuT78QHg4wVEmDfjCrrlce66ZnzwUHyDQSGasA==", "7ad59820-3f17-42a9-8266-457728862e63" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc267ec-d43c-4e3b-8108-a1a1f819906d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36133d24-05e9-47a7-92e7-26a3a04657c0", "AQAAAAIAAYagAAAAEFFugz4+/jgC5expBuZd0vaXRKHu8AQ7CVNbM+H1sHeylsaLv2GJzpByC5lk785NFQ==", "17a80c1d-54b0-4a38-836d-07d816449916" });
        }
    }
}
