using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projetocripto.Models;

namespace projetocripto.Controllers
{
    public class TransacoesController : Controller
    {
        private readonly Contexto _context;

        public TransacoesController(Contexto context)
        {
            _context = context;
        }

        // GET: Transacoes
        public async Task<IActionResult> Index()
        {
              return View(await _context.transasoes.ToListAsync());
        }

        // GET: Transacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.transasoes == null)
            {
                return NotFound();
            }

            var transasao = await _context.transasoes
                .FirstOrDefaultAsync(m => m.id == id);
            if (transasao == null)
            {
                return NotFound();
            }

            return View(transasao);
        }

        // GET: Transacoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,data,quantidade,valor,operacao")] Transasao transasao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transasao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transasao);
        }

        // GET: Transacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.transasoes == null)
            {
                return NotFound();
            }

            var transasao = await _context.transasoes.FindAsync(id);
            if (transasao == null)
            {
                return NotFound();
            }
            return View(transasao);
        }

        // POST: Transacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,data,quantidade,valor,operacao")] Transasao transasao)
        {
            if (id != transasao.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transasao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransasaoExists(transasao.id))
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
            return View(transasao);
        }

        // GET: Transacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.transasoes == null)
            {
                return NotFound();
            }

            var transasao = await _context.transasoes
                .FirstOrDefaultAsync(m => m.id == id);
            if (transasao == null)
            {
                return NotFound();
            }

            return View(transasao);
        }

        // POST: Transacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.transasoes == null)
            {
                return Problem("Entity set 'Contexto.transasoes'  is null.");
            }
            var transasao = await _context.transasoes.FindAsync(id);
            if (transasao != null)
            {
                _context.transasoes.Remove(transasao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransasaoExists(int id)
        {
          return _context.transasoes.Any(e => e.id == id);
        }
    }
}
