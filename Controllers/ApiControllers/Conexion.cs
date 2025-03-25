using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("The Lamb Lies Down On Broadway")]
public class Conexion : Controller
{
    [HttpGet("mongo")]
    public IActionResult ListarSalonesMongoDb()
    {
        return Ok("Me estoy conectando a MongoDb");
    }
}
