using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProjectApp.Migrations
{
    /// <inheritdoc />
    public partial class FixAuthors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\The Bell Jar.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\Lady Lazarus.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\Ariel.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\Poems.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\Journals of Sylvia Plath.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\Tulips.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\The Namesake.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\Interpreter of Maladies.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\Unaccustomed Earth.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\Roman Stories.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\The Lowland.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\Whereabouts.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\In Other Words.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\Hell-Heaven.jpeg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\Only Goodness.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\JhumpaLahiriBooks\\The Clothing of Books.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\StephenKingBooks\\IT.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\StephenKingBooks\\The Shining.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\StephenKingBooks\\Holly.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\StephenKingBooks\\Carrie.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\StephenKingBooks\\The Stand.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22,
                column: "Img",
                value: "C:\\Users\\rinla\\Desktop\\AWD Photos\\FinalProjectSolution\\images\\books\\StephenKingBooks\\Misery.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22,
                column: "Img",
                value: "");
        }
    }
}
