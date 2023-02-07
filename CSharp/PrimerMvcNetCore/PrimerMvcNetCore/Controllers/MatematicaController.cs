using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
    public class MatematicaController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SumarNumeroGet(int valor1, int valor2)
        {
            ViewData["VALOR"] = valor1 + valor2;
            return View();
        }

        public IActionResult SumarNumeroPost()
        {
            return View();
        }

        public IActionResult ConjeturaCollatz()
        {
            return View();
            //return View(new List<int>());
        }

        public IActionResult TablaMultiplicar()
        {
            return View();
        }

        public IActionResult TablaMultiplicarCompuesta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarCompuesta(int numero)
        {
            List<FilaTablaMultiplicar> resultados = new List<FilaTablaMultiplicar>();
            for (int i = 1; i <= 10; i++)
            {
                FilaTablaMultiplicar fila = new FilaTablaMultiplicar();
                fila.Operacion = numero + " * " + i;
                fila.Resultado = numero * i;
                resultados.Add(fila);
            }
            return View(resultados);

        }

        [HttpPost]
        public IActionResult TablaMultiplicar(int numero)
        {
            List<int> listaOperadores = new List<int>(); 
            int[] operadores = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40 };
            for (int i = 0; i < operadores.Length; i++)
            {
                listaOperadores.Add(numero * operadores[i]);
            }
            return View(listaOperadores);
        }

        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            List<int> numeros = new List<int>();
            while( numero != 1)
            {
                if(numero % 2 == 0)
                {
                    numero /= 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                numeros.Add(numero);
            }
            return View(numeros);
        }

        [HttpPost]
        public IActionResult SumarNumeroPost(int valor1, int valor2)
        {
            ViewData["VALOR"] = valor1 + valor2; 
            return View();
        }

        //public List<int> CalcularCollatz(int num)
        //{
        //    while(num != 1)
        //    {
        //        if(num % 2 == 0)
        //        {
        //            num /= 2;
        //        }
        //        else
        //        {
        //            num = num * 3 + 1;
        //        }
        //        List<int> numeros = new List<int>();
        //        numeros.Add(num);
        //    }
        //}
    }
}
