using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class CustomersModel
    {

        [DisplayName("Customers Id")]
        public int Id { get; set; }
        [DisplayName("Customers Document")]
        [Required(ErrorMessage = "Customers Document is required")]
        [StringLength(16, ErrorMessage = "Customers Document must be 16 characters or less")]
        public string Document { get; set; }

        [DisplayName("Customers Name")]
        [Required(ErrorMessage = "Customers Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customers name must be between 3 and 50 characters")]
        public string Name { get; set; }
        [DisplayName("Customers firstName")]
        [Required(ErrorMessage = "Customers firstName is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customers FirstName must be between 3 and 50 characters")]
        public string FirstName { get; set; }
        [DisplayName("Customers lastName")]
        [Required(ErrorMessage = "Customers lastName is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customers LastName must be between 3 and 50 characters")]
        public string lastName { get; set; }

        [DisplayName("Customers Address")]
        [Required(ErrorMessage = "Customers Address is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customers Address must be between 3 and 50 characters")]
        public string Address {  get; set; }
        [DisplayName("Customers Date")]
        [Required(ErrorMessage = "Customers Date is required ")]

        public string Date { get; set; }
        [DisplayName("Customers Phone")]
        [Required(ErrorMessage = "Customers Date is required ")]
        public string PhoneNumber { get; set; }
        [DisplayName("Customers Email")]
        [Required(ErrorMessage = "Customers Email is required ")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customers Phone must be between 3 and 50 characters")]
        public string Email { get; set; }
    }
}
