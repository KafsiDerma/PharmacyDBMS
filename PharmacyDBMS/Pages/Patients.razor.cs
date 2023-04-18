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
    public partial class Patients
    {
        // flag to show edit form when editing
        public bool EditRecord { get; set; }

        public int EditingId { get; set; }
        public bool ShowCreate { get; set; }
        protected override async Task OnInitializedAsync()
        {
            ShowCreate = false;

            await ShowPatients();
        }

        private PharmacyContext? _context;
        // list to fill for insertion
        public Patient? NewPatient { get; set; }
        // list to fill for reading
        public List<Patient>? ReadPatients { get; set; }
        // temporary tuple holder to edit an entry

        public List<Patient>? FilterPatients { get; set; }

        // for filtering our Patients
        public string findName;
        public Patient? PatientToUpdate { get; set; }


        // form to add new Patients
        public void ShowCreateForm()
        {
            NewPatient = new Patient();
            ShowCreate = true;
        }

        // ADD Patients
        public async Task InsertNewPatient()
        {
            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (NewPatient is not null)
            {


                _context?.Patients.Add(NewPatient);
                _context?.SaveChangesAsync();
            }
            ShowCreate = false;
            //to show the new Patients
            await ShowPatients();

        }

        public async Task ShowPatients()
        {
            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                // u can edit to make it into a specific SQL query
                ReadPatients = await _context.Patients.ToListAsync();
            }

            //commenting this out, we dispose later , if your table is not editable then just dispose here
            //if (_context is not null) await _context.DisposeAsync();
        }

        public async Task FindPatients()
        {
            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                // if the name contains findName
                // referencing https://stackoverflow.com/questions/32641664/how-to-search-data-from-database-using-linq
                ReadPatients = _context.Patients.Where(e => e.PatientFullName.Contains(findName)).ToList();

            }
        }

        public async Task ShowEditForm(Patient ourPatient)
        {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();
            // pull the actual data from the database ( not neccesarily what you see on screen )
            PatientToUpdate = _context.Patients.FirstOrDefault(x => x.HealthCardNum == ourPatient.HealthCardNum);
            EditingId = ourPatient.HealthCardNum;
            EditRecord = true;
        }
        // editing will be 2 parts, click edit to start editing then clicking save button

        public async Task EditPatient()
        {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {

                if (PatientToUpdate is not null) _context.Patients.Update(PatientToUpdate);
                await _context.SaveChangesAsync();
                // dispose is used to release allocated resource, issue with this is it only allows you to edit one entry before refreshing website, from online sources I found
                // out that it releases later by itself
                //await _context.DisposeAsync();
            }
            // once done editing close the form
            EditRecord = false;
        }

        public async Task DeletePatient(Patient selectedPatient)
        {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                if (selectedPatient is not null) _context.Patients.Remove(selectedPatient);
                await _context.SaveChangesAsync();
            }
            await ShowPatients();


        }
    }
}
