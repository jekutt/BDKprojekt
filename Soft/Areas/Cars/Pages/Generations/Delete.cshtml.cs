﻿using System.Threading.Tasks;
using Loppprojekt.Domain.Cars.Generations;
using Loppprojekt.Domain.Cars.Marks;
using Loppprojekt.Domain.Cars.Models;
using Loppprojekt.Pages.Cars.Generations;
using Microsoft.AspNetCore.Mvc;

namespace Loppprojekt.Soft.Areas.Cars.Pages.Generations
{
    public class DeleteModel : GenerationsPage
    {
        public DeleteModel(IGenerationsRepository r, IModelsRepository m, IMarksRepository s) : base(r, m, s)
        {
        }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
            await deleteObject(id, fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }

    }

}

