using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvajalWindowsForms
{
    class ClsInicio : System.Windows.Forms.ApplicationContext
    {
        public ClsInicio()
        {
            Login.Login forma = new Login.Login();
            forma.Show();
            this.Dispose();
        }
    }
}
