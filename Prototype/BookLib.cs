using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class BookLib : ICloneable
    {
        private string _libName;
        private List<book> _libBooks;
        public void SetLibraryName(string val)
        {
            _libName = val;
        }
        public List<book> GetBooks()
        {
            return GetBooks();
        }
        public void LoadBooks()
        {
            for (int i = 0; i < 10; i++)
            {
                book b = new book();
                b.bname = "book " + i;
                b.bookID = i;
                GetBooks().Add(b);
            }
        }
        public override string ToString()
        {
            return "bookLib [libName= " + this._libName + ", books ="+ GetBooks()+"]";
        }

        public BookLib Clone()
        {
            throw new NotImplementedException();
        }
    }

    class book
    {
        public string bname;
        public int bookID;
    }
}
