using Accademy.Entities;
using DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.DataManager
{
    public interface IDataManager
    {
        bool LoginIsOK(string username, string password);
        bool IsAnOwner(string username);
        DataOperationResult CreatenewCliente(Cliente newCliente);
        ContoCorrente GetContoCorrenteByUsername(string username);
    }
}
