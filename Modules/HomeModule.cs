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
    }
  }
}
