using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvajalWindowsForms.Menu
{
    class clsANMenu
    {
        clsADMenu clsADMen = new clsADMenu();

        public DataTable ValidaPermisoUsuario(string login)
        {
            return clsADMen.ValidaPermisoUsuario(login);
        }

    }
}
