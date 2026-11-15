using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOCCERMVC2020ZULU.Web.Data;
using SOCCERMVC2020ZULU.Web.Data.Entities;
using SOCCERMVC2020ZULU.Web.Helpers;
using SOCCERMVC2020ZULU.Web.Models;

namespace SOCCERMVC2020ZULU.Web.Controllers;

public class TeamsController : Controller
{
    private readonly DataContext _context;
    private readonly IConverterHelper _converterHelper;
    private readonly IImageHelper _imageHelper;

    public TeamsController(DataContext context, IImageHelper imageHelper, IConverterHelper converterHelper)
    {
        _context = context;
        _converterHelper = converterHelper;
        _imageHelper = imageHelper;
    }

    // GET: Teams
    public async Task<IActionResult> Index()
    {
        return _context.Teams != null ?
                    View(await _context.Teams.ToListAsync()) :
                    Problem("Entity set 'DataContext.Team'  is null.");
    }

    // GET: Teams/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.Teams == null)
        {
            return NotFound();
        }

        var team = await _context.Teams
            .FirstOrDefaultAsync(m => m.Id == id);
        if (team == null)
        {
            return NotFound();
        }

        return View(team);
    }

    // GET: Teams/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Teams/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(TeamViewModel teamViewModel)
    {
        if (ModelState.IsValid)
        {
            var path = string.Empty;
            if (teamViewModel.LogoFile != null)
            {
                path = await _imageHelper.UploadImageAsync(teamViewModel.LogoFile, "Teams");
            }
            var team = _converterHelper.ToTeamEntity(teamViewModel, path, true);
            _context.Add(team);
            try
            {
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                if (ex.InnerException!.Message.Contains("duplicate"))
                {
                    ModelState.AddModelError(string.Empty, "Already exists a team with the same name.");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                }
            }
        }
        return View(teamViewModel);
    }

    // GET: Teams/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.Teams == null)
        {
            return NotFound();
        }

        var team = await _context.Teams.FindAsync(id);
        if (team == null)
        {
            return NotFound();
        }
        var teamViewModel = _converterHelper.ToTeamViewModel(team);
        return View(teamViewModel);
    }

    // POST: Teams/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, TeamViewModel teamViewModel)
    {
        if (id != teamViewModel.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            string path = teamViewModel.LogoPath!;
            if (teamViewModel.LogoFile != null)
            {
                path = await _imageHelper.UploadImageAsync(teamViewModel.LogoFile, "Teams");
            }
            Team team = _converterHelper.ToTeamEntity(teamViewModel, path, false);
            _context.Update(team);
            try
            {
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamExists(team.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException!.Message.Contains("duplicate"))
                {
                    ModelState.AddModelError(string.Empty, $"Already exists the team: {team.Name}.");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(teamViewModel);
    }

    // GET: Teams/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || _context.Teams == null)
        {
            return NotFound();
        }
        //normal
        var team = await _context.Teams
            .FirstOrDefaultAsync(m => m.Id == id);
        if (team == null)
        {
            return NotFound();
        }

        // modificado, estaba abajo
        _context.Teams.Remove(team);
        await _context.SaveChangesAsync();
        //aqui continua normal
        return View(team);
    }

    //// POST: Teams/Delete/5
    //[HttpPost, ActionName("Delete")]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> DeleteConfirmed(int id)
    //{
    //    if (_context.Teams == null)
    //    {
    //        return Problem("Entity set 'DataContext.Team'  is null.");
    //    }
    //    var team = await _context.Teams.FindAsync(id);
    //    if (team != null)
    //    {
    //        _context.Teams.Remove(team);
    //    }

    //    await _context.SaveChangesAsync();
    //    return RedirectToAction(nameof(Index));
    //}

    private bool TeamExists(int id)
    {
        return (_context.Teams?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}