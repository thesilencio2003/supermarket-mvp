using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class InvoiceModel
    {

        [DisplayName("Invoice Id")]
        public int Id { get; set; }

        [DisplayName("Invoice number")]
        [Required(ErrorMessage = "Invoice number is required")]
        public int Number { get; set; }
        [DisplayName("Date")]
        [Required(ErrorMessage = "Invoice Date is required")]
        public DateTime Date { get; set; }
    }
}
