using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gmail
{
    public partial class Password : System.Web.UI.UserControl
    {
        public string password
        {
            get
            {
                return PasswordText.Text;
            }
            set
            {
                PasswordText.Attributes["value"] = value;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

    }




}