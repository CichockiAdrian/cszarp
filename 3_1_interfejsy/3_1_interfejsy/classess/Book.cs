using System;
namespace _3_1_interfejsy.classess
{
	internal class Book : IComparable<Book>
	{
        public string Title { get; set; }
        public string Author { get; set; }
        public ushort YearOfPublicatin { get; set; }
        public double Price { get; set; }

        public Book(string title, string author, ushort yearOfPublication, double price)
        {
            Title = title;
            Author = author;
            YearOfPublicatin = yearOfPublication;
            Price = price;

        }

        public int CompareTo(Book other)
        {
            if (this == null) return 1;
            return Price.CompareTo(other.Price);
            //return Author.CompareTo(other.Author);
        }


        public override string ToString()
        {
            return $"{Title}, {Author}, {YearOfPublicatin}, {Price}zł";
        }

    }
}

