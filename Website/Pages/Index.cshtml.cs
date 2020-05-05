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
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// The filtered categories
        /// </summary>      
        [BindProperty(SupportsGet = true)]
        public string[] Categories { get; set; }

        /// <summary>
        /// The minimum calories
        /// </summary> 
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// The maximum calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// The minimum price
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum price
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Items = Menu.CompleteMenu();
            //Search for items by the SearchTerms
            if (SearchTerms != null)
            {
                Items = Items.Where(item => item.ToString() != null && item.ToString().Contains(SearchTerms, StringComparison.CurrentCultureIgnoreCase));
            }

            //Filter by Category
            if(Categories != null && Categories.Length != 0)
            {
                Items = Items.Where(item => Categories.Contains(item.GetType().BaseType.Name));
            }

            //Filter by Calories
            if (CaloriesMin == null && CaloriesMax != null)
            {
                Items = Items.Where(item => item.Calories <= CaloriesMax);
            }

            if (CaloriesMax == null && CaloriesMin != null)
            {
                Items = Items.Where(item => item.Calories >= CaloriesMin);
            }

            if (CaloriesMax != null && CaloriesMin != null)
            {

                Items = Items.Where(item => item.Calories >= CaloriesMin && item.Calories <= CaloriesMax);
            }

            //Filter by Price
            if (PriceMin == null && PriceMax != null)
            {
                Items = Items.Where(item => item.Price <= PriceMax);
            }

            if (PriceMax == null && PriceMin != null)
            {
                Items = Items.Where(item => item.Price >= PriceMin);
            }

            if (PriceMax != null && PriceMin != null)
            {

                Items = Items.Where(item => item.Price >= PriceMin && item.Price <= PriceMax);
            }
        }      
    }
}
