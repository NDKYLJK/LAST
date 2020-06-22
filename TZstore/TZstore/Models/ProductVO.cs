using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TZstore.Models
{
    public class ProductVO
    {
        public long Id { get; set; }

        //产品编号以及长度
        public string ProductNumber { get; set; }

        //产品名称以及长度
        public string ProductName { get; set; }

        //产品类型以及长度
        public string ProductType { get; set; }

        //产品价格以及长度
        public string Price { get; set; }
        //产品的库存数量
        public string Inventory { get; set; }
        //产品图片地址以及长度
        public string ImgUrl { get; set; }
        //产品判断是否在购物车里
        public string ShowCarYN { get; set; }

        public string BuyNum { get; set; }
    }
}
