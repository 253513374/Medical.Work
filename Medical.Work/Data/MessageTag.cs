using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;

namespace Medical.Work.Data
{
    public class MessageTag
    {
        [Inject]
        public MessageService messageService { get; set; }

        public void ShowColorMessage(Color color, string content, Message message)
        {
            //message.SetPlacement(Placement.Top);
            //Messageservice?.Show(new MessageOption()
            //{
            //    Host = message,
            //    Content = content,
            //    Icon = "fa fa-info-circle",
            //    Color = color
            //});
            message.SetPlacement(Placement.Top);
            messageService?.Show(new MessageOption()
            {
                Content = content,
                Icon = "fa fa-info-circle",
                Color = color,
                ShowBar = true,
                ShowDismiss = true,
            }, message);
        }
    }
}