namespace InitOnlySetters_After
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
		public string FirstName { get; init; }
		public string LastName { get; init; }

		public void Mutate()
		{
			// Property is immutable, can't assign a value

			//FirstName = "Steven";
		}
	}
}
