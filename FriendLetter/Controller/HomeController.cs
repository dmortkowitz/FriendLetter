using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    // [Route("/hello")]
    // public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }
    [Produces("text/html")]
    [Route("/")]
    public ActionResult Hello()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient("Jessica");
      myLetterVariable.SetSender("John");
      return View(myLetterVariable);
    }
    [Route("/journal")]
    public ActionResult Journal()
    {
      return View();
    }
  }
}