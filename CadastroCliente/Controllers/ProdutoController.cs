using CadastroCliente.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroCliente.Controllers
    {
    public class ProdutoController : Controller
        {
         

        public static string Id { get; private set; }
        public static string Nome { get; private set; }

        [HttpGet (Name = "ProdutoController")]
        public IProduto<ProdutoController> Get( )
            {
            var Produto = new ProdutoController();
            ProdutoController.Id = "";
            ProdutoController.Nome = "";



            return View ();


            return Enumerable.Range (1, 5).Select (index => new WeatherForecast
                {
                Date = DateTime.Now.AddDays (index),
                TemperatureC = Random.Shared.Next (-20, 55),
                Summary = Summaries[Random.Shared.Next (Summaries.Length)]
                })
            .ToArray ();
            }


        [HttpPost (Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast>Post( )
            {
            return Enumerable.Range (1, 5).Select (index => new WeatherForecast
                {
                Date = DateTime.Now.AddDays (index),
                TemperatureC = Random.Shared.Next (-20, 55),
                Summary = Summaries[Random.Shared.Next (Summaries.Length)]
                })
            .ToArray ();
            }

        [HttpPut (Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Put( )
            {
            return Enumerable.Range (1, 5).Select (index => new WeatherForecast
                {
                Date = DateTime.Now.AddDays (index),
                TemperatureC = Random.Shared.Next (-20, 55),
                Summary = Summaries[Random.Shared.Next (Summaries.Length)]
                })
            .ToArray ();
            }

        [HttpDelete (Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Delete( )
            {
            return Enumerable.Range (1, 5).Select (index => new WeatherForecast
                {
                Date = DateTime.Now.AddDays (index),
                TemperatureC = Random.Shared.Next (-20, 55),
                Summary = Summaries[Random.Shared.Next (Summaries.Length)]
                })
            .ToArray ();
            }






        } 
    }
