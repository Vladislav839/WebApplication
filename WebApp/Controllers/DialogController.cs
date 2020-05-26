using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using WebApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class DialogController : Controller
    {
        private ApplicationContext _applicationContext;
        private DialogService _dialogService;
        private MessageService _messageService;
        private UserService _userService;

        public DialogController(ApplicationContext context)
        {
            _applicationContext = context;
            _dialogService = new DialogService(context);
            _messageService = new MessageService(context);
            _userService = new UserService(context);
        }
        
        [HttpGet]
        public List<Message> GetMessagesOfDialog(int dialog_id)
        {
            return _dialogService.GetMessagesFromDialog(dialog_id);
        }

        [HttpGet]
        public IActionResult Dialog(int Id)
        {
            int firstPersonId = new int();
            firstPersonId = _userService.FindByName(User.Identity.Name).Id;
            if (_applicationContext.DialogsModels.FirstOrDefault(d =>
                (d.FirstPersonId == firstPersonId && d.SecondPersonId == Id) ||
                (d.FirstPersonId == Id && d.SecondPersonId == firstPersonId)) != null)
            {
                return View(Mappers.BuildDialog(_applicationContext.DialogsModels.FirstOrDefault(d =>
                    (d.FirstPersonId == firstPersonId && d.SecondPersonId == Id) ||
                    (d.FirstPersonId == Id && d.SecondPersonId == firstPersonId))));
            }
            else
            {
                DialogModel dialogModel = new DialogModel()
                {
                    UsersDialogs = new List<UserDialog>(),
                    FirstPersonId = firstPersonId,
                    SecondPersonId = Id
                };
                _applicationContext.DialogsModels.Add(dialogModel);
                _applicationContext.SaveChanges();
                return View(Mappers.BuildDialog(dialogModel));
            }
        }
        
        // [HttpGet]
        // public async Task<IActionResult> Dialog(int dialogId)
        // {
        //     var dialog = await _applicationContext.DialogsModels.FirstOrDefaultAsync(d => d.Id == dialogId).ConfigureAwait(true);
        //     return View(Mappers.BuildDialog(dialog));
        // }
        [HttpPost]
        public Message SaveMessage(string text, int dialogId)
        {
            
            MessageModel messageModel = new MessageModel
            {
            Text = text,
            OwnerId = _applicationContext.UserModels.FirstOrDefault(um => um.NickName == User.Identity.Name) == null ? _applicationContext.UserModels.FirstOrDefault(um => um.Id == 1)?.Id ?? -1 : _applicationContext.UserModels.FirstOrDefault(um => um.NickName == User.Identity.Name)?.Id ?? -1,
            SendingTime = DateTime.Now,
            OwnerDialogId = dialogId
            };
            _applicationContext.MessagesModels.Add(messageModel);
            _applicationContext.SaveChanges();
            return Mappers.BuildMessage(messageModel);
        }
         
    }
}