using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArchitectBuroDataAccess;
using ArchitectBuroDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Bogus;
using System.Threading;

namespace ArchitectBuroSeeder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Инициализация базы данных... ");
            using (MySQLApplicationContext db = new MySQLApplicationContext())
            {
                Console.Write("OK\nУдаление старых данных... ");
                db.Projects.RemoveRange(db.Projects);
                db.SaveChanges();
                db.Customers.RemoveRange(db.Customers);
                db.SaveChanges();
                db.Employees.RemoveRange(db.Employees);
                db.SaveChanges();
                db.Teams.RemoveRange(db.Teams);
                db.SaveChanges();
                db.Positions.RemoveRange(db.Positions);
                db.SaveChanges();
                db.ProjectTypes.RemoveRange(db.ProjectTypes);
                db.SaveChanges();
                db.ProjectStatuses.RemoveRange(db.ProjectStatuses);
                db.SaveChanges();
                db.Database.ExecuteSqlRaw(
                    "ALTER TABLE customers AUTO_INCREMENT = 1;" +
                    "ALTER TABLE employees AUTO_INCREMENT = 1;" +
                    "ALTER TABLE teams AUTO_INCREMENT = 1;" +
                    "ALTER TABLE positions AUTO_INCREMENT = 1;" +
                    "ALTER TABLE projecttypes AUTO_INCREMENT = 1;" +
                    "ALTER TABLE projects AUTO_INCREMENT = 1;" +
                    "ALTER TABLE projectstatuses AUTO_INCREMENT = 1;");
                db.SaveChanges();
                Console.Write("OK\nДобавление типов проектов... ");

                db.ProjectTypes.AddRange(
                    new ProjectType() { Name = "Архитектура" },
                    new ProjectType() { Name = "Дизайн интерьеров" },
                    new ProjectType() { Name = "Разработка концепции" },
                    new ProjectType() { Name = "Проектирование" },
                    new ProjectType() { Name = "Авторский надзор" },
                    new ProjectType() { Name = "Согласование в службах" }
                    );
                db.SaveChanges();
                Console.Write("OK\nДобавление статусов проектов... ");

                db.ProjectStatuses.AddRange(
                    new ProjectStatus() { Name = "Готово"},
                    new ProjectStatus() { Name = "Отменено"},
                    new ProjectStatus() { Name = "В процессе"},
                    new ProjectStatus() { Name = "Не начато"}
                    );
                db.SaveChanges();
                Console.Write("OK\nДобавление должностей... ");

                db.Positions.AddRange(
                    new Position() { Name = "Архитектор" },
                    new Position() { Name = "Директор" },
                    new Position() { Name = "Строитель" },
                    new Position() { Name = "Бухгалтер" },
                    new Position() { Name = "Представитель банка" }
                    );
                db.SaveChanges();
                Console.Write("OK\nГенерация команд... ");

                for (int i = 0; i < 5; i++)
                {
                    Faker faker = new Faker("ru");
                    db.Teams.Add(new Team() { Name = faker.Address.City()});
                }
                db.SaveChanges();
                Console.Write("OK\nГенерация сотрудников... ");

                for (int i = 0; i < 20; i++)
                {
                    Faker faker = new Faker("ru");
                    db.Employees.Add(new Employee()
                    {
                        FirstName = faker.Person.FirstName,
                        LastName = faker.Person.LastName,
                        ApplyDate = faker.Date.Past(1),
                        BirthDate = faker.Date.Past(30,new DateTime(DateTime.Now.Year-18,1,1)),
                        HomeAddress = faker.Address.FullAddress(),
                        Phone = faker.Phone.PhoneNumber(),
                        PositionId = faker.Random.Number(1, db.Positions.Count()),
                        TeamId = faker.Random.Number(1, db.Teams.Count())
                    });
                }
                db.SaveChanges();
                Console.Write("OK\nГенерация клиентов... ");

                for (int i = 0; i < 20; i++)
                {
                    Faker faker = new Faker("ru");
                    db.Customers.Add(new Customer()
                    {
                        FirstName = faker.Person.FirstName,
                        LastName = faker.Person.LastName,
                        Email = faker.Person.Email,
                        Phone = faker.Phone.PhoneNumber()
                    });
                }
                db.SaveChanges();
                Console.Write("OK\nГенерация проектов... ");

                for (int i = 0; i < 20; i++)
                {
                    Faker faker = new Faker("ru");
                    db.Projects.Add(new Project()
                    {
                        CustomerId = faker.Random.Number(1, db.Customers.Count()),
                        TeamId = faker.Random.Number(1, db.Teams.Count()),
                        OrderDate = faker.Date.Past(1, new DateTime(DateTime.Now.Year,1,1)),
                        FinishDate = faker.Date.Future(1, new DateTime(DateTime.Now.Year, 1, 1)),
                        ProjectStatusId = faker.Random.Number(1, db.ProjectStatuses.Count()),
                        ProjectTypeId = faker.Random.Number(1, db.ProjectTypes.Count())
                    });
                }
                db.SaveChanges();
                Console.Write("OK\nГенерация прошла успешно!");
                Thread.Sleep(3000);
            }
        }
    }
}
