using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppStudent.Models;

namespace AppStudent.Pages.Do
{
    public class EditModel : PageModel
    {
        private readonly AppStudent.Models.AppStudentContext _context;

        public EditModel(AppStudent.Models.AppStudentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MyStud MyStud { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyStud = await _context.MyStud.FirstOrDefaultAsync(m => m.ID == id);

            if (MyStud == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MyStud).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyStudExists(MyStud.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MyStudExists(int id)
        {
            return _context.MyStud.Any(e => e.ID == id);
        }
    }
}
