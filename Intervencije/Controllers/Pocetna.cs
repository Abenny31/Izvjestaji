using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intervencije.Controllers
{
    public class Pocetna : Controller
    {

        //index vraca pocetnu stranicu sa izbornikom (ovisno o pravima)
        //Upisat intervenciju, pregledat, popravit 
        //admin - popis svih uredit sve poredat po zelji
        public IActionResult Index()
        {
            //
            return View();

        }
    }
}
