using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace covid19
{
    public partial class showreport : Form
    {
        string constr = @"Data Source=.\sqlexpress;Initial Catalog=covid;Integrated Security=True";

        public showreport()
        {
            InitializeComponent();
        }

        private void showreport_Load(object sender, EventArgs e)
        {

           
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter("select conName from tblCountry", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {

                cbCountry.Items.Add(row[0].ToString().ToUpper());
            }
            
            SqlDataAdapter da1 = new SqlDataAdapter("select sum(new),sum(recovered),sum(death),sum(vaccinated) from tblLiveUpdate",con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            lblTotal.Text = ds1.Tables[0].Rows[0][0].ToString();
            lblRecovered.Text = ds1.Tables[0].Rows[0][1].ToString();
            lblDeath.Text = ds1.Tables[0].Rows[0][2].ToString();
            lblVaccine.Text = ds1.Tables[0].Rows[0][3].ToString();
            SqlDataAdapter da2 = new SqlDataAdapter("select sum(new),sum(recovered),sum(death),sum(vaccinated) from tblLiveUpdate where date like '"+DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy")+"'", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);

            SqlDataAdapter da3 = new SqlDataAdapter("select sum(new),sum(recovered),sum(death),sum(vaccinated) from tblLiveUpdate where date like '" + DateTime.Now.AddDays(-2).ToString("dd/MM/yyyy") + "'", con);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);

            if (Int64.Parse(ds2.Tables[0].Rows[0][0].ToString()) > Int64.Parse(ds3.Tables[0].Rows[0][0].ToString()))
                lblTodayNew.ForeColor = System.Drawing.Color.Red;
            else
                lblTodayNew.ForeColor = System.Drawing.Color.Green;

            if (Int64.Parse(ds2.Tables[0].Rows[0][1].ToString()) > Int64.Parse(ds3.Tables[0].Rows[0][1].ToString()))
                lblTodayRecovered.ForeColor = System.Drawing.Color.Red;
            else
                lblTodayRecovered.ForeColor = System.Drawing.Color.Green;

            if (Int64.Parse(ds2.Tables[0].Rows[0][3].ToString()) > Int64.Parse(ds3.Tables[0].Rows[0][3].ToString()))
                lblTodayVaccine.ForeColor = System.Drawing.Color.Red;
            else
                lblTodayVaccine.ForeColor = System.Drawing.Color.Green;

            lblTodayNew.Text = ds2.Tables[0].Rows[0][0].ToString();
            lblTodayRecovered.Text=ds2.Tables[0].Rows[0][1].ToString();
            lblTodayDeath.Text=ds2.Tables[0].Rows[0][2].ToString();
            lblTodayVaccine.Text = ds2.Tables[0].Rows[0][3].ToString();





            SqlDataAdapter da4 = new SqlDataAdapter("select date,sum(new) from tblLiveUpdate group by date order by date asc", con);
            DataSet ds4 = new DataSet();
            da4.Fill(ds4);
            Series s = chart1.Series["Series1"];
            int j = 0;
            for (int i = 0; i < ds4.Tables[0].Rows.Count; i++)
            {
                s.Points.AddXY(ds4.Tables[0].Rows[i][0].ToString().Substring(0,5),ds4.Tables[0].Rows[i][1].ToString());

            }


        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCountry.SelectedIndex != 0)
            {
                cbState.Enabled = true;
                lblCountry.Text = cbCountry.Text;
            }
            else
            {
                lblCountry.Text = "WORLDWIDE";
                cbState.Enabled = false;
            }

            
            
            cbState.Items.Clear();
            cbState.Items.Add("ALL");
            cbState.SelectedIndex = 0;
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter("select stateName from tblState where conId= (select conId from tblCountry where conName like '" + cbCountry.SelectedItem.ToString() + "')", con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {

                cbState.Items.Add(row[0].ToString().ToUpper());
            }

            string query = "",query1="",query2="";
            if (cbCountry.SelectedIndex != 0)
            {

                query = "select sum(new),sum(recovered),sum(death),sum(vaccinated) from tblLiveUpdate where conName like '" + cbCountry.SelectedItem.ToString() + "'";
                query1 = "select sum(new),sum(recovered),sum(death),sum(vaccinated) from tblLiveUpdate where date like '" + DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy") + "' and conName like '"+cbCountry.Text+"'";
                query2 = "select date,sum(new) from tblLiveUpdate where conName like '" + cbCountry.Text + "' group by date order by date asc";
            }
            else
            {
                query = "select sum(new),sum(recovered),sum(death),sum(vaccinated) from tblLiveUpdate ";
                query1="select sum(new),sum(recovered),sum(death),sum(vaccinated) from tblLiveUpdate where date like '" + DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy") + "'";
                query2 = "select date,sum(new) from tblLiveUpdate group by date order by date asc";

            }
            SqlDataAdapter da1 = new SqlDataAdapter(query, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            lblTotal.Text = ds1.Tables[0].Rows[0][0].ToString();
            lblRecovered.Text = ds1.Tables[0].Rows[0][1].ToString();
            lblDeath.Text = ds1.Tables[0].Rows[0][2].ToString();
            lblVaccine.Text = ds1.Tables[0].Rows[0][3].ToString();


            SqlDataAdapter da2 = new SqlDataAdapter(query1, con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            lblTodayNew.Text = ds2.Tables[0].Rows[0][0].ToString();
            lblTodayRecovered.Text = ds2.Tables[0].Rows[0][1].ToString();
            lblTodayDeath.Text = ds2.Tables[0].Rows[0][2].ToString();
            lblTodayVaccine.Text = ds2.Tables[0].Rows[0][3].ToString();
                        
            SqlDataAdapter da4 = new SqlDataAdapter(query2, con);
            DataSet ds4 = new DataSet();
            da4.Fill(ds4);
            Series s = chart1.Series["Series1"];
            s.Points.Clear();
            int j = 0;
            for (int i = 0; i < ds4.Tables[0].Rows.Count; i++)
            {
                s.Points.AddXY(ds4.Tables[0].Rows[i][0].ToString().Substring(0, 5), ds4.Tables[0].Rows[i][1].ToString());

            }
            
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter("select sum(new),sum(recovered),sum(death),sum(vaccinated) from tblLiveUpdate where conName like '" + cbCountry.Text + "' and stateName like '"+cbState.Text+"'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            lblTotal.Text = ds.Tables[0].Rows[0][0].ToString();
            lblRecovered.Text = ds.Tables[0].Rows[0][1].ToString();
            lblDeath.Text = ds.Tables[0].Rows[0][2].ToString();
            lblVaccine.Text = ds.Tables[0].Rows[0][3].ToString();

            string query = "", query1 = "",query2="";
            if (cbState.SelectedIndex != 0)
            {

                query = "select sum(new),sum(recovered),sum(death),sum(vaccinated) from tblLiveUpdate where stateName like '" + cbState.Text + "'";
                query1 = "select sum(new),sum(recovered),sum(death),sum(vaccinated) from tblLiveUpdate where date like '" + DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy") + "' and stateName like '" + cbState.Text + "'";
                query2 = "select date,sum(new) from tblLiveUpdate where stateName like '" + cbState.Text + "' group by date order by date asc";

            }
            else
            {
                query = "select sum(new),sum(recovered),sum(death),sum(vaccinated) from tblLiveUpdate where conName like '"+cbCountry.Text+"' ";
                query1 = "select sum(new),sum(recovered),sum(death),sum(vaccinated) from tblLiveUpdate where date like '" + DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy") + "' and conName like '" + cbCountry.Text + "'";
                query2 = "select date,sum(new) from tblLiveUpdate group by date order by date asc";

            }
            SqlDataAdapter da1 = new SqlDataAdapter(query, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            lblTotal.Text = ds1.Tables[0].Rows[0][0].ToString();
            lblRecovered.Text = ds1.Tables[0].Rows[0][1].ToString();
            lblDeath.Text = ds1.Tables[0].Rows[0][2].ToString();
            lblVaccine.Text = ds1.Tables[0].Rows[0][3].ToString();


            SqlDataAdapter da2 = new SqlDataAdapter(query1, con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            lblTodayNew.Text = ds2.Tables[0].Rows[0][0].ToString();
            lblTodayRecovered.Text = ds2.Tables[0].Rows[0][1].ToString();
            lblTodayDeath.Text = ds2.Tables[0].Rows[0][2].ToString();
            lblTodayVaccine.Text = ds2.Tables[0].Rows[0][3].ToString();


            SqlDataAdapter da4 = new SqlDataAdapter(query2, con);
            DataSet ds4 = new DataSet();
            da4.Fill(ds4);
            Series s = chart1.Series["Series1"];
            s.Points.Clear();
            int j = 0;
            for (int i = 0; i < ds4.Tables[0].Rows.Count; i++)
            {
                s.Points.AddXY(ds4.Tables[0].Rows[i][0].ToString().Substring(0, 5), ds4.Tables[0].Rows[i][1].ToString());

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
