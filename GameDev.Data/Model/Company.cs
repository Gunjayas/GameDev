//this represents stuffs I want to store in my database
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev.Data.Model
{
    public class Company 
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Display(Name = "Type of Game")]
        public GenreType Genre { get; set; }//If I want to restrict the Genre's of company, have to make a enum class
    }
}
