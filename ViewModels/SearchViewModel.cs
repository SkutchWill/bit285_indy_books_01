using System;
using System.ComponentModel.DataAnnotations;
namespace IndyBooks.ViewModels
{
    public class SearchViewModel
    {
        public String Title { get; set; }

        public String Author { get; set; }

        [DataType(DataType.Currency)]
        public Decimal MinPrice { get; set; }

        [DataType(DataType.Currency)]
        public Decimal MaxPrice { get; set; }
        //TODO: Add properties needed for searching
    }
}
