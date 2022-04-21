using Microsoft.EntityFrameworkCore;
using MvcStudent.Data;

namespace MvcStudent.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcStudentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcStudentContext>>()))
            {
                // Look for any students.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {

                         Name = "刘涛",
                         Gender = "女",
                         Age = 32,
                         BirthDate = DateTime.Parse("1991-2-12"),
                         Phone = "15694128964",
                         Temperature = 36.7f,
                         Dateoffilling = DateTime.Parse("2022-3-12")

                    },

                    new Student
                    {

                        Name = "孙博",
                        Gender = "男",
                        Age = 22,
                        BirthDate = DateTime.Parse("2001-8-25"),
                        Phone = "15789624592",
                        Temperature = 36.5f,
                        Dateoffilling = DateTime.Parse("2022-4-12")

                    },

                   new Student
                   {

                       Name = "李四",
                       Gender = "男",
                       Age = 42,
                       BirthDate = DateTime.Parse("1981-7-25"),
                       Phone = "18595483685",
                       Temperature = 35.9f,
                       Dateoffilling = DateTime.Parse("2022-1-19")

                   },

                    new Student
                    {

                        Name = "薇薇",
                        Gender = "女",
                        Age = 12,
                        BirthDate = DateTime.Parse("2011-9-24"),
                        Phone = "13685472956",
                        Temperature = 36.4f,
                        Dateoffilling = DateTime.Parse("2022-3-22")

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
    
