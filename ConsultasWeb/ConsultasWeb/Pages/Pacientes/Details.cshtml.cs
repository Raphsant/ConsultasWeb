using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConsultasWeb.Data;
using ConsultasWeb.Models;

namespace ConsultasWeb
{
    public class DetailsModel : PageModel
    {
        private readonly ConsultasWeb.Data.ClinicContext _context;

        public DetailsModel(ConsultasWeb.Data.ClinicContext context)
        {
            _context = context;
        }

        public Pacient Pacient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pacient = await _context.Pacient.FirstOrDefaultAsync(m => m.ID == id);

            if (Pacient == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
