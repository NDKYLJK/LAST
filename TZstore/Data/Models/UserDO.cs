using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.Models
{
    [Table("User")]
    public class UserDO
    {
        //设定主码 （这里的属性都是表的信息设置）
        [Key] public long Id { get; set; }

        //用户名称以及长度
        [StringLength(50)] public string UserName { get; set; }

        //用户密码及长度
        [StringLength(50)] public string UserPassword { get; set; }

        //用户号码以及长度
        [StringLength(50)] public string PhoneNumber { get; set; }

        //地址以及长度
        [StringLength(300)] public string Address { get; set; }
    }
}
