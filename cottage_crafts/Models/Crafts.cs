using System.ComponentModel.DataAnnotations;

namespace cottage_crafts.Models
{
    public class Crafts
    {
        [Key]
        public int cid { get; set; }
        [Required(ErrorMessage ="Please enter product's name")]
        [Display(Name ="Product Name:")]
        public string cname { get; set; }
        [Required(ErrorMessage = "Please enter product's price")]
        [Display(Name = "Product Price:")]
        public int cprice { get; set; }
        [Required(ErrorMessage = "Please enter product's description")]
        [Display(Name = "Product Description:")]
        public string cdesc { get; set; }
        [Required(ErrorMessage = "Please enter product's Image URL")]
        [Display(Name = "Product Image URL:")]
        public string cimg { get; set; }
        [Required(ErrorMessage = "Please enter product's category")]
        [Display(Name = "Product Category:")]
        public string ccategory { get; set; }
    }
}
