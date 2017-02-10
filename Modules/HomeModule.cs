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

          Get["/contacts-view/{id}"] = parameters =>
          {
              Contact idContact = Contact.Find(parameters.id);
              return View["view.cshtml", idContact];
          };

          Post["/contacts-new"] = _ =>
          {
              Contact newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-phone-number"], Request.Form["contact-address"]);
              return View["new.cshtml"];
          };

          Post["/contacts-clear"] = _ =>
          {
              int contactIndex = int.Parse(Request.Form["delete-button"]);
              Contact.DeleteContact(contactIndex);
              return View["clear.cshtml"];
          };

          Post["/contacts-clear-all"] = _ =>
          {
              Contact.ClearAll();
              return View["clearall.cshtml"];
          };
        }
    }
}
