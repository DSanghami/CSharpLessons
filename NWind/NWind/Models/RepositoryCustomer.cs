using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace NWind.Models
{
    public class RepositoryCustomer
    {
        private readonly NorthwindContext _context;
        public int SelectedId { get; set; }
        public List<SelectListItem> CustomerSelectView { get; set; }

        public RepositoryCustomer() { }
        public RepositoryCustomer(NorthwindContext context)
        {
            _context = context;
        }
        //public Order FindOrderById(int id)
        //{
        //    var order = _context.Orders.Find(id);
        //    return order;
        //}
        
        public Customer FindCustomerById(string id)
        {
            var customer = _context.Customers.Find(id);
            return customer;

        }
        public List<Order> FindCustomerByCustomerID(string customerID)
        {
            return null;



        }
        //public List<OrderDetail> FindCustomerDetailByOrderId(int id)
        //{

        //    List<Customer> customersWithCustomerDetails = _context.Customers.Include(d => d.Customers).ToList();
        //    Order order = customersWithCustomerDetails.FirstOrDefault(x => x.CustomerId == id);
        //    return order.customerDetails.ToList();



        //}

       
        public List<string> GetAllCustomerId()
        {
            List<string> customerIds = new List<string>();
            foreach (var customer in _context.Customers)
            {
                customerIds.Add(customer.CustomerId);
            }
            return customerIds;
        }
        public List<Order> GetOrders(string id)
        {
            List<Customer> customers = _context.Customers.Include(o => o.Orders).ToList();
            Customer customer = customers.FirstOrDefault(x => x.CustomerId == id);



            return customer.Orders.ToList();



        }
        public List<Order> FindCustomersDetailbyOrders(string id)
        {
            //{
            //    Customer customer = _context.Customers.Find(id);
            //      return customer.Orders.ToList();



            //Customer customer = _context.Customers.Find(id);
            //// return order.OrderQries.ToList();
            //return customer.OrdersQries.ToString();



            //Order order = _context.Orders.Find(id);
            //return order.OrderDetails.ToList();



            List<Customer> ordersWithOrderDetails = _context.Customers.Include(d => d.Orders).ToList();
            Customer cust = ordersWithOrderDetails.FirstOrDefault(x => x.CustomerId == id);
            return cust.Orders.ToList();




        }

    }
}

