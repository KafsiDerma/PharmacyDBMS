using PharmacyDBMS.Data;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using System.ComponentModel.DataAnnotations;
using SQLitePCL;

namespace PharmacyDBMS.Pages
{
    public partial class Doctors
    {
        // flag to show edit form when editing
        public bool EditRecord { get; set; }

        public int EditingId { get; set; }
        public bool ShowCreate { get; set; }
        protected override async Task OnInitializedAsync()
        {
            ShowCreate = false;

            await ShowDoctors();
        }

        private PharmacyContext? _context;
        // list to fill for insertion
        public Doctor? NewDoctor { get; set; }
        // list to fill for reading
        public List<Doctor>? ReadDoctors { get; set; }
        // temporary tuple holder to edit an entry

        public List<Doctor>? FilterDoctors { get; set; }

        // for filtering our doctors
        public string findName;
        public Doctor? DoctorToUpdate { get; set; }


        // form to add new doctors
        public void ShowCreateForm()
        {
            NewDoctor = new Doctor();
            ShowCreate = true;
        }

        // ADD DOCTORS
        public async Task InsertNewDoctor()
        {
            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (NewDoctor is not null)
            {
                Supplier newSupplier = new Supplier { BusinessID = 9999 }; //instantiate, you can edit this later
                NewProduct.Supplier = newSupplier;


                _context?.Product.Add(NewProduct);
                _context?.Doctors.Add(NewDoctor);
                _context?.SaveChangesAsync();
            }
            ShowCreate = false;
            //to show the new doctors
            await ShowDoctors();

        }

        public async Task ShowDoctors()
        {
            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                // u can edit to make it into a specific SQL query
                ReadDoctors = await _context.Doctors.ToListAsync();
            }

            //commenting this out, we dispose later , if your table is not editable then just dispose here
            //if (_context is not null) await _context.DisposeAsync();
        }

        public async Task FindDoctors()
        {
            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                // if the name contains findName
                // referencing https://stackoverflow.com/questions/32641664/how-to-search-data-from-database-using-linq
                ReadDoctors = _context.Doctors.Where(e => e.name.Contains(findName)).ToList();

            }
        }

        public async Task ShowEditForm(Doctor ourDoctor)
        {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();
            // pull the actual data from the database ( not neccesarily what you see on screen )
            DoctorToUpdate = _context.Doctors.FirstOrDefault(x => x.Medical_License == ourDoctor.Medical_License);
            EditingId = ourDoctor.Medical_License;
            EditRecord = true;
        }
        // editing will be 2 parts, click edit to start editing then clicking save button

        public async Task EditDoctor()
        {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {

                if (DoctorToUpdate is not null) _context.Doctors.Update(DoctorToUpdate);
                await _context.SaveChangesAsync();
                // dispose is used to release allocated resource, issue with this is it only allows you to edit one entry before refreshing website, from online sources I found
                // out that it releases later by itself
                //await _context.DisposeAsync();
            }
            // once done editing close the form
            EditRecord = false;
        }

        public async Task DeleteDoctor(Doctor selectedDoctor)
        {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                if (selectedDoctor is not null) _context.Doctors.Remove(selectedDoctor);
                await _context.SaveChangesAsync();
            }
            await ShowDoctors();


        }
    }
}
