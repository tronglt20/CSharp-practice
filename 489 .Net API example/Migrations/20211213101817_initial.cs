using Microsoft.EntityFrameworkCore.Migrations;

namespace _489_.Net_API_example.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    CateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CateId",
                        column: x => x.CateId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Samsung" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Iphone" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CateId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "P1", 2000.0 },
                    { 2, 1, "P2", 4500.0 },
                    { 3, 1, "P3", 3000.0 },
                    { 4, 2, "P4", 4000.0 },
                    { 5, 2, "P5", 4000.0 },
                    { 6, 2, "P6", 4000.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CateId",
                table: "Product",
                column: "CateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
