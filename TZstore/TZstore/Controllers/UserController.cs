using System;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using TZstore.Models;
using Service;
using Microsoft.AspNetCore.Http;


namespace TZstore.Controllers
{
   
    public class UserController : Controller
    {
        //构造方法
        private UserService _userService;
        public UserController(DataContext context)
        {
            _userService = new UserService(context);
        }

        //返回首页面一定要写否则无法进入
        public IActionResult Index()
        {
            return View();
        }
        //登录页面
        public IActionResult Login()
        {
            return View();
        }

        //判断登录的
        public IActionResult PLogin([FromBody] UserVO user) {
            //判断为空直接返回
            string userName = user.UserName;
            string password = user.UserPassword;
            if (userName == null || password == null || userName == "" || password == "")
            {
                return Json(new
                {
                    code = "fail",
                });
            }

            //如果已经存在登录
            string newUser = HttpContext.Session.GetString("UserName");
            if (newUser != null && newUser != "")
            {
                return Json(new
                {
                    code = "NowHave",
                });
            }


            //首先根据用户名查找到用户信息
            UserDO result = _userService.SearchName(userName);
            //再根据用户信息的密码来比较
            if (result != null && password == result.UserPassword)
            {
                //保存好登录的用户信息 顺便清空一下NewRegisterName
                HttpContext.Session.SetString("UserName", userName);
                HttpContext.Session.SetString("NewRegisterName", "");
                //string nameTEXT= HttpContext.Session.GetString("UserName");

                return Json(new
               {
                    code = "success",
                    data = result
                });
            }
            else
            {
                return Json(new
                {
                    code = "fail",
                });
            }
        }
       
        //添加新用户也就是注册
        [HttpPost]
        public IActionResult CreateUser([FromBody] UserVO User)
        {
            UserDO result = _userService.SearchName(User.UserName);
            //表示用户名没有重复可以注册
            if (result == null)
            {
                HttpContext.Session.SetString("NewRegisterName", User.UserName);
                //注册新的时候如果是登录状态的话就要将原来的设置
                HttpContext.Session.SetString("UserName","");
                var userDO = new UserDO
                {
                    UserName = User.UserName,
                    UserPassword = User.UserPassword,
                    PhoneNumber = User.PhoneNumber,
                    Address = User.Address
                };
                try
                {
                    var insertedProduct = _userService.Insert(userDO);
                    return Json(new
                    {
                        code = "success",
                        data = insertedProduct
                    });
                }
                catch (Exception ex)
                {
                    return Json(new
                    {
                        code = "fail",
                        message = ex.Message
                    });
                }
            }
            else //用户名重复了
            {
                return Json(new
                {
                    code = "repetition",
                });
            }

           
        }
        //跳转注册页面
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult RegisterSuccess()
        {
            string newRegisterName = HttpContext.Session.GetString("NewRegisterName");
            if (newRegisterName != null && newRegisterName != "") {
                return Json(new
                {
                    code = "success",
                    data = newRegisterName
                });
            }
            else{
                return Json(new
                {
                    code = "fail",
                });
            }
        }
        //登录退出操作
        public IActionResult LogonOut() {

           string Uname= HttpContext.Session.GetString("UserName");
            //如果初一已经登录的装态就将登陆信息重置
            if (Uname != null && Uname != "")
            {
                HttpContext.Session.SetString("UserName","");
                return Json(new
                {
                    code = "success",
                });
            }
            else
            {
                return Json(new
                {
                    code = "null",
                });
            }
        }
        //跳到个人信息修改EditUser
         public IActionResult EditUser()
        {
            return View();
        }
        public IActionResult LoginYes_or_No() {
            string Uname = HttpContext.Session.GetString("UserName");
            if (Uname == null || Uname == "")
            {
                return Json(new
                {
                    code = "NO",
                });
            }
            else
            {
                return Json(new
                {
                    code = "YES",
                });
            }
        }

        //加上[HttpPost]
        [HttpPost]
        public IActionResult UpdataUser([FromBody] UserEditVO user) {
            //UserEditVO user可以取得页面的上的新密码和电话还有地址 
            //拿到当前用户的名字
            string Uname = HttpContext.Session.GetString("UserName");
            //首先按名字查找到当前的用户
            UserDO NowUer = _userService.SearchName(Uname);
            //如果用户不存在则是空
            if (Uname == null || Uname == "")
            {
                return Json(new
                {
                    code = "fail",
                });
            }
            else {
                //如果旧密码和查出来的user的密码相同则进行修正
                if (NowUer.UserPassword == user.OldPassword)
                {

                    //每个不同的类的数据也不同的
                    NowUer.UserName = user.UserName;
                    NowUer.UserPassword = user.UserPassword;
                    NowUer.Address = user.Address;
                    NowUer.PhoneNumber = user.PhoneNumber;

                    _userService.Update(NowUer);

                    //利用之前的注册的方法
                    string UU = HttpContext.Session.GetString("UserName");
                    HttpContext.Session.SetString("NewRegisterName", UU);
                    //修改后重新登录所以要清空session
                    HttpContext.Session.SetString("UserName", "");
                    

                    return Json(new
                    {
                        code = "success",
                    });
                    
                }
                else {
                    return Json(new
                    {
                        code = "fail",
                    });
                }
            }
        }
        //根据已经登录的用户名查找
        public IActionResult SearchUserName() {
            string Uname = HttpContext.Session.GetString("UserName");
            //首先按名字查找到当前的用户
            UserDO NowUer = _userService.SearchName(Uname);
            return Json(new
            {
                data = NowUer,
            });
        }

