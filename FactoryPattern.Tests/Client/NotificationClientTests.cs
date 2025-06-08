using FactoryPattern.Core.Interfaces;
 
using FactoryPattern.Client.Factory;
using Moq;

namespace FactoryPattern.Tests.Client;

public class NotificationClientTests
{
    [Fact]
    public void Notify_CallsSendMethod()
    {
        // Arrange  
        var mockService = new Mock<INotificationService>();
        var client = mockService.Object;  

        // Act  
        client.Send("Hello World!");

        // Assert  
        mockService.Verify(s => s.Send("Hello World!"), Times.Once);
    }
}
