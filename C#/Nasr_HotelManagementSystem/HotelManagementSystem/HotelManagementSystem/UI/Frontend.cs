using Dapper;
using HotelManagementSystem.Context.FrontendReservation;
using HotelManagementSystem.Entities.FrontendReservation;
using MetroFramework.Drawing;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using static System.Windows.Forms.AxHost;
namespace HotelManagementSystem.UI
{
    public partial class Frontend : MetroForm
    {
        string AccountSid = "ACcb86dacb791bef978628a2e16b1f7a24";
        string AuthToken = "3f344a07336d2e0ac5e467f72a1e650d";
        string RecvPhoneNumber = "";
        FrontendReservationContext FrontendReservationContext = new FrontendReservationContext();
        public Frontend()
        {
            InitializeComponent();
            CenterToScreen();
            entryDatePicker.MinDate = DateTime.Today;
            depDatePicker.MinDate = DateTime.Today.AddDays(1);

            LoadForDataGridView();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();

            this.roomOccupiedListBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.roomOccupiedListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.roomOccupiedListBox_DrawItem);
            this.roomReservedListBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.roomReservedListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.roomReservedListBox_DrawItem);
        }



        private void roomOccupiedListBox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            this.roomOccupiedListBox.IntegralHeight = false;
            this.roomOccupiedListBox.ItemHeight = 25;
            e.DrawBackground();
            Font listBoxFont;
            Brush brush;

            int i = e.Index;

            listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
            brush = Brushes.Black;
            e.Graphics.DrawString(roomOccupiedListBox.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);

        }
        private void roomReservedListBox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            this.roomReservedListBox.IntegralHeight = false;
            this.roomReservedListBox.ItemHeight = 25;
            e.DrawBackground();
            Font listBoxFont;
            Brush brush;

            int i = e.Index;

            listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
            brush = Brushes.Black;
            e.Graphics.DrawString(roomReservedListBox.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);

        }


        private string getval;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Getval
        {
            get { return getval; }
            set { getval = value; }
        }

        public string towelS, cleaningS, surpriseS;

        public int foodBill;
        public string birthday = "";

        public string food_menu = "";
        public int totalAmount = 0;
        public int checkin = 0;
        public int foodStatus = 0;
        public Int32 primartyID = 0;
        public Boolean taskFinder = false;
        public Boolean editClicked = false;
        public string FPayment, FCnumber, FcardExpOne, FcardExpTwo, FCardCVC;
        private double finalizedTotalAmount = 0.0;
        private string paymentType;
        private string paymentCardNumber;
        private string MM_YY_Of_Card;
        private string CVC_Of_Card;
        private string CardType;

        private int lunch = 0; private int breakfast = 0; private int dinner = 0;
        private string cleaning; private string towel;
        private string surprise;

        private void MainTab_Load(object sender, EventArgs e)
        {
            foodSupplyCheckBox.Enabled = false;
            //FrontendReservationContext.Database.EnsureCreated();
            FrontendReservationContext.Reservations.Load();

        }

        public void foodMenuButton_Click(object sender, EventArgs e)
        {

            FoodMenu food_menu = new FoodMenu();
            if (taskFinder)
            {
                if (breakfast > 0)
                {
                    food_menu.breakfastCheckBox.Checked = true;
                    food_menu.breakfastQTY.Text = Convert.ToString(breakfast);
                }
                if (lunch > 0)
                {
                    food_menu.lunchCheckBox.Checked = true;

                    food_menu.lunchQTY.Text = Convert.ToString(lunch);
                }
                if (dinner > 0)
                {
                    food_menu.dinnerCheckBox.Checked = true;
                    food_menu.dinnerQTY.Text = Convert.ToString(dinner);
                }
                if (cleaning == "1")
                {
                    food_menu.cleaningCheckBox.Checked = true;
                }
                if (towel == "1")
                {
                    food_menu.towelsCheckBox.Checked = true;
                }
                if (surprise == "1")
                {
                    food_menu.surpriseCheckBox.Checked = true;
                }
            }
            food_menu.ShowDialog();

            breakfast = food_menu.BreakfastQ;
            lunch = food_menu.LunchQ;
            dinner = food_menu.DinnerQ;

            cleaning = food_menu.Cleaning.Replace(" ", string.Empty) == "Cleaning" ? "1" : "0";
            towel = food_menu.Towel.Replace(" ", string.Empty) == "Towels" ? "1" : "0";

            surprise = food_menu.Surprise.Replace(" ", string.Empty) == "Sweetestsurprise" ? "1" : "0";

            if (breakfast > 0 || lunch > 0 || dinner > 0)
            {
                int bfast = 7 * breakfast;
                int Lnch = 15 * lunch;
                int di_ner = 15 * dinner;
                foodBill = bfast + Lnch + di_ner;
            }
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (roomTypeComboBox.SelectedItem.Equals("Single"))
            {
                totalAmount = 149;
                floorComboBox.SelectedItem = "1";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Double"))
            {
                totalAmount = 299;
                floorComboBox.SelectedItem = "2";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Twin"))
            {
                totalAmount = 349;
                floorComboBox.SelectedItem = "3";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Duplex"))
            {
                totalAmount = 399;
                floorComboBox.SelectedItem = "4";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Suite"))
            {
                totalAmount = 499;
                floorComboBox.SelectedItem = "5";
            }
            int selectedTemp = 0;
            string selected;
            bool temp = int.TryParse(qtGuestComboBox.SelectedItem.ToString(), out selectedTemp);
            if (!temp)
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter # of guests first", "Error parsing", MessageBoxButtons.OK);
            }
            else
            {
                selected = qtGuestComboBox.SelectedItem.ToString();
                selectedTemp = Convert.ToInt32(selected);
                if (selectedTemp >= 3)
                {
                    totalAmount += (selectedTemp * 5);
                }
            }


        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editClicked = true;
            entryDatePicker.MinDate = new DateTime(2014, 4, 1);
            entryDatePicker.CustomFormat = "MM-dd-yyyy";
            entryDatePicker.Format = DateTimePickerFormat.Custom;

            depDatePicker.MinDate = new DateTime(2014, 4, 1);
            depDatePicker.CustomFormat = "MM-dd-yyyy";
            depDatePicker.Format = DateTimePickerFormat.Custom;

            //submitButton.Visible = false;
            submitButton.Visible = true;
            updateButton.Visible = true;
            deleteButton.Visible = true;
            resEditButton.Visible = true;

            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
        }


        private void finalizeButton_Click(object sender, EventArgs e)
        {
            if (breakfast == 0 && lunch == 0 && dinner == 0 && cleaning == "0" && towel == "0" && surprise == "0")
            {
                foodSupplyCheckBox.Checked = true;
            }
            updateButton.Enabled = true;

            FinalizePayment finalizebil = new FinalizePayment();
            finalizebil.totalAmountFromFrontend = totalAmount;
            finalizebil.foodBill = foodBill;
            if (taskFinder)
            {
                finalizebil.paymentComboBox.SelectedItem = FPayment.Replace(" ", string.Empty);
                finalizebil.phoneNComboBox.Text = FCnumber;
                finalizebil.monthComboBox.SelectedItem = FcardExpOne;
                finalizebil.yearComboBox.SelectedItem = FcardExpTwo;
                finalizebil.cvcComboBox.Text = FCardCVC;
            }

            finalizebil.ShowDialog();

            finalizedTotalAmount = finalizebil.FinalTotalFinalized;
            paymentType = finalizebil.PaymentType;
            paymentCardNumber = finalizebil.PaymentCardNumber;
            MM_YY_Of_Card = finalizebil.MM_YY_Of_Card1;
            CVC_Of_Card = finalizebil.CVC_Of_Card1;
            CardType = finalizebil.CardType1;

            //if (!editClicked)
            //{
            submitButton.Visible = true;
            //}
        }

        private void SendSMS(int secondUserID)
        {
            //creating an instance of twilio rest
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            string name = firstNameTextBox.Text + " " + lastNameTextBox.Text;

            string end_num = paymentCardNumber.Substring(paymentCardNumber.Length - Math.Min(4, paymentCardNumber.Length));

            if (smsCheckBox.Checked)
            {
                //building message for twilio
                string buildMesage = "Hello " + name + "! Your unique ID# " + secondUserID + " Total bill of $" + finalizedTotalAmount + " is charged on your card # ending-" + end_num;
                //creating message 
                var message = twilio.SendMessage("+12034562736", RecvPhoneNumber, buildMesage, "");
                //sending message
                Console.WriteLine(message.Sid);
                smsCheckBox.Text = "SMS Sent";
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            birthday = (monthComboBox.SelectedItem) + "-" + (dayComboBox.SelectedIndex + 1) + "-" + yearTextBox.Text;
            Int32 getIDBack = 0;
            FrontendReservationContext.Reservations.Add(new()
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                BirthDay = birthday,
                Gender = genderComboBox.SelectedItem.ToString(),
                PhoneNumber = phoneNumberTextBox.Text,
                EmailAddress = emailTextBox.Text,
                NumberGuest = qtGuestComboBox.SelectedIndex + 1,
                StreetAddress = addLabel.Text,
                AptSuite = aptTextBox.Text,
                City = cityTextBox.Text,
                State = stateComboBox.SelectedItem.ToString(),
                ZipCode = zipComboBox.Text,
                RoomType = roomTypeComboBox.SelectedItem.ToString(),
                RoomFloor = floorComboBox.SelectedItem.ToString(),
                RoomNumber = roomNComboBox.SelectedItem.ToString(),
                TotalBill = finalizedTotalAmount,
                PaymentType = paymentType,
                CardType = CardType,
                CardNumber = paymentCardNumber,
                CardExp = MM_YY_Of_Card,
                CardCvc = CVC_Of_Card,
                ArrivalTime = DateOnly.Parse(entryDatePicker.Text),
                LeavingTime = DateOnly.Parse(depDatePicker.Text),
                CheckIn = checkin == 1 ? true : false,
                BreakFast = breakfast,
                Lunch = lunch,
                Dinner = dinner,
                SupplyStatus = foodStatus == 1 ? true : false,
                Cleaning = cleaning == "1" ? true : false,
                Towel = towel == "1" ? true : false,
                SSurprise = surprise == "1" ? true : false,
                FoodBill = foodBill
            });

            FrontendReservationContext.SaveChanges();
            MessageBox.Show("Entry successfully inserted into database.adminf");
            //string query = "insert into reservation(first_name, last_name, birth_day, gender, phone_number, email_address, number_guest, street_address, apt_suite,city, state, zip_code," +
            //    " room_type, room_floor, room_number," +
            //    " total_bill,payment_type, card_type, " +
            //    "card_number,card_exp,card_cvc, arrival_time, leaving_time, " +
            //    "check_in, break_fast, lunch, dinner, supply_status, " +
            //    "cleaning, towel, s_surprise, food_bill) values('" + firstNameTextBox.Text +
            //  "', '" + lastNameTextBox.Text + "', '" + birthday + "', '" + genderComboBox.SelectedItem + "', '" + phoneNumberTextBox.Text + "', '" + emailTextBox.Text +
            //  "', '" + (qtGuestComboBox.SelectedIndex + 1) + "', '" + addLabel.Text + "', '" + aptTextBox.Text + "', '" + cityTextBox.Text +
            //  "', '" + stateComboBox.SelectedItem + "', '" + zipComboBox.Text + "', '" + roomTypeComboBox.SelectedItem + "', '" + floorComboBox.SelectedItem +
            //  "', '" + roomNComboBox.SelectedItem + "', '" + finalizedTotalAmount + "', '" + paymentType +
            //  "', '" + CardType + "','" + paymentCardNumber + "','" + MM_YY_Of_Card + "','" + CVC_Of_Card + "', '" + entryDatePicker.Text + "', '" + depDatePicker.Text + "','" + checkin +
            //  "', '" + breakfast + "','" + lunch + "','" + dinner + "', '" + foodStatus + "', '" + Convert.ToInt32(cleaning) + "', '" + Convert.ToInt32(towel) + "', '" + Convert.ToInt32(surprise) + "','" + foodBill + "');";
            //query += "SELECT CAST(scope_identity() AS int)";
            //SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);

            //SqlCommand query_table = new SqlCommand(query, connection);
            //try
            //{
            //    connection.Open();
            //getIDBack = (Int32)query_table.ExecuteScalar();

            //string userID = Convert.ToString(getIDBack);
            //SendSMS(getIDBack);
            //MetroFramework.MetroMessageBox.Show(this, "Entry successfully inserted into database. " + "\n\n" +
            //        "Provide this unique ID to the customer." + "\n\n" +
            //    "USER UNIQUE ID: " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);

            //    connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            submitButton.Visible = false;
            updateButton.Visible = false;
            deleteButton.Visible = false;
            resEditButton.Visible = false;
            reset_frontend();
        }
        public void ClearAllTextBoxes(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    ClearAllTextBoxes(control);
                }
            }
        }
        public void ClearAllComboBox(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control == roomTypeComboBox)
                {
                    continue;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                if (control.HasChildren)
                {
                    ClearAllComboBox(control);
                }
            }
        }
        private void reset_frontend()
        {
            try
            {

                resEditButton.Items.Clear();
                checkinCheckBox.Checked = false;
                foodSupplyCheckBox.Checked = false;

                ClearAllComboBox(this);
                ClearAllTextBoxes(this);

                ComboBoxItemsFromDataBase();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void frontend_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (FrontendReservationContext.Reservations.Any(r => r.Id == primartyID))
            {
                //    string query = "delete from reservation where Id = '" + primartyID + "'";
                //    SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);
                FrontendReservationContext.Reservations.Remove(FrontendReservationContext.Reservations.Where(r => r.Id == primartyID).FirstOrDefault());
                FrontendReservationContext.SaveChanges();
                MessageBox.Show($"Successfully removed reservation with ID: {primartyID}");
                //    SqlCommand query_table = new SqlCommand(query, connection);
                //    SqlDataReader reader;
                //    try
                //    {
                //        connection.Open();
                //        reader = query_table.ExecuteReader();

                //        MetroFramework.MetroMessageBox.Show(this, "Reservation For the UNIQUE USER ID of: " + "\n\n" +
                //    " " + primartyID + " is DELETED.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                //        connection.Close();

                //    }
                //    catch (Exception ex)
                //    {
                //        MetroFramework.MetroMessageBox.Show(this, "Selected ID doesn't exist." + ex.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                //    }
            }
            else
            {
                MessageBox.Show(this, "Selected ID doesn't exist.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
             birthday = (monthComboBox.SelectedItem) + "-" + (dayComboBox.SelectedIndex + 1) + "-" + yearTextBox.Text;
            // MessageBox.Show(Convert.ToString(cleaning) + " " + Convert.ToString(towel) + " " + Convert.ToString(surprise));
            // string query = "update reservation set first_name ='" + firstNameTextBox.Text +
            //   "', last_name ='" + lastNameTextBox.Text + "', birth_day='" + birthday + "', gender='" + genderComboBox.SelectedItem + "', phone_number='" + phoneNumberTextBox.Text + "', email_address='" + emailTextBox.Text +
            //   "', number_guest='" + (qtGuestComboBox.SelectedIndex + 1) + "', street_address='" + addLabel.Text + "', apt_suite='" + aptTextBox.Text + "', city='" + cityTextBox.Text +
            //   "', state='" + stateComboBox.SelectedItem + "', zip_code='" + zipComboBox.Text + "', room_type='" + roomTypeComboBox.SelectedItem + "', room_floor='" + floorComboBox.SelectedItem +
            //   "', room_number='" + roomNComboBox.SelectedItem + "', total_bill='" + finalizedTotalAmount + "', payment_type='" + paymentType +
            //   "', card_type ='" + CardType + "', card_number='" + paymentCardNumber + "',card_exp='" + MM_YY_Of_Card + "', card_cvc='" + CVC_Of_Card + "', arrival_time='" + entryDatePicker.Text + "', leaving_time='" + depDatePicker.Text + "', break_fast='" + breakfast +
            //   "', check_in='" + checkin + "', lunch='" + lunch + "', dinner='" + dinner + "', supply_status='" + foodStatus + "',cleaning='" + Convert.ToInt32(cleaning) + "',towel='" + Convert.ToInt32(towel) + "',s_surprise='" + Convert.ToInt32(surprise) + "',food_bill='" + foodBill + "' WHERE Id = '" +
            //   + "';";
            var ExistingReservation = FrontendReservationContext.Reservations.Where(r => r.Id == primartyID).FirstOrDefault();
            if (ExistingReservation != null)
            {
                ExistingReservation.FirstName = firstNameTextBox.Text;
                ExistingReservation.LastName = lastNameTextBox.Text;
                ExistingReservation.BirthDay = birthday;
                ExistingReservation.Gender = genderComboBox.SelectedItem.ToString();
                ExistingReservation.PhoneNumber = phoneNumberTextBox.Text;
                ExistingReservation.EmailAddress = emailTextBox.Text;
                ExistingReservation.NumberGuest = qtGuestComboBox.SelectedIndex + 1;
                ExistingReservation.StreetAddress = addLabel.Text;
                ExistingReservation.AptSuite = aptTextBox.Text;
                ExistingReservation.City = cityTextBox.Text;
                ExistingReservation.State = stateComboBox.SelectedItem.ToString();
                ExistingReservation.ZipCode = zipComboBox.Text;
                ExistingReservation.RoomType = roomTypeComboBox.SelectedItem.ToString();
                ExistingReservation.RoomFloor = floorComboBox.SelectedItem.ToString();
                ExistingReservation.RoomNumber = roomNComboBox.SelectedItem.ToString();
                ExistingReservation.TotalBill = finalizedTotalAmount;
                ExistingReservation.PaymentType = paymentType;
                ExistingReservation.CardType = CardType;
                ExistingReservation.CardNumber = paymentCardNumber;
                ExistingReservation.CardExp = MM_YY_Of_Card;
                ExistingReservation.CardCvc = CVC_Of_Card;
                ExistingReservation.ArrivalTime = DateOnly.Parse(entryDatePicker.Text);
                ExistingReservation.LeavingTime = DateOnly.Parse(depDatePicker.Text);
                ExistingReservation.CheckIn = checkin == 1 ? true : false;
                ExistingReservation.BreakFast = breakfast;
                ExistingReservation.Lunch = lunch;
                ExistingReservation.Dinner = dinner;
                ExistingReservation.SupplyStatus = foodStatus == 1 ? true : false;
                ExistingReservation.Cleaning = cleaning == "1" ? true : false;
                ExistingReservation.Towel = towel == "1" ? true : false;
                ExistingReservation.SSurprise = surprise == "1" ? true : false;
                ExistingReservation.FoodBill = foodBill;
            }
           
            FrontendReservationContext.SaveChanges();
            MessageBox.Show("Entry successfully updated into database. For the UNIQUE USER ID of: " + primartyID);

            // SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);

            // SqlCommand query_table = new SqlCommand(query, connection);
            // SqlDataReader reader;
            // try
            // {
            //     connection.Open();
            //     string userID = Convert.ToString(primartyID);
            //     reader = query_table.ExecuteReader();

            //     MetroFramework.MetroMessageBox.Show(this, "Entry successfully updated into database. For the UNIQUE USER ID of: " + "\n\n" +
            //     " " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //     SendSMS(primartyID);
            //     while (reader.Read())
            //     {

            //     }
            //     connection.Close();
            // }
            // catch (Exception ex)
            // {
            //     MessageBox.Show(ex.Message);
            // }

            // ComboBoxItemsFromDataBase();

            reset_frontend();
            LoadForDataGridView();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }

        private void checkinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkinCheckBox.Checked)
            {
                checkinCheckBox.Text = "Checked in";
                checkin = 1;
            }
            else
            {
                checkin = 0;
                checkinCheckBox.Text = "Check in ?";
            }
        }

        private void resEditButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbConnection conn = FrontendReservationContext.Database.GetDbConnection();
            getChecked();
            string getQuerystring = resEditButton.Text.Substring(0, 3).Replace(" ", string.Empty);
            MessageBox.Show("ID+" + getQuerystring);
            //var reservation = FrontendReservationContext.Reservations.Where(r => r.Id == Convert.ToInt32(getQuerystring)).FirstOrDefault();
            var reservation = conn.Query<dynamic>("Select * from reservations where Id= @Id", new { Id = Convert.ToInt32(getQuerystring) }).FirstOrDefault();

            if (reservation == null)
            {
                MessageBox.Show("Selected ID doesn't exist.");
                return;
            }
            //  string query = "Select * from reservation where Id= '" + getQuerystring + "'";

            //  SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);
            //  SqlCommand query_table = new SqlCommand(query, connection);
            //  SqlDataReader reader;
            //  try
            //  {
            //      connection.Open();
            //      reader = query_table.ExecuteReader();
            //      while (reader.Read())
            //      {
            //          taskFinder = true;

            string ID = reservation.Id.ToString();
            string first_name = reservation.FirstName.ToString();
            string last_name = reservation.LastName.ToString();
            string birth_day = reservation.BirthDay.ToString();
            string gender = reservation.Gender.ToString();
            string phone_number = reservation.PhoneNumber.ToString();
            string email_address = reservation.EmailAddress.ToString();
            string number_guest = reservation.NumberGuest.ToString();
            string street_address = reservation.StreetAddress.ToString();
            string apt_suite = reservation.AptSuite.ToString();
            string city = reservation.City.ToString();
            string state = reservation.State.ToString();
            string zip_code = reservation.ZipCode.ToString();
            string room_type = reservation.RoomType.ToString();
            string room_floor = reservation.RoomFloor.ToString();
            string room_number = reservation.RoomNumber.ToString();

            string payment_type = reservation.PaymentType.ToString();
            string card_number = reservation.CardNumber.ToString();
            string card_exp = reservation.CardExp.ToString();
            string card_cvc = reservation.CardCvc.ToString();

            string _cleaning = reservation.Cleaning.ToString();
            string _towel = reservation.Towel.ToString();
            string _surprise = reservation.SSurprise.ToString();

            if (_cleaning == "True")
            {
                cleaning = "1";
            }
            else { cleaning = "0"; }

            if (_towel == "True")
            {
                towel = "1";
            }
            else { towel = "0"; }
            if (_surprise == "True")
            {
                surprise = "1";
            }
            else
            {
                surprise = "0";
            }
            roomNComboBox.Items.Add(room_number);
            roomNComboBox.SelectedItem = room_number;

            FPayment = payment_type; FCnumber = card_number;
            FCardCVC = card_cvc; FcardExpOne = card_exp.Substring(0, card_exp.IndexOf('/'));
            FcardExpTwo = card_exp.Substring(card_exp.Length - Math.Min(2, card_exp.Length));
            string check_in = reservation.CheckIn.ToString();

            string supply_status = reservation.SupplyStatus.ToString();
            string food_billD = reservation.FoodBill.ToString();

            string arrival_date = reservation.ArrivalTime.ToString("MM-dd-yyyy").Replace(" ", string.Empty);
            entryDatePicker.Value = Convert.ToDateTime(arrival_date);

            string leaving_date = reservation.LeavingTime.ToString("MM-dd-yyyy").Replace(" ", string.Empty);
            depDatePicker.Value = Convert.ToDateTime(leaving_date);
            entryDatePicker.Value.ToShortDateString();
            depDatePicker.Value.ToShortDateString();

            string _breakfast = reservation.BreakFast.ToString();
            string _lunch = reservation.Lunch.ToString();
            string _dinner = reservation.Dinner.ToString();

            double Num;
            bool isNum = double.TryParse(_lunch, out Num);
            if (isNum)
            {
                lunch = Int32.Parse(_lunch);
            }
            else
            {
                lunch = 0;
            }
            isNum = double.TryParse(_breakfast, out Num);
            if (isNum)
            {
                breakfast = Int32.Parse(_breakfast);
            }
            else
            {
                breakfast = 0;
            }
            isNum = double.TryParse(_dinner, out Num);
            if (isNum)
            {
                dinner = Int32.Parse(_dinner);
            }
            else
            {
                dinner = 0;
            }



            foodBill = Convert.ToInt32(food_billD);

            if (supply_status == "True")
            {
                foodSupplyCheckBox.Checked = true;
            }
            else
            {
                foodSupplyCheckBox.Checked = false;
            }


            firstNameTextBox.Text = first_name;
            lastNameTextBox.Text = last_name;
            phoneNumberTextBox.Text = phone_number;
            genderComboBox.SelectedItem = gender;

            monthComboBox.SelectedItem = birth_day.Substring(0, birth_day.IndexOf('-'));
            dayComboBox.SelectedItem = birth_day.Substring(birth_day.IndexOf('-') + 1, 2);
            yearTextBox.Text = birth_day.Substring(birth_day.Length - Math.Min(4, birth_day.Length));

            emailTextBox.Text = email_address;
            qtGuestComboBox.SelectedItem = number_guest;
            addLabel.Text = street_address;
            aptTextBox.Text = apt_suite;
            cityTextBox.Text = city;
            stateComboBox.SelectedItem = state;
            zipComboBox.Text = zip_code;
            roomTypeComboBox.SelectedItem = room_type.Replace(" ", string.Empty);
            floorComboBox.SelectedItem = room_floor.Replace(" ", string.Empty);
            roomNComboBox.SelectedItem = room_number.Replace(" ", string.Empty);

            if (check_in == "True")
            {
                checkinCheckBox.Checked = true;
            }
            else
            {
                checkinCheckBox.Checked = false;
            }


            primartyID = Convert.ToInt32(ID);
        }
        
              
              
        

        private void ComboBoxItemsFromDataBase()
        {
            //string query = "Select * from reservation";
            //SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);

            //SqlCommand query_table = new SqlCommand(query, connection);
            //SqlDataReader reader;
            //try
            //{
            //    connection.Open();
            //    reader = query_table.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        string ID = reader["ID"].ToString();
            //        string first_name = reader["first_name"].ToString();
            //        string last_name = reader["last_name"].ToString();
            //        string phone_number = reader["phone_number"].ToString();
            //        resEditButton.Items.Add(ID + "  | " + first_name + "  " + last_name + " | " + phone_number);

            DbConnection conn = FrontendReservationContext.Database.GetDbConnection();
            //var Result = FrontendReservationContext.Reservations.Select(x => new
            //{
            //    x.Id,
            //    x.FirstName,
            //    x.LastName,
            //    x.PhoneNumber
            //}).ToList();
            
            var Result = conn.Query<dynamic>("Select Id, FirstName, LastName, PhoneNumber from reservations").ToList();

            foreach (var item in Result)
            {
                resEditButton.Items.Add(item.Id + "  | " + item.FirstName + "  " + item.LastName + " | " + item.PhoneNumber);
            }

            //    }
            //    connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void LoadForDataGridView()
        {
            //SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);
            //SqlCommand query = new SqlCommand("Select * from reservation", connection);
            //try
            //{
            //    connection.Open();
            //    SqlDataAdapter dataAdapter = new SqlDataAdapter(query);
            //    DataTable dataTable = new DataTable();
            //    dataAdapter.Fill(dataTable);

            DbConnection conn = FrontendReservationContext.Database.GetDbConnection();

            FrontendReservationContext.Reservations.Load();
            BindingSource bindingSource = new BindingSource();
            //bindingSource.DataSource = FrontendReservationContext.Reservations.Local.ToBindingList();
            bindingSource.DataSource = conn.Query<dynamic>("Select * from reservations").ToList();
            resTotalDataGridView.DataSource = bindingSource;
            FrontendReservationContext.SaveChanges();
            //    dataAdapter.Update(dataTable);
            //    connection.Close();
            //}
            //catch (Exception)
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Error loading data", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
            //}
        }

        private void foodSupplyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (foodSupplyCheckBox.Checked)
            {
                foodSupplyCheckBox.Text = "Food/Supply: Complete";
                foodStatus = 1;
            }
            else
            {
                foodStatus = 0;
                foodSupplyCheckBox.Text = "Food/Supply status?";
            }
        }

        private void GetOccupiedRoom()
        {
            //roomOccupiedListBox.Items.Clear();
            //string query = "Select * from reservation where check_in = '" + "True" + "';";
            DbConnection conn = FrontendReservationContext.Database.GetDbConnection();

            //var rooms = FrontendReservationContext.Reservations.Where(r => r.CheckIn == true).Select(r => new
            //{
            //    r.RoomNumber,
            //    r.RoomType,
            //    r.Id,
            //    r.FirstName,
            //    r.LastName,
            //    r.PhoneNumber,
            //    r.ArrivalTime,
            //    r.LeavingTime
            //}).ToList();
            
            var rooms = conn.Query<dynamic>("Select RoomNumber, RoomType, Id, FirstName, LastName, PhoneNumber from reservations where CheckIn = @checkin", new { checkin = true }).ToList();
            foreach (var room in rooms)
            {
                roomOccupiedListBox.Items.Add("[" + room.RoomNumber.Replace(" ", string.Empty) + "]" +
                    " " + room.RoomType.Replace(" ", string.Empty) +
                    " " + room.Id.ToString().Replace(" ", string.Empty) +
                    " " + "[" + room.FirstName.Replace(" ", string.Empty) +
                    " " + room.LastName.Replace(" ", string.Empty) + "]" +
                    " " + room.PhoneNumber.Replace(" ", string.Empty));
            }
            //SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);

            //SqlCommand query_table = new SqlCommand(query, connection);
            //SqlDataReader reader;
            //try
            //{
            //    connection.Open();
            //    reader = query_table.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        string room_number = reader["room_number"].ToString();
            //        string room_type = reader["room_type"].ToString();
            //        string ID = reader["ID"].ToString();
            //        string first_name = reader["first_name"].ToString();
            //        string last_name = reader["last_name"].ToString();
            //        string phone_number = reader["phone_number"].ToString();
            //        string arrival_time = reader["arrival_time"].ToString();
            //        string dep_time = reader["leaving_time"].ToString();
            //        roomOccupiedListBox.Items.Add("[" + room_number.Replace(" ", string.Empty) + "]" +
            //            " " + room_type.Replace(" ", string.Empty) +
            //            " " + ID.Replace(" ", string.Empty) +
            //            " " + "[" + first_name.Replace(" ", string.Empty) +
            //            " " + last_name.Replace(" ", string.Empty) + "]" +
            //            " " + phone_number.Replace(" ", string.Empty));
            //    }
            //    connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void ReservedRoom()
        {
            roomReservedListBox.Items.Clear();

            DbConnection conn = FrontendReservationContext.Database.GetDbConnection();
            //var rooms = FrontendReservationContext.Reservations.Where(r => r.CheckIn == false).Select(r => new
            //{
            //    r.RoomNumber,
            //    r.RoomType,
            //    r.Id,
            //    r.FirstName,
            //    r.LastName,
            //    r.PhoneNumber,
            //    r.ArrivalTime,
            //    r.LeavingTime
            //}).ToList();
            
            var rooms = conn.Query<dynamic>("Select RoomNumber, RoomType, Id, FirstName, LastName, PhoneNumber from reservations where CheckIn = @checkin", new { checkin = false }).ToList();

            foreach (var room in rooms)
            {
                roomReservedListBox.Items.Add("[" + room.RoomNumber.Replace(" ", string.Empty) + "]" +
                    " " + room.RoomType.Replace(" ", string.Empty) +
                    " " + room.Id.ToString().Replace(" ", string.Empty) +
                    " " + "[" + room.FirstName.Replace(" ", string.Empty) +
                    " " + room.LastName.Replace(" ", string.Empty) + "]" +
                    " " + room.PhoneNumber.Replace(" ", string.Empty));
            }

            //string query = "Select * from reservation where check_in = '" + "False" + "';";
            //SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);
            //SqlCommand query_table = new SqlCommand(query, connection);
            //SqlDataReader reader;
            //try
            //{
            //    connection.Open();
            //    reader = query_table.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        string room_number = reader["room_number"].ToString();
            //        string room_type = reader["room_type"].ToString();
            //        string ID = reader["ID"].ToString();
            //        string first_name = reader["first_name"].ToString();
            //        string last_name = reader["last_name"].ToString();
            //        string phone_number = reader["phone_number"].ToString();

            //        string arrival_date = Convert.ToDateTime(reader["arrival_time"]).ToString("MM-dd-yyyy");
            //        string leaving_date = Convert.ToDateTime(reader["leaving_time"]).ToString("MM-dd-yyy");

            //        roomReservedListBox.Items.Add("[" + room_number.Replace(" ", string.Empty) + "]" +
            //            " " + room_type.Replace(" ", string.Empty) +
            //            " " + ID.Replace(" ", string.Empty) +
            //            " " + first_name.Replace(" ", string.Empty) +
            //            " " + last_name.Replace(" ", string.Empty) +
            //            " " + phone_number.Replace(" ", string.Empty) +
            //            " " + arrival_date.Replace(" ", string.Empty) +
            //            " " + leaving_date.Replace(" ", string.Empty));
            //    }
            //    connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }


        private void getChecked()
        {
            //List<string> TakenRoomList = new List<string>();

            //string query = "Select room_number from reservation where check_in = '" + "True" + "';";
            DbConnection conn = FrontendReservationContext.Database.GetDbConnection();
            //var TakenRoomList = FrontendReservationContext.Reservations.Where(r => r.CheckIn == true).Select(r => r.RoomNumber == " " ? string.Empty : r.RoomNumber).ToList();
            var TakenRoomList = conn.Query<string>("Select RoomNumber from reservations where CheckIn = @checkin", new { checkin = true }).ToList();
            //SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);

            //SqlCommand query_table = new SqlCommand(query, connection);

            //SqlDataReader reader;
            //try
            //{
            //    connection.Open();
            //    reader = query_table.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        string room_number = reader["room_number"].ToString();
            //        TakenRoomList.Add(room_number.Replace(" ", string.Empty));
            //    }
            //    connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            foreach (string roomList in TakenRoomList)
            {
                if (roomNComboBox.Items.Contains(roomList))
                {

                    int temp = roomNComboBox.Items.IndexOf(roomList);
                    roomNComboBox.Items.RemoveAt(temp);
                }
            }
        }

        private void phoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            RecvPhoneNumber = "+1" + phoneNumberTextBox.Text.Replace(" ", string.Empty);
            long getphn = Convert.ToInt64(phoneNumberTextBox.Text);
            string formatString = String.Format("{0:(000)000-0000}", getphn);
            phoneNumberTextBox.Text = formatString;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            DbConnection conn = FrontendReservationContext.Database.GetDbConnection();
            //SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.frontend_reservationConnectionString);

            //  connection.Open();
            FrontendReservationContext.Reservations.Load();
            //  string query =                                           "Select * from reservation where Id like '%" + searchTextBox.Text + "%' OR last_name like '%" + searchTextBox.Text + "%' OR first_name like '%" + searchTextBox.Text + "%' OR gender like '%" + searchTextBox.Text + "%' OR state like '%" + searchTextBox.Text + "%' OR city like '%" + searchTextBox.Text + "%' OR room_number like '%" + searchTextBox.Text + "%' OR room_type like '%" + searchTextBox.Text + "%' OR email_address like '%" + searchTextBox.Text + "%' OR phone_number like '%" + searchTextBox.Text + "%'";
    //        var result = FrontendReservationContext.Reservations.FromSqlInterpolated($@"
    //Select * from Reservations 
    //where Id like {searchTextBox.Text} 
    //OR LastName like {searchTextBox.Text} 
    //OR FirstName like {searchTextBox.Text} 
    //OR gender like {searchTextBox.Text} 
    //OR state like {searchTextBox.Text} 
    //OR city like {searchTextBox.Text} 
    //OR RoomNumber like {searchTextBox.Text} 
    //OR RoomType like {searchTextBox.Text} 
    //OR EmailAddress like {searchTextBox.Text} 
    //OR PhoneNumber like {searchTextBox.Text}").ToList();

            var result = conn.Query<dynamic>(@"Select * from reservations
            where Id like @searchText OR 
            LastName like @searchText OR 
            FirstName like @searchText 
            OR gender like @searchText 
            OR state like @searchText 
            OR city like @searchText 
            OR RoomNumber like @searchText 
            OR RoomType like @searchText 
            OR EmailAddress like @searchText 
            OR PhoneNumber like @searchText",
new { searchText = "%" + searchTextBox.Text + "%" }).ToList();
            //  SqlCommand com = new SqlCommand(query, connection);
            //  SqlDataAdapter data_adapter = new SqlDataAdapter(query, connection);
            //  DataTable data_table = new DataTable();

            //  data_adapter.Fill(data_table);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = result;
            searchDataGridView.DataSource = bindingSource;

            //  data_adapter.Update(data_table);
            if (result.Count > 0)
            {
                searchButton.Location = new Point(752, 7);
                searchTextBox.Location = new Point(68, 7);
                searchDataGridView.Visible = true;
                SearchError.Visible = false;
            }
            else
            {
                searchDataGridView.Visible = false;
                SearchError.Visible = true;
                SearchError.Text = "SORRY DUDE :(" + "\n"
                    + "I ran out of gas trying to search for " + searchTextBox.Text + "\n"
                + "I sure will find it next time.";
            }
            //  SqlDataReader reader;
            //  reader = com.ExecuteReader();
            //  if (reader.HasRows)
            //  {
            //      reader.Read();
            //      searchButton.Location = new Point(752, 7);
            //      searchTextBox.Location = new Point(68, 7);
            //      searchDataGridView.Visible = true;
            //      SearchError.Visible = false;

            //  }
            //  else
            //  {
            //      searchDataGridView.Visible = false;
            //      SearchError.Visible = true;
            //      SearchError.Text = "SORRY DUDE :(" +"\n"
            //          +"I ran out of gas trying to search for "+ searchTextBox.Text +"\n"
            //      +"I sure will find it next time."; 
            //  }
            FrontendReservationContext.SaveChanges();
        }

    }
}
