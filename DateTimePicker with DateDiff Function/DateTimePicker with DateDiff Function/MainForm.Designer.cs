
namespace DateTimePicker_with_DateDiff_Function
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCustName = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lstPayment = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbDeluxe = new System.Windows.Forms.RadioButton();
			this.rdbSuite = new System.Windows.Forms.RadioButton();
			this.rdbRegular = new System.Windows.Forms.RadioButton();
			this.cbbCapacity = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpIn = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpOut = new System.Windows.Forms.DateTimePicker();
			this.txtDays = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnCompute = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.lblPrompt = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(537, 61);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(513, 61);
			this.label1.TabIndex = 1;
			this.label1.Text = "CASA DE CAPILLO HOTEL";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Customer Name:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCustName
			// 
			this.txtCustName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCustName.Location = new System.Drawing.Point(122, 89);
			this.txtCustName.Name = "txtCustName";
			this.txtCustName.Size = new System.Drawing.Size(190, 23);
			this.txtCustName.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DimGray;
			this.panel2.Controls.Add(this.lstPayment);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Controls.Add(this.cbbCapacity);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(337, 61);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 280);
			this.panel2.TabIndex = 3;
			// 
			// lstPayment
			// 
			this.lstPayment.BackColor = System.Drawing.Color.DimGray;
			this.lstPayment.ForeColor = System.Drawing.Color.White;
			this.lstPayment.FormattingEnabled = true;
			this.lstPayment.ItemHeight = 15;
			this.lstPayment.Items.AddRange(new object[] {
									"Cash",
									"Check",
									"Credit Card"});
			this.lstPayment.Location = new System.Drawing.Point(12, 216);
			this.lstPayment.Name = "lstPayment";
			this.lstPayment.Size = new System.Drawing.Size(176, 49);
			this.lstPayment.TabIndex = 8;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbDeluxe);
			this.groupBox1.Controls.Add(this.rdbSuite);
			this.groupBox1.Controls.Add(this.rdbRegular);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(12, 71);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(176, 115);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Room Type:";
			// 
			// rdbDeluxe
			// 
			this.rdbDeluxe.Location = new System.Drawing.Point(50, 52);
			this.rdbDeluxe.Name = "rdbDeluxe";
			this.rdbDeluxe.Size = new System.Drawing.Size(77, 24);
			this.rdbDeluxe.TabIndex = 7;
			this.rdbDeluxe.TabStop = true;
			this.rdbDeluxe.Text = "De Luxe";
			this.rdbDeluxe.UseVisualStyleBackColor = true;
			// 
			// rdbSuite
			// 
			this.rdbSuite.Location = new System.Drawing.Point(50, 82);
			this.rdbSuite.Name = "rdbSuite";
			this.rdbSuite.Size = new System.Drawing.Size(77, 24);
			this.rdbSuite.TabIndex = 6;
			this.rdbSuite.TabStop = true;
			this.rdbSuite.Text = "Suite";
			this.rdbSuite.UseVisualStyleBackColor = true;
			// 
			// rdbRegular
			// 
			this.rdbRegular.Location = new System.Drawing.Point(50, 22);
			this.rdbRegular.Name = "rdbRegular";
			this.rdbRegular.Size = new System.Drawing.Size(77, 24);
			this.rdbRegular.TabIndex = 5;
			this.rdbRegular.TabStop = true;
			this.rdbRegular.Text = "Regular";
			this.rdbRegular.UseVisualStyleBackColor = true;
			// 
			// cbbCapacity
			// 
			this.cbbCapacity.BackColor = System.Drawing.Color.DimGray;
			this.cbbCapacity.ForeColor = System.Drawing.Color.White;
			this.cbbCapacity.FormattingEnabled = true;
			this.cbbCapacity.Items.AddRange(new object[] {
									"Single",
									"Double",
									"Family"});
			this.cbbCapacity.Location = new System.Drawing.Point(12, 42);
			this.cbbCapacity.Name = "cbbCapacity";
			this.cbbCapacity.Size = new System.Drawing.Size(176, 23);
			this.cbbCapacity.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(12, 189);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 1;
			this.label8.Text = "Type of Payment:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(12, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 1;
			this.label7.Text = "Room Capacity:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpIn
			// 
			this.dtpIn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dtpIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpIn.Location = new System.Drawing.Point(171, 126);
			this.dtpIn.Name = "dtpIn";
			this.dtpIn.Size = new System.Drawing.Size(141, 23);
			this.dtpIn.TabIndex = 1;
			this.dtpIn.ValueChanged += new System.EventHandler(this.DtpInValueChanged);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Check-in Date:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Check-out Date:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 183);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 23);
			this.label5.TabIndex = 1;
			this.label5.Text = "Total Days of Stay:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpOut
			// 
			this.dtpOut.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dtpOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpOut.Location = new System.Drawing.Point(171, 155);
			this.dtpOut.Name = "dtpOut";
			this.dtpOut.Size = new System.Drawing.Size(141, 23);
			this.dtpOut.TabIndex = 2;
			this.dtpOut.ValueChanged += new System.EventHandler(this.DtpOutValueChanged);
			// 
			// txtDays
			// 
			this.txtDays.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtDays.Location = new System.Drawing.Point(171, 184);
			this.txtDays.Name = "txtDays";
			this.txtDays.Size = new System.Drawing.Size(141, 23);
			this.txtDays.TabIndex = 3;
			this.txtDays.Text = "0";
			// 
			// txtTotal
			// 
			this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtTotal.Location = new System.Drawing.Point(171, 232);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(141, 23);
			this.txtTotal.TabIndex = 6;
			this.txtTotal.TabStop = false;
			this.txtTotal.Text = "0";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 231);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(116, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Total:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel3.Controls.Add(this.btnClose);
			this.panel3.Controls.Add(this.btnCompute);
			this.panel3.Controls.Add(this.btnClear);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 282);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(337, 59);
			this.panel3.TabIndex = 7;
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Location = new System.Drawing.Point(222, 14);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(91, 33);
			this.btnClose.TabIndex = 11;
			this.btnClose.Text = "Cl&ose";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// btnCompute
			// 
			this.btnCompute.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
			this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCompute.Location = new System.Drawing.Point(16, 14);
			this.btnCompute.Name = "btnCompute";
			this.btnCompute.Size = new System.Drawing.Size(91, 33);
			this.btnCompute.TabIndex = 9;
			this.btnCompute.Text = "&Compute";
			this.btnCompute.UseVisualStyleBackColor = true;
			this.btnCompute.Click += new System.EventHandler(this.BtnComputeClick);
			// 
			// btnClear
			// 
			this.btnClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Location = new System.Drawing.Point(119, 14);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(91, 33);
			this.btnClear.TabIndex = 10;
			this.btnClear.Text = "C&lear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// lblPrompt
			// 
			this.lblPrompt.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrompt.ForeColor = System.Drawing.Color.Red;
			this.lblPrompt.Location = new System.Drawing.Point(171, 258);
			this.lblPrompt.Name = "lblPrompt";
			this.lblPrompt.Size = new System.Drawing.Size(141, 23);
			this.lblPrompt.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(537, 341);
			this.Controls.Add(this.lblPrompt);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dtpOut);
			this.Controls.Add(this.dtpIn);
			this.Controls.Add(this.txtDays);
			this.Controls.Add(this.txtCustName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(216, 159);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Casa de Capillo Hotel";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblPrompt;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ListBox lstPayment;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbbCapacity;
		private System.Windows.Forms.RadioButton rdbRegular;
		private System.Windows.Forms.RadioButton rdbSuite;
		private System.Windows.Forms.RadioButton rdbDeluxe;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnCompute;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtDays;
		private System.Windows.Forms.DateTimePicker dtpOut;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpIn;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtCustName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
