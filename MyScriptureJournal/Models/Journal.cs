using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class Journal
    {
        public int ID { get; set; }

        [StringLength(30)]
        [Required]
        [Display(Name = "Entry Name")]
        public string EntryName { get; set; }

        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Standard Work")]
        [StringLength(30)]
        [Required]
        public string BookOfScripture { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9"".:'\s-]*$")]
        [Display(Name = "Book and Reference")]
        [StringLength(30)]
        [Required]
        public string Reference { get; set; }
        
        
        [StringLength(200)]
        [Required]
        public string Note { get; set; }
    }
}
