using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Labb1.Migrations
{
    public partial class FixImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://kbimages1-a.akamaihd.net/63661c91-7cb6-4ec0-bd67-9dd1810d00b2/353/569/90/False/harry-potter-och-hemligheternas-kammare.jpg");

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 2,
                column: "LoanDate",
                value: new DateTime(2022, 10, 13, 0, 32, 51, 27, DateTimeKind.Local).AddTicks(1213));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://image.bokus.com/images/9789129723960_200x_harry-potter-och-hemligheternas-kammare");

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 2,
                column: "LoanDate",
                value: new DateTime(2022, 10, 13, 0, 31, 10, 810, DateTimeKind.Local).AddTicks(5872));
        }
    }
}
