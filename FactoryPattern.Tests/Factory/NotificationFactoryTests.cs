using FactoryPattern.Client.Factory;
using FactoryPattern.Core.Enums;
using FactoryPattern.Services;


namespace FactoryPattern.Tests.Factory;

public class NotificationFactoryTests
{
    [Fact]
    public void Factory_ReturnsEmailNotificationService()
    {
        // Act  
        var service = NotificationFactory.Create(NotificationType.Email.ToString());

        // Assert  
        Assert.IsType<EmailNotificationService>(service);
    }

    [Fact]
    public void Factory_ReturnsSmsNotificationService()
    {
        var service = NotificationFactory.Create(NotificationType.Sms.ToString());
        Assert.IsType<SmsNotificationService>(service);
    }

    [Fact]
    public void Factory_ThrowsOnUnknownType()
    {
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() =>
            NotificationFactory.Create(((NotificationType)999).ToString()));

        Assert.Contains("Unknown type", ex.Message);
    }
}
