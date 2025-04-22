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
using DevExpress.Utils;
using DevExpress.XtraLayout.Utils;

namespace InventorySystem.Locations
{
    public partial class AddLocation : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddLocation()
        {
            InitializeComponent();
        }

        private void InsertLocation()
        {
            Location location = new Location();
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString)) { 
                for (int i = 1; i < 6; i++)
                {
                    for (int j = 1; j < 11; j++)
                    {
                        location.LocationID = "B-" + i + "-" + j;
                        string sql = "INSERT INTO Location (LocationID, ProductID , Availability) VALUES (@LocationID,'', 'Available')";
                        connection.Execute(sql, location);
                    }
                }
            }
        }

     


        private void BtnSubmit_Click(object sender, EventArgs e)
        {
          

            InsertLocation();


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


            MessageBox.Show("Location successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}