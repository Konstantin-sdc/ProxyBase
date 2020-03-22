using Microsoft.EntityFrameworkCore.Migrations;

namespace ProxyBaseMVC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patronymic = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MayorModelId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Persons_MayorModelId",
                        column: x => x.MayorModelId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proxies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ip = table.Column<string>(nullable: true),
                    Port = table.Column<int>(nullable: true),
                    IsWork = table.Column<bool>(nullable: true),
                    CityModelId = table.Column<int>(nullable: true),
                    ResponseTime = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proxies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proxies_Cities_CityModelId",
                        column: x => x.CityModelId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Protocols",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProtocolsGroup = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProxyModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protocols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Protocols_Proxies_ProxyModelId",
                        column: x => x.ProxyModelId,
                        principalTable: "Proxies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_MayorModelId",
                table: "Cities",
                column: "MayorModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Protocols_ProxyModelId",
                table: "Protocols",
                column: "ProxyModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Proxies_CityModelId",
                table: "Proxies",
                column: "CityModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Protocols");

            migrationBuilder.DropTable(
                name: "Proxies");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
