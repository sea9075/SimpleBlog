using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleBlog.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "請輸入分類名稱")]
        [Column(TypeName = "nvarchar(20)")]
        [DisplayName("分類名稱")]
        [StringLength(20)]
        [RegularExpression(@"^[a-zA-Z0-9\u4e00-\u9fa5]{1,20}$", ErrorMessage = "分類名稱只能包含中文、英文和數字")]
        public string Name { get; set; }
    }
}
