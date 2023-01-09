using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp2.Server.Migrations
{
    /// <inheritdoc />
    public partial class @try : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buku_Genre_Genre_id1",
                table: "Buku");

            migrationBuilder.DropPrimaryKey(
                name: "PrimaryKey_Genre_id",
                table: "Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PrimaryKey_Id_buku",
                table: "Buku");

            migrationBuilder.AlterColumn<int>(
                name: "Genre_id1",
                table: "Buku",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "Genre_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Buku",
                table: "Buku",
                column: "Id_buku");

            migrationBuilder.InsertData(
                table: "Buku",
                columns: new[] { "Id_buku", "Genre_id", "Genre_id1", "Judul_buku", "Jumlah_halaman", "Penerbit" },
                values: new object[,]
                {
                    { 11, 1, null, "Dear Nathan", 250, "Tere" },
                    { 12, 2, null, "Dilan 1991", 250, "Pidi Baiq" },
                    { 16, 3, null, "Dibalik 98", 250, "Ismail" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Genre_id", "Nama_Genre" },
                values: new object[,]
                {
                    { 1, "Horor" },
                    { 2, "Comedi" },
                    { 3, "Romance" },
                    { 4, "Fantasi" },
                    { 5, "Edukasi" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Buku_Genre_Genre_id1",
                table: "Buku",
                column: "Genre_id1",
                principalTable: "Genre",
                principalColumn: "Genre_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buku_Genre_Genre_id1",
                table: "Buku");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Buku",
                table: "Buku");

            migrationBuilder.DeleteData(
                table: "Buku",
                keyColumn: "Id_buku",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Buku",
                keyColumn: "Id_buku",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Buku",
                keyColumn: "Id_buku",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Genre_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Genre_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Genre_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Genre_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Genre_id",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "Genre_id1",
                table: "Buku",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PrimaryKey_Genre_id",
                table: "Genre",
                column: "Genre_id");

            migrationBuilder.AddPrimaryKey(
                name: "PrimaryKey_Id_buku",
                table: "Buku",
                column: "Id_buku");

            migrationBuilder.AddForeignKey(
                name: "FK_Buku_Genre_Genre_id1",
                table: "Buku",
                column: "Genre_id1",
                principalTable: "Genre",
                principalColumn: "Genre_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
