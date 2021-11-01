﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_6
{
    class Library
    {
        public Book[] Books;

        public void addBook(Book book)
        {
            var temp = this.Books;
            Book[] nBooks = new Book[temp.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                nBooks[i] = temp[i];
            }
            nBooks[nBooks.Length - 1] = book;
            this.Books = nBooks;
        }

        public Book[] GetFilterBook(Book[] books, string genre)
        {
            int counter = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if (genre == books[i].Genre)
                {
                    counter++;
                }
            }
            Book[] FilterGenrebook = new Book[counter];
            int index = 0;


            for (int i = 0; i < books.Length; i++)
            {
                if (genre == books[i].Genre)
                {
                    FilterGenrebook[index] = books[i];
                    index++;
                }
            }
            return FilterGenrebook;
        }

        public Book[] GetFilteredBook(Book[] books, double minPrice = 0, double maxPrice = double.MaxValue)
        {
            int count = 0;

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Price >= minPrice && books[i].Price <= maxPrice)
                {
                    count++;
                }

            }
            Book[] filterBook = new Book[count];
            int index = 0;

            for (int i = 0; i < books.Length; i++)
            {

                if (books[i].Price >= minPrice && books[i].Price <= maxPrice)
                {
                    filterBook[index] = books[i];
                    index++;
                }
            }
            return filterBook;
        }
    }
}