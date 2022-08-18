using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkunmusPirinc.Entities.Concretes
{
    [Table("tblProductCategory")]
    public class ProductCategory
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
        public int? MainCategoryID { get; set; } = null;
        public string CategoryImage { get; set; } = "/Uploads/Images/placeholder.png";
    }
}
