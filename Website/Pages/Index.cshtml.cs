using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// The items to display on the index page
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// The current search terms
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; }

        /// <summary>
        /// The filtered categories
        /// </summary>
        [BindProperty]
        public string[] Categories { get; set; }

        /// <summary>
        /// The minimum calories
        /// </summary>
        [BindProperty]
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// The maximum calories
        /// </summary>
        [BindProperty]
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// The minimum price
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }
        
        /// <summary>
        /// The maximum price
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Items = Menu.CompleteMenu();
        }

        public void OnPost()
        {
            Items = Menu.Search(Menu.CompleteMenu(), SearchTerms);
            Items = Menu.FilterByCategory(Menu.CompleteMenu(), Categories);
            Items = Menu.FilterByCalories(Menu.CompleteMenu(), CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Menu.CompleteMenu(), PriceMin, PriceMax);
        }
    }
}
