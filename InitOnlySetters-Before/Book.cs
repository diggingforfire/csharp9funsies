namespace InitOnlySetters_Before
{
	public class Book
	{
		public Book()
		{
			Author = new Author { FirstName = "Stephen", LastName = "King" };
		}

		public string Title { get; set; }
		public Author Author { get; set; }

		public string Genre { get; set; }
	}

	public class Author
	{
		// Property needs to be mutable for object initializer to work
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public void Mutate()
		{
			FirstName = "Steven";
		}
	}
}
