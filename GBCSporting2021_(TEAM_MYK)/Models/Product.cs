using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace GBCSporting2021__TEAM_MYK_.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "*Please enter a valid code.")]
        public string Code { get; set; }
        [Required(ErrorMessage = "*Please enter a valid name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*Please enter a valid price.")]
        public string Price { get; set; }
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:yyyy/MM/dd}")]
        public DateTime? ReleaseDate { get; set; }
        public string Slug => Name?.Replace(' ', '-').ToLower();
    }
}
