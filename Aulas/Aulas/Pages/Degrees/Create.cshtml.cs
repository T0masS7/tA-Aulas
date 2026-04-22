using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Aulas.Data;
using Aulas.Data.Model;

namespace Aulas.Pages.Degrees
{
    public class CreateModel : PageModel
    {
        private readonly Aulas.Data.ApplicationDbContext _context;

        public CreateModel(Aulas.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// mostra a página do Create, quando o pedido é feito em Http Get
        /// </summary>
        /// <returns>CLiente Page </returns>

        public IActionResult OnGet()
        {
            return Page();
        }

        /// <summary>
        /// atributo que define o objeto a ser processado na vista (page) 
        /// </summary>

        [BindProperty]
        public Degree Degree { get; set; } = default!;

        /// <summary>
        /// atributo que define o fichaeiro da imagem a ser processado
        /// </summary>
        [BindProperty]
        public IFormFile ImageLogo { get; set; }

        // For more information, see https://aka.ms/RazorPagesCRUD.

        /// <summary>
        /// Processa o pedido Http Post, quando o formulário do Create é submetido
        /// Se os dados forem válidos, o novo Curso é adicionado à base de dados 
        /// e o utilizador é redirecionado para a página de índice dos CUrsos 
        /// </summary>
        /// <returns>Página de listagem de todos os crusos </returns>
        public async Task<IActionResult> OnPostAsync()
        {
            if (ImageLogo == null)
            {
                ModelState.AddModelError("ImageLogo", "O ficheiro de imagem é obrigatorio");
                return Page();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Degrees.Add(Degree);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
