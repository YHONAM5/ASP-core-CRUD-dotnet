using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoDF.Data;
using DemoDF.Models;

namespace DemoDF.Pages_Clientes
{
    public class IndexModel : PageModel
    {
        private readonly DemoDF.Data.AppDbContext _context;

        public IndexModel(DemoDF.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Cliente = await _context.Clientes.ToListAsync();
        }
    }
}
