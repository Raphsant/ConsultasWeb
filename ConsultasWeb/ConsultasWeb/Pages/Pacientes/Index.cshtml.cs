using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConsultasWeb.Data;
using ConsultasWeb.Models;

namespace ConsultasWeb.Pages.Pacientes
{
    public class IndexModel : PageModel
    {
        private readonly ConsultasWeb.Data.ClinicContext _context;

        public IndexModel(ConsultasWeb.Data.ClinicContext context)
        {
            _context = context;
        }

        public IList<Pacient> Pacient { get;set; }

        public async Task OnGetAsync()
        {
            Pacient = await _context.Pacient.ToListAsync();
        }
    }
}
