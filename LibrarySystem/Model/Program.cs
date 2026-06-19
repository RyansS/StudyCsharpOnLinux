
using System.ComponentModel.DataAnnotations;

public class LibraryModel {
    
    [MaxLength(70)]
    [Required]
    public string Book {get; private set;}

    [Required]
    public string Author {get; private set;}

    [MaxLength(30)]
    [Required]
    public string User {get; set;}

    public bool BorrowState {get; private set;}


}


