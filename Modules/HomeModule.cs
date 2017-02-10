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
        return View["index.cshtml"];
      };
      Get["/contacts/view"] = _ =>
      {
        return View["index.cshtml"];
      };
      Get["/contacts/new"] = _ =>
      {
        return View["index.cshtml"];
      };
      Get["/contacts/clear"] = _ =>
      {
        return View["index.cshtml"];
      };
    }
  }
}