        //判断用户是否登陆并且判断是不是管理员
        public IActionResult LoginAndAdmin() {
            //首先查看session有无记录
            string UserName = HttpContext.Session.GetString("UserName");

            if (UserName != null && UserName != "" && UserName == "admin")
            {
                return Json(new
                {
                    data = "UserName",
                    code = "success",
                });
            }
            else if (UserName != null && UserName != "" && UserName != "admin")
            {
                return Json(new
                {
                    data = "UserName",
                    code = "NoAdmin",
                });
            }
            else {
                return Json(new
                {
                    code = "NoLogin",
                });
            }
            
        }
        //跳转到购物车结算页面
        public IActionResult ShowCar(long id)
        {
            ViewBag.Id = id;
            return View();
        }

        //提交订单了
        public IActionResult UpdateOrder([FromBody] ProductVO product) 
        {
            try
            {
                if (product != null)
                {
                    //得到当前登录用户的信息
                    string userName = HttpContext.Session.GetString("UserName");



                    if (userName == "" || userName == null) {
                        return Json(new
                        {
                            code = "NoLogin",
                        });
                    }

                    if (userName == "admin") {
                        return Json(new
                        {
                            code = "isAdmin",
                        });
                    }
                    //设置订单初始状态
                    //首先得到当前用户的信息
                    UserDO nowuser = _userService.SearchName(userName);
                    string orderstate = "已下单";
                    string productName = product.ProductName;
                    int productid = Convert.ToInt32(product.Id);
                    int BuyNum = Convert.ToInt32(product.BuyNum);
                    int Inv = Convert.ToInt32(product.Inventory);
                    //如果库存小于购买数量
                    if (Inv < BuyNum) {
                        return Json(new
                        {
                            code = "Lack",
                        });
                    }
                    if (BuyNum == 0) {
                        return Json(new
                        {
                            code = "noBuyNum",
                        });
                    }
                    //获取当前时间
                    string time=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff");
                    //编制订单的编码
                    string ordernumber = productid.ToString()+ BuyNum.ToString()+DateTime.Now.ToString("yyyyMMddHHmmssffff");
                    var orderDO = new OrderDO
                    {
                        ProductId = productid,
                        OrderState = orderstate,
                        UserName = userName,
                        ProductName = productName,
                        Number = BuyNum,
                        TotalMoney = BuyNum * Convert.ToDouble(product.Price),
                        Ordertime =time,
                        OrderNumber = ordernumber,

                        Userphone = nowuser.PhoneNumber,
                        Useraddress = nowuser.Address,
                        UserId =nowuser.Id
                    };
                    //插入新的订单
                    _userService.InsertOrder(orderDO);
                    //提交成功后货物的库存也要减少
                    var productDO = new ProductDO
                    {
                        //每个不同的类的数据也不同的
                        Id = product.Id,
                        ProductName = product.ProductName,
                        ProductNumber = product.ProductNumber,
                        ProductType = product.ProductType,
                        //主要是改变数量的减少
                        Inventory = Convert.ToInt32(product.Inventory) - BuyNum,
                        Price = Convert.ToDouble(product.Price),
                        ImgUrl = product.ImgUrl
                    };
                    //减少数量
                    _userService.updataNamePro(productDO);
                }

                return Json(new
                {
                    code = "success",
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    code = "fail",
                    message = ex.Message
                });
            }
        }
        //跳转到前台订单页面
        public IActionResult Orderlist()
        {
            return View();
        }

        public IActionResult GetMyOders(string ord)
        {
            try
            {
                string UserName = HttpContext.Session.GetString("UserName");
                var result = _userService.GetMyOders(ord, UserName);
                return Json(new
                {
                    code = "success",
                    //传递到HTML页面
                    data = result
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    code = "fali",
                    message = ex.Message
                });
            }
        }

        public IActionResult GetAllOders() 
        {
            try
            {
                var result = _userService.GetAllOders();
                return Json(new
                {
                    code = "success",
                    //传递到HTML页面
                    data = result
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    code = "fali",
                    message = ex.Message
                });
            }
        }

       

    }
}

