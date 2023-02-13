using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5CNEW
{
    public partial class Form1 : Form
    {
        EventManager eventManager;
        public Form1()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            cmbCountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            cmbCountry.SelectedIndex = (int)Countries.Sverige;

            lblNumParticipants.Text = "0";
            lblTotalCost.Text = "0.00";
            lblTotalFees.Text = "0.00";
            lblProfit.Text = "0.00";
            lstParticipant.Items.Clear();

            grbAddParti.Enabled = false;
            grbNewEvent.Enabled = true;
        }

        private void UpdateGUI()
        {
            string[] strInfo = eventManager.Participants.GetParticipantInfo();

            if (strInfo != null)
            {
                lstParticipant.Items.Clear();
                lstParticipant.Items.AddRange(strInfo);
                lblNumParticipants.Text = lstParticipant.Items.Count.ToString();
            }

            double totalCost = eventManager.CalcTotalCost();
            lblTotalCost.Text = totalCost.ToString("0.00");
            lblNumParticipants.Text = eventManager.Participants.Count.ToString();

            double totalFees = eventManager.CalcTotalFees();
            lblTotalFees.Text = totalFees.ToString("0.00");
            lblProfit.Text = (totalFees - totalCost).ToString("0.00");
        }

        private void CreateEvent()
        {
            EventManager eventManager = new EventManager();


            this.Text = txtMaxNum.Text;

            bool costAmountsOK = ReadCostPerPerson();
            bool feeAmountOK = ReadFeePerPerson();

            if ((costAmountsOK) && (feeAmountOK))
            {
                grbAddParti.Enabled = true;
                MessageBox.Show($"Event created");
                UpdateGUI();
            }
        }

        private bool ReadCostPerPerson()
        {
            double amount = 0.0;
            bool ok = true;
            eventManager = new EventManager();

            if (double.TryParse(txtCostAmount.Text, out amount) && (amount >= 0.0))
            {
                eventManager.CostPerPerson = amount;
            }
            else
            {
                MessageBox.Show("Invalid cost amount. Please try again.");
                ok = false;
            }
            return ok;
        }

        private bool ReadFeePerPerson()
        {
            double amount = 0.0;
            bool ok = true;

            if (double.TryParse(txtFeeAmount.Text, out amount) && (amount >= 0.0))
            {
                eventManager.FeePerPerson = amount;
                ok = true;
            }
            else
            {
                MessageBox.Show("Invalid fee amount. Please try again.");
                ok = false;
            }
            return ok;
        }

        private void EmptyTextBoxes(GroupBox groupBox)
        {
            foreach (Control ctrl in groupBox.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = string.Empty;
            }
        }

        private bool ReadInput(ref Participant participant)
        {
            bool ok = ReadParticipantData(ref participant);
            if (ok)
            {
                eventManager.Participants.AddParticipant(participant);
            }
            else
            {
                string strMessage = "First namem, last name and city is requierd";
                MessageBox.Show(strMessage);
            }
            return ok;
        }

        private bool ReadParticipantData(ref Participant participant)
        {
            participant.FirstName = txtFirstName.Text;
            participant.LastName = txtLastName.Text;

            Address address = ReadAddress();

            participant.Address = address;
            bool ok = address.Validate();
            return ok;
        }

        private Address ReadAddress()
        {
            Address address = new Address();

            address.Street = txtStreet.Text;
            address.City = txtCity.Text;
            address.ZipCode = txtZipCode.Text;

            address.Country = (Countries)cmbCountry.SelectedIndex;

            return address;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            EmptyTextBoxes(grbAddParti);
            lstParticipant.Items.Clear();
            CreateEvent();
        }

        private void AddParticipant_Click(object sender, EventArgs e)
        {
            Participant participant = new Participant();
            if (ReadInput(ref participant))
            {
                UpdateGUI();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = lstParticipant.SelectedIndex;

            if (index < 0)
                return;

            Participant participant = eventManager.Participants.GetParticipantAt(index);
            if (ReadParticipantData(ref participant))
            {
                eventManager.Participants.ChangeParticipant(participant, index);
                UpdateGUI();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstParticipant.SelectedIndex;
            if (index < 0)
                return;

            eventManager.Participants.DeleteParticipant(index);
            UpdateGUI();
            
        }

        private void lstParticipant_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstParticipant.SelectedIndex;

            if (index >= 0)
            {
                Participant participant = eventManager.Participants.GetParticipantAt(index);

                txtFirstName.Text = participant.FirstName;
                txtLastName.Text = participant.LastName;
                txtStreet.Text = participant.Address.Street;
                txtCity.Text = participant.Address.City;
                txtZipCode.Text = participant.Address.ZipCode;

                cmbCountry.SelectedIndex = (int)participant.Address.Country;
            }
        }
    }
}
