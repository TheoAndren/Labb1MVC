using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Avalible = table.Column<bool>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBooks",
                columns: table => new
                {
                    CustomerBookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    LoanDate = table.Column<DateTime>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBooks", x => x.CustomerBookId);
                    table.ForeignKey(
                        name: "FK_CustomerBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerBooks_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Avalible", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "J.K. Rowling", false, "https://kbimages1-a.akamaihd.net/90aadf1a-79ea-4942-b055-2391cba20012/353/569/90/False/harry-potter-og-de-vises-sten.jpg", "Harry Potter och De Vises Sten" },
                    { 2, "J.K. Rowling", false, "https://kbimages1-a.akamaihd.net/63661c91-7cb6-4ec0-bd67-9dd1810d00b2/1200/1200/False/harry-potter-och-hemligheternas-kammare.jpg", "Harry Potter och Hemligheternas kammare" },
                    { 3, "J.K. Rowling", false, "https://kbimages1-a.akamaihd.net/f5e2b97b-0438-4cd5-8a47-09c26b3fb4cf/353/569/90/False/harry-potter-and-the-prisoner-of-azkaban-5.jpg", "Harry Potter and the Prisoner of Azkaban" },
                    { 4, "J.K. Rowling", false, "https://kbimages1-a.akamaihd.net/da827f3c-534e-4cdc-b1ae-103d8a8bf4c8/353/569/90/False/harry-potter-och-den-flammande-bagaren.jpg", "Harry Potter och den flammande bägaren" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "theokingen@gmail.com", "Theo", "Andrén" },
                    { 2, "Anasekung123@gmail.com", "Anas", "Qlok" }
                });

            migrationBuilder.InsertData(
                table: "CustomerBooks",
                columns: new[] { "CustomerBookId", "BookId", "CustomerId", "LoanDate", "ReturnDate" },
                values: new object[] { 2, 2, 1, new DateTime(2022, 10, 12, 23, 53, 58, 147, DateTimeKind.Local).AddTicks(4611), new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "CustomerBooks",
                columns: new[] { "CustomerBookId", "BookId", "CustomerId", "LoanDate", "ReturnDate" },
                values: new object[] { 1, 1, 1, new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "CustomerBooks",
                columns: new[] { "CustomerBookId", "BookId", "CustomerId", "LoanDate", "ReturnDate" },
                values: new object[] { 3, 2, 2, new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBooks_BookId",
                table: "CustomerBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBooks_CustomerId",
                table: "CustomerBooks",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
