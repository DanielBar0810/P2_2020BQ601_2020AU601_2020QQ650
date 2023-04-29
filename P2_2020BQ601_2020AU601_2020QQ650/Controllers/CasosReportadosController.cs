using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2020BQ601_2020AU601_2020QQ650.Models;

namespace P2_2020BQ601_2020AU601_2020QQ650.Controllers
{
    public class CasosReportadosController : Controller
    {

            private readonly covidConnection _covidConnection;
            public CasosReportadosController(covidConnection covidConnection)
            {
                _covidConnection = covidConnection;
            }


            public IActionResult Index()
            {

            var listadoDepartamentos = (from d in _covidConnection.Departamentos select d).ToList();
            //Manejador de controlador y vista
            ViewData["listadoDepartamentos"] = new SelectList(listadoDepartamentos, "id_departamento", "nombre_departamento");



            var listadoDeGeneros = (from g in _covidConnection.Generos select g).ToList();
            //Manejador de controlador y vista
            ViewData["listadoDeGeneros"] = new SelectList(listadoDeGeneros, "id_genero","nombre_genero");



            return View();
            }
    }
}
