using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSForm1
{
    public partial class frmMenu : Form
    {
        Form paymentForm;
        Employee currentUser;
        List<Product> cart = new List<Product>();
        double subtotal = 0;
        double tax, total;
        List<Auditorium> frontenacCinema = new List<Auditorium>()
            {
                new Auditorium(180, 0, 0, 0),
                new Auditorium(86, 0, 0, 0),
                new Auditorium(100, 0, 0, 0),
                new Auditorium(150, 0, 0, 0)
            };
        public frmMenu(Employee employee)
        {
            InitializeComponent();
            currentUser = employee;
            lblCurrentUser.Text = $"Signed in as: {currentUser.Name}";
        }
        public void AddItem()
        {
            lboOrder.Items.Clear();
            lboOrder.Items.AddRange(cart.ToArray());
            subtotal = 0;
            foreach (Product product in cart)
            {
                subtotal += product.Price;
            }
            tax = .09 * subtotal;
            total = subtotal + tax;
            lblSubtotal.Text = $"Subtotal: {subtotal:c}";
            lblTax.Text = $"Tax: {tax:c}";
            lblTotal.Text = $"Total: {total:c}";
            if(cart.Count == 0) { btnCompleteTransaction.Enabled = false; }
            else { btnCompleteTransaction.Enabled = true; }
        }
        public void ReserveSeat(byte theater, byte timeslot,  int numTickets)
        {
            theater--;
            if (timeslot == 1)
            {
                frontenacCinema[theater].MorningTix += numTickets;
            } else if (timeslot == 2)
            {
                frontenacCinema[theater].AfternoonTix += numTickets;

            } else if (timeslot == 3)
            {
                frontenacCinema[theater].EveningTix += numTickets;
            }
            CheckAvailability(theater, timeslot);
        }
        public void CheckAvailability(byte theater, byte timeslot)
        {
            Button toDisable = null;
            if (theater == 0)
            {
                if (timeslot == 1)
                {
                    if (frontenacCinema[theater].MorningTix >= frontenacCinema[theater].Capacity) toDisable = btnTheater1Morning;
                }
                else if (timeslot == 2)
                {
                    if (frontenacCinema[theater].AfternoonTix >= frontenacCinema[theater].Capacity) toDisable = btnTheater1Afternoon;
                }
                else if (timeslot == 3)
                {
                    if (frontenacCinema[theater].EveningTix >= frontenacCinema[theater].Capacity) toDisable = btnTheater1Evening;
                }
            } else if (theater == 1)
            {
                if (timeslot == 1)
                {
                    if (frontenacCinema[theater].MorningTix >= frontenacCinema[theater].Capacity) toDisable = btnTheater2Morning;
                }
                else if (timeslot == 2)
                {
                    if (frontenacCinema[theater].AfternoonTix >= frontenacCinema[theater].Capacity) toDisable = btnTheater2Afternoon;
                }
                else if (timeslot == 3)
                {
                    if (frontenacCinema[theater].EveningTix >= frontenacCinema[theater].Capacity) toDisable = btnTheater2Evening;
                }
            } else if (theater==2)
            {
                if (timeslot == 1)
                {
                    if (frontenacCinema[theater].MorningTix >= frontenacCinema[theater].Capacity) toDisable = btnTheater3Morning;
                }
                else if (timeslot == 2)
                {
                    if (frontenacCinema[theater].AfternoonTix >= frontenacCinema[theater].Capacity) toDisable = btnTheater3Afternoon;
                }
                else if (timeslot == 3)
                {
                    if (frontenacCinema[theater].EveningTix >= frontenacCinema[theater].Capacity) toDisable = btnTheater3Evening;
                }
            } else if (theater== 3)
            {
                if (timeslot == 1)
                {
                    if (frontenacCinema[theater].MorningTix >= frontenacCinema[theater].Capacity) toDisable = btnTheater4Morning;
                }
                else if (timeslot == 2)
                {
                    if (frontenacCinema[theater].AfternoonTix >= frontenacCinema[theater].Capacity) toDisable = btnTheater4Afternoon;
                }
                else if (timeslot == 3)
                {
                    if (frontenacCinema[theater].EveningTix >= frontenacCinema[theater].Capacity) toDisable = btnTheater4Evening;
                }
            }
            if(toDisable != null) toDisable.Enabled = false;
        }
        private void btnNavMain_Click(object sender, EventArgs e)
        {
            grpConcessionsMain.Visible = true;
            grpConcessionsCandy.Visible = false;
            grpConcessionsDrinks.Visible = false;
        }

        private void btnNavCandy_Click(object sender, EventArgs e)
        {
            grpConcessionsMain.Visible = false;
            grpConcessionsCandy.Visible = true;
            grpConcessionsDrinks.Visible = false;
        }

        private void btnNavDrinks_Click(object sender, EventArgs e)
        {
            grpConcessionsMain.Visible = false;
            grpConcessionsCandy.Visible = false;
            grpConcessionsDrinks.Visible = true;
        }

        private void btnCompleteTransaction_Click(object sender, EventArgs e)
        {
            paymentForm = new frmPurchase(cart, currentUser);
            paymentForm.ShowDialog();
        }

        //Concession Buttons
        private void btnMilkDuds_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(4, "Milk Duds"));
            AddItem();
        }

        private void btnSnoCaps_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(4, "Sno Caps"));
            AddItem();
        }

        private void btnJrMints_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(4, "Junior Mints"));
            AddItem();
        }

        private void btnTwizzlers_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(4, "Twizzlers"));
            AddItem();
        }

        private void btnSourPatchKids_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(4, "Sour Patch Kids"));
            AddItem();
        }

        private void btnMMs_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(4, "M&M's"));
            AddItem();
        }

        private void btnPeanutMMs_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(4, "Peanut M&M's"));
            AddItem();
        }

        private void btnBudLite_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(5.5, "Bud Lite"));
            AddItem();
        }

        private void btnZwickel_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(9, "Zwickel"));
            AddItem();
        }

        private void btnStlipa_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(9, "STLIPA"));
            AddItem();
        }

        private void btnChardonnay_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(9, "Chardonnay"));
            AddItem();
        }

        private void btnPinoGrigio_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(9, "Pino Grigio"));
            AddItem();
        }

        private void btnCabernet_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(9, "Cabernet"));
            AddItem();
        }

        private void btnSmallPopcorn_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(7, "Small Popcorn"));
            AddItem();
        }

        private void btnSmallSoda_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(5.5, "Small Soda"));
            AddItem();
        }

        private void btnSmallCombo_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(12, "Small Combo"));
            AddItem();
        }

        private void btnWaterBottle_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(4.5, "Water Bottle"));
            AddItem();
        }

        private void btnLargePopcorn_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(9, "Large Popcorn"));
            AddItem();
        }

        private void btnLargeSoda_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(6.5, "Large Soda"));
            AddItem();
        }

        private void btnLargeCombo_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(15, "Large Combo"));
            AddItem();
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(5, "Bottled Tea"));
            AddItem();
        }

        private void btnPretzel_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(5, "Pretzel"));
            AddItem();
        }

        private void btnNachos_Click(object sender, EventArgs e)
        {
            cart.Add(new Product(4, "Nachos"));
            AddItem();
        }
        //Ticket Buttons
        private void btnTheater1Morning_Click(object sender, EventArgs e)
        {
            cart.Add(new Ticket(10, "Ghstbsters, 12:45", 1));
            AddItem();
            ReserveSeat(1, 1, 1);
        }

        private void btnTheater1Afternoon_Click(object sender, EventArgs e)
        {
            cart.Add(new Ticket(10, "Ghstbsters, 3:45", 1));
            AddItem();
            ReserveSeat(1, 2, 1);
        }

        private void btnTheater1Evening_Click(object sender, EventArgs e)
        {
            cart.Add(new Ticket(10, "Ghstbsters, 6:45", 1));
            AddItem();
            ReserveSeat(1, 3, 1);
        }

        private void btnTheater2Morning_Click(object sender, EventArgs e)
        {
            cart.Add(new Ticket(10, "Ind. Jones, 12:50", 2));
            AddItem();
            ReserveSeat(2, 1, 1);
        }

        private void btnTheater2Afternoon_Click(object sender, EventArgs e)
        {
            cart.Add(new Ticket(10, "Ind. Jones, 12:50", 2));
            AddItem();
            ReserveSeat(2, 2, 1);
        }

        private void btnTheater2Evening_Click(object sender, EventArgs e)
        {
            cart.Add(new Ticket(10, "Ind. Jones, 12:50", 2));
            AddItem();
            ReserveSeat(2, 3, 1);
        }

        private void btnTheater3Morning_Click(object sender, EventArgs e)
        {
            cart.Add(new Ticket(10, "Star Wars, 1:00", 3));
            AddItem();
            ReserveSeat(3, 1, 1);
        }

        private void btnTheater3Afternoon_Click(object sender, EventArgs e)
        {
            cart.Add(new Ticket(10, "Star Wars, 4:00", 3));
            AddItem();
            ReserveSeat(3, 2, 1);
        }

        private void btnTheater3Evening_Click(object sender, EventArgs e)
        {
            cart.Add(new Ticket(10, "Star Wars, 7:00", 3));
            AddItem();
            ReserveSeat(3, 3, 1);
        }

        private void btnTheater4Morning_Click(object sender, EventArgs e)
        {
            cart.Add(new Ticket(10, "A. Powers, 1:15", 4));
            AddItem();
            ReserveSeat(4, 1, 1);
        }

        private void btnTheater4Afternoon_Click(object sender, EventArgs e)
        {
            cart.Add(new Ticket(10, "A. Powers, 4:15", 4));
            AddItem();
            ReserveSeat(4, 2, 1);
        }

        private void btnTheater4Evening_Click(object sender, EventArgs e)
        {
            cart.Add(new Ticket(10, "A. Powers, 7:15", 4));
            AddItem();
            ReserveSeat(4, 3, 1);
        }
        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnClear1_Click(object sender, EventArgs e)
        {
            try
            {
                cart.RemoveAt(lboOrder.SelectedIndex);
                AddItem();
            } catch(Exception ex) { }
            lboOrder.SelectedIndex = lboOrder.Items.Count - 1;
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            cart.Clear();
            AddItem();
        }
        private void frmMenu_Activated(object sender, EventArgs e)
        {
            if (paymentForm != null)
            {
                if (paymentForm.DialogResult == DialogResult.OK)
                {
                    cart.Clear();
                    AddItem();
                }
            }
        }
    }
}
