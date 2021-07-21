using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvajalWindowsForms.UserClient
{
    class AnClient
    {
        AdClient adclient = new AdClient();

        public DataTable ListarInfoClientxId(string origen, string destino)
        {
            return adclient.ListarInfoClientxId(origen, destino);
        }

        public DataTable ListarInfoClient()
        {
            return adclient.ListarInfoClient();
        }
    }
}
