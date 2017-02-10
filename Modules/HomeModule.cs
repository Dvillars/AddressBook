using Nancy;
using System.Collections.Generic;
using System.IO;
using AdressBook.Objects;

namespace AdressBook
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
          Get["/"] = _ =>
          {
              if (Contact.GetCounter() == 0)
              {
                return View["none.cshtml"];
              }
              else
              {
                return View["index.cshtml", Contact.ContactList()];
              }
          };

          Get["/contacts/view/{id}"] = parameters =>
          {
              return View["view.cshtml"];
          };

          Post["/contacts/new"] = _ =>
          {
            Contact newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-phone-number"], Request.Form["contact-address"]);
            return View["new.cshtml"];
          };

          Get["/contacts/clear"] = _ =>
          {
              return View["clear.cshtml"];
          };
        }
    }
}
