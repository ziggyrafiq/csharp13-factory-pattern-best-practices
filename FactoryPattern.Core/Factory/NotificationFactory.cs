using FactoryPattern.Core.Interfaces;
using FactoryPattern.Services;

namespace FactoryPattern.Core.Factory;


public static class NotificationFactory
{
    public static INotificationService Create(string type) => type.ToLower() switch
    {
        "email" => new EmailNotificationService(),
        "sms" => new SmsNotificationService(),
        _ => throw new ArgumentException($"Notification type '{type}' is not supported.", nameof(type))
    };
}
