using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Task2.Models
{
    public class NormalizeViewModel
    {
       
        public string InputText { get; set; } = string.Empty;

        [BindNever]
        public string OutputText { get; set; } = string.Empty;
    }
}
