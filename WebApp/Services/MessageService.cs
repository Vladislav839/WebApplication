using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;

namespace WebApp.Services
{
    public class MessageService
    {
        private readonly ApplicationContext _applicationContext;

        public MessageService(ApplicationContext db)
        {
            _applicationContext = db;
        }

        public List<Message> GetMessages()
        {
            return _applicationContext.MessagesModels.Select(Mappers.BuildMessage).ToList();
        }

        public Message GetMessageById(int message_id)
        {
            return _applicationContext.MessagesModels.Select(Mappers.BuildMessage)
                .FirstOrDefault(m => m.MessageId == message_id);
        }

        public User GetOwnerById(int owner_id)
        {
            return _applicationContext.UserModels.Select(Mappers.BuildUser).FirstOrDefault(u => u.Id == owner_id);
        }

        public DateTime? GetSendingTime(int message_id)
        {
            return _applicationContext.MessagesModels.Select(Mappers.BuildMessage)
                .FirstOrDefault(m => m.MessageId == message_id)?.SendingTime;
        }

        public string GetText(int message_id)
        {
            return _applicationContext.MessagesModels.Select(Mappers.BuildMessage)
                .FirstOrDefault(m => m.MessageId == message_id)?.Text;
        }

        public int GetOwnerDialogId(int message_id)
        {
            return _applicationContext.MessagesModels.Select(Mappers.BuildMessage)
                .FirstOrDefault(m => m.MessageId == message_id)?.OwnerDialogId ?? -1;
        }

        public int GetMessageId(Message m)
        {
            return _applicationContext.MessagesModels.Select(Mappers.BuildMessage)
                .FirstOrDefault(mes => mes.MessageId == m.MessageId)?.MessageId ?? -1;
        }
    }
}