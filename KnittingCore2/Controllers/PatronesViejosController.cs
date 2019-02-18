using KnittingCore2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
//using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;

namespace KnittingCore2.Controllers
{
    public class PatronesViejosController : Controller
    {
       
        // GET: Patrones
        public IActionResult Index()
        {
            using (ModelosPuntoContext contexto = new ModelosPuntoContext())
            {
                return View(contexto.Patrones.ToList());
            }
        }

        // GET: Patrones/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: Patrones/Create
        public IActionResult Create()
        {
            try
            {
                using (ModelosPuntoContext contexto = new ModelosPuntoContext())
                { 
                    List<SelectListItem> lanas = (from l in contexto.Lanas.AsEnumerable()
                                                  select new SelectListItem
                                                  {
                                                      Text = l.NombreLana,
                                                      Value = l.IdLana.ToString()
                                                  }).ToList();

                lanas.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });


                List<SelectListItem> prendas = (from p in contexto.Prendas.AsEnumerable()
                                                select new SelectListItem
                                                {
                                                    Text = p.NombrePrendas,
                                                    Value = p.IdPrendas.ToString()
                                                }).ToList();

                prendas.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });

          

                List<SelectListItem> autores = (from ap in contexto.AutorPatron.AsEnumerable()
                                                select new SelectListItem
                                                {
                                                    Text = ap.NombreAutor,
                                                    Value = ap.IdAutorPatron.ToString()
                                                }).ToList();
                autores.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });

                List<SelectListItem> revistas = (from r in contexto.Revistas.AsEnumerable()
                                                 select new SelectListItem
                                                 {
                                                     Text = r.NombreRevista,
                                                     Value = r.IdRevistas.ToString()
                                                 }).ToList();

                revistas.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });



                List<SelectListItem> carac = (from c in contexto.TiposCaracteristicas.AsEnumerable()
                                              select new SelectListItem
                                              {
                                                  Text = c.NombreCaracteristicas,
                                                  Value = c.IdTiposCaract.ToString()
                                              }).ToList();

                carac.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });


                List<SelectListItem> TiposTej = (from t in contexto.TiposDeTejer.AsEnumerable()
                                                 select new SelectListItem
                                                 {
                                                     Text = t.NombreDeTejer,
                                                     Value = t.IdTiposTejer.ToString()
                                                 }).ToList();

                TiposTej.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });


                List<SelectListItem> GenEdad = (from g in contexto.GeneroEdad.AsEnumerable()
                                                select new SelectListItem
                                                {
                                                    Text = g.GenEdad,
                                                    Value = g.IdGenEd.ToString()
                                                }).ToList();

                GenEdad.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });


                // progCodesList;
                ViewBag.ProgCodeId = lanas;
                ViewBag.ProgAutPat = autores;
                ViewBag.progCodePrendas = prendas;
                ViewBag.progCodeRevistas = revistas;
                ViewBag.progCodeTiposCarac = carac;
                ViewBag.progCodeTipoTej = TiposTej;
                ViewBag.progCodeGen = GenEdad;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return View();
        }

        // POST: Patrones/Create
        [HttpPost]
        public IActionResult Create(System.Web.Mvc.FormCollection collection)
        {
            try
            {
                using (ModelosPuntoContext contexto = new ModelosPuntoContext())
                { 
                Patrones pat = new Patrones();
                byte[] rutapatron = Encoding.ASCII.GetBytes(collection.Get("Patr"));
                //int a = pat.IdAutorPatron.Value;
                pat.NombrePatron = collection.Get("NombPatron"); 
                pat.IdAutorPatron = Convert.ToInt32(collection.Get("Autorid"));
                //Conviertes a byte[]  idat != null ? idat : null;
                pat.Patron = rutapatron != null ? rutapatron : null;
                pat.IdLana = Convert.ToInt32(collection.Get("Lanasid"));
                pat.IdPrendas = Convert.ToInt32(collection.Get("Prendasid"));
                pat.IdRevistas = Convert.ToInt32(collection.Get("Revistasid"));
                pat.IdTiposCaract = Convert.ToInt32(collection.Get("CaracId"));
                pat.IdTiposdeTejer = Convert.ToInt32(collection.Get("TiposTej"));
                pat.IdGenEdad = Convert.ToInt32(collection.Get("TiposTej"));
                contexto.Patrones.Add(pat);
                contexto.SaveChanges();
                    
                }
                return IRedirectToActionResult("Index", "Home");
              
            }
            catch (Exception ex)
            {
                //string a = ex.ToString();
                return View();
            }
        }

        // GET: Patrones/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: Patrones/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, System.Web.Mvc.FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Patrones/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: Patrones/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
