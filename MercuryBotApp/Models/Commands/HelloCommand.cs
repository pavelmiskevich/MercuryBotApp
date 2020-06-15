using Telegram.Bot;
using Telegram.Bot.Types;

namespace MercuryBotApp.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "привет";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //TODO: Bot logic

            //await client.SendTextMessageAsync(chatId, "Hello2", replyToMessageId: messageId);

            await client.SendTextMessageAsync(chatId, "Hi " + message.MessageId);
        }
    }
}