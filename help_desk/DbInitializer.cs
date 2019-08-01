using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace help_desk
{
    public class DbInitializer
    {
      static public  Models.Company[] companies;
        static public Models.Department[] departments;
        public static void Initialize(ApplicationContext context)
        {
            if (!context.Companies.Any())
            {
                 companies = new Models.Company[]
                 {
                    new Models.Company{ Name = "GodCompany", Address = "Soviet Unoin" }

                 };
                foreach (Models.Company c in companies)
                {
                    context.Companies.Add(c);
                }
                context.SaveChanges();
            }

            if (!context.Departments.Any())
            {
                departments = new Models.Department[]
                {
                    new Models.Department{ Name = "General", Adress = "Soviet Union", CompanyId = companies[0].Id, Slug=Helpers.SlugGenerator.GenerateSlug("General") }

                };
                foreach (Models.Department d in departments)
                {
                    context.Departments.Add(d);
                }
                context.SaveChanges();
            }

            if (!context.Users.Any())
            {
                var users = new Models.User[]
                 {
                    new Models.User{Fname="Yan", Lname="Kolovorotny", Login="Somelog", Email="yankolovorotny@gmail.com", Phone="somephone", DepartmentId = departments[0].Id, Password = "super7secret7password7"}

                 };
                foreach (Models.User us in users)
                {
                    context.Users.Add(us);
                }
                context.SaveChanges();
            }

            if (!context.Groups.Any())
            {
             var   groups = new Models.Group[]
             {
                 new Models.Group { Name = "Супер Администратор",  Slug = Helpers.SlugGenerator.GenerateSlug("Супер Администратор")  },
                 new Models.Group { Name = "Администратор",  Slug = Helpers.SlugGenerator.GenerateSlug("Администратор")  },
                 new Models.Group { Name = "Администратор предприятия",  Slug = Helpers.SlugGenerator.GenerateSlug("Администратор предприятия")  },
                 new Models.Group { Name = "Администратор структурного подразделения",  Slug = Helpers.SlugGenerator.GenerateSlug("Администратор структурного подразделения")  },
                 new Models.Group { Name = "Пользователь",  Slug = Helpers.SlugGenerator.GenerateSlug("Пользователь")  },
                 new Models.Group { Name = "Исполнитель",  Slug = Helpers.SlugGenerator.GenerateSlug("Исполнитель")  },

             };
                foreach (Models.Group s1 in groups)
                {
                    context.Groups.Add(s1);
                }
                context.SaveChanges();
            }

            if (!context.Statuses.Any())
            {
                var statuses = new Models.Statuse[]
               {
                new Models.Statuse{Title="Новая и ожидает назначения исполнителя", Description="Заявка принята и ожидает назначеня исполнителя"},
                new Models.Statuse{Title="Активная", Description="Исполнитель назначен и занимается выполнением"},
                new Models.Statuse{Title="Ожидает выполнения", Description="По определенным причинам исполнение приостановлено"},
                new Models.Statuse{Title="Ожидание материалов", Description="ожидание материалов"},
                new Models.Statuse{Title="Перемещение в сервис",Description="заявка перемещена в сервис" },
                new Models.Statuse{Title="В сервисе", Description="заявка в сервисе" },
                new Models.Statuse{Title="Перемещение из сервиса", Description="заявка перемещена из сервиса"},
                new Models.Statuse{Title="Выполнена", Description="заявка выполнена или отменена"},
               };
                foreach (Models.Statuse s2 in statuses)
                {
                    context.Statuses.Add(s2);
                }
                context.SaveChanges();
            }

            if (!context.Priorities.Any())
            {
                var priority = new Models.Priority[]
               {
                new Models.Priority{Title="Высокий", Description="Заявка требует срочного рассмотрения", Slug=Helpers.SlugGenerator.GenerateSlug("Высокий")  },
                new Models.Priority{Title="Средний", Description="Заявка второстепенной важности", Slug=Helpers.SlugGenerator.GenerateSlug("Средний")  },
                new Models.Priority{Title="Низкий", Description="Заявка не требующая немедленного выполнения", Slug=Helpers.SlugGenerator.GenerateSlug("Низкий")  },
               };
                foreach (Models.Priority p in priority)
                {
                    context.Priorities.Add(p);
                }
                context.SaveChanges();
            }
            
        }
    }

}
