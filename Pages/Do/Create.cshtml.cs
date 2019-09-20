using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AppStudent.Models;

namespace AppStudent.Pages.Do
{
    public class CreateModel : PageModel
    {
        private readonly AppStudent.Models.AppStudentContext _context;

        public CreateModel(AppStudent.Models.AppStudentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MyStud MyStud { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MyStud.Add(MyStud);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}