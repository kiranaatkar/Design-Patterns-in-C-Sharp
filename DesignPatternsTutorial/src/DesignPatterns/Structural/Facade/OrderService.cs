namespace DesignPatternsTutorial.src.DesignPatterns.Structural.Facade
{
    public class OrderService
    {
        public void Order(OrderRequest orderReq)
        {
            var auth = new Authenticate();
            var inventory = new Inventory();
            foreach(var id in orderReq.ItemIds)
            {
                inventory.CheckInventory(id);
            }

            var payment = new Payment(orderReq.Name, orderReq.CardNumber, orderReq.Amount);
            payment.Pay();

            var orderFufillment = new OrderFufillment(inventory);
            orderFufillment.Fufill(orderReq.Name, orderReq.Address, orderReq.ItemIds);
        }
    }
}