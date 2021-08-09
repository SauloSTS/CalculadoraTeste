using CalculadoraTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraTeste.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CalculadoraViewModel calculadoraViewModel)
        {
            ModelState.Clear();
            if (calculadoraViewModel.Operador.Equals("+"))
            {
                calculadoraViewModel.Resultado = calculadoraViewModel.Num1 + calculadoraViewModel.Num2;
            }
            if (calculadoraViewModel.Operador.Equals("-"))
            {
                calculadoraViewModel.Resultado = calculadoraViewModel.Num1 - calculadoraViewModel.Num2;
            }
            if (calculadoraViewModel.Operador.Equals("*"))
            {
                calculadoraViewModel.Resultado = calculadoraViewModel.Num1 * calculadoraViewModel.Num2;
            }
            if (calculadoraViewModel.Operador.Equals("/"))
            {
                calculadoraViewModel.Resultado = calculadoraViewModel.Num1 / calculadoraViewModel.Num2;
            }
            return View(calculadoraViewModel);
        }

    }
}