using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.Models.Email;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {

        twoformsDB twoforms = new twoformsDB();
        WebConfig webConfig = new WebConfig();


        private EmailSender emailSender = new EmailSender();

        string dwMail = WebConfig.DwMail();

        public ActionResult Contact()
        {
           
            return View();
        }

        public ActionResult Create(Create create)
        {

           

            if (ModelState.IsValid)


            {

                int statusMail = 1;

                try
                {

                    emailSender.SendInfoEmail(create.subject, create.text, create.email, dwMail);

                }

                catch
                {
                    
                    statusMail = 0;

                }

                ut_forms forms = new ut_forms { id = 0, name = create.name, surname = create.surname, mail = create.email, text = create.text, subject = create.subject, statusmail = statusMail };
                
                twoforms.ut_forms.Add(forms);
                twoforms.SaveChanges();
               

            }


            return RedirectToAction("Index");

        }


        public ActionResult Index()
        {



            List<ut_forms> ut_Forms = twoforms.ut_forms.ToList();



            return View("Index", ut_Forms);




        }

    }
}