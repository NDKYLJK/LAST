using System;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using TZstore.Models;
using Service;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace TZstore.Controllers
{
    public class ProductController : Controller
    {
        private ProductService _productService;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ProductController(DataContext context, IHostingEnvironment hostingEnvironment)
        {
            _productService = new ProductService(context);
            _hostingEnvironment = hostingEnvironment;
        }


        //返回首页面
        public IActionResult Index()
        {
            return View();
        }

        //调到添加页面
        public IActionResult Create()
        {
            return View();
        }

        //返回所有的数据到页面上
        public IActionResult GetAll(string order)
        {
            //测试
           // string nameTEXT = HttpContext.Session.GetString("UserName");
            try
            {
                var result = _productService.GetAll(order);

                return Json(new
                {
                    code = "success",
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


        

        //添加新产品
        [HttpPost]
        public IActionResult Create([FromBody] ProductVO product)
        {
            var productDO = new ProductDO
            {
                ProductNumber = product.ProductNumber,
                ProductName = product.ProductName,
                ProductType = product.ProductType,
                Inventory =Convert.ToInt32(product.Inventory),
                Price = Convert.ToDouble(product.Price),
                ImgUrl = product.ImgUrl
            };

            try
            {
                var insertedProduct = _productService.Insert(productDO);

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


        //上传图片以及保存路径等
        [HttpPost]
        public IActionResult UploadImage(IFormFile file)
        {
            //上传文件的相对路径
            var uploadDir = "upload";
            //上传文件的扩展名
            var fileExtension = Path.GetExtension(file.FileName);
            //使用Guid类生成唯一一个ID作为上传后的文件名
            var targetFileName = $"{Guid.NewGuid()}{fileExtension}";
            //web应用程序（项目中的wwwroot文件夹下）的upload子文件夹在磁盘上的绝对路径
            var targetDir = Path.Combine(_hostingEnvironment.WebRootPath, uploadDir);
            var targetFilePath = Path.Combine(targetDir, targetFileName);

            try
            {
                //如果放置图片的位置不存在则创建文件夹
                if (!Directory.Exists(targetDir))
                {
                    Directory.CreateDirectory(targetDir);
                }
                //将上传的文件复制到指定位置
                using (var fs = new FileStream(targetFilePath, FileMode.Create))
                {
                    file.CopyTo(fs);
                }

                return Json(new
                {
                    code = "success",
                    data = targetFileName
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    code = "fail",
                    data = targetFileName
                });
            }
        }
        //对应的table展示页面
        public IActionResult Table()
        {
            return View();
        }

        //用于index的分类排序筛选
        public IActionResult GetProductsByCategory(string category)
        {
            try
            {
                var result = _productService.GetByCategory(category);

                return Json(new
                {
                    code = "success",
                    data = result
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

        //这是获取id
        public IActionResult GetProductByID(long id)
        {
            try
            {
                var product = _productService.GetByID(id);
                return Json(new
                {
                    code = "success",
                    data = product
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
        //调到修改数据的页面
        public IActionResult Edit(long id) {
            ViewBag.Id = id;

            return View();
        }

        //修改数据
        [HttpPost]
        public IActionResult Update([FromBody] ProductVO product)
        {
            try
            {
                if (product != null)
                {
                    var productDO = new ProductDO
                    {
                        //每个不同的类的数据也不同的
                        Id = product.Id,
                        ProductName = product.ProductName,
                        ProductNumber = product.ProductNumber,
                        ProductType = product.ProductType,
                        Inventory =Convert.ToInt32(product.Inventory),
                        Price = Convert.ToDouble(product.Price),
                        ImgUrl = product.ImgUrl
                    };
                    _productService.Update(productDO);
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
        //修改订单
        [HttpPost]
        public IActionResult UpdateOrder([FromBody] OrderVO order)
        {
            try
            {
                if (order != null)
                {
                    var orderDO = new OrderDO
                    {
                        //每个不同的类的数据也不同的
                        Id = order.Id,
                        OrderNumber = order.OrderNumber,
                        OrderState = order.OrderState,
                        Ordertime = order.Ordertime,
                        ProductId = order.ProductId,
                        ProductName = order.ProductName,
                        Number = order.Number,
                        TotalMoney = order.TotalMoney,
                        Useraddress = order.Useraddress,
                        UserId = order.UserId,
                        UserName = order.UserName,
                        Userphone = order.Userphone

                    };
                    _productService.UpdateOrder(orderDO);
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
        //删除的action
        // [HttpPost]不可以用
        public IActionResult Delete(long id)
        {
            try
            {
                _productService.Delete(id);
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
        //处理客户端发送的用于筛选记录的请求
        //用于筛选
        public IActionResult GetProductsByKeyword(string keyword)
        {
            try
            {
                //从Service哪里获取成功
                var result = _productService.GetByKeyword(keyword);
                
                return Json(new
                {
                    code = "success",
                    data = result
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
        //调到后台订单表的管理
        public IActionResult OrderTable()
        {
            return View();
        }

        public IActionResult EditOrder(long id)
        {
            //记录下该条订单的id
            ViewBag.Id = id;
            return View();
        }

        public IActionResult getOrderById(long id)
        {
            try
            {
                var Order = _productService.getOrderById(id);
                return Json(new
                {
                    code = "success",
                    data = Order
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

        
    }
}