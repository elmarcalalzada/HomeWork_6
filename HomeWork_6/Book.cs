﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_6
{
    class Book : Product
    {
        public Book(string genre, int no, string name, double price, int count) : base(no, name, price, count)
        {
            this.Genre = genre;
        }


        public string Genre;

        public string getInfo()
        {
            return $"No-{this.No} Name-{this.Name} Genre-{this.Genre} Price-{this.Price} Count-{this.Count}";
        }

    }
}