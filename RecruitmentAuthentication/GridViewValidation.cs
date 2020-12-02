using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecruitmentCodeFirstFromDB;

namespace RecruitmentAuthentication
{
    class GridViewAuthentication
    {
        public GridViewAuthentication()
        {

        }
        public void DataGridViewCompany_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            DataGridViewRow row = gridView.Rows[e.RowIndex];

            Debug.WriteLine("CompanyRowValidating started index " + e.RowIndex);

            // only validate if there is changed data. NewRow has no data in it to start.

            if (row == null || row.IsNewRow == true)
            {
                Debug.WriteLine("\tCompanyRowValidating row null or new row " + e.RowIndex);
                return;
            }

            if (gridView.IsCurrentRowDirty == false)
            {
                Debug.WriteLine("\tCompanyRowValidating row not dirty index " + e.RowIndex);
                return;
            }

            // the row is now bound to our entity. check to see if company data is valid.

            Company company = row.DataBoundItem as Company;

            if (company.InfoIsInvalid() == false)
            {
                MessageBox.Show("CompanyRowValidating issue in company data: " + company);
                Debug.WriteLine("\tCompanyRowValidating company data invalid: " + company);
                RowCancelNew(gridView, e.RowIndex);
                return;
            }

            Debug.WriteLine("\tCompanyRowValidating order validated: " + company);

        }
        public void DataGridViewPerk_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            DataGridViewRow row = gridView.Rows[e.RowIndex];

            Debug.WriteLine("PerksRowValidating started index " + e.RowIndex);

            // only validate if there is changed data. NewRow has no data in it to start.

            if (row == null || row.IsNewRow == true)
            {
                Debug.WriteLine("\tPerksRowValidating row null or new row " + e.RowIndex);
                return;
            }

            if (gridView.IsCurrentRowDirty == false)
            {
                Debug.WriteLine("\tPerksRowValidating row not dirty index " + e.RowIndex);
                return;
            }

            // the row is now bound to our entity. check to see if company data is valid.

            Perk perk = row.DataBoundItem as Perk;

            if (perk.InfoIsInvalid() == false)
            {
                MessageBox.Show("PerkRowValidating issue in company data: " + perk);
                Debug.WriteLine("\tPerkRowValidating company data invalid: " + perk);
                RowCancelNew(gridView, e.RowIndex);
                return;
            }

            Debug.WriteLine("\tPerksRowValidating order validated: " + perk);

        }
        private void RowCancelNew(DataGridView gridView, int rowIndex)
        {
            gridView.CancelEdit();
            gridView.InvalidateRow(rowIndex);

            gridView.Refresh();
        }
        public void DataGridViewCompany_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            DataGridViewRow row = gridView.Rows[e.RowIndex];
            string columnName = gridView.Columns[e.ColumnIndex].DataPropertyName;
            string cellValue = e.FormattedValue.ToString().Trim();
            if (cellValue.Length == 0)
            {
                MessageBox.Show("Company field [" + columnName + "] is missing");
                CellCancelNew(gridView, e);
            }
        }
        public void DataGridViewPerk_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            DataGridViewRow row = gridView.Rows[e.RowIndex];
            string columnName = gridView.Columns[e.ColumnIndex].DataPropertyName;
            string cellValue = e.FormattedValue.ToString().Trim();
            if (cellValue.Length == 0)
            {
                MessageBox.Show("Perk field [" + columnName + "] is missing");
                CellCancelNew(gridView, e);
            }
        }
        public void CellCancelNew(DataGridView gridView, DataGridViewCellValidatingEventArgs e)
        {
            RowCancelNew(gridView, e.RowIndex);
            e.Cancel = true;
        }
    }
}
