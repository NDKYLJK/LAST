using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Service
{
    public class UserService
    {
        private readonly DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }

        //用于添加用户
        public UserDO Insert(UserDO user)
        {
            _context.Set<UserDO>().Add(user);
            _context.SaveChanges();

            return user;
        }

        //用于登录和主测的的查询
        public UserDO SearchName(string userName)
        {
            //这个首先根据用户名来查询
            var user = _context.Set<UserDO>()
             .FirstOrDefault(t => t.UserName == userName);
            return user;
        }

        public UserDO Update(UserDO user)
        {
            var UserExists = _context.Set<UserDO>().Any(t => t.Id == user.Id);

            if (!UserExists)
            {
                throw new Exception("没有找到指定的ID的记录");
            }

            _context.Set<UserDO>().Update(user);
            _context.SaveChanges();

            return user;
        }

        public OrderDO InsertOrder(OrderDO order) {
            _context.Set<OrderDO>().Add(order);
            _context.SaveChanges();

            return order;
        }
        public ProductDO updataNamePro(ProductDO product) {

            var ProductExists = _context.Set<ProductDO>().Any(t => t.Id == product.Id);

            if (!ProductExists)
            {
                throw new Exception("没有找到指定的ID的记录");
            }

            _context.Set<ProductDO>().Update(product);
            _context.SaveChanges();

            return product;
        }

        public IEnumerable<OrderDO> GetMyOders(String order,string UserName)
        {
            //根据订单收货人姓名查找
            var result = _context.Set<OrderDO>().Where(t => t.UserName == UserName);

            return result; 
        }
        //查找到所有的订单
        public IEnumerable<OrderDO> GetAllOders()
        {
            //查找所有
            var result = _context.Set<OrderDO>().ToList();

            return result;
        }

    }
}
