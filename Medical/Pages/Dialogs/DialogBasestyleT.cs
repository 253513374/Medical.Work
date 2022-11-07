using System.ComponentModel.DataAnnotations;

namespace Medical.Pages.Dialogs
{
    public class DialogBasestyleT
    {
        [Required(ErrorMessage = "ID必须填写")]
        public string ID { set; get; }
    }
}