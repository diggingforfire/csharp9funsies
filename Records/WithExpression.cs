namespace Records
{
    public class WithExpression
    {
        public void Method()
        {
            Book one = new()
            {
                Title = "Fahrenheit 451",
                Author = "Ray Bradbury"
            };

            Book two = one with { Title = "Fahrenheit 452" };
        }
    }

    public record Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
    }
}
