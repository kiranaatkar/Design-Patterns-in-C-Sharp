using DesignPatternsTutorial.src.DesignPatterns.Creational.Factory.MVCFramework;

namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Factory
{
    public class OrdersController : Controller
    { 
        public void ListOrders()
        {
            // simulate fetching orders from db
            var orders = new Dictionary<string, object>
            {
                {"socks", "£5"},
                {"shoes", "£10"},
                {"pants", "£15"}
            };

            Render("orders.php", orders);
        }

        public void GetOrder(int id)
        {
            // simulate fetching order from db
            var order = new Dictionary<string, object>
            {
                {"socks", "£5"}
            };

            Render("order.php", order);
        }
    }
}