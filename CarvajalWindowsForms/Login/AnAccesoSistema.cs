using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvajalWindowsForms.Login
{
    class AnAccesoSistema
    {
        AdAccesoSistema clsAD = new AdAccesoSistema();

        public DataTable ExisteUsuario(string login)
        {
            return clsAD.ExisteUsuario(login);
        }
    }
}
