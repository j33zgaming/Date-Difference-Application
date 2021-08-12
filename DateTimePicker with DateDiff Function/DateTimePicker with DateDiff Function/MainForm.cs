using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DateTimePicker_with_DateDiff_Function
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			rdbRegular.Checked = false;
			rdbSuite.Checked = false;
			rdbDeluxe.Checked = false;
			
			dtpIn.CustomFormat = "";
			dtpOut.CustomFormat = "";
		}		
		
		void DtpInValueChanged(object sender, EventArgs e)
		{
			dtpIn.CustomFormat = "MM/dd/yyyy";
		}
		
		void DtpOutValueChanged(object sender, EventArgs e)
		{
			dtpOut.CustomFormat = "MM/dd/yyyy";
		}
		
		void BtnComputeClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtCustName.Text)) {
				MessageBox.Show("Please enter Customer's Name.", "Customer's Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtCustName.Focus();
			}
			else if (string.IsNullOrEmpty(cbbCapacity.Text)) {
				MessageBox.Show("Please select a Room Capacity.", "Room Capacity", MessageBoxButtons.OK, MessageBoxIcon.Information);
				cbbCapacity.Focus();
				lblPrompt.Text = "";
			}
			else if (!rdbRegular.Checked && !rdbSuite.Checked && !rdbDeluxe.Checked) {
				MessageBox.Show("Please select a Room Type.", "Room Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
				lblPrompt.Text = "";
			}
			else if (string.IsNullOrEmpty(lstPayment.Text)) {
				MessageBox.Show("Please select a Mode of Payment.", "Mode of Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
				lstPayment.Focus();
				lblPrompt.Text = "";
			}
			else
			{
				DateTime CheckIn = Convert.ToDateTime(dtpIn.Text);
				DateTime CheckOut = Convert.ToDateTime(dtpOut.Text);
				
				if (CheckOut == CheckIn) {
					txtDays.Text = "1";
				}
				else if (CheckOut < CheckIn) {
					MessageBox.Show("Please enter a valid Check-out Date.", "Invalid Dates Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					txtDays.Text = CheckOut.Subtract(CheckIn).Days.ToString();
				}
			}
			
			string RoomCap;
			double Rate = 0;
			double DaysOfStay;
			
			DaysOfStay = Convert.ToDouble(txtDays.Text);
			
			if (string.IsNullOrEmpty(txtDays.Text)) {
				txtDays.Text = "0";
			}
				if (cbbCapacity.SelectedIndex != -1)
				{
					RoomCap = cbbCapacity.SelectedItem.ToString();
				
					switch (RoomCap)
					{
						case "Single":
							if (rdbRegular.Checked == true) {
								Rate = 100.00;
							}
							if (rdbDeluxe.Checked == true) {
								Rate = 300.00;
							}
							if (rdbSuite.Checked == true) {
								Rate = 500.00;
							}
							break;
						case "Double":
							if (rdbRegular.Checked == true) {
								Rate = 200.00;
							}
							if (rdbDeluxe.Checked == true) {
								Rate = 500.00;
							}
							if (rdbSuite.Checked == true) {
								Rate = 800.00;
							}
							break;
						case "Family":
							if (rdbRegular.Checked == true) {
								Rate = 500.00;
							}
							if (rdbDeluxe.Checked == true) {
								Rate = 750.00;
							}
							if (rdbSuite.Checked == true) {
								Rate = 1000.00;
							}
							break;
					}
					double BasicRate = DaysOfStay * Rate;
					double AddCharge = 0;
					
					if (lstPayment.Text == "Check") {
						AddCharge = BasicRate * 0.05;
						lblPrompt.Text = "+ 5% additional charge.";
					}
					else if (lstPayment.Text == "Credit Card") {
						AddCharge = BasicRate * 0.1;
						lblPrompt.Text = "+ 10% additional charge.";
					}
					else
					{
						lblPrompt.Text = "No additional charge.";
					}

					double TotalCharge = BasicRate + AddCharge;
					txtTotal.Text = Convert.ToString(TotalCharge);		
			}
		}
		
		void BtnClearClick(object sender, EventArgs e)
		{
			txtCustName.Text = "";
			dtpIn.Value  = DateTime.Now;
			dtpOut.Value  = DateTime.Now;
			txtDays.Text = "0";
			txtTotal.Text = "0";
			lblPrompt.Text = "";
			cbbCapacity.Text = "";
			rdbRegular.Checked = false;
			rdbDeluxe.Checked = false;
			rdbSuite.Checked = false;
			lstPayment.ClearSelected();
		}
		
		void BtnCloseClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
