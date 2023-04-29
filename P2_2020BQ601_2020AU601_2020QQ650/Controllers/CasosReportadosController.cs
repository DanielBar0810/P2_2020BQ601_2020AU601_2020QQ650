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
            ViewData["listadoDeGeneros"] = new SelectList(listadoDeGeneros, "id_genero", "nombre_genero");

            var listadoCasosReportados = (  from c in _covidConnection.CasosReportados
                                            join d in _covidConnection.Departamentos
                                            on c.id_departamento equals d.id_departamento
                                            join g in _covidConnection.Generos
                                            on c.id_genero equals g.id_genero
                                            select new
                                          {
                                              departamento = d.nombre_departamento,
                                              genero = g.nombre_genero,
                                              confirmados = c.casosConfirmados,
                                              recuperados = c.casosRecuperados,
                                              fallecidos = c.casosFallecidos
                                          }).ToList();
            ViewData["listadoCasosReportados"] = listadoCasosReportados;


            return View();
         }
        public IActionResult crearRegistro(CasosReportados NuevoCaso) 
        {
            _covidConnection.Add(NuevoCaso);
            _covidConnection.SaveChanges();
            return RedirectToAction("Index");
        
        }
    }
}
