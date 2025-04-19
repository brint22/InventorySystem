using DevExpress.XtraBars;
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
using Dapper;
using DevExpress.XtraEditors;

namespace InventorySystem.Locations
{
    public partial class AddLocation : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddLocation()
        {
            InitializeComponent();
        }

        private void InsertLocation(Location location)
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                string sql = "INSERT INTO Location (LocationStart, LocationFinish, Availability) VALUES (@LocationStart, @LocationFinish, @Availability)";
                connection.Execute(sql, location);
            }
        }

        private bool LocationExists(string locationStart, string locationFinish)
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                string sql = "SELECT COUNT(1) FROM Location WHERE LocationStart = @LocationStart AND LocationFinish = @LocationFinish";
                int count = connection.ExecuteScalar<int>(sql, new { LocationStart = locationStart, LocationFinish = locationFinish });
                return count > 0;
            }
        }


        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string start = teLocationStart.Text.Trim();
            string finish = teLocationFinish.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(start))
            {
                MessageBox.Show("Please enter a starting location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(finish))
            {
                MessageBox.Show("Please enter a finishing location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (start.Equals(finish, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Starting and finishing locations cannot be the same.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (LocationExists(start, finish))
            {
                MessageBox.Show("This location already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Location location = new Location()
            {
                LocationStart = start,
                LocationFinish = finish,
                Availability = 1
            };

            // Confirm submission
            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to add this location?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            // Call the insert method
            InsertLocation(location);
            MessageBox.Show("Location successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}