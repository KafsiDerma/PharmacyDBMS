using PharmacyDBMS.Data;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;


namespace PharmacyDBMS.Pages
{
    public partial class Carts
    {
        public bool ShowCreate { get; set; }

        private PharmacyContext? _context;
        public Cart? NewCart { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ShowCreate = false;
            //await ShowCart();
        }

        public void ShowCreateForm()
        {
            NewCart = new Cart();
            ShowCreate = true;  
        }

        public async Task InsertNewCart()
        {
            _context ??= await PharmacyContextFactory.CreateDbContextAsync();

            if (NewCart is not null)
            {
                _context?.Carts.Add(NewCart);
                _context?.SaveChangesAsync();
            }
            ShowCreate = false;
        }
    }
}
