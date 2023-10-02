using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchMvc.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategorys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories(Name)" + "VALUES('Material Escolar')");
            migrationBuilder.Sql("INSERT INTO Categories(Name)" + "VALUES('Material Informatica')");
            migrationBuilder.Sql("INSERT INTO Categories(Name)" + "VALUES('Material Escritorio')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
