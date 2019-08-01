using Microsoft.EntityFrameworkCore.Migrations;

namespace help_desk.Migrations
{
    public partial class AddingSoftDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "tickets",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "templates_categories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "templates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "statuses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "priorities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "permissions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "invites",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "groups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "departments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "companies",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "comments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "attachments",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "users");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "templates_categories");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "templates");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "statuses");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "priorities");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "permissions");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "invites");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "groups");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "companies");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "attachments");
        }
    }
}
