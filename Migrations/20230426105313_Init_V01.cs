using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DF_NTCong_Repo_Core.Migrations
{
    /// <inheritdoc />
    public partial class Init_V01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product_Table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Products__3213E83FC142A735", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SINHVIEN",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    TEN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TUOI = table.Column<int>(type: "int", nullable: false),
                    KHOAHOC = table.Column<string>(type: "char(25)", unicode: false, fixedLength: true, maxLength: 25, nullable: true),
                    HOCPHI = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SINHVIEN__3214EC2758545D8C", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product_Table");

            migrationBuilder.DropTable(
                name: "SINHVIEN");
        }
    }
}
