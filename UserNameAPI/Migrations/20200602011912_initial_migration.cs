using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserNameAPI.Migrations
{
    public partial class initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserNames",
                columns: table => new
                {
                    NameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Service = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    created = table.Column<DateTime>(nullable: false),
                    modified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNames", x => x.NameId);
                });

            migrationBuilder.InsertData(
                table: "UserNames",
                columns: new[] { "NameId", "Email", "Password", "Service", "created", "modified" },
                values: new object[,]
                {
                    { 1, "myladys21111@live.com", "moonlIte00", "Outlook.com", new DateTime(2020, 6, 2, 1, 19, 12, 317, DateTimeKind.Utc).AddTicks(9560), new DateTime(2020, 6, 2, 1, 19, 12, 317, DateTimeKind.Utc).AddTicks(9561) },
                    { 2, "ltdtwo@outlook.com", "moonlIte00", "Outlook.com", new DateTime(2020, 6, 2, 1, 19, 12, 318, DateTimeKind.Utc).AddTicks(692), new DateTime(2020, 6, 2, 1, 19, 12, 318, DateTimeKind.Utc).AddTicks(692) },
                    { 3, "wavetravel@outlook.com", "moonlIte00", "Outlook.com", new DateTime(2020, 6, 2, 1, 19, 12, 318, DateTimeKind.Utc).AddTicks(704), new DateTime(2020, 6, 2, 1, 19, 12, 318, DateTimeKind.Utc).AddTicks(704) },
                    { 4, "myladys21111@gmail.com", "moonlIte00", "Gmail", new DateTime(2020, 6, 2, 1, 19, 12, 318, DateTimeKind.Utc).AddTicks(705), new DateTime(2020, 6, 2, 1, 19, 12, 318, DateTimeKind.Utc).AddTicks(705) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserNames");
        }
    }
}
