using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.Models
{
    [Table("Orders")]
    public class OrderDO
    {
        //设定主码 （这里的属性都是表的信息设置）
        [Key] public long Id { get; set; }

        //订单编号以及长度
        [StringLength(50)] public string OrderNumber { get; set; }

        //订单状态以及长度
        [StringLength(50)] public string OrderState { get; set; }

        //菜品id以及长度
        [StringLength(50)] public long ProductId { get; set; }

        //菜品名称以及长度
        [StringLength(50)] public string ProductName { get; set; }

        //数量
         public long Number { get; set; }

        //用户id以及长度
        [StringLength(50)] public long UserId { get; set; }
        //订单的实时状态
        [StringLength(50)] public string Ordertime { get; set; }

        [StringLength(50)] public string UserName { get; set; }
        //单金额
        [StringLength(50)] public double TotalMoney { get; set; }

        //单
        [StringLength(50)] public string Userphone { get; set; }
        //单
        [StringLength(50)] public string Useraddress { get; set; }
    }
}
