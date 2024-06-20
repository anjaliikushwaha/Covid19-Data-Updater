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

namespace covid19
{


    public partial class adddata : Form
    {

        string constr = @"Data Source=.\sqlexpress;Initial Catalog=covid;Integrated Security=True";

        public adddata()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void adddata_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter("select conName from tblCountry", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            foreach (DataRow row in ds.Tables[0].Rows)
            {

                cbCountry.Items.Add( row[0].ToString().ToUpper());
            }
                                    
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbState.Items.Clear();
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter("select stateName from tblState where conId= (select conId from tblCountry where conName like '" + cbCountry.SelectedItem.ToString() + "')", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cbState.Items.Clear();
            cbState.Items.Add("ALL");
            cbState.SelectedIndex = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {

                cbState.Items.Add(row[0].ToString().ToUpper());
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from tblLiveUpdate where conName like '"+cbCountry.Text+"' and stateName like '"+cbState.Text+"' and date like '"+dtpDate.Text+"'";
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                con.Close();
                con.Open();
                cmd.CommandText = "insert into tblLiveUpdate values ('" + cbCountry.Text + "','" + cbState.Text + "','" + dtpDate.Text + "'," + txtNew.Text + "," + txtRecovered.Text + ",'" + txtDeath.Text + "'," + txtVaccine.Text + ")";
                DataSet ds = new DataSet();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record saved successfully");
                txtNew.Text = "";
                txtRecovered.Text = "";
                txtDeath.Text = "";
                txtVaccine.Text = "";
            }
            else
            {
                MessageBox.Show("Data already added for this date");
            }
           
        }
    }
}
