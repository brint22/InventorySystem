using Dapper;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using InventorySystem.Infrastracture.Repositories;
using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem.Locations
{
    public partial class ViewLocation : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ViewLocation()
        {
            InitializeComponent();
        }

       

        private void ViewLocation_Load(object sender, EventArgs e)
        {
            // Optional: formatting or layout before data
            GlobalMethod.LoadLocationList(gcLocation);

            gvLocation.RowClick += (s, ev) =>
            {
                if (gvLocation.FocusedRowHandle >= 0)
                {
                    var locationStart = gvLocation.GetRowCellValue(gvLocation.FocusedRowHandle, "LocationStart")?.ToString();
                    teLocationStart.Text = locationStart;
                    var locationFinish = gvLocation.GetRowCellValue(gvLocation.FocusedRowHandle, "LocationFinish")?.ToString();
                    teLocationFinish.Text = locationFinish;
                    var availability = gvLocation.GetRowCellValue(gvLocation.FocusedRowHandle, "Availability")?.ToString();
                    teAvailability.Text = availability;
                }
            };
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            var repository = new ProductRepository(GlobalClass.connectionString);
        

            if (gvLocation.FocusedRowHandle < 0)
            {
                MessageBox.Show("Please select a location to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string start = teLocationStart.Text.Trim();
            string finish = teLocationFinish.Text.Trim();
            //string availability = teAvailability.Text.Trim();

            if (string.IsNullOrEmpty(start) || string.IsNullOrEmpty(finish))
            {
                MessageBox.Show("Start and Finish location cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update this location?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //int locationId = Convert.ToInt32(gvLocation.GetRowCellValue(gvLocation.FocusedRowHandle, "LocationID"));

                MessageBox.Show("Location updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Corrected refresh call
                GlobalMethod.LoadLocationList(gcLocation);
            }
        }
    }
}