using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BLogProject.Migrations
{
    /// <inheritdoc />
    public partial class _2ndCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubCommentId",
                table: "Subcomments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LikeId",
                table: "Likes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MainCommentId",
                table: "Comments",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Subcomments",
                newName: "SubCommentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Likes",
                newName: "LikeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Comments",
                newName: "MainCommentId");
        }
    }
}
