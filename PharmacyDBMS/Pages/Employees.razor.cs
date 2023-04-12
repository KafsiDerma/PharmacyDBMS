using PharmacyDBMS.Data;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;

namespace PharmacyDBMS.Pages
{
    public partial class Employees
    {   // flag to show create employee form to avoid showing all forms at once
        public bool ShowCreate { get; set; }
        // flag to show edit form when editing
        public bool EditRecord { get; set; }

        public int EditingId { get; set; }
        protected override async Task OnInitializedAsync()
        {
            ShowCreate = false;

            await ShowEmployees();
        }

        private PharmacyContext? _context;
        // list to fill for insertion
        public Employee? NewEmployee { get; set; }
        // list to fill for reading
        public List<Employee>? ReadEmployees { get; set; }
        // temporary tuple holder to edit an entry
        public Employee? EmployeeToUpdate { get; set; }
        


        // form to add new employees

        public void ShowCreateForm()
        {
            NewEmployee = new Employee();
            ShowCreate = true;
        }
        // ADD EMPLOYEES
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
            //to show the new employees
            await ShowEmployees();

        }



        // View Employees

        public async Task ShowEmployees()
        {
            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                // u can edit to make it into a specific SQL query
                ReadEmployees = await _context.Employees.ToListAsync();
            }
            //commenting this out, we dispose later , if your table is not editable then just dispose here
            //if (_context is not null) await _context.DisposeAsync();
        }


        // edit employees

        public async Task ShowEditForm(Employee ourEmployee)
        {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();
            // pull the actual data from the database ( not neccesarily what you see on screen )
            EmployeeToUpdate = _context.Employees.FirstOrDefault(x => x.Id == ourEmployee.Id);
            EditingId = ourEmployee.Id;
            EditRecord = true;
        }
        // editing will be 2 parts, click edit to start editing then clicking save button

        public async Task EditEmployee() {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null) {

                if (EmployeeToUpdate is not null) _context.Employees.Update(EmployeeToUpdate);
                await _context.SaveChangesAsync();
                // dispose is used to release allocated resource, issue with this is it only allows you to edit one entry before refreshing website, from online sources I found
                // out that it releases later by itself
                //await _context.DisposeAsync();
            }
            // once done editing close the form
            EditRecord = false;
            





        }

        public async Task DeleteEmployee(Employee selectedEmployee)
        {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                if (selectedEmployee is not null) _context.Employees.Remove(selectedEmployee);
                await _context.SaveChangesAsync();
            }
            await ShowEmployees();


        }

    }
}
