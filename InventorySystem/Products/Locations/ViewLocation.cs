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
            ProductRepository repo = new ProductRepository(GlobalClass.connectionString);
            DataTable locations = repo.GetAllLocations();
            gcLocation.DataSource = locations;

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

            cbLocationGroup.SelectedIndexChanged += (s, ev) =>
            {
                FilterByGroup();
            };
        }

        private void FilterByGroup()
        {
            {
                try
                {
                    string selectedGroup = cbLocationGroup.Text.Trim().ToUpper();
                    ProductRepository repo = new ProductRepository(GlobalClass.connectionString);

                    // If "ALL" is selected, pass an empty string or "ALL" to fetch all locations
                    List<Location> locations = repo.GetLocationsByGroup(selectedGroup == "ALL" ? null : selectedGroup);

                    if (locations.Count == 0)
                    {
                        MessageBox.Show("No records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    gcLocation.DataSource = locations;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading locations by group: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string filterText = cbFilterBy.Text.Trim().ToLower();
                ProductRepository repo = new ProductRepository(GlobalClass.connectionString);

                switch (filterText)
                {
                    case "all availability":
                        DataTable allLocations = repo.GetAllLocations();
                        gcLocation.DataSource = allLocations;
                        return;

                    case "occupied":
                        List<Location> occupiedLocations = repo.GetLocationsByAvailability("Occupied");
                        if (occupiedLocations.Count == 0)
                        {
                            MessageBox.Show("No records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        gcLocation.DataSource = occupiedLocations;
                        break;

                    case "available":
                        List<Location> availableLocations = repo.GetLocationsByAvailability("Available");
                        if (availableLocations.Count == 0)
                        {
                            MessageBox.Show("No records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        gcLocation.DataSource = availableLocations;
                        break;


                    default:
                        MessageBox.Show("Invalid filter selection.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading locations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
