namespace DesignPatternsTutorial.src.OopPrinciples.Coupling
{
  public class Order
  {
    private readonly INotificationService notificationService;

    public Order(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }
    public void Placeorder()
    {
        notificationService.SendNotification("Order placed successfully.");
    }
  }
}