using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data
{
    public class MessageTag
    {

        [Inject]
        public MessageService? MessageService { get; set; }

        public  void ShowColorMessage(Color color, string content,  Message message)
        {
            message.SetPlacement(Placement.Top);
            MessageService?.Show(new MessageOption()
            {
                Host = message,
                Content = content,
                Icon = "fa fa-info-circle",
                Color = color
            });
        }
    }
}
