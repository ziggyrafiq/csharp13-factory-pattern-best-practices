using FactoryPattern.Core.Enums;
using FactoryPattern.Core.Interfaces;
using FactoryPattern.Services;

namespace FactoryPattern.Client.Factory;


public static class NotificationFactory
{
    //public static INotificationService Create(string type) => type.ToLower() switch
    //{
    //    "email" => new EmailNotificationService(),
    //    "sms" => new SmsNotificationService(),
    //    _ => throw new ArgumentOutOfRangeException(nameof(type), $"Unknown type: {type}")
    //};

    public static INotificationService Create(NotificationType type) =>
    type switch
    {
        NotificationType.Email => new EmailNotificationService(),
        NotificationType.Sms => new SmsNotificationService(),
        _ => throw new ArgumentOutOfRangeException(nameof(type), $"Unknown type: {type}")
    };


}
