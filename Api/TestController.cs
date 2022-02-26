namespace dotnet_vite.Controllers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/test")]
    public class TestController : Controller
    {
        // GET: TestController
        public ActionResult Index()
        {
            return this.Ok(
                new TestResponse
                {
                    Text = "Hello world"
                });
        }
    }

    public class TestResponse
    {
        public string Text { get; set; }
    }
}
