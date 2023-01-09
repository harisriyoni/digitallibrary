using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp2.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Genreid = table.Column<int>(name: "Genre_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaGenre = table.Column<string>(name: "Nama_Genre", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_Genre_id", x => x.Genreid);
                });

            migrationBuilder.CreateTable(
                name: "Buku",
                columns: table => new
                {
                    Idbuku = table.Column<int>(name: "Id_buku", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Judulbuku = table.Column<string>(name: "Judul_buku", type: "nvarchar(max)", nullable: false),
                    Penerbit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jumlahhalaman = table.Column<int>(name: "Jumlah_halaman", type: "int", nullable: false),
                    Genreid1 = table.Column<int>(name: "Genre_id1", type: "int", nullable: false),
                    Genreid = table.Column<int>(name: "Genre_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_Id_buku", x => x.Idbuku);
                    table.ForeignKey(
                        name: "FK_Buku_Genre_Genre_id1",
                        column: x => x.Genreid1,
                        principalTable: "Genre",
                        principalColumn: "Genre_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buku_Genre_id1",
                table: "Buku",
                column: "Genre_id1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buku");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
