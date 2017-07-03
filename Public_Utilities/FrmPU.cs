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
    public partial class FrmPU : Form
    {
        public FrmPU()
        {
            InitializeComponent();
            fLATSTableAdapter.Fill(full.FLATS);
        }

        private void FrmPU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'full.DIC_PU1' table. You can move, or remove it, as needed.
            this.dIC_PU1TableAdapter.Fill(this.full.DIC_PU1);
            // TODO: This line of code loads data into the 'full.PRIVILEGES' table. You can move, or remove it, as needed.
            this.pRIVILEGESTableAdapter.Fill(this.full.PRIVILEGES);
// TODO: This line of code loads data into the 'full.LodgersForTable' table. You can move, or remove it, as needed.
this.lodgersForTableTableAdapter.FillLodgersSelect(this.full.LodgersForTable);
            // TODO: This line of code loads data into the 'full.LODGER_DATES' table. You can move, or remove it, as needed.
            this.lODGER_DATESTableAdapter.Fill(this.full.LODGER_DATES);
            // TODO: This line of code loads data into the 'full.PUBLIC_UTILITIES' table. You can move, or remove it, as needed.
            this.pUBLIC_UTILITIESTableAdapter.Fill(this.full.PUBLIC_UTILITIES);
            // TODO: This line of code loads data into the 'full.PRICES' table. You can move, or remove it, as needed.
            this.pRICESTableAdapter.Fill(this.full.PRICES);
            // TODO: This line of code loads data into the 'full.READINGS' table. You can move, or remove it, as needed.
            this.rEADINGSTableAdapter.Fill(this.full.READINGS);
            // TODO: This line of code loads data into the 'full.METERS' table. You can move, or remove it, as needed.
            this.mETERSTableAdapter.Fill(this.full.METERS);
            // TODO: This line of code loads data into the 'full.DIC_PU' table. You can move, or remove it, as needed.
            this.dIC_PUTableAdapter.Fill(this.full.DIC_PU);
            // TODO: This line of code loads data into the 'full.ORGANIZATION' table. You can move, or remove it, as needed.
            this.oRGANIZATIONTableAdapter.Fill(this.full.ORGANIZATION);
            // TODO: This line of code loads data into the 'full.PAYMENTS' table. You can move, or remove it, as needed.
            this.pAYMENTSTableAdapter.Fill(this.full.PAYMENTS);
            // TODO: This line of code loads data into the 'full.LODGERS' table. You can move, or remove it, as needed.
            this.lODGERSTableAdapter.Fill(this.full.LODGERS);
            // TODO: This line of code loads data into the 'full.FLATS' table. You can move, or remove it, as needed.
            this.fLATSTableAdapter.Fill(this.full.FLATS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fLATSTableAdapter.Update(full.FLATS);
        }

        private void FlatsDelete_Click(object sender, EventArgs e)
        {
            fLATSBindingSource.RemoveCurrent();
        }

        private void LodgersSave_Click(object sender, EventArgs e)
        {
            lODGERSTableAdapter.Update(full.LODGERS);
            privilegeS_DATESTableAdapter1.Update(full.PRIVILEGES_DATES);
            lODGER_DATESTableAdapter.Update(full.LODGER_DATES);
        }

        private void LodgersDelete_Click(object sender, EventArgs e)
        {
            int id = (int)DGVLodgers.CurrentRow.Cells["L_ID"].Value;
            lodgersForTableBindingSource.RemoveCurrent();
            lODGER_DATESTableAdapter.DeleteByLodgerId(id);
            privilegeS_DATESTableAdapter1.DeleteByLodgerID(id);
            lODGERSTableAdapter.DeleteById(id);
        }

        private void PaymentsDelete_Click(object sender, EventArgs e)
        {
            pAYMENTSBindingSource.RemoveCurrent();
        }

        private void PaymentsSave_Click(object sender, EventArgs e)
        {
            pAYMENTSTableAdapter.Update(full.PAYMENTS);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridView4.CurrentRow.Cells["oIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> organ_count = countRead_MeterTableAdapter1.SQCountOrganizationsInPU(id);
                if (organ_count == 0)
                {
                    oRGANIZATIONBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Эта организация предоставляет некоторые услуги");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка выдачи информации про автора", "Выдача информации про автора");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oRGANIZATIONTableAdapter.Update(full.ORGANIZATION);
        }

        private void DeleteMeters_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)DGVMeters.CurrentRow.Cells["mETERIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> met_count = countRead_MeterTableAdapter1.SQCountRead_Meter(id);
                if(met_count==0)
                {
                    mETERSBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Существуют показания по этому счетчику");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка выдачи информации про автора", "Выдача информации про автора");
            }
        }

        private void SaveMeters_Click(object sender, EventArgs e)
        {
            mETERSTableAdapter.Update(full.METERS);
        }

        private void DeleteReadings_Click(object sender, EventArgs e)
        {
            rEADINGSBindingSource.RemoveCurrent();
        }

        private void SaveReadings_Click(object sender, EventArgs e)
        {
            rEADINGSTableAdapter.Update(full.READINGS);
        }

        private void DeletePrices_Click(object sender, EventArgs e)
        {
            pRICESBindingSource.RemoveCurrent();
        }

        private void SavePrices_Click(object sender, EventArgs e)
        {
            pRICESTableAdapter.Update(full.PRICES);
        }

        private void DeletePU_Click(object sender, EventArgs e)
        {
            pUBLICUTILITIESBindingSource.RemoveCurrent();
        }

        private void SavePU_Click(object sender, EventArgs e)
        {
            pUBLIC_UTILITIESTableAdapter.Update(full.PUBLIC_UTILITIES);
        }

        private void Find_Click(object sender, EventArgs e)
        {
            Search search_dialog = new Search();
            search_dialog.ShowDialog(this);
            search_dialog.Dispose();
        }


        private void MouseEnterReadingsSearch(object sender, DataGridViewCellEventArgs e)
        {
            int pu_id = 0;
            try
            {
                pu_id = (int)dataGridViewPU.CurrentRow.Cells["pUIDDataGridViewTextBoxColumn"].Value;
                readingS2TableAdapter2.FillReadingsByPU(full.READINGS2, pu_id);
            }
            catch { }
        }



    }
}
