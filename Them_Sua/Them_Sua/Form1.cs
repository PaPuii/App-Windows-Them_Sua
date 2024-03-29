using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Them_Sua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=PaPuii\SQLEXPRESS;Initial Catalog=Them_Sua;Integrated Security=True;");


        private void OpenCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void ClosedCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }


        private Boolean Exe (string cmd)
        {
            OpenCon();

            Boolean check;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }


            ClosedCon();
            return check;
        }

        private DataTable Red (string cmd) {
            OpenCon();

            DataTable dt  = new DataTable();

            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }

            ClosedCon();
            return dt;

        }

        private void load ()
        {
            DataTable dt = Red("SELECT * FROM Quanly_Thongtin");
            if(dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            MaTen.ResetText();
            HoTen.ResetText();
            NamSinh.ResetText();
            QueQuan.ResetText();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Exe("INSERT INTO Quanly_Thongtin(MaTen, HoTen, NamSinh, QueQuan) VALUES (N'" + MaTen.Text + "' , N'" + HoTen.Text + "' , N'" + NamSinh.Text + "' , N'" + QueQuan.Text + "')");
        }

        private void btn_Trove_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exe("UPDATE Quanly_Thongtin SET MaTen =  N'" + MaTen.Text + "' , HoTen = N'" + HoTen.Text + "' , NamSinh = N'" + NamSinh.Text + "' , QueQuan = N'" + QueQuan.Text + "' WHERE MaTen = '" + MaTen.Text+ "' ");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MaTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            HoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            NamSinh.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            QueQuan.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Exe("DELETE FROM Quanly_Thongtin WHERE MaTen = '" + MaTen.Text+ "' ");
        }

        private void Tim_Kiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = Red("SELECT *  FROM Quanly_Thongtin WHERE MaTen = '" + Tim_Kiem.Text+ "' ");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
    }
}

