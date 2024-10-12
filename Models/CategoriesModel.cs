using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class CategoriesModel
    {

        [DisplayName("Categories Id")]
        public int Id { get; set; }

        [DisplayName("Categories Name")]
        [Required(ErrorMessage = "Categories name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Categories name must be between 3 and 50 characters")]
        public string Name { get; set; }
        [DisplayName("Description")]
        [Required(ErrorMessage = "Categories Description is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Categories Description must be between 3 and 50 characters")]
        public string Description { get; set; }
    }
}
