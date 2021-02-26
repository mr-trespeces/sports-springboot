using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GBCSporting2021__TEAM_MYK_.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postalcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Technicians",
                columns: table => new
                {
                    TechnicianId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicians", x => x.TechnicianId);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    IncidentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechnicianId = table.Column<int>(type: "int", nullable: true),
                    DateOpened = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateClosed = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.IncidentId);
                    table.ForeignKey(
                        name: "FK_Incidents_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, "Kyrgyzstan" },
                    { 2, "Brunei" },
                    { 3, "Kiribati" },
                    { 4, "Vanuatu" },
                    { 5, "Tajikistan" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "City", "CountryId", "Email", "Firstname", "Lastname", "Phone", "Postalcode", "State" },
                values: new object[,]
                {
                    { 1, "1396 Harvest Moon Dr", "Balykchy", 1, "yp.yoo@georgebrown.ca", "YP", "Yoo", "4167240128", "L3R 0L7", "Bishkek" },
                    { 2, "1863 Lynden Road", "Tutong", 2, "mark.tres@georgebrown.ca", "Mark", "Tres", "4161720326", "L0B 1B0", "Belait" },
                    { 3, "4354 Wallace Street", "Panjakent", 3, "kent.pedro@georgebrown.ca", "Kent", "Pedro", "4161932185", "V9R 3A8", "Norak" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Code", "Name", "Price", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "QWE123", "Bat", "10.99", new DateTime(2021, 2, 26, 15, 16, 7, 601, DateTimeKind.Local).AddTicks(5614) },
                    { 2, "ASD456", "Net", "15.55", new DateTime(2021, 2, 26, 15, 16, 7, 604, DateTimeKind.Local).AddTicks(8303) },
                    { 3, "ZXC789", "Ball", "$2.00", new DateTime(2021, 2, 26, 15, 16, 7, 604, DateTimeKind.Local).AddTicks(8329) }
                });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "TechnicianId", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "gowther@georgebrown.ca", "Gowther Kangman", "416-854-0113" },
                    { 2, "tiny.tony@gmail.com", "Tiny Tony", "4167542904" },
                    { 3, "duc.mihn@yahoo.com", "Duc Mihn", "4167125209" }
                });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "IncidentId", "CustomerId", "DateClosed", "DateOpened", "Description", "ProductId", "TechnicianId", "Title" },
                values: new object[] { 2, 2, new DateTime(2021, 2, 26, 15, 16, 7, 606, DateTimeKind.Local).AddTicks(793), new DateTime(2021, 2, 26, 15, 16, 7, 606, DateTimeKind.Local).AddTicks(781), "Broken leg because of the bat.", 1, 2, "Broken Leg" });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "IncidentId", "CustomerId", "DateClosed", "DateOpened", "Description", "ProductId", "TechnicianId", "Title" },
                values: new object[] { 1, 1, new DateTime(2021, 2, 26, 15, 16, 7, 606, DateTimeKind.Local).AddTicks(462), new DateTime(2021, 2, 26, 15, 16, 7, 606, DateTimeKind.Local).AddTicks(127), "The ball exploded.", 3, 1, "Explosion" });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "IncidentId", "CustomerId", "DateClosed", "DateOpened", "Description", "ProductId", "TechnicianId", "Title" },
                values: new object[] { 3, 3, new DateTime(2021, 2, 26, 15, 16, 7, 606, DateTimeKind.Local).AddTicks(810), new DateTime(2021, 2, 26, 15, 16, 7, 606, DateTimeKind.Local).AddTicks(807), "The net ripped.", 3, 3, "Ripped Net" });

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_CustomerId",
                table: "Incidents",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ProductId",
                table: "Incidents",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "Technicians");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
