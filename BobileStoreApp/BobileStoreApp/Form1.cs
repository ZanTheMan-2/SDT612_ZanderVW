namespace BobileStoreApp
{
    public partial class Form1 : Form
    {

        public List<Phone> phones = new List<Phone>();
        public Form1()
        {
            InitializeComponent();
        }
        // Event handler for the Add button click event
        private void AddBTN_Click(object sender, EventArgs e)
        {
            // Validate and add phone details to the list
            try
            {
                int mobileCode = int.Parse(MobileCodeTB.Text);
                string make = MakeTB.Text;
                int quantity = int.Parse(QuantityTB.Text);

                Phone phone = new Phone(mobileCode, make, quantity);
                phones.Add(phone);

                OutputTXT.Text = phone.GetPhoneDetails() + "\nRecord Added Successfully!";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter valid numbers for Mobile Code and Quantity.");
            }


        }
        // Event handler for the Delete button click event
        private void DeleteBTN_Click(object sender, EventArgs e)
        {
           

            // Validate and delete phone details from the list
            try
            {
                Phone phoneToDelete = phones.Find(p => p.MobileCode == int.Parse(MobileCodeTB.Text));
                if (phoneToDelete != null)
                {
                    phones.Remove(phoneToDelete);
                    MessageBox.Show("Phone record deleted successfully.");

                    MobileCodeTB.Clear();
                    MakeTB.Clear();
                    QuantityTB.Clear();
                }
                else
                {
                    MessageBox.Show("Phone record not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter a valid number for Mobile Code.");
            }
        }
        // Event handler for the Find button click event
        private void FindBTN_Click(object sender, EventArgs e)
        {
            // Validate and find phone details from the list
            try
            {
                Phone phoneToFInd = phones.Find(p => p.MobileCode == int.Parse(MobileCodeTB.Text));
                MessageBox.Show("Searching for Mobile Code.");
                if (phoneToFInd != null)
                {
                    OutputTXT.Text = phoneToFInd.GetPhoneDetails();
                }
                else
                {
                    MessageBox.Show("Phone record not found.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter a valid number for Mobile Code.");
            }
        }
    }
}
