using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Button_UserName
{
    public class bnt_Username : System.Windows.Forms.Label
    {

        private String Name_User;

        public String UserName
        {
            get { return Name_User; }
            set { Name_User = value;}
        }

       

    }
}
