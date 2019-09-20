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
    public class IndexModel : PageModel
    {
        private readonly AppStudent.Models.AppStudentContext _context;

        public IndexModel(AppStudent.Models.AppStudentContext context)
        {
            _context = context;
        }

        public IList<MyStud> MyStud { get;set; }

        public async Task OnGetAsync()
        {
            MyStud = await _context.MyStud.ToListAsync();
        }
    }
}
