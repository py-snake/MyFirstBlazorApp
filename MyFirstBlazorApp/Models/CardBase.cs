namespace MyFirstBlazorApp.Models
{
    public class CardBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Action OnButtonClick { get; set; }
    }
}
