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
using DevExpress.XtraPrinting.Native;
using System.Net;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.Pdf.Native.BouncyCastle.Utilities.Net;
using DevExpress.XtraLayout.Customization;
using InventorySystem.Infrastracture.Repositories;
using InventorySystem.Infrastracture.SQL;

namespace InventorySystem.Employees
{
    public partial class AddEmployee : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            EmployeeRepository.LoadRole(lueRole);
            gcAddress.DataSource = CreateAddressTable();
        }



        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Field validations for Employee
            if (string.IsNullOrWhiteSpace(teFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(teMiddleName.Text))
            {
                MessageBox.Show("Middle Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(teLastName.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (EmployeeRepository.GetGender(rdGender) == null)
            {
                MessageBox.Show("Gender is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbCivilStatus.Text))
            {
                MessageBox.Show("Civil Status is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (deDateOfBirth.DateTime == DateTime.MinValue)
            {
                MessageBox.Show("Date of Birth is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tePhoneNumber.Text))
            {
                MessageBox.Show("Phone Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (deDateHired.DateTime == DateTime.MinValue)
            {
                MessageBox.Show("Date Hired is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (EmployeeRepository.GetRole(lueRole) == 0)
            {
                MessageBox.Show("Role ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(teZipCode.Text, out int zipCodeNumber))
            {
                MessageBox.Show("Please enter a valid zip code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Field validations for Address
            if (string.IsNullOrWhiteSpace(teBarangayName.Text))
            {
                MessageBox.Show("Barangay Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(teMunicipality.Text))
            {
                MessageBox.Show("Municipality Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(teProvince.Text))
            {
                MessageBox.Show("Province Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(teCountry.Text))
            {
                MessageBox.Show("Country Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm submission
            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to add this employee?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            // Build Employee object
            Employee employee = new Employee
            {
                FirstName = teFirstName.Text,
                MiddleName = teMiddleName.Text,
                LastName = teLastName.Text,
                NameExtension = teNameExtension.Text,
                Gender = EmployeeRepository.GetGender(rdGender).ToString(),
                CivilStatus = cbCivilStatus.Text,
                DateOfBirth = deDateOfBirth.DateTime,
                PhoneNumber = tePhoneNumber.Text,
                DateHired = deDateHired.DateTime,
                RoleID = EmployeeRepository.GetRole(lueRole)
            };

            // Read image bytes from image path
            string imagePath = meEmployeeImagePath.Text.Trim();
            byte[] imageBytes = File.Exists(imagePath) ? File.ReadAllBytes(imagePath) : null;

            if (imageBytes == null)
            {
                MessageBox.Show("Invalid image file. Please select a valid image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Build Address object
            Address address = new Address
            {
                BarangayName = teBarangayName.Text,
                MunicipalityName = teMunicipality.Text,
                ProvinceName = teProvince.Text,
                ZipCodeNumber = zipCodeNumber,
                CountryName = teCountry.Text,
            };


            EmployeeRepository repo = new EmployeeRepository(GlobalClass.connectionString);

            // Call the repository method to register the employee using predefined SQL queries
            repo.RegisterEmployee(
                employee,
                imageBytes,
                address
            );

            EmployeeRepository.ClearEmployeeInputs(
              teFirstName, teMiddleName, teLastName,
              teNameExtension, rdGender, cbCivilStatus,
              deDateOfBirth, tePhoneNumber, deDateHired, lueRole);

            ClearInputsAddress();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    if (meEmployeeImagePath != null)
                    {
                        meEmployeeImagePath.Text = filePath;
                    }
                    else
                    {
                        MessageBox.Show("Error: TextBox 'meEmployeeImagePath' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // ✅ Display the selected image in the PictureEdit control
                    if (peProfile != null)
                    {
                        peProfile.Image = System.Drawing.Image.FromFile(filePath);
                    }
                    else
                    {
                        MessageBox.Show("Error: PictureEdit 'peProfile' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Data table of Address
        DataTable dtAddress = new DataTable();
        private DataTable CreateAddressTable()
        {
            dtAddress.Columns.Add("Barangay", typeof(string));
            dtAddress.Columns.Add("Municipality", typeof(string));
            dtAddress.Columns.Add("Province", typeof(string));
            dtAddress.Columns.Add("ZipCode", typeof(string));
            dtAddress.Columns.Add("Country", typeof(string));
            return dtAddress;
        }


        //Methid for Temporary Adding Address in gcAddress
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string barangay = teBarangayName.Text.Trim();
            string municipality = teMunicipality.Text.Trim();
            string province = teProvince.Text.Trim();
            string zipCode = teZipCode.Text.Trim();
            string country = teCountry.Text.Trim();
            // Validation to check if any field is empty
            if (string.IsNullOrEmpty(barangay) ||
                string.IsNullOrEmpty(municipality) ||
                string.IsNullOrEmpty(province) ||
                string.IsNullOrEmpty(zipCode) ||
                string.IsNullOrEmpty(country))
            {
                MessageBox.Show("Please fill out all fields before adding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataRow newRow = dtAddress.NewRow();
            newRow["Barangay"] = barangay;
            newRow["Municipality"] = municipality;
            newRow["Province"] = province;
            newRow["ZipCode"] = zipCode;
            newRow["Country"] = country;
            dtAddress.Rows.Add(newRow);

            gcAddress.DataSource = dtAddress;
            gvAddress.RefreshData();
        }

        //Methid for Temporary Removing Address in gcAddress
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvAddress.FocusedRowHandle;

            if (focusedRowHandle >= 0)
            {
                DataRow rowDelete = gvAddress.GetDataRow(focusedRowHandle);
                if (rowDelete != null)
                {
                    dtAddress.Rows.Remove(rowDelete);

                    gcAddress.DataSource = dtAddress;
                    gvAddress.RefreshData();
                }
                else
                {
                    XtraMessageBox.Show("Please select a row to remove.");
                }
            }
        }

        //Clearing the inputs in Address
        private void ClearInputsAddress()
        {
            teBarangayName.Text = string.Empty;
            teMunicipality.Text = string.Empty;
            teProvince.Text = string.Empty;
            teZipCode.Text = string.Empty;
            teCountry.Text = string.Empty;
           
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}