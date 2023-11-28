using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_of_books
{
    internal class Book
    {
        public string name;
        public string writer;
        public string genre;
        public string date;
        public int sum;
        public int inStock;
        public string path;

        public Book(string name, string writer, string genre, string date, string sum,string inStock, string path) 
        {
            this.name = name;
            this.writer = writer;
            this.genre = genre;
            this.date = date;
            this.sum = int.Parse(sum);
            this.inStock = int.Parse (inStock);
            this.path = path;
        }
    }
}
