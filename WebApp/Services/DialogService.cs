using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;

namespace WebApp.Services
{
    public class DialogService
    {
        private readonly ApplicationContext _applicationContext;
        

        public DialogService(ApplicationContext db)
        {
            _applicationContext = db;
        }
        public Dialog GetDialogById(int dialog_id)
        {
            return _applicationContext.DialogsModels.Select(Mappers.BuildDialog)
                .FirstOrDefault(d => d.Id == dialog_id);
        }

        public Dialog GetDialogByMatesId(int firstPersonId, int secondPersonId)
        {
            return _applicationContext.DialogsModels.Select(Mappers.BuildDialog)
                .FirstOrDefault(d => d.FirstPersonId == firstPersonId &&
                                     d.SecondPersonId == secondPersonId);
        }

        public bool IsDialogExist(int firstPersonId, int secondPersonId)
        {
            if (_applicationContext.DialogsModels.Select(Mappers.BuildDialog).First(d =>
                d.FirstPersonId == firstPersonId && d.SecondPersonId == secondPersonId) == null)
            {
                return false;
            }

            return true;
        }
        public List<Message> GetMessagesFromDialog(int id)
        {
            var m = _applicationContext.MessagesModels.
            Where(mes => mes.OwnerDialogId == id)?.
            Select(Mappers.BuildMessage).ToList();
            return m;
        }

        public void AddMessageToDialog(string text)
        {
            Message message = new Message();
            message.Text = text;
            message.SendingTime = DateTime.Now;
        }
    }
}