using HumanResourcesManager_Project.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HumanResourcesManager_Project.UI
{
    public partial class HR_ManagerApp : Form
    {
        private Timer feedbackTimer;

        public HR_ManagerApp()
        {
            InitializeComponent();
            Employee.GetAllEmployees();
            feedbackTimer = new Timer();
            feedbackTimer.Tick += FeedbackTimer_Tick;
        }

        private void HR_ManagerApp_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.highTechDataSet.Employee);
        }

        private void FeedbackTimer_Tick(object sender, EventArgs e)
        {
            lblFeedback.Visible = false;
            feedbackTimer.Stop();
        }

        private void ShowFeedback(string text, Color color, bool visible = true, int duration = 4000)
        {
            lblFeedback.Text = text;
            lblFeedback.ForeColor = color;
            lblFeedback.Visible = visible;
            if (visible && duration > 0)
            {
                feedbackTimer.Interval = duration;
                feedbackTimer.Start();
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                dgvHighTech.DataSource = null;
                dgvHighTech.DataSource = Employee.Employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing the data grid view: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtSsn.Text = "";
            dtpHireDate.Value = DateTime.Now;
        }

        private void DgvHighTech_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHighTech.SelectedRows.Count > 0)
            {
                int index = dgvHighTech.SelectedRows[0].Index;
                if (index >= 0 && index < Employee.Employees.Count)
                {
                    Employee selected = Employee.Employees[index];
                    txtId.Text = selected.Id.ToString();
                    txtFirstName.Text = selected.FirstName;
                    txtLastName.Text = selected.LastName;
                    txtEmail.Text = selected.Email;
                    txtSsn.Text = selected.Ssn;
                    dtpHireDate.Value = selected.HireDate;
                }
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee(
                    Convert.ToInt32(txtId.Text),
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtEmail.Text,
                    txtSsn.Text,
                    dtpHireDate.Value
                );
                Employee.Insert(emp);
                RefreshDataGridView();
                ShowFeedback("Employee inserted successfully.", Color.Green);
                ClearFields();
            }
            catch (ValidationException ex)
            {
                ShowFeedback(ex.Message, Color.Red);
            }
            catch (Exception ex)
            {
                ShowFeedback("An error occurred while inserting the employee.", Color.Red);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee(
                    Convert.ToInt32(txtId.Text),
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtEmail.Text,
                    txtSsn.Text,
                    dtpHireDate.Value
                );
                Employee.Update(emp);
                RefreshDataGridView();
                ShowFeedback("Employee updated successfully.", Color.Green);
                ClearFields();
            }
            catch (ValidationException ex)
            {
                ShowFeedback(ex.Message, Color.Red);
            }
            catch (Exception ex)
            {
                ShowFeedback("An error occurred while updating the employee.", Color.Red);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                Employee.Delete(id);
                RefreshDataGridView();
                ShowFeedback("Employee deleted successfully.", Color.Green);
            }
            catch (ValidationException ex)
            {
                ShowFeedback(ex.Message, Color.Red);
            }
            catch (Exception ex)
            {
                ShowFeedback("An error occurred while deleting the employee.", Color.Red);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSsn.Text + txtId.Text))
                {
                    ShowFeedback("Please enter a search term.", Color.Red);
                    return;
                }
                Employee.SearchEmployees(searchId: txtId.Text, searchSsn: txtSsn.Text);
                RefreshDataGridView();
                ShowFeedback("Search completed.", Color.Green);
            }
            catch (ValidationException ex)
            {
                ShowFeedback(ex.Message, Color.Red);
            }
            catch (Exception ex)
            {
                ShowFeedback("An error occurred while searching employees.", Color.Red);
                RefreshDataGridView();
            }
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                Employee.GetAllEmployees();
                RefreshDataGridView();
                ShowFeedback("All employees displayed.", Color.Green);
            }
            catch (Exception ex)
            {
                ShowFeedback("An error occurred while displaying employees.", Color.Red);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Employee.GetAllEmployees();
            RefreshDataGridView();
            ShowFeedback("Form refreshed.", Color.Green);
            ClearFields();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
