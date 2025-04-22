using Dapper;
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

        private void RetrieveLocation()
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                string sql = @"SELECT LocationID, 
                        LocationStart, 
                        LocationFinish, 
                        Availability
                        FROM Location";
                var locationList = connection.Query<Location>(sql).ToList();

                // Bind data to the grid
                gcLocation.DataSource = locationList;

                // Configure columns (after data is bound)
                gvLocation.PopulateColumns();

                // Show computed AvailabilityText
                gvLocation.Columns["AvailabilityText"].Visible = true;
                gvLocation.Columns["AvailabilityText"].Caption = "Availability";

                // Optionally hide raw int Availability column
                gvLocation.Columns["Availability"].Visible = false;
            }
        }

        private void ViewLocation_Load(object sender, EventArgs e)
        {
            // Optional: formatting or layout before data
            GlobalMethod.LoadCategoryData(gcLocation);

            RetrieveLocation();

            // Ensure the GridView is properly attached to the GridControl//
            gcLocation.MainView = gvLocation;

            // Use FocusedRowChanged instead of RowClick
            gvLocation.FocusedRowChanged += (s, ev) =>
            {
                if (gvLocation.FocusedRowHandle >= 0)
                {
                    var locationStart = gvLocation.GetRowCellValue(gvLocation.FocusedRowHandle, "LocationStart")?.ToString();
                    var locationFinish = gvLocation.GetRowCellValue(gvLocation.FocusedRowHandle, "LocationFinish")?.ToString();
                    var availability = gvLocation.GetRowCellValue(gvLocation.FocusedRowHandle, "AvailabilityText")?.ToString();

                    teLocationStart.Text = locationStart;
                    teLocationFinish.Text = locationFinish;
                    teAvailability.Text = availability;
                }
            };
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            if (gvLocation.FocusedRowHandle < 0)
            {
                MessageBox.Show("Please select a location to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string start = teLocationStart.Text.Trim();
            string finish = teLocationFinish.Text.Trim();
            int availability = int.Parse(teAvailability.Text.Trim());

            if (string.IsNullOrEmpty(start) || string.IsNullOrEmpty(finish))
            {
                MessageBox.Show("Start and Finish location cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update this location?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int locationId = Convert.ToInt32(gvLocation.GetRowCellValue(gvLocation.FocusedRowHandle, "LocationID"));

                var repository = new ProductRepository(GlobalClass.connectionString);
                repository.UpdateLocation(locationId, start, finish, availability);

                MessageBox.Show("Location updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RetrieveLocation(); // reload the grid
            }
        }
    }
}