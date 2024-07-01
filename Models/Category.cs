using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWebApp.Models
{
	public class Category
	{
        [Key]// if name is Id  model+Id=CategoryId then not required
        public int Id { get; set; }
        [Required]//not Null
        [MaxLength(200)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage = "The field Display Order must be between 1 and 100.")]
        public int DisplayOrder { get; set; }   


    }
}
