using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarDB {
    public partial class Form1 : Form {
        DBConnection db = new DBConnection();

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string error = db.Connection();

            if (error != null) MessageBox.Show(error);

            DataSet data = db.Starcraft();
            GridStarcraft.DataSource = data;
            GridStarcraft.DataMember = "unit";
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            db.InsertData();
        }

        private void button2_Click(object sender, EventArgs e) {
            db.DeleteData();
        }
    }
}
