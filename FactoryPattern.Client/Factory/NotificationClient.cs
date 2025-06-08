using FactoryPattern.Core.Enums;
using FactoryPattern.Core.Interfaces;

namespace FactoryPattern.Client.Factory;

public class NotificationClient(NotificationType type)
{
    //private readonly INotificationService _service;

    //public NotificationClient(NotificationType type)
    //{
    //    _service = NotificationFactory.Create(type.ToString()); 
    //}

    //public void Notify(string message) => _service.Send(message);

    private readonly INotificationService _service =
    NotificationFactory.Create(type.ToString());

    public void Notify(string message) => _service.Send(message);

}
