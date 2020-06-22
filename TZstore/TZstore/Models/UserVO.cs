using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TZstore.Models
{
    public  class UserVO
    {
        public long Id { get; set; }

        //用户名称以及长度
        public string UserName { get; set; }

        //用户密码及长度
        public string UserPassword { get; set; }

        //用户号码以及长度
        public string PhoneNumber { get; set; }

        //地址以及长度
        public string Address { get; set; }
    }
}
