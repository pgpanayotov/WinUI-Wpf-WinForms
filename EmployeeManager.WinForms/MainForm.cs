using EmployeeManager.DataAccess;
using EmployeeManager.ViewModel;
using System;
using System.Windows.Forms;

namespace EmployeeManager.WinForms
{
    public partial class MainForm : Form
    {
        private readonly MainViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            _viewModel = new MainViewModel(new EmployeeDataProvider());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            _viewModel.Load();
            EmployeesBindingSource.DataSource = _viewModel.Employees;
            lsbEmployees.DataSource = EmployeesBindingSource;
            lsbEmployees.DisplayMember = "FirstName";

            cmbJobRole.DataSource = _viewModel.JobRoles;
            cmbJobRole.DisplayMember = "RoleName";
            cmbJobRole.ValueMember = "Id";

            var areDataBindingsInitialized = cmbJobRole.DataBindings.Count > 0;
            if(areDataBindingsInitialized)
            {
                EmployeesBindingSource.ResetBindings(false);
            }
            else
            {
                cmbJobRole.DataBindings.Add("SelectedValue", EmployeesBindingSource, "JobRoleId");

                txtFirstName.DataBindings.Add("Text", EmployeesBindingSource, "FirstName", false, DataSourceUpdateMode.OnPropertyChanged);
                dtpEntryDate.DataBindings.Add("Value", EmployeesBindingSource, "EntryDateTime");
                checkIsCoffeeDrinker.DataBindings.Add("Checked", EmployeesBindingSource, "IsCoffeeDrinker");

                btnSave.DataBindings.Add("Enabled", EmployeesBindingSource, "CanSave");
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(EmployeesBindingSource.Current is EmployeeViewModel employeeViewModel && employeeViewModel.CanSave)
            {
                employeeViewModel.Save();
            }
        }
    }
}
