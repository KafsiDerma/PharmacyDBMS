using PharmacyDBMS.Data;
using BCrypt.Net;

namespace PharmacyDBMS.Pages
{
    public partial class Employees
    {
        public bool ShowCreate { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ShowCreate = false;
        }

        private PharmacyContext? _context;

        public Employee? NewEmployee { get; set; }


        // form to add new employees

        public void ShowCreateForm()
        {
            NewEmployee = new Employee();
            ShowCreate = true;
        }

        public async Task InsertNewEmployee() {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (NewEmployee is not null)
            {
                // Hash the password before adding the employee
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(NewEmployee.HashedPassword);
                NewEmployee.HashedPassword = hashedPassword;
                

                _context?.Employees.Add(NewEmployee);
                _context?.SaveChangesAsync();
            }
            ShowCreate = false;

        }

    }
}
