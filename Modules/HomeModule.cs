using Nancy;
using System.Collections.Generic;
using AdressBook.Objects;

namespace AdressBook
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
          Get["/"] = _ =>
          {
              if (Job.GetCounter() == 0)
              {
                return View["none.cshtml"];
              }
              else
              {
                return View["index.cshtml", Job.JobList()];
              }
          };

          Get["/contacts/view/{id}"] = parameters =>
          {
              return View["view.cshtml"];
          };

          Post["/contacts/new"] = _ =>
          {
            Job newJob = new Job(Request.Form["job-name"], Request.Form["job-description"], Request.Form["job-contact"]);
            return View["new.cshtml"];
          };

          Get["/contacts/clear"] = _ =>
          {
              return View["clear.cshtml"];
          };
        }
    }
}
