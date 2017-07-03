using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Public_Utilities
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            String text = InputTextBox.Text;
            int flat_id=0;
            flat_id=Int32.Parse(text);
            readingS1TableAdapter1.FindReadingsByFlats(full1.READINGS1, flat_id);

        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'full1.PUBLIC_UTILITIES' table. You can move, or remove it, as needed.
            this.pUBLIC_UTILITIESTableAdapter.Fill(this.full1.PUBLIC_UTILITIES);

        }
    }
}
