using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KnittingCore2.Models;
using System.Web.Mvc;
using SelectListItem = Microsoft.AspNetCore.Mvc.Rendering.SelectListItem;
using System.Text;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using ValidateAntiForgeryTokenAttribute = Microsoft.AspNetCore.Mvc.ValidateAntiForgeryTokenAttribute;
using SelectList = Microsoft.AspNetCore.Mvc.Rendering.SelectList;
using BindAttribute = Microsoft.AspNetCore.Mvc.BindAttribute;
using ActionNameAttribute = Microsoft.AspNetCore.Mvc.ActionNameAttribute;
using Microsoft.AspNetCore.Http;

namespace KnittingCore2.Controllers
{
    public class PatronesController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ModelosPuntoContext _context;

        public PatronesController(ModelosPuntoContext context) //Inyeccion de dependencias del contexto
        {
            _context = context;
        }

        // GET: Patrones
        public async Task<IActionResult> Index()
        {
            var modelosPuntoContext = _context.Patrones.Include(p => p.AutorPatron).Include(p => p.GeneroEdad).Include(p => p.Lanas).Include(p => p.Prendas).Include(p => p.Revistas).Include(p => p.TiposCaracteristicas).Include(p => p.TiposDeTejer);
            return View(await modelosPuntoContext.ToListAsync());
        }

