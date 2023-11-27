using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Work_Integrated_Learning.Migrations
{
    /// <inheritdoc />
    public partial class AddPresentersAndReviewsToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Presenters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PresenterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresenterTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresenterDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresentationTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    PresentationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PresentationStage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presenters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Presenters");

            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
