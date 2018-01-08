using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;

namespace Pharmacy_Project
{
    public partial class Delete : Form
    {
         Medicine m = new Medicine();

        
        public Delete()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click( object sender, EventArgs e )
        {
            Main_Menu m = new Main_Menu ();
            m.Show ();
            this.Hide ();   
        }

        private void Delete_FormClosing( object sender, FormClosingEventArgs e )
        {

            Application.Exit ();
        }

        private void buttonDeleteMedicine_Click( object sender, EventArgs e )
        {
            m.DeleteMedicine(int.Parse(textBox1Delete.Text));
            MessageBox.Show("Medicine Deleted");

        }

        private void textBox1Delete_TextChanged( object sender, EventArgs e )
        {

        }

        private void dataGridDelete_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void Delete_Load( object sender, EventArgs e )
        {
            dataGridDelete.DataSource = m.GetMedicineList();
        }
    }
}
