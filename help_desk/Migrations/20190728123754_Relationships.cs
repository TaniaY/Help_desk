using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace help_desk.Migrations
{
    public partial class Relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users_groups",
                table: "users_groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_invites_groups",
                table: "invites_groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_groups_permissions",
                table: "groups_permissions");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "users_groups");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "invites_groups");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "groups_permissions");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "users_groups",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<int>(
                name: "TTemplatesCategoryId",
                table: "templates",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "invites_groups",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "groups_permissions",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_users_groups_Id",
                table: "users_groups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users_groups",
                table: "users_groups",
                columns: new[] { "UserId", "GroupId" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_invites_groups_Id",
                table: "invites_groups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_invites_groups",
                table: "invites_groups",
                columns: new[] { "InviteId", "GroupId" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_groups_permissions_Id",
                table: "groups_permissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_groups_permissions",
                table: "groups_permissions",
                columns: new[] { "GroupId", "PermissionId" });

            migrationBuilder.CreateIndex(
                name: "IX_users_groups_GroupId",
                table: "users_groups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_AssigneeId",
                table: "tickets",
                column: "AssigneeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tickets_AuthorId",
                table: "tickets",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_PriorityId",
                table: "tickets",
                column: "PriorityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tickets_StatusId",
                table: "tickets",
                column: "StatusId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tickets_TemplateId",
                table: "tickets",
                column: "TemplateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_templates_GroupId",
                table: "templates",
                column: "GroupId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_templates_TTemplatesCategoryId",
                table: "templates",
                column: "TTemplatesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_invites_groups_GroupId",
                table: "invites_groups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_invites_DepartmentId",
                table: "invites",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_groups_permissions_PermissionId",
                table: "groups_permissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_departments_CompanyId",
                table: "departments",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_comments_TicketId",
                table: "comments",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_attachments_CommentId",
                table: "attachments",
                column: "CommentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_attachments_comments_CommentId",
                table: "attachments",
                column: "CommentId",
                principalTable: "comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_tickets_TicketId",
                table: "comments",
                column: "TicketId",
                principalTable: "tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_departments_companies_CompanyId",
                table: "departments",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_groups_permissions_groups_GroupId",
                table: "groups_permissions",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_groups_permissions_permissions_PermissionId",
                table: "groups_permissions",
                column: "PermissionId",
                principalTable: "permissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_invites_departments_DepartmentId",
                table: "invites",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_invites_groups_groups_GroupId",
                table: "invites_groups",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_invites_groups_invites_InviteId",
                table: "invites_groups",
                column: "InviteId",
                principalTable: "invites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_templates_groups_GroupId",
                table: "templates",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_templates_templates_categories_TTemplatesCategoryId",
                table: "templates",
                column: "TTemplatesCategoryId",
                principalTable: "templates_categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_users_AssigneeId",
                table: "tickets",
                column: "AssigneeId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_users_AuthorId",
                table: "tickets",
                column: "AuthorId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_priorities_PriorityId",
                table: "tickets",
                column: "PriorityId",
                principalTable: "priorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_statuses_StatusId",
                table: "tickets",
                column: "StatusId",
                principalTable: "statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_templates_TemplateId",
                table: "tickets",
                column: "TemplateId",
                principalTable: "templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_groups_groups_GroupId",
                table: "users_groups",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_groups_users_UserId",
                table: "users_groups",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attachments_comments_CommentId",
                table: "attachments");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_tickets_TicketId",
                table: "comments");

            migrationBuilder.DropForeignKey(
                name: "FK_departments_companies_CompanyId",
                table: "departments");

            migrationBuilder.DropForeignKey(
                name: "FK_groups_permissions_groups_GroupId",
                table: "groups_permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_groups_permissions_permissions_PermissionId",
                table: "groups_permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_invites_departments_DepartmentId",
                table: "invites");

            migrationBuilder.DropForeignKey(
                name: "FK_invites_groups_groups_GroupId",
                table: "invites_groups");

            migrationBuilder.DropForeignKey(
                name: "FK_invites_groups_invites_InviteId",
                table: "invites_groups");

            migrationBuilder.DropForeignKey(
                name: "FK_templates_groups_GroupId",
                table: "templates");

            migrationBuilder.DropForeignKey(
                name: "FK_templates_templates_categories_TTemplatesCategoryId",
                table: "templates");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_users_AssigneeId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_users_AuthorId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_priorities_PriorityId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_statuses_StatusId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_templates_TemplateId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_users_groups_groups_GroupId",
                table: "users_groups");

            migrationBuilder.DropForeignKey(
                name: "FK_users_groups_users_UserId",
                table: "users_groups");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_users_groups_Id",
                table: "users_groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users_groups",
                table: "users_groups");

            migrationBuilder.DropIndex(
                name: "IX_users_groups_GroupId",
                table: "users_groups");

            migrationBuilder.DropIndex(
                name: "IX_tickets_AssigneeId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_AuthorId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_PriorityId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_StatusId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_TemplateId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_templates_GroupId",
                table: "templates");

            migrationBuilder.DropIndex(
                name: "IX_templates_TTemplatesCategoryId",
                table: "templates");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_invites_groups_Id",
                table: "invites_groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_invites_groups",
                table: "invites_groups");

            migrationBuilder.DropIndex(
                name: "IX_invites_groups_GroupId",
                table: "invites_groups");

            migrationBuilder.DropIndex(
                name: "IX_invites_DepartmentId",
                table: "invites");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_groups_permissions_Id",
                table: "groups_permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_groups_permissions",
                table: "groups_permissions");

            migrationBuilder.DropIndex(
                name: "IX_groups_permissions_PermissionId",
                table: "groups_permissions");

            migrationBuilder.DropIndex(
                name: "IX_departments_CompanyId",
                table: "departments");

            migrationBuilder.DropIndex(
                name: "IX_comments_TicketId",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_attachments_CommentId",
                table: "attachments");

            migrationBuilder.DropColumn(
                name: "TTemplatesCategoryId",
                table: "templates");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "users_groups",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "users_groups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "invites_groups",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "invites_groups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "groups_permissions",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "groups_permissions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_users_groups",
                table: "users_groups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_invites_groups",
                table: "invites_groups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_groups_permissions",
                table: "groups_permissions",
                column: "Id");
        }
    }
}
