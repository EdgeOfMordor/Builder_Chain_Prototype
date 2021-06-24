namespace ConsoleApp5.Chain
{
    public class News
    {
        public int Counter { get; set; }
        public Type type { get; set; }

        public string Text { get; set; }

        public News(Type type, string text)
        {
            this.type = type;
            Text = text;

        }
    }
}