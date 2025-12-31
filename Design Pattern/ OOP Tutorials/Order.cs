using System;

namespace OOP_Tutorials;

public class Order
{
    private readonly INotificationService notificationService;

    public Order(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }
    public void PlaceOrder()
    {
        // Place order logic
        notificationService.SendNotification("Order was successfully placesd");
    }
}

// Order class is tightly/ highly coupled to the EmailSender class. Since it directly creates an instance of the EmailSender
// So a notification interface was made to abstract it.
