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
                .FirstOrDefault(m => m.Id == message_id);
        }

        public User GetOwnerById(int owner_id)
        {
            return _applicationContext.UserModels.Select(Mappers.BuildUser).FirstOrDefault(u => u.Id == owner_id);
        }

        public string GetSendingTime(int message_id)
        {
            DateTime time = _applicationContext.MessagesModels.Select(Mappers.BuildMessage)
                .FirstOrDefault(m => m.Id == message_id).SendingTime;
            string textTime = time.Hour.ToString() + ":";
            if (time.Minute < 10)
            {
                textTime += '0';
            }

            textTime += time.Minute.ToString();
            // + " ";
            //
            // textTime += time.Day.ToString() + ".";
            // textTime += time.Month.ToString() + ".";
            // textTime += time.Year.ToString();
            return textTime;
        }

        public string GetText(int message_id)
        {
            return _applicationContext.MessagesModels.Select(Mappers.BuildMessage)
                .FirstOrDefault(m => m.Id == message_id)?.Text;
        }

        public int GetOwnerDialogId(int message_id)
        {
            return _applicationContext.MessagesModels.Select(Mappers.BuildMessage)
                .FirstOrDefault(m => m.Id == message_id)?.OwnerDialogId ?? -1;
        }

        public int GetMessageId(Message m)
        {
            return _applicationContext.MessagesModels.Select(Mappers.BuildMessage)
                .FirstOrDefault(mes => mes.Id == m.Id)?.Id ?? -1;
        }
    }
}