using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationsPNotify.ViewComponents
{
    public class AdminMensagens : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var temp = TempData.FirstOrDefault();          
            
            
            await Task.FromResult<object>(null);
            return View(temp);
        }

        

       

        public class TempMsg
        {
            public bool MsgExiste { get; set; }
            public string MsgTexto { get; set; }
            public string MsgTipo { get; set; }            
        }
    }
}
