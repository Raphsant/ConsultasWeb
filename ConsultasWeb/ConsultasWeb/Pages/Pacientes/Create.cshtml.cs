using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ConsultasWeb.Data;
using ConsultasWeb.Models;

namespace ConsultasWeb
{
    public class CreateModel : PageModel
    {
        private readonly ConsultasWeb.Data.ClinicContext _context;

        public CreateModel(ConsultasWeb.Data.ClinicContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pacient Pacient { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pacient.Add(Pacient);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
