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
        public IEnumerable<IOrderItem> Items { get; protected set; } = Menu.CompleteMenu();

        /// <summary>
        /// The current search terms
        /// </summary>        
        public string SearchTerms { get; set; }

        /// <summary>
        /// The filtered categories
        /// </summary>      
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

        public void OnGet(int? caloriesMin, int? caloriesMax, double? priceMin, double? priceMax)
        {
            CaloriesMin = caloriesMin;
            CaloriesMax = caloriesMax;
            PriceMin = priceMin;
            PriceMax = priceMax;
            SearchTerms = Request.Query["SearchTerms"];
            Categories = Request.Query["Categories"];
            Items = Menu.Search(Items, SearchTerms);
            Items = Menu.FilterByCategory(Items, Categories);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }      
    }
}
