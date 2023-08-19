using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using academia.Contexto;
using academia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace academia.Controllers
{
    public class AlunosController : Controller
    {
        private readonly AcademiaDbContext _context;

        public AlunosController(AcademiaDbContext context)
        {
            _context = context;
        }
        // GET: Alunos
        public async Task<IActionResult> Index()
        {
            var alunos = await _context.Aluno.ToListAsync();
            return View(alunos);
        }

        // GET: Alunos Devendo
        public async Task<IActionResult> Devendo()
        {
            var alunos = await _context.Aluno.Where(a => a.DiaPagamento - (int)DateTime.Now.Day < 0).ToListAsync();
            return View(alunos);
        }

        // GET: Alunos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Alunos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alunos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Aluno aluno)
        {
            try
            {
                _context.Aluno.Add(aluno);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Alunos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Alunos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Alunos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Alunos/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}