using DevExpress.XtraBars;
using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem.Employee
{
    public partial class AddEmployee : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddEmployee()
        {
            InitializeComponent();
        }


        private void RegisterEmployee(Employees employee)
        {

        }

        private static string GenerateID()
        {
            Random random = new Random();
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string id = string.Empty;

            for (int i = 0; i < 4; i++)
            {
                id += letters[random.Next(letters.Length)];
                id += random.Next(0, 8);

            }
            return id;
        }

        private int GetDepartmentID()
        {
            int intRoleID = 0;

            if (lueRole.EditValue != null)
            {
                intRoleID = (int)lueRole.EditValue;

            }
            else
            {
                intRoleID = 0;
            }
            return intRoleID;
        }
    }
}