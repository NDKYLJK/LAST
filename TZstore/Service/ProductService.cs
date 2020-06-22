using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class ProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }
        //
        public ProductDO Insert(ProductDO product)
        {
            _context.Set<ProductDO>().Add(product);
            _context.SaveChanges();

            return product;
        }

        //返回所有产品的GetAll()方法
        public IEnumerable<ProductDO> GetAll(String order)
        {

            if (order == "asc")
            {
                return _context.Set<ProductDO>().OrderBy(t => t.Price);
            }
            return _context.Set<ProductDO>().OrderByDescending(t => t.Price);
        }

        //用于产品分类刷选
        public IEnumerable<ProductDO> GetByCategory(string category)
        {
            var result = _context.Set<ProductDO>().Where(t => t.ProductType == category);

            return result;
        }

        //修改数据
        public ProductDO Update(ProductDO product)
        {
            var ProductExists = _context.Set<ProductDO>().Any(t => t.Id == product.Id);

            if (!ProductExists)
            {
                throw new Exception("没有找到指定的ID的记录");
            }

            _context.Set<ProductDO>().Update(product);
            _context.SaveChanges();

            return product;
        }

        //删除记录
        public void Delete(long id)
        {
            var product = _context.Set<ProductDO>().FirstOrDefault(t => t.Id == id);

            if (product == null)
                throw new Exception("没有找到指定的ID的产品");
            _context.Set<ProductDO>().Remove(product);
            _context.SaveChanges();
        }



        //通过id查询
        public ProductDO GetByID(long id)
        {
           
            var product = _context.Set<ProductDO>()
             .FirstOrDefault(t => t.Id == id);
            return product;
        }

        //用于筛选出产品名称含关键字的记录
        public IEnumerable<ProductDO> GetByKeyword(string keyword)
        {
            var result = _context.Set<ProductDO>().Where(t => t.ProductName.Contains(keyword));
            return result;
        }

        public OrderDO getOrderById(long id)
        {

            var order = _context.Set<OrderDO>()
             .FirstOrDefault(t => t.Id == id);

            return order;
        }
        public OrderDO UpdateOrder(OrderDO order)
        {
            var OrdertExists = _context.Set<OrderDO>().Any(t => t.Id == order.Id);

            if (!OrdertExists)
            {
                throw new Exception("没有找到指定的ID的记录");
            }

            _context.Set<OrderDO>().Update(order);
            _context.SaveChanges();

            return order;
        }

    }
}
