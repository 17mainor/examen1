using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApp.Pages.Instituciones
{
    public class EditModel : PageModel
    {
        private readonly InstitucionService institucion;

        public EditModel(InstitucionService institucion)
        {
            this.institucion = institucion;
        }

        public void OnGet()
        {
        }
    }
}
