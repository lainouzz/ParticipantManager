namespace Assignment5CNEW
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbNewEvent = new System.Windows.Forms.GroupBox();
            this.txtFeeAmount = new System.Windows.Forms.TextBox();
            this.txtCostAmount = new System.Windows.Forms.TextBox();
            this.txtMaxNum = new System.Windows.Forms.TextBox();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.txtFees = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbAddParti = new System.Windows.Forms.GroupBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.AddParticipant = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lstParticipant = new System.Windows.Forms.ListBox();
            this.grbEconomy = new System.Windows.Forms.GroupBox();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblNumParticipants = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbNewEvent.SuspendLayout();
            this.grbAddParti.SuspendLayout();
            this.grbEconomy.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNewEvent
            // 
            this.grbNewEvent.Controls.Add(this.txtFeeAmount);
            this.grbNewEvent.Controls.Add(this.txtCostAmount);
            this.grbNewEvent.Controls.Add(this.txtMaxNum);
            this.grbNewEvent.Controls.Add(this.btnCreateEvent);
            this.grbNewEvent.Controls.Add(this.txtFees);
            this.grbNewEvent.Controls.Add(this.txtAmount);
            this.grbNewEvent.Controls.Add(this.label3);
            this.grbNewEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNewEvent.Location = new System.Drawing.Point(12, 12);
            this.grbNewEvent.Name = "grbNewEvent";
            this.grbNewEvent.Size = new System.Drawing.Size(288, 151);
            this.grbNewEvent.TabIndex = 0;
            this.grbNewEvent.TabStop = false;
            this.grbNewEvent.Text = "New Event";
            // 
            // txtFeeAmount
            // 
            this.txtFeeAmount.Location = new System.Drawing.Point(182, 85);
            this.txtFeeAmount.Name = "txtFeeAmount";
            this.txtFeeAmount.Size = new System.Drawing.Size(100, 22);
            this.txtFeeAmount.TabIndex = 6;
            // 
            // txtCostAmount
            // 
            this.txtCostAmount.Location = new System.Drawing.Point(182, 56);
            this.txtCostAmount.Name = "txtCostAmount";
            this.txtCostAmount.Size = new System.Drawing.Size(100, 22);
            this.txtCostAmount.TabIndex = 5;
            // 
            // txtMaxNum
            // 
            this.txtMaxNum.Location = new System.Drawing.Point(85, 24);
            this.txtMaxNum.Name = "txtMaxNum";
            this.txtMaxNum.Size = new System.Drawing.Size(197, 22);
            this.txtMaxNum.TabIndex = 4;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(85, 116);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(97, 29);
            this.btnCreateEvent.TabIndex = 3;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // txtFees
            // 
            this.txtFees.AutoSize = true;
            this.txtFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFees.Location = new System.Drawing.Point(6, 88);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(121, 16);
            this.txtFees.TabIndex = 2;
            this.txtFees.Text = "Fee Per Participant";
            // 
            // txtAmount
            // 
            this.txtAmount.AutoSize = true;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(6, 56);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(124, 16);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Text = "Cost Per Participant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Event Title";
            // 
            // grbAddParti
            // 
            this.grbAddParti.Controls.Add(this.txtZipCode);
            this.grbAddParti.Controls.Add(this.txtCity);
            this.grbAddParti.Controls.Add(this.txtStreet);
            this.grbAddParti.Controls.Add(this.txtLastName);
            this.grbAddParti.Controls.Add(this.txtFirstName);
            this.grbAddParti.Controls.Add(this.AddParticipant);
            this.grbAddParti.Controls.Add(this.label11);
            this.grbAddParti.Controls.Add(this.label10);
            this.grbAddParti.Controls.Add(this.label9);
            this.grbAddParti.Controls.Add(this.label8);
            this.grbAddParti.Controls.Add(this.label7);
            this.grbAddParti.Controls.Add(this.label6);
            this.grbAddParti.Controls.Add(this.cmbCountry);
            this.grbAddParti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddParti.Location = new System.Drawing.Point(13, 169);
            this.grbAddParti.Name = "grbAddParti";
            this.grbAddParti.Size = new System.Drawing.Size(287, 259);
            this.grbAddParti.TabIndex = 1;
            this.grbAddParti.TabStop = false;
            this.grbAddParti.Text = "Add Participant";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(125, 146);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(156, 22);
            this.txtZipCode.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(125, 117);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(156, 22);
            this.txtCity.TabIndex = 11;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(125, 87);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(156, 22);
            this.txtStreet.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(125, 53);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(156, 22);
            this.txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(125, 23);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(156, 22);
            this.txtFirstName.TabIndex = 8;
            // 
            // AddParticipant
            // 
            this.AddParticipant.Location = new System.Drawing.Point(84, 224);
            this.AddParticipant.Name = "AddParticipant";
            this.AddParticipant.Size = new System.Drawing.Size(97, 29);
            this.AddParticipant.TabIndex = 7;
            this.AddParticipant.Text = "Add";
            this.AddParticipant.UseVisualStyleBackColor = true;
            this.AddParticipant.Click += new System.EventHandler(this.AddParticipant_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Country";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Zip Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Street";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "First Name";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(125, 182);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(121, 24);
            this.cmbCountry.TabIndex = 0;
            // 
            // lstParticipant
            // 
            this.lstParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstParticipant.FormattingEnabled = true;
            this.lstParticipant.ItemHeight = 16;
            this.lstParticipant.Location = new System.Drawing.Point(330, 26);
            this.lstParticipant.Name = "lstParticipant";
            this.lstParticipant.Size = new System.Drawing.Size(610, 180);
            this.lstParticipant.TabIndex = 2;
            this.lstParticipant.SelectedIndexChanged += new System.EventHandler(this.lstParticipant_SelectedIndexChanged);
            // 
            // grbEconomy
            // 
            this.grbEconomy.Controls.Add(this.lblProfit);
            this.grbEconomy.Controls.Add(this.lblTotalFees);
            this.grbEconomy.Controls.Add(this.lblTotalCost);
            this.grbEconomy.Controls.Add(this.lblNumParticipants);
            this.grbEconomy.Controls.Add(this.label15);
            this.grbEconomy.Controls.Add(this.label14);
            this.grbEconomy.Controls.Add(this.label13);
            this.grbEconomy.Controls.Add(this.label12);
            this.grbEconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEconomy.Location = new System.Drawing.Point(469, 277);
            this.grbEconomy.Name = "grbEconomy";
            this.grbEconomy.Size = new System.Drawing.Size(315, 151);
            this.grbEconomy.TabIndex = 3;
            this.grbEconomy.TabStop = false;
            this.grbEconomy.Text = "Event Economy";
            // 
            // lblProfit
            // 
            this.lblProfit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProfit.Location = new System.Drawing.Point(195, 121);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(94, 24);
            this.lblProfit.TabIndex = 7;
            this.lblProfit.Text = "label19";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFees.Location = new System.Drawing.Point(195, 92);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(93, 23);
            this.lblTotalFees.TabIndex = 6;
            this.lblTotalFees.Text = "label18";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Location = new System.Drawing.Point(195, 61);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(91, 23);
            this.lblTotalCost.TabIndex = 5;
            this.lblTotalCost.Text = "label17";
            // 
            // lblNumParticipants
            // 
            this.lblNumParticipants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumParticipants.Location = new System.Drawing.Point(195, 30);
            this.lblNumParticipants.Name = "lblNumParticipants";
            this.lblNumParticipants.Size = new System.Drawing.Size(91, 24);
            this.lblNumParticipants.TabIndex = 4;
            this.lblNumParticipants.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Surplus";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Total Fees";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Total Cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Number of Participants";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Participants";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(625, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(459, 213);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(91, 30);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(664, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 440);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbEconomy);
            this.Controls.Add(this.lstParticipant);
            this.Controls.Add(this.grbAddParti);
            this.Controls.Add(this.grbNewEvent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbNewEvent.ResumeLayout(false);
            this.grbNewEvent.PerformLayout();
            this.grbAddParti.ResumeLayout(false);
            this.grbAddParti.PerformLayout();
            this.grbEconomy.ResumeLayout(false);
            this.grbEconomy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNewEvent;
        private System.Windows.Forms.TextBox txtFeeAmount;
        private System.Windows.Forms.TextBox txtCostAmount;
        private System.Windows.Forms.TextBox txtMaxNum;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Label txtFees;
        private System.Windows.Forms.Label txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbAddParti;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button AddParticipant;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.ListBox lstParticipant;
        private System.Windows.Forms.GroupBox grbEconomy;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblNumParticipants;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
    }
}

