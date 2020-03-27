using System.Collections.Generic;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abc.Pages.Quantity
{
    public abstract class MeasuresPage : PageModel
    {
        protected internal readonly IMeasureRepository db;

        protected internal MeasuresPage(IMeasureRepository r)
        {
            db = r;
        }
        [BindProperty]
        public MeasureView Item { get; set; }
        public IList<MeasureView> Items { get; set; }


    }
}
