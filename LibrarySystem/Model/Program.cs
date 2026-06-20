
using System.ComponentModel.DataAnnotations;

public class LibraryModel {

    [MaxLength(70)]
    [Required]
    public string Book {get; private set;} = string.Empty;

    [Required]
    public string Author {get; private set;} = string.Empty;

    [MaxLength(30)]
    [Required]
    public string User {get; set;} = string.Empty;

    public bool BorrowState {get; private set;}

    public static int BookId { get; set;}

    public LibraryModel (string book, string author)
    {
        Book = book;
        Author = author;
        BookId += 1;
    }

    


}


