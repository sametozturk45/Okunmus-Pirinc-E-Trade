using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkunmusPirinc.Entities.Concretes
{
    [Table("tblProduct")]
    public class Product
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public string ProductExtraDesc { get; set; } = "Çobanın masaya doğru adresini telefonu adresini masaya doğru gördüm kapının kulu orta camisi. Anlamsız sandalye gülüyorum balıkhaneye koşuyorlar patlıcan de yazın kalemi domates. Işık dağılımı ekşili çorba türemiş sıfat hesap makinesi türemiş sıfat salladı.";
        public string ProductImage { get; set; } = "/Uploads/Images/placeholder.png";
        public float ProductPrice { get; set; }
        public int DiscountPercent { get; set; } = 0;
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public ProductCategory Category { get; set; }
    }
}
