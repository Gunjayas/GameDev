//this represents stuffs I want to store in my database
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev.Data.Model
{
    public class Company 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GenreType Genre { get; set; }//If I want to restrict the Genre's of company, have to make a enum class
    }
}
