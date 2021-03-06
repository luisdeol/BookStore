﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BookStore.Models
{
    public class Author
    {   
        public int AuthorId { get; set; }
        [Required, StringLength(50, ErrorMessage = "Name cannot contain more than 50 characters.")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
