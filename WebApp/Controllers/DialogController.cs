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

        public DialogController(ApplicationContext context)
        {
            _applicationContext = context;
            _dialogService = new DialogService(context);
            _messageService = new MessageService(context);
        }
        
        [HttpGet]
        public List<Message> GetMessagesOfDialog(int dialog_id)
        {
            return _dialogService.GetMessagesFromDialog(dialog_id);
        }

        [HttpGet]
        public IActionResult Dialog()
        {
            return View();
        }

        [HttpPost]
        public void AddMessage(string text)
        {
            
        }
         
    }
}