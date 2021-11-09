using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1108.OOP
{
    class StudentiRepository : IRepository
    {
        bool IRepository.Add()
        {
            //inserisco il tot dato nella lista
            return true;
        }

        bool IRepository.Delete()
        {
            throw new NotImplementedException();
        }

        bool IRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        bool IRepository.Update()
        {
            throw new NotImplementedException();
        }
    }
}
