using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Work_Integrated_Learning.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToPresenters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PresenterImageURL",
                table: "Presenters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PresenterImageURL",
                table: "Presenters");
        }
    }
}
