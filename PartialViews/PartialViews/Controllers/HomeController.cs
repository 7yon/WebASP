using PartialViews.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViews.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Department> all = new List<Department>();

            Department accounting = new Department("Бухгалтерия", "Челябинск, Бр. Кашириных, 129, кабинет 82", "8-800-555-35-35");
            Department management = new Department("Менеджеры", "Челябинск, Бр. Кашириных, 129, кабинет 181", "8-800-555-55-00");
            Department programmers = new Department("Программисты", "Челябинск, Бр. Кашириных, 129, кабинет 327", "8-800-545-28-10");
            Department programmersASP = new Department("ASP-программисты", "Челябинск, Бр.Кашириных, 129, кабинет 329", "8-800-555-55-00");

            Employee accountant = new Employee("Пупкина", "Лариса", "Ивановна", 39, "8-982-872-17-27");
            Employee accountant2 = new Employee("Пирожкова", "Евгения", "Лаврентьевна", 48, "8-351-922-00-97");
            Employee manager = new Employee("Управленцева", "Александра", "Васильевна", 29, "8-902-720-12-12");
            Employee programmerASP = new Employee("Сименкова", "Дарья", "Игоревна", 20, "8-900-072-27-27");
            Employee programmerASP2 = new Employee("Огородникова", "Валерия", "Дмитриевна", 20, "8-964-298-29-99");

            accounting.AddEmployee(accountant);
            accounting.AddEmployee(accountant2);
            management.AddEmployee(manager);
            programmersASP.AddEmployee(programmerASP);
            programmersASP.AddEmployee(programmerASP2);
            programmers.AddDepartment(programmersASP);

            all.Add(accounting);
            all.Add(management);
            all.Add(programmers);

           return View(all);
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}