using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class ReaennModel
    {
        private int value;
        [Required(ErrorMessage = "Please enter a Name.")]
        public string name { get; set; }
        [Required(ErrorMessage = "Please enter a Number.")]
        public int number { get; set; }

    }
}
