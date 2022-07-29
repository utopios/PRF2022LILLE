using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpListCompteBancaireClassAdoNET.Classes;
using TpListCompteBancaireClassAdoNET.Tools;

namespace TpListCompteBancaireClassAdoNET.DAO
{
    internal class ClientDAO : BaseDAO<Client>
    {
        public override int Create(Client element)
        {
            _connection = Connection.New;
            _request = "";
            return 1;
        }

        public override int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override int Delete(Client element)
        {
            throw new NotImplementedException();
        }

        public override Client Find(int index)
        {
            throw new NotImplementedException();
        }

        public override List<Client> Find(Func<Client, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<Client> FindAll()
        {
            throw new NotImplementedException();
        }

        public override int Update(Client element)
        {
            throw new NotImplementedException();
        }
    }
}
