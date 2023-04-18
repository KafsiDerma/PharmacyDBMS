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
    public partial class Suppliers
    {
        // flag to show edit form when editing
        public bool EditRecord { get; set; }

        public int EditingId { get; set; }
        public bool ShowCreate { get; set; }
        protected override async Task OnInitializedAsync()
        {
            ShowCreate = false;

            await ShowSuppliers();
        }

        private PharmacyContext? _context;
        // list to fill for insertion
        public Supplier? NewSupplier { get; set; }
        // list to fill for reading
        public List<Supplier>? ReadSuppliers { get; set; }
        // temporary tuple holder to edit an entry

        public List<Supplier>? FilterSuppliers { get; set; }

        // for filtering our Suppliers
        public string findName;
        public Supplier? SupplierToUpdate { get; set; }


        // form to add new Suppliers
        public void ShowCreateForm()
        {
            NewSupplier = new Supplier();
            ShowCreate = true;
        }

        // ADD Suppliers
        public async Task InsertNewSupplier()
        {
            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (NewSupplier is not null)
            {


                _context?.Suppliers.Add(NewSupplier);
                _context?.SaveChangesAsync();
            }
            ShowCreate = false;
            //to show the new Suppliers
            await ShowSuppliers();

        }

        public async Task ShowSuppliers()
        {
            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                // u can edit to make it into a specific SQL query
                ReadSuppliers = await _context.Suppliers.ToListAsync();
            }

            //commenting this out, we dispose later , if your table is not editable then just dispose here
            //if (_context is not null) await _context.DisposeAsync();
        }

        public async Task FindSuppliers()
        {
            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                // if the name contains findName
                // referencing https://stackoverflow.com/questions/32641664/how-to-search-data-from-database-using-linq
                ReadSuppliers = _context.Suppliers.Where(e => e.BusinessName.Contains(findName)).ToList();

            }
        }

        public async Task ShowEditForm(Supplier ourSupplier)
        {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();
            // pull the actual data from the database ( not neccesarily what you see on screen )
            SupplierToUpdate = _context.Suppliers.FirstOrDefault(x => x.BusinessID == ourSupplier.BusinessID);
            EditingId = ourSupplier.BusinessID;
            EditRecord = true;
        }
        // editing will be 2 parts, click edit to start editing then clicking save button

        public async Task EditSupplier()
        {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {

                if (SupplierToUpdate is not null) _context.Suppliers.Update(SupplierToUpdate);
                await _context.SaveChangesAsync();
                // dispose is used to release allocated resource, issue with this is it only allows you to edit one entry before refreshing website, from online sources I found
                // out that it releases later by itself
                //await _context.DisposeAsync();
            }
            // once done editing close the form
            EditRecord = false;
        }

        public async Task DeleteSupplier(Supplier selectedSupplier)
        {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                if (selectedSupplier is not null) _context.Suppliers.Remove(selectedSupplier);
                await _context.SaveChangesAsync();
            }
            await ShowSuppliers();


        }
    }
}
