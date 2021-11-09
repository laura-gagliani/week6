using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1108.OOP
{
    public interface IRepository //tipo uno storage. bene metterla public l'interfaccia
    {
        //qui dichiarerò una serie di metodi, una serie di "gusci" di metodi.
        // una classe che implementa questa interfaccia avrà questi metodi
            //che vuol dire che una classe implementa un'interfaccia? vuol dire che USA tutti i metodi che essa descrive
            //e che ne implementa le procedure! proprio perchè nell'interfaccia ci sono solo le firme

        public bool Add();

        public bool Delete();

        public bool GetAll();

        public bool Update();

        //la stessa interfaccia può essere implementata da più classi! es. una classe DocentiRepository
        // i metodi da implementare saranno sempre questi, ma magari fatti sui docenti (con diversa implementazione)
        //potremo anche fare una classe COLLEGATA AD UN VERO DB che implementa questi stessi metodi dell'interfaccia
    }
}
