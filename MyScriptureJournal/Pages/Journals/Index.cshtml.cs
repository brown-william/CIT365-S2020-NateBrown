using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Journals
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public string BookSort { get; set; }

        public string DateSort { get; set; }
        public IList<Journal> Journal { get;set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Book { get; set; }

        [BindProperty(SupportsGet = true)]
        public string NoteSearch { get; set; }
        public async Task OnGetAsync()
        {

            //BookSort = string.IsNullOrEmpty(BookSort) ? "entry_desc" : "";
            //DateSort = DateSort == "Date" ? "date_desc" : "Date";

            //IQueryable <Journal> sortEntry = from y in _context.Journal select y;

            //switch
            //{
                //case "date_desc":
                    //sortEntry = sortEntry.OrderByDescending(y => y.EntryDate);
                    //break;

                //case "entry_desc":
                    //sortEntry = sortEntry.OrderByDescending(y => y.BookOfScripture);
                    //break;

               // default:
                    //sortEntry = sortEntry.OrderBy(y => y.BookOfScripture);
                    //break;
                    
            //}











            IQueryable<string> bookQuery = from m in _context.Journal
                                            orderby m.BookOfScripture
                                            select m.BookOfScripture;
            var journals = from m in _context.Journal
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                journals = journals.Where(s => s.Note.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(NoteSearch))
            {
                journals = journals.Where(x => x.BookOfScripture == NoteSearch);
            }
            Book = new SelectList(await bookQuery.Distinct().ToListAsync());



            Journal = await journals.ToListAsync();
        }
    }
}
