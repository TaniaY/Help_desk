using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace help_desk
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        #region <!--DbSet-->

        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Statuse> Statuses { get; set; }
        public DbSet<Models.Permission> Permissions { get; set; }
        public DbSet<Models.Priority> Priorities { get; set; }
        public DbSet<Models.Company> Companies { get; set; }
        public DbSet<Models.Group> Groups { get; set; }
        public DbSet<Models.GroupsPermission> GroupsPermissions { get; set; }
        public DbSet<Models.UsersGroup> UsersGroups { get; set; }
        public DbSet<Models.Department> Departments { get; set; }
        public DbSet<Models.Attachment> Attachments { get; set; }
        public DbSet<Models.Invite> Invites { get; set; }
        public DbSet<Models.InvitesGroup> InvitesGroups { get; set; }
        public DbSet<Models.Ticket> Tickets { get; set; }
        public DbSet<Models.Comment> Comments { get; set; }
        public DbSet<Models.TemplatesCategory> TemplatesCategories { get; set; }
        public DbSet<Models.Template> Templates { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            //strings for using SoftDelee in concret Tables
            //modelBuilder.Entity<Models.GroupsPermission>().Property<bool>("isDeleted");
            //modelBuilder.Entity<Models.GroupsPermission>().HasQueryFilter(m => EF.Property<bool>(m, "isDeleted") == false);

            //modelBuilder.Entity<Models.UsersGroup>().Property<bool>("isDeleted");
            //modelBuilder.Entity<Models.UsersGroup>().HasQueryFilter(m => EF.Property<bool>(m, "isDeleted") == false);

            //modelBuilder.Entity<Models.InvitesGroup>().Property<bool>("isDeleted");
            //modelBuilder.Entity<Models.InvitesGroup>().HasQueryFilter(m => EF.Property<bool>(m, "isDeleted") == false);

            #region <!--strings to create a many-to-many relationships-->
            //GroupsPermission
            modelBuilder.Entity<Models.GroupsPermission>()
           .HasKey(t => new { t.GroupId, t.PermissionId });

            modelBuilder.Entity<Models.GroupsPermission>()
                .HasOne(sc => sc.GPGroup)
                .WithMany(s => s.GroupsPermissions)
                .HasForeignKey(sc => sc.GroupId);

            modelBuilder.Entity<Models.GroupsPermission>()
                .HasOne(sc => sc.GPPermission)
                .WithMany(c => c.GroupsPermissions)
                .HasForeignKey(sc => sc.PermissionId);

            //UsersGroup
            modelBuilder.Entity<Models.UsersGroup>()
               .HasKey(t => new { t.UserId, t.GroupId });

            modelBuilder.Entity<Models.UsersGroup>()
                .HasOne(sc => sc.UGUser)
                .WithMany(s => s.UsersGroups)
                .HasForeignKey(sc => sc.UserId);

            modelBuilder.Entity<Models.UsersGroup>()
                .HasOne(sc => sc.UGGroup)
                .WithMany(c => c.UsersGroups)
                .HasForeignKey(sc => sc.GroupId);

            //InvitesGroup
            modelBuilder.Entity<Models.InvitesGroup>()
              .HasKey(t => new { t.InviteId, t.GroupId });

            modelBuilder.Entity<Models.InvitesGroup>()
                .HasOne(sc => sc.IInvite)
                .WithMany(s => s.InvitesGroups)
                .HasForeignKey(sc => sc.InviteId);

            modelBuilder.Entity<Models.InvitesGroup>()
                .HasOne(sc => sc.IGroup)
                .WithMany(c => c.InvitesGroups)
                .HasForeignKey(sc => sc.GroupId);
            #endregion

            #region <!--strings to create a one-to-one relationships-->

            modelBuilder
            .Entity<Models.Company>()
            .HasOne(u => u.CDepartment)
            .WithOne(p => p.DCompany)
            .HasForeignKey<Models.Department>(p => p.CompanyId);

            modelBuilder
           .Entity<Models.Statuse>()
           .HasOne(u => u.STicket)
           .WithOne(p => p.Tstatuse)
           .HasForeignKey<Models.Ticket>(p => p.StatusId);

            modelBuilder
           .Entity<Models.Priority>()
           .HasOne(u => u.PTicket)
           .WithOne(p => p.Tpriority)
           .HasForeignKey<Models.Ticket>(p => p.PriorityId);

            modelBuilder
          .Entity<Models.Template>()
          .HasOne(u => u.TTicket)
          .WithOne(p => p.Ttemplate)
          .HasForeignKey<Models.Ticket>(p => p.TemplateId);

            modelBuilder
         .Entity<Models.Group>()
         .HasOne(u => u.GTemplate)
         .WithOne(p => p.TGroup)
         .HasForeignKey<Models.Template>(p => p.GroupId);
            
            modelBuilder
      .Entity<Models.Comment>()
      .HasOne(u => u.Cattachment)
      .WithOne(p => p.Atcomment)
      .HasForeignKey<Models.Attachment>(p => p.CommentId);
            #endregion

            #region <!-- tables naming -->
            modelBuilder.Entity<Models.User>().ToTable("users");
            modelBuilder.Entity<Models.Statuse>().ToTable("statuses");
            modelBuilder.Entity<Models.Permission>().ToTable("permissions");
            modelBuilder.Entity<Models.Priority>().ToTable("priorities");
            modelBuilder.Entity<Models.Company>().ToTable("companies");
            modelBuilder.Entity<Models.Group>().ToTable("groups");
            modelBuilder.Entity<Models.GroupsPermission>().ToTable("groups_permissions");
            modelBuilder.Entity<Models.UsersGroup>().ToTable("users_groups");
            modelBuilder.Entity<Models.Department>().ToTable("departments");
            modelBuilder.Entity<Models.Attachment>().ToTable("attachments");
            modelBuilder.Entity<Models.Invite>().ToTable("invites");
            modelBuilder.Entity<Models.InvitesGroup>().ToTable("invites_groups");
            modelBuilder.Entity<Models.Ticket>().ToTable("tickets");
            modelBuilder.Entity<Models.Comment>().ToTable("comments");
            modelBuilder.Entity<Models.TemplatesCategory>().ToTable("templates_categories");
            modelBuilder.Entity<Models.Template>().ToTable("templates");
            #endregion
        }
        #region <!--region with methods that make SoftDelete work -->
        //public override int SaveChanges()
        //{
        //    UpdateSoftDeleteStatuses();
        //    return base.SaveChanges();
        //}

        //public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    UpdateSoftDeleteStatuses();
        //    return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        //}

        //private void UpdateSoftDeleteStatuses()
        //{
        //    foreach (var entry in ChangeTracker.Entries())
        //    {
        //        switch (entry.State)
        //        {
        //            case EntityState.Added:
        //                entry.CurrentValues["isDeleted"] = false;
        //                break;
        //            case EntityState.Deleted:
        //                entry.State = EntityState.Modified;
        //                entry.CurrentValues["isDeleted"] = true;
        //                break;
        //        }
        //    }
        //}
        #endregion
    }
}