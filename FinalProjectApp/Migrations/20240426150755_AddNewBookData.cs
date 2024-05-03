using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProjectApp.Migrations
{
    /// <inheritdoc />
    public partial class AddNewBookData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "AuthorName", "BookName", "Isbn", "PublishYear" },
                values: new object[] { "Sylvia Plath", "The Bell Jar", "5897", 1963 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "AuthorName", "BookName", "Isbn", "PublishYear" },
                values: new object[] { "Sylvia Plath", "Lady Lazarus", "5897", 1965 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorName", "BookName", "Img", "Isbn", "PublishYear" },
                values: new object[,]
                {
                    { 3, "Sylvia Plath", "Ariel", "", "5897", 1965 },
                    { 4, "Sylvia Plath", "Sylvia Plath: Poems", "", "5897", 1985 },
                    { 5, "Sylvia Plath", "Journals of Sylvia Plath", "", "5897", 1982 },
                    { 6, "Sylvia Plath", "Tulips", "", "5897", 1965 },
                    { 7, "Jhumpa Lahiri", "The Namesake", "", "8367", 2003 },
                    { 8, "Jhumpa Lahiri", "Interpreter of Maladies", "", "8367", 1999 },
                    { 9, "Jhumpa Lahiri", "Unaccustomed Earth", "", "8367", 2008 },
                    { 10, "Jhumpa Lahiri", "Roman Stories", "", "8367", 2023 },
                    { 11, "Jhumpa Lahiri", "The Lowland", "", "8367", 2013 },
                    { 12, "Jhumpa Lahiri", "Whereabouts", "", "8367", 2018 },
                    { 13, "Jhumpa Lahiri", "The Other Words", "", "8367", 2015 },
                    { 14, "Jhumpa Lahiri", "Hell-Heaven", "", "8367", 2015 },
                    { 15, "Jhumpa Lahiri", "Only Goodness", "", "8367", 2013 },
                    { 16, "Jhumpa Lahiri", "The Clothing of Books", "", "8367", 2016 },
                    { 17, "Stephen King", "It", "", "1648", 1986 },
                    { 18, "Stephen King", "The Shining", "", "1648", 1977 },
                    { 19, "Stephen King", "Holly", "", "1648", 2023 },
                    { 20, "Stephen King", "Carrie", "", "1648", 1974 },
                    { 21, "Stephen King", "The Stand", "", "1648", 1978 },
                    { 22, "Stephen King", "Misery", "", "1648", 1987 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "AuthorName", "BookName", "Isbn", "PublishYear" },
                values: new object[] { "John Steinbeck", "Of Mice and Men", "1234567890", 2000 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "AuthorName", "BookName", "Isbn", "PublishYear" },
                values: new object[] { "Rudyard Kipling", "Kim", "2345678901", 2010 });
        }
    }
}