       public IActionResult _Buscar()
        {
            List<SelectListItem> NomPatron = (from ap in _context.NombrePatron.AsEnumerable()
                                              select new SelectListItem
                                              {
                                                  Text = ap.NombrePatron,
                                                  Value = ap.IdNombrePatron.ToString()
                                              }).ToList();
            NomPatron.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });
            ViewData["IdNombrePatron"] = NomPatron;

            //*******************************************************************************************
            //El autor en la lista
            List<SelectListItem> autores = (from ap in _context.AutorPatron.AsEnumerable()
                                            select new SelectListItem
                                            {
                                                Text = ap.NombreAutor,
                                                Value = ap.IdAutorPatron.ToString()
                                            }).ToList();
            autores.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });
            ViewData["IdAutorPatron"] = autores;
            //*******************************************************************************************
            //El campo Genero edad en la lista
            List<SelectListItem> GenEdad = (from g in _context.GeneroEdad.AsEnumerable()
                                            select new SelectListItem
                                            {
                                                Text = g.GenEdad,
                                                Value = g.IdGenEd.ToString()
                                            }).ToList();

            GenEdad.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });
            ViewData["IdGenEdad"] = GenEdad;
            //*******************************************************************************************
            //Lanas
            List<SelectListItem> lanas = (from l in _context.Lanas.AsEnumerable()
                                          select new SelectListItem
                                          {
                                              Text = l.NombreLana,
                                              Value = l.IdLana.ToString()
                                          }).ToList();

            lanas.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });
            ViewData["IdLana"] = lanas;
            //*******************************************************************************************
            //Prendas
            List<SelectListItem> prendas = (from p in _context.Prendas.AsEnumerable()
                                            select new SelectListItem
                                            {
                                                Text = p.NombrePrendas,
                                                Value = p.IdPrendas.ToString()
                                            }).ToList();

            prendas.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });
            ViewData["IdPrendas"] = prendas;
            //*******************************************************************************************
            //Revistas
            List<SelectListItem> revistas = (from r in _context.Revistas.AsEnumerable()
                                             select new SelectListItem
                                             {
                                                 Text = r.NombreRevista,
                                                 Value = r.IdRevistas.ToString()
                                             }).ToList();

            revistas.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });
            ViewData["IdRevistas"] = revistas;
            //*******************************************************************************************
            //Tipos de características
            List<SelectListItem> carac = (from c in _context.TiposCaracteristicas.AsEnumerable()
                                          select new SelectListItem
                                          {
                                              Text = c.NombreCaracteristicas,
                                              Value = c.IdTiposCaract.ToString()
                                          }).ToList();

            carac.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });
            ViewData["IdTiposCaract"] = carac;
            //*******************************************************************************************
            //Tipos de tejido
            List<SelectListItem> TiposTej = (from t in _context.TiposDeTejer.AsEnumerable()
                                             select new SelectListItem
                                             {
                                                 Text = t.NombreDeTejer,
                                                 Value = t.IdTiposTejer.ToString()
                                             }).ToList();

            TiposTej.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });
            ViewData["IdTiposdeTejer"] = TiposTej;
            //*******************************************************************************************
       
            //Dos opciones: Si tiene o no elegido el Nombre del patrón
            //Si lo tiene elegido buscaremos el id. 


            //     List<Patrones> GetFilteredData(int? IdNombrePatron,
            //string FirstName, string LastName,
            //string CustomerType, bool Active)


            //IQueryable<Patrones> oDataQuery = _context.Patrones;

            //    //Filter by Integer
            //    if (IdNombrePatron != null)
            //    {
            //        oDataQuery = oDataQuery.Where(a => a.IdNombrePatron == IdNombrePatron);
            //    }

            //    //Filter by containing words
            //    if (FirstName.Trim().Length > 0)
            //    {
            //        oDataQuery = oDataQuery.Where(a => a.FirstName.Contains(FirstName));
            //    }

            //    //Filter by containing words
            //    if (LastName.Trim().Length > 0)
            //    {
            //        oDataQuery = oDataQuery.Where(a => a.LastName.Contains(LastName));
            //    }

            //    //Filter by a Foreign Key Relationship
            //    if (CustomerType.Trim().Length > 0)
            //    {
            //        oDataQuery = oDataQuery.Where(a => a.CustomerTypeID == (
            //          from b in oDB.CustomerTypes
            //          where b.CustomerType1 ==CustomerType
            //          select b.CustomerTypeID).FirstOrDefault());
            //    }

            //    //Filter by boolean
            //    oDataQuery = oDataQuery.Where(a => a.Active == Active);

            return View();

        }

        // GET: Patrones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patrones = await _context.Patrones
                .Include(p => p.AutorPatron)
                .Include(p => p.GeneroEdad)
                .Include(p => p.Lanas)
                .Include(p => p.Prendas)
                .Include(p => p.Revistas)
                .Include(p => p.TiposCaracteristicas)
                .Include(p => p.TiposDeTejer)
                .FirstOrDefaultAsync(m => m.IdNombrePatron == id);
            if (patrones == null)
            {
                return NotFound();
            }

            return View(patrones);
        }

        // GET: Patrones/Create
        public IActionResult Create()
        {
            //*******************************************************************************************
            //El autor en la lista
            List<SelectListItem> autores = (from ap in _context.AutorPatron.AsEnumerable()
                                            select new SelectListItem
                                            {
                                                Text = ap.NombreAutor,
                                                Value = ap.IdAutorPatron.ToString()
                                            }).ToList();
            autores.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });
            ViewData["IdAutorPatron"] = autores;
            //*******************************************************************************************
            //El campo Genero edad en la lista
            List<SelectListItem> GenEdad = (from g in _context.GeneroEdad.AsEnumerable()
                                            select new SelectListItem
                                            {
                                                Text = g.GenEdad,
                                                Value = g.IdGenEd.ToString()
                                            }).ToList();

            GenEdad.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });
            ViewData["IdGenEdad"] = GenEdad;
            //*******************************************************************************************
            //Lanas
            List<SelectListItem> lanas = (from l in _context.Lanas.AsEnumerable()
                                          select new SelectListItem
                                          {
                                              Text = l.NombreLana,
                                              Value = l.IdLana.ToString()
                                          }).ToList();

            lanas.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });
            ViewData["IdLana"] = lanas;
            //*******************************************************************************************
            //Prendas
            List<SelectListItem> prendas = (from p in _context.Prendas.AsEnumerable()
                                            select new SelectListItem
                                            {
                                                Text = p.NombrePrendas,
                                                Value = p.IdPrendas.ToString()
                                            }).ToList();

            prendas.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });
            ViewData["IdPrendas"] = prendas;
            //*******************************************************************************************
            //Revistas
            List<SelectListItem> revistas = (from r in _context.Revistas.AsEnumerable()
                                             select new SelectListItem
                                             {
                                                 Text = r.NombreRevista,
                                                 Value = r.IdRevistas.ToString()
                                             }).ToList();

            revistas.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });
            ViewData["IdRevistas"] = revistas;
            //*******************************************************************************************
            //Tipos de características
            List<SelectListItem> carac = (from c in _context.TiposCaracteristicas.AsEnumerable()
                                          select new SelectListItem
                                          {
                                              Text = c.NombreCaracteristicas,
                                              Value = c.IdTiposCaract.ToString()
                                          }).ToList();

            carac.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });
            ViewData["IdTiposCaract"] = carac;
            //*******************************************************************************************
            //Tipos de tejido
            List<SelectListItem> TiposTej = (from t in _context.TiposDeTejer.AsEnumerable()
                                             select new SelectListItem
                                             {
                                                 Text = t.NombreDeTejer,
                                                 Value = t.IdTiposTejer.ToString()
                                             }).ToList();

            TiposTej.Insert(0, new SelectListItem { Text = "Selecciona un elemento", Value = "-1" });
            ViewData["IdTiposdeTejer"] = TiposTej;
            //*******************************************************************************************
            //Retorna a la vista
            return View();
        }

        // POST: Patrones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection collection)//([Bind("IdNombrePatron,NombrePatron,IdAutorPatron,IdLana,IdPrendas,IdRevistas,IdTiposCaract,IdTiposdeTejer,IdGenEdad,Patron")] Patrones patrones)
        {

            Patrones pat = new Patrones();
            byte[] rutapatron = Encoding.ASCII.GetBytes(Request.Form["Patron"]);
            pat.NombrePatron = Request.Form["NombrePatron"];
            pat.IdAutorPatron = Convert.ToInt32(Request.Form["IdAutorPatron"]) > 0 ? pat.IdAutorPatron : null;
            //Conviertes a byte[]  idat != null ? idat : null;
            pat.Patron = rutapatron != null ? rutapatron : null;
            pat.IdLana = Convert.ToInt32(Request.Form["IdLana"]) > 0 ? pat.IdLana : null;
            pat.IdPrendas = Convert.ToInt32(Request.Form["IdPrendas"]) > 0 ? pat.IdPrendas : null;
            pat.IdRevistas = Convert.ToInt32(Request.Form["IdRevistas"]) > 0 ? pat.IdRevistas : null;
            pat.IdTiposCaract = Convert.ToInt32(Request.Form["IdTiposCaract"]) > 0 ? pat.IdTiposCaract : null;
            pat.IdTiposdeTejer = Convert.ToInt32(Request.Form["IdTiposdeTejer"]) > 0 ? pat.IdTiposdeTejer : null;
            pat.IdGenEdad = Convert.ToInt32(Request.Form["IdGenEdad"]) > 0 ? pat.IdGenEdad : null;
            _context.Patrones.Add(pat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            //if (ModelState.IsValid)
            //{
            //    _context.Add(patrones);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["IdAutorPatron"] = new SelectList(_context.AutorPatron, "IdAutorPatron", "NombreAutor", pat.IdAutorPatron);
            //ViewData["IdGenEdad"] = new SelectList(_context.GeneroEdad, "IdGenEd", "GenEdad", pat.IdGenEdad);
            //ViewData["IdLana"] = new SelectList(_context.Lanas, "IdLana", "NombreLana", pat.IdLana);
            //ViewData["IdPrendas"] = new SelectList(_context.Prendas, "IdPrendas", "NombrePrendas", pat.IdPrendas);
            //ViewData["IdRevistas"] = new SelectList(_context.Revistas, "IdRevistas", "NombreRevista", pat.IdRevistas);
            //ViewData["IdTiposCaract"] = new SelectList(_context.TiposCaracteristicas, "IdTiposCaract", "NombreCaracteristicas", pat.IdTiposCaract);
            //ViewData["IdTiposdeTejer"] = new SelectList(_context.TiposDeTejer, "IdTiposTejer", "NombreDeTejer", pat.IdTiposdeTejer);
            //return View(pat);
        }

        // GET: Patrones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patrones = await _context.Patrones.FindAsync(id);
            if (patrones == null)
            {
                return NotFound();
            }
            ViewData["IdAutorPatron"] = new SelectList(_context.AutorPatron, "IdAutorPatron", "NombreAutor", patrones.IdAutorPatron);
            ViewData["IdGenEdad"] = new SelectList(_context.GeneroEdad, "IdGenEd", "GenEdad", patrones.IdGenEdad);
            ViewData["IdLana"] = new SelectList(_context.Lanas, "IdLana", "NombreLana", patrones.IdLana);
            ViewData["IdPrendas"] = new SelectList(_context.Prendas, "IdPrendas", "NombrePrendas", patrones.IdPrendas);
            ViewData["IdRevistas"] = new SelectList(_context.Revistas, "IdRevistas", "NombreRevista", patrones.IdRevistas);
            ViewData["IdTiposCaract"] = new SelectList(_context.TiposCaracteristicas, "IdTiposCaract", "NombreCaracteristicas", patrones.IdTiposCaract);
            ViewData["IdTiposdeTejer"] = new SelectList(_context.TiposDeTejer, "IdTiposTejer", "NombreDeTejer", patrones.IdTiposdeTejer);
            return View(patrones);
        }

        // POST: Patrones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdNombrePatron,NombrePatron,IdAutorPatron,IdLana,IdPrendas,IdRevistas,IdTiposCaract,IdTiposdeTejer,IdGenEdad,Patron")] Patrones patrones)
        {
            if (id != patrones.IdNombrePatron)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patrones);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatronesExists(patrones.IdNombrePatron))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdAutorPatron"] = new SelectList(_context.AutorPatron, "IdAutorPatron", "IdAutorPatron", patrones.IdAutorPatron);
            ViewData["IdGenEdad"] = new SelectList(_context.GeneroEdad, "IdGenEd", "IdGenEd", patrones.IdGenEdad);
            ViewData["IdLana"] = new SelectList(_context.Lanas, "IdLana", "IdLana", patrones.IdLana);
            ViewData["IdPrendas"] = new SelectList(_context.Prendas, "IdPrendas", "IdPrendas", patrones.IdPrendas);
            ViewData["IdRevistas"] = new SelectList(_context.Revistas, "IdRevistas", "IdRevistas", patrones.IdRevistas);
            ViewData["IdTiposCaract"] = new SelectList(_context.TiposCaracteristicas, "IdTiposCaract", "IdTiposCaract", patrones.IdTiposCaract);
            ViewData["IdTiposdeTejer"] = new SelectList(_context.TiposDeTejer, "IdTiposTejer", "NombreDeTejer", patrones.IdTiposdeTejer);
            return View(patrones);
        }

        // GET: Patrones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patrones = await _context.Patrones
               // .Include(p => p.NombrePatron)
                .Include(p => p.AutorPatron)
                .Include(p => p.GeneroEdad)
                .Include(p => p.Lanas)
                .Include(p => p.Prendas)
                .Include(p => p.Revistas)
                .Include(p => p.TiposCaracteristicas)
                .Include(p => p.TiposDeTejer)
                .FirstOrDefaultAsync(m => m.IdNombrePatron == id);
            if (patrones == null)
            {
                return NotFound();
            }

            return View(patrones);
        }

        // POST: Patrones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var patrones = await _context.Patrones.FindAsync(id);
            _context.Patrones.Remove(patrones);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatronesExists(int id)
        {
            return _context.Patrones.Any(e => e.IdNombrePatron == id);
        }
    }
}
