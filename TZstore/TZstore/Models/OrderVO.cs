using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TZstore.Models
{
    public class OrderVO
    {
        public long Id { get; set; }

        //订单编号以及长度
        public string OrderNumber { get; set; }

        //订单状态以及长度
        public string OrderState { get; set; }

        //菜品id以及长度
        public long ProductId { get; set; }

        //菜品名称以及长度
        public string ProductName { get; set; }

        //数量
        public long Number { get; set; }

        //用户id以及长度
        public long UserId { get; set; }
        //订单的实时状态
        public string Ordertime { get; set; }

        public string UserName { get; set; }
        //单金额
        public double TotalMoney { get; set; }

        //联系电话
        public string Userphone { get; set; }
        //配送地址
        public string Useraddress { get; set; }
    }
}
