using Accademy.Entities;
using DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.DataManager
{
    public class SQLDataManager: IDataManager
    {

        public ContoCorrente GetContoCorrenteByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public bool IsAnOwner(string username)
        {
            throw new NotImplementedException();
        }

        public bool LoginIsOK(string username, string password)
        {
            throw new NotImplementedException();
        }

        

        DataOperationResult IDataManager.CreatenewCliente(Cliente newCliente)
        {
            throw new NotImplementedException();
        }
    }
}
