using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppStudent.Models;

namespace AppStudent.Pages.Do
{
    public class DetailsModel : PageModel
    {
        private readonly AppStudent.Models.AppStudentContext _context;

        public DetailsModel(AppStudent.Models.AppStudentContext context)
        {
            _context = context;
        }

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
    }
}
