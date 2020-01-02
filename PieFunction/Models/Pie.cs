using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PieFunction
{
    public class Pie
    {
        public int PieId { get; set; }
        public string Name { get; set; }
        [MaxLength(100)]
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
     
        public string ImageUrl { get; set; }
       
        public string ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<PieReview> PieReviews { get; set; }

        //Specific for Model Binding
        public SugarLevel SugarLevel { get; set; }
        public RecipeInformation RecipeInformation { get; set; }


    }
}
