using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.Models
{
    [Table("Products")]
    public class ProductDO
    {
        //设定主码 （这里的属性都是表的信息设置）
        [Key] public long Id { get; set; }

        //产品编号以及长度
        [StringLength(100)] public string ProductNumber { get; set; }

        //产品名称以及长度
        [StringLength(100)] public string ProductName { get; set; }

        //产品类型以及长度
        [StringLength(100)] public string ProductType { get; set; }

        //产品价格以及长度
        [StringLength(100)] public double Price { get; set; }
        //产品的库存数量
        [StringLength(100)] public int Inventory { get; set; }
        //产品图片地址以及长度
        [StringLength(300)] public string ImgUrl { get; set; }

        //判断是否计入购物车
        [StringLength(300)] public string ShowCarYN { get; set; }
    }
}
