using dataBinding.Models;
using System.Web.Mvc;

namespace dataBinding.Controllers
{
  public class QuestionController : Controller
  {
    // GET: Question
    public ActionResult Index()
    {
      //List<Question> qlist = new List<Question>();

      return View();
    }

    [HttpPost]
    public ActionResult Index(Question[] q)
    {
      //List<Question> qlist = new List<Question>();

      return View();
    }
  }
}