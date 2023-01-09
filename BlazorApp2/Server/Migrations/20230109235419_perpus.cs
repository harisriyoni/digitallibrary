using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp2.Server.Migrations
{
    /// <inheritdoc />
    public partial class perpus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
