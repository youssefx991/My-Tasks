using Day16_HMS.Context;
using Microsoft.EntityFrameworkCore;

namespace Day16_HMS
{
    public partial class Form1 : Form
    {
        HotelContext Context = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Context.Database.Migrate();
            Context.Kitchens.RemoveRange(Context.Kitchens);
            Context.Frontends.RemoveRange(Context.Frontends);
            Context.Reservations.RemoveRange(Context.Reservations);
            Context.Kitchens.Add(new() { Username = "k1", Password = "p1" });
            Context.Frontends.Add(new() { Username = "f1", Password = "p1" });
            Context.Reservations.Add(new()
            {
                FirstName = "John",
                LastName = "Doe",
                AptSuite = "101",
                BirthDay = "01/01/1990",
                ArrivalTime = DateTime.Now,
                City = "New York",
                BreakFast = 1,
                CheckIn = true,
                CardCvc = "123",
                CardExp = "12/25",
                CardNumber = "4111111111111111",
                CardType = "Visa",
                Cleaning = true,
                EmailAddress = "john.doe@example.com",
                Dinner = 1,
                FoodBill = 100,
                Gender = "male",
                NumberGuest = 2,
                LeavingTime = DateTime.Now,
                Lunch = 3,
                PaymentType = "Credit Card",
                PhoneNumber = "555-1234",
                RoomFloor = "10",
                RoomNumber = "1001",
                RoomType = "Deluxe",
                SSurprise = true,
                State = "NY",
                StreetAddress = "123 Main St",
                SupplyStatus = true,
                TotalBill = 500,
                Towel = true,
                ZipCode = "10001",
            });

        }

        private void loadReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Context.Reservations.Local.ToBindingList();
        }

        private void LoadKitchensStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Context.Kitchens.Local.ToBindingList();

        }

        private void loadFrontendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Context.Frontends.Local.ToBindingList();

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Context.SaveChanges();

        }
    }
}
