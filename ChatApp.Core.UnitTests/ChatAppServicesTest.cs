using ChatApp.Core.Services;

namespace ChatApp.Core.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ChatAppService__Invoke__WithHappyDataGetResponseBack()
        {
            IChatServicesInfra chatServicesInfra = null;
            // arrange
            var chatService = new ChatServices(chatServicesInfra);
            var chatCommand = new ChatCommand();
            chatCommand.Text = "Hello";

            // act
            ChatResponse response = chatService.Invoke(chatCommand);

            // assert
            Assert.IsTrue(response != null);
        }
    }
}