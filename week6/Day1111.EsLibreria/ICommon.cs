using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1111.EsLibreria
{
     public interface ICommon<T>
    {
        public List<T> GetBooks();

        public T FindBookByTitle(string title);

        public T FindBookByISBN(int code);

        public void AddBook(T item);
    }
}
