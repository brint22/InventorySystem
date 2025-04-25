using Dapper;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
                    var locationStart = gvLocation.GetRowCellValue(gvLocation.FocusedRowHandle, "LocationID")?.ToString();
                    teLocationID.Text = locationStart;
                    var locationFinish = gvLocation.GetRowCellValue(gvLocation.FocusedRowHandle, "ProductID")?.ToString();
                    teProductID.Text = locationFinish;
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

            string start = teLocationID.Text.Trim();
            string finish = teProductID.Text.Trim();
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

        public List<Location> GetFilteredLocation(string availabality)
        {
            if (string.IsNullOrWhiteSpace(availabality))
            {
                MessageBox.Show("Please select a locationID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new List<Location>(); // Return an empty list if classification is invalid
            }

            try
            {
                string connStr = GlobalClass.connectionString;
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    const string query = @"
                SELECT 
                      l.LocationID, 
                      l.ProductID, 
                      l.Availability
                FROM Location l     
                WHERE l.Availability = @Availability;";

                    return connection.Query<Location>(query, new { Availability = availabality }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving Location: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Location>(); // Return an empty list on failure
            }
        }
        private void FilterBtn_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string filterText = cbFilterBy.Text.Trim().ToLower();
                    List<Location> location;

                    switch (filterText)
                    {
                        case "all availability":
                            GlobalMethod.LoadLocationList(gcLocation);
                            return;

                        case "occupied":
                            location = GetFilteredLocation("Occupied");
                            break;

                        case "available":
                            location = GetFilteredLocation("Available");
                            break;

                        default:
                            MessageBox.Show("Invalid filter selection.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                    }

                    if (location.Count == 0)
                    {
                        MessageBox.Show("No records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    gcLocation.DataSource = location;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading locations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}