using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qwe
{
    public partial class Form1 : Form
    {
        private class Tkani
        {
            public int id { Get; Set; }
            public string название { get; set; }
            public string цвет { get; set; }
            public double цена { get; set; }
            
            public Tkani (int i, string n, string c, double p)
                this.id = i;
                this.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            public void fillCombos()
            {
                String sql = "SELECT" id, название, цвет, цена FROM tkani;
                ConnectionState.Open();
                SqlCommand command = new SqlComman(sql, connection);
                SqlDataReadder reader = comand.ExecuteReader();
                List<Tkani> listoftkani = new List<Tkani>();

                    while (reader.Read())
                    {
                        listoftkani.Add(new Tkani(Convert.ToInt32(reader["id"]), reader["название"].ToString(), reader["цвет"].ToString(),Convert.ToDouble reader["цена"])));
                }
                comboBox1.DataSource = listoftkani;
                comboBox1.DisplayMember = "название";
                reader.Close();
            }
        }
    }
}
