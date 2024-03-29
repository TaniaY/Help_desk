﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using help_desk;

namespace help_desk.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("help_desk.Models.Attachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CommentId");

                    b.Property<string>("Src")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.HasIndex("CommentId")
                        .IsUnique();

                    b.ToTable("attachments");
                });

            modelBuilder.Entity("help_desk.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body")
                        .IsRequired();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("TicketId");

                    b.Property<string>("Title");

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("help_desk.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.ToTable("companies");
                });

            modelBuilder.Entity("help_desk.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress")
                        .IsRequired();

                    b.Property<int>("CompanyId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Slug")
                        .IsRequired();

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId")
                        .IsUnique();

                    b.ToTable("departments");
                });

            modelBuilder.Entity("help_desk.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("PriorityId");

                    b.Property<string>("Slug")
                        .IsRequired();

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.ToTable("groups");
                });

            modelBuilder.Entity("help_desk.Models.GroupsPermission", b =>
                {
                    b.Property<int>("GroupId");

                    b.Property<int>("PermissionId");

                    b.Property<int>("Id");

                    b.HasKey("GroupId", "PermissionId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("PermissionId");

                    b.ToTable("groups_permissions");
                });

            modelBuilder.Entity("help_desk.Models.Invite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Token")
                        .IsRequired();

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("invites");
                });

            modelBuilder.Entity("help_desk.Models.InvitesGroup", b =>
                {
                    b.Property<int>("InviteId");

                    b.Property<int>("GroupId");

                    b.Property<int>("Id");

                    b.HasKey("InviteId", "GroupId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("invites_groups");
                });

            modelBuilder.Entity("help_desk.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<string>("Slug")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.ToTable("permissions");
                });

            modelBuilder.Entity("help_desk.Models.Priority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Slug")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.ToTable("priorities");
                });

            modelBuilder.Entity("help_desk.Models.Statuse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.ToTable("statuses");
                });

            modelBuilder.Entity("help_desk.Models.Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("GroupId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("TTemplatesCategoryId");

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.HasIndex("GroupId")
                        .IsUnique();

                    b.HasIndex("TTemplatesCategoryId");

                    b.ToTable("templates");
                });

            modelBuilder.Entity("help_desk.Models.TemplatesCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Order");

                    b.Property<int>("ParentId");

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.ToTable("templates_categories");
                });

            modelBuilder.Entity("help_desk.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssigneeId");

                    b.Property<int>("AuthorId");

                    b.Property<string>("Body");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DeadlineDate");

                    b.Property<int>("PriorityId");

                    b.Property<int>("StatusId");

                    b.Property<int>("TemplateId");

                    b.Property<string>("Title");

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.HasIndex("AssigneeId")
                        .IsUnique();

                    b.HasIndex("AuthorId");

                    b.HasIndex("PriorityId")
                        .IsUnique();

                    b.HasIndex("StatusId")
                        .IsUnique();

                    b.HasIndex("TemplateId")
                        .IsUnique();

                    b.ToTable("tickets");
                });

            modelBuilder.Entity("help_desk.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Fname")
                        .IsRequired();

                    b.Property<string>("Lname")
                        .IsRequired();

                    b.Property<string>("Login")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId")
                        .IsUnique();

                    b.ToTable("users");
                });

            modelBuilder.Entity("help_desk.Models.UsersGroup", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("GroupId");

                    b.Property<int>("Id");

                    b.HasKey("UserId", "GroupId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("users_groups");
                });

            modelBuilder.Entity("help_desk.Models.Attachment", b =>
                {
                    b.HasOne("help_desk.Models.Comment", "Atcomment")
                        .WithOne("Cattachment")
                        .HasForeignKey("help_desk.Models.Attachment", "CommentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("help_desk.Models.Comment", b =>
                {
                    b.HasOne("help_desk.Models.Ticket", "Cticket")
                        .WithMany("Comments")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("help_desk.Models.Department", b =>
                {
                    b.HasOne("help_desk.Models.Company", "DCompany")
                        .WithOne("CDepartment")
                        .HasForeignKey("help_desk.Models.Department", "CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("help_desk.Models.GroupsPermission", b =>
                {
                    b.HasOne("help_desk.Models.Group", "GPGroup")
                        .WithMany("GroupsPermissions")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("help_desk.Models.Permission", "GPPermission")
                        .WithMany("GroupsPermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("help_desk.Models.Invite", b =>
                {
                    b.HasOne("help_desk.Models.Department", "IDepartment")
                        .WithMany("DInvite")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("help_desk.Models.InvitesGroup", b =>
                {
                    b.HasOne("help_desk.Models.Group", "IGroup")
                        .WithMany("InvitesGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("help_desk.Models.Invite", "IInvite")
                        .WithMany("InvitesGroups")
                        .HasForeignKey("InviteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("help_desk.Models.Template", b =>
                {
                    b.HasOne("help_desk.Models.Group", "TGroup")
                        .WithOne("GTemplate")
                        .HasForeignKey("help_desk.Models.Template", "GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("help_desk.Models.TemplatesCategory", "TTemplatesCategory")
                        .WithMany("Templates")
                        .HasForeignKey("TTemplatesCategoryId");
                });

            modelBuilder.Entity("help_desk.Models.Ticket", b =>
                {
                    b.HasOne("help_desk.Models.User", "Assignee")
                        .WithOne("AssigneeTicket")
                        .HasForeignKey("help_desk.Models.Ticket", "AssigneeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("help_desk.Models.User", "Author")
                        .WithMany("Tickets")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("help_desk.Models.Priority", "Tpriority")
                        .WithOne("PTicket")
                        .HasForeignKey("help_desk.Models.Ticket", "PriorityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("help_desk.Models.Statuse", "Tstatuse")
                        .WithOne("STicket")
                        .HasForeignKey("help_desk.Models.Ticket", "StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("help_desk.Models.Template", "Ttemplate")
                        .WithOne("TTicket")
                        .HasForeignKey("help_desk.Models.Ticket", "TemplateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("help_desk.Models.User", b =>
                {
                    b.HasOne("help_desk.Models.Department", "UDepartment")
                        .WithOne("DUser")
                        .HasForeignKey("help_desk.Models.User", "DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("help_desk.Models.UsersGroup", b =>
                {
                    b.HasOne("help_desk.Models.Group", "UGGroup")
                        .WithMany("UsersGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("help_desk.Models.User", "UGUser")
                        .WithMany("UsersGroups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
