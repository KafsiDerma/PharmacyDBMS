using PharmacyDBMS.Data;
using Microsoft.EntityFrameworkCore;

namespace PharmacyDBMS.Pages
{
    public partial class Products
    {   // flag to show create employee form to avoid showing all forms at once
        public bool ShowCreate { get; set; }
        // flag to show edit form when editing
        public bool EditRecord { get; set; }

        public int EditingId { get; set; }
        protected override async Task OnInitializedAsync()
        {
            ShowCreate = false;

            await ShowProducts();
        }

        private PharmacyContext? _context;
        // list to fill for insertion
        public Product? NewProduct { get; set; }
        // list to fill for reading
        public List<Product>? ReadProducts { get; set; }
        // temporary tuple holder to edit an entry
        public Product? ProductToUpdate { get; set; }



        // form to add new employees

        public void ShowCreateForm()
        {
            NewProduct = new Product();
            ShowCreate = true;
        }
        // ADD Products
        public async Task InsertNewProduct()
        {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (NewProduct is not null)
            {



                
                _context?.Product.Add(NewProduct);
                _context?.SaveChangesAsync();
            }
            ShowCreate = false;
            //to show the new products
            await ShowProducts();

        }



        // View Products

        public async Task ShowProducts()
        {
            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                // u can edit to make it into a specific SQL query
                ReadProducts = await _context.Product.ToListAsync();
            }
            //commenting this out, we dispose later , if your table is not editable then just dispose here
            //if (_context is not null) await _context.DisposeAsync();
        }


        // edit Products

        public async Task ShowEditForm(Product ourProduct)
        {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();
            // pull the actual data from the database ( not neccesarily what you see on screen )
            ProductToUpdate = _context.Product.FirstOrDefault(x => x.productID == ourProduct.productID);
            EditingId = ourProduct.productID;
            EditRecord = true;
        }
        // editing will be 2 parts, click edit to start editing then clicking save button

        public async Task EditProduct()
        {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {

                if (ProductToUpdate is not null) _context.Product.Update(ProductToUpdate);
                await _context.SaveChangesAsync();
                // dispose is used to release allocated resource, issue with this is it only allows you to edit one entry before refreshing website, from online sources I found
                // out that it releases later by itself
                //await _context.DisposeAsync();
            }
            // once done editing close the form
            EditRecord = false;






        }

        public async Task DeleteProduct(Product selectedProduct)
        {

            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                if (selectedProduct is not null) _context.Product.Remove(selectedProduct);
                await _context.SaveChangesAsync();
            }
            await ShowProducts();


        }

    }
}
