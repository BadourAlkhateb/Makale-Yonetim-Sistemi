using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AMS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    FileName = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AuthorFirstName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    AuthorLastName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    AuthorPhone = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    AuthorMail = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    AuthorNotes = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "smalldatetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Phone = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Mail = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    Role = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Pass = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Title = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefereeArticle",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    RefereeId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Score = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    State = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RefereeA__2C24FEBAA9F94638", x => new { x.ArticleId, x.RefereeId });
                    table.ForeignKey(
                        name: "FK__RefereeAr__Artic__145C0A3F",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__RefereeAr__Refer__15502E78",
                        column: x => x.RefereeId,
                        principalTable: "SystemUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RefereeArticle_RefereeId",
                table: "RefereeArticle",
                column: "RefereeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefereeArticle");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "SystemUser");
        }
    }
}
