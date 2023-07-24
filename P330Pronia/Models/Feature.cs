using P330Pronia.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace P330Pronia.Models
{

    public class Feature: BaseEntity
    {
        public string Image { get; set; }
        [Required, MaxLength(100)]
        public string Title { get; set; }
        [Required, MaxLength(255)]

        public string Description { get; set; }
    }
}
