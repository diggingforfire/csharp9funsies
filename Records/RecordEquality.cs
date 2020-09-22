namespace Records
{
    class RecordEquality
    {
        public bool Equal()
        {
            Movie one = new() { Title = "Jurassic Park", Director = "Spielberg" };
            Movie two = new() { Title = "Jurassic Park", Director = "Spielberg" };

            Film uno = new() { Title = "Jurassic Park", Director = "Spielberg" };
            Film dos = new() { Title = "Jurassic Park", Director = "Spielberg" };

            return one == two;
        }
    }

    // init only auto properties
    public record Movie { public string Title; public string Director; }

    public class Film
    {
        public string Title { get; set; }
        public string Director { get; set; }
    }
}
