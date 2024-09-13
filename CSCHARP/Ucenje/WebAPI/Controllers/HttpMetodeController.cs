using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    // anotacija [ApiController] je skraćenica za [Controller] i [Produces("application/json")]
    // atributi su metapodaci koji se koriste za opisivanje klasa, svojstava, metoda i drugih elemenata koda
    [ApiController]
    // ova klasa ce biti api kontroler
    // anotacija [Route] se koristi za mapiranje ruta na metode kontrolera


    [Route("api/v1/[controller]")]
    // ovo znaci da ce ruta biti /api/v1/HttpMetode
    public class HttpMetodeController : ControllerBase
    {
        // ovdje pocinje ruta /api/v1/HttpMetode
        [HttpGet]
        public string Pozdravi()
        {

            return "Hello world";
        }

        // ovdje zavrsava ruta /api/v1/HttpMetode



        // ovdje pocinje ruta /api/v1/HttpMetode/echo
        [HttpGet]
        [Route("Pozdravi")]
        public string Pozdravi(string ime)
        {
            return "Hello " + ime;
        }

        // kreirajte rutu naziva Zbroj koja prima dva cijela broja i vraca njihov zbroj
        // ovdje pocinje ruta /api/v1/HttpMetode/Zbroj
        [HttpGet]
        [Route("Zbroj")]
        public int Zbroj(int a, int b)
        {
            return a + b;
        }
        // ovdje zavrsava ruta /api/v1/HttpMetode/Zbroj

        // ovdje pocinje ruta /api/v1/HttpMetode/Pozdrav
        [HttpGet]
        [Route("Hello")]
        public IActionResult Pozdravi(int id, string ime)
        {
            return Ok(new { id = id, ime = ime });
        }
        // ovdje zavrsava ruta /api/v1/HttpMetode/Pozdrav


        // ovdje pocinje ruta 
        [HttpPost]
        public IActionResult Post()
        {
            return BadRequest(new { greska = true, poruka = "Nesto ne valja" });
        }
        // ovdje zavrsava ruta



        // ovdje pocinje ruta 
        [HttpPut]
        public IActionResult Put(Osoba osoba)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { greska = true, poruka = "Nije dobar parametar" });
            }
            osoba.Prezime = "g." + osoba.Prezime;
            return StatusCode(StatusCodes.Status206PartialContent, osoba);
        }
        // ovdje zavrsava ruta

        // ovdje pocinje ruta
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return NotFound(new { id = id, poruka = "Ne mogu pronaci", greska = true }); 
                
        } 
        // ovdje zavrsava ruta
    }
}
