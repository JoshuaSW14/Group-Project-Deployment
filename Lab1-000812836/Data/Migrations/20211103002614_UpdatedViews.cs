using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1_TeamMembershipSystem.Data.Migrations
{
    public partial class UpdatedViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeamName",
                table: "Teams",
                newName: "SportCategoryFK");

            migrationBuilder.RenameColumn(
                name: "EstablishedDate",
                table: "Teams",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Teams",
                newName: "LeagueFK");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Teams",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Teams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Buckets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buckets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ApplicationUserFK = table.Column<string>(type: "TEXT", nullable: true),
                    TeamFK = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interests_AspNetUsers_ApplicationUserFK",
                        column: x => x.ApplicationUserFK,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Interests_Teams_TeamFK",
                        column: x => x.TeamFK,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SportCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BucketTeamConnections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    TeamFK = table.Column<Guid>(type: "TEXT", nullable: false),
                    BucketFK = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BucketTeamConnections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BucketTeamConnections_Buckets_BucketFK",
                        column: x => x.BucketFK,
                        principalTable: "Buckets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BucketTeamConnections_Teams_TeamFK",
                        column: x => x.TeamFK,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeagueFK",
                table: "Teams",
                column: "LeagueFK");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_SportCategoryFK",
                table: "Teams",
                column: "SportCategoryFK");

            migrationBuilder.CreateIndex(
                name: "IX_BucketTeamConnections_BucketFK",
                table: "BucketTeamConnections",
                column: "BucketFK");

            migrationBuilder.CreateIndex(
                name: "IX_BucketTeamConnections_TeamFK",
                table: "BucketTeamConnections",
                column: "TeamFK");

            migrationBuilder.CreateIndex(
                name: "IX_Interests_ApplicationUserFK",
                table: "Interests",
                column: "ApplicationUserFK");

            migrationBuilder.CreateIndex(
                name: "IX_Interests_TeamFK",
                table: "Interests",
                column: "TeamFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Leagues_LeagueFK",
                table: "Teams",
                column: "LeagueFK",
                principalTable: "Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_SportCategories_SportCategoryFK",
                table: "Teams",
                column: "SportCategoryFK",
                principalTable: "SportCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Leagues_LeagueFK",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_SportCategories_SportCategoryFK",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "BucketTeamConnections");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DropTable(
                name: "SportCategories");

            migrationBuilder.DropTable(
                name: "Buckets");

            migrationBuilder.DropIndex(
                name: "IX_Teams_LeagueFK",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_SportCategoryFK",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "SportCategoryFK",
                table: "Teams",
                newName: "TeamName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Teams",
                newName: "EstablishedDate");

            migrationBuilder.RenameColumn(
                name: "LeagueFK",
                table: "Teams",
                newName: "Email");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Teams",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
