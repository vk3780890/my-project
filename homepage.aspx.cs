using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gmail
{
    public partial class homepage : System.Web.UI.Page
    {
        private object ucPasswordToggle;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Loadcountry();
                userIdHidden.Value = "0";

            }
        }
        private void Loadcountry()
        {
            try
            {
                userinfo Userinfo = new userinfo();
                DataTable dt = Userinfo.GetLookups(string.Empty, "country");
                if (dt != null && dt.Rows.Count > 0)
                {
                    ddlcountry.DataSource = dt;
                    ddlcountry.DataBind();
                    ddlcountry.Items.Insert(0, new ListItem("select", ""));

                }

            }
            catch
            {

            }

        }
        private void LoadState()
        {
            try
            {


                string countryid = ddlcountry.SelectedValue;
                if (countryid != string.Empty)
                {
                    userinfo Userinfo = new userinfo();
                    DataTable dt = Userinfo.GetLookups(countryid, "state");
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        ddlstate.DataSource = dt;
                        ddlstate.DataBind();
                        ddlstate.Items.Insert(0, new ListItem("select", ""));
                    }
                }
            }
            catch
            { }



        }

        protected void country_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadState();
            ucPasswordToggle.Passwordtext = ucPasswordToggle.PasswordText;


        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            userinfo Userinfo = new userinfo();
            int uid = int.Parse(userIdHidden.Value);

            string fname = firstname.Text;
            string lname = lastnamet.Text;
            string gender = genderList1t.SelectedValue;
            string username = usernamet.Text;
            string password = ucPasswordToggle.PasswordText;
            string countryid = ddlcountry.SelectedValue;
            string stateid = ddlstate.SelectedValue;
            char active = active1.Checked ? 'A' : 'I';

            Userinfo.btnsave(uid, fname, lname, gender, username, password, countryid, stateid, active);
            if (uid == 0)
            {
                msglbl.Text = "Saved sucessfully";

            }
            else
            {
                msglbl.Text = "Updated sucessfully";
            }
            Response.Redirect("nextpage.aspx");

        }
    }
    }


