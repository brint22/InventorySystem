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
using InventorySystem.Infrastracture.Repositories;

namespace InventorySystem.Locations
{
    public partial class AddLocation : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddLocation()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to add these locations?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            ProductRepository repo = new ProductRepository(GlobalClass.connectionString);
            repo.InsertLocation();

            MessageBox.Show("Locations successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}