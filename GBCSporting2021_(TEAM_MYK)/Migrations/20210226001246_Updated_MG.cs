using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GBCSporting2021__TEAM_MYK_.Migrations
{
    public partial class Updated_MG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Country_CountryId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CountryId",
                table: "Customers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOpened",
                table: "Incidents",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateClosed",
                table: "Incidents",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "CountryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2021, 2, 25, 19, 12, 45, 512, DateTimeKind.Local).AddTicks(968), new DateTime(2021, 2, 25, 19, 12, 45, 512, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2021, 2, 25, 19, 12, 45, 512, DateTimeKind.Local).AddTicks(1320), new DateTime(2021, 2, 25, 19, 12, 45, 512, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 3,
                columns: new[] { "DateClosed", "DateOpened", "Description" },
                values: new object[] { new DateTime(2021, 2, 25, 19, 12, 45, 512, DateTimeKind.Local).AddTicks(1331), new DateTime(2021, 2, 25, 19, 12, 45, 512, DateTimeKind.Local).AddTicks(1328), "Yes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 25, 19, 12, 45, 507, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 25, 19, 12, 45, 510, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 25, 19, 12, 45, 510, DateTimeKind.Local).AddTicks(9467));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReleaseDate",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateOpened",
                table: "Incidents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateClosed",
                table: "Incidents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "CountryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { "1-14-2013", "9-2-2012" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { "8-19-2012", "5-21-1992" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 3,
                columns: new[] { "DateClosed", "DateOpened", "Description" },
                values: new object[] { "3-18-2019", "12-3-2017", "Yes ./." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: "12-12-2020");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: "11-13-2012");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: "2-23-2018");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CountryId",
                table: "Customers",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Country_CountryId",
                table: "Customers",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
