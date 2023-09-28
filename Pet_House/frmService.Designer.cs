namespace pet_house
{
    partial class frmService
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbPetInfo = new System.Windows.Forms.TabPage();
            this.rbtNonVeg = new System.Windows.Forms.RadioButton();
            this.rbtVeg = new System.Windows.Forms.RadioButton();
            this.cmbPetTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rbtNonAC = new System.Windows.Forms.RadioButton();
            this.rbtAC = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtYes = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbPetService = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPtType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCustom = new System.Windows.Forms.ComboBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Servicecmb = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tbPetInfo.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tbPetService.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tbControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 750);
            this.panel1.TabIndex = 19;
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbPetInfo);
            this.tbControl.Controls.Add(this.tbPetService);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControl.Location = new System.Drawing.Point(0, 0);
            this.tbControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(1371, 750);
            this.tbControl.TabIndex = 0;
            this.tbControl.SelectedIndexChanged += new System.EventHandler(this.tbControl_SelectedIndexChanged);
            // 
            // tbPetInfo
            // 
            this.tbPetInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPetInfo.Controls.Add(this.rbtNonVeg);
            this.tbPetInfo.Controls.Add(this.rbtVeg);
            this.tbPetInfo.Controls.Add(this.cmbPetTypes);
            this.tbPetInfo.Controls.Add(this.label1);
            this.tbPetInfo.Controls.Add(this.btnSubmit);
            this.tbPetInfo.Controls.Add(this.label4);
            this.tbPetInfo.Controls.Add(this.panel6);
            this.tbPetInfo.Controls.Add(this.label10);
            this.tbPetInfo.Controls.Add(this.panel7);
            this.tbPetInfo.Controls.Add(this.txtAge);
            this.tbPetInfo.Controls.Add(this.txtName);
            this.tbPetInfo.Controls.Add(this.panel8);
            this.tbPetInfo.Controls.Add(this.label13);
            this.tbPetInfo.Controls.Add(this.label15);
            this.tbPetInfo.Location = new System.Drawing.Point(4, 36);
            this.tbPetInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPetInfo.Name = "tbPetInfo";
            this.tbPetInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPetInfo.Size = new System.Drawing.Size(1363, 710);
            this.tbPetInfo.TabIndex = 4;
            this.tbPetInfo.Text = "Pet Information";
            this.tbPetInfo.ToolTipText = "Pet Information";
            // 
            // rbtNonVeg
            // 
            this.rbtNonVeg.AutoSize = true;
            this.rbtNonVeg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtNonVeg.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNonVeg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtNonVeg.Location = new System.Drawing.Point(796, 280);
            this.rbtNonVeg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtNonVeg.Name = "rbtNonVeg";
            this.rbtNonVeg.Size = new System.Drawing.Size(146, 34);
            this.rbtNonVeg.TabIndex = 3;
            this.rbtNonVeg.TabStop = true;
            this.rbtNonVeg.Text = "Non Veg.";
            this.rbtNonVeg.UseVisualStyleBackColor = false;
            // 
            // rbtVeg
            // 
            this.rbtVeg.AutoSize = true;
            this.rbtVeg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtVeg.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtVeg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtVeg.Location = new System.Drawing.Point(673, 280);
            this.rbtVeg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtVeg.Name = "rbtVeg";
            this.rbtVeg.Size = new System.Drawing.Size(90, 34);
            this.rbtVeg.TabIndex = 2;
            this.rbtVeg.TabStop = true;
            this.rbtVeg.Text = "Veg.";
            this.rbtVeg.UseVisualStyleBackColor = false;
            // 
            // cmbPetTypes
            // 
            this.cmbPetTypes.FormattingEnabled = true;
            this.cmbPetTypes.Location = new System.Drawing.Point(673, 179);
            this.cmbPetTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPetTypes.Name = "cmbPetTypes";
            this.cmbPetTypes.Size = new System.Drawing.Size(275, 35);
            this.cmbPetTypes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 30);
            this.label1.TabIndex = 114;
            this.label1.Text = "Select Pet Type :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(550, 550);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(277, 48);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 30);
            this.label4.TabIndex = 110;
            this.label4.Text = "Pet Food Habbit :";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rbtNonAC);
            this.panel6.Controls.Add(this.rbtAC);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(417, 327);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(555, 36);
            this.panel6.TabIndex = 109;
            // 
            // rbtNonAC
            // 
            this.rbtNonAC.AutoSize = true;
            this.rbtNonAC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtNonAC.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNonAC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtNonAC.Location = new System.Drawing.Point(379, 2);
            this.rbtNonAC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtNonAC.Name = "rbtNonAC";
            this.rbtNonAC.Size = new System.Drawing.Size(137, 34);
            this.rbtNonAC.TabIndex = 5;
            this.rbtNonAC.TabStop = true;
            this.rbtNonAC.Text = "Non A/C";
            this.rbtNonAC.UseVisualStyleBackColor = false;
            // 
            // rbtAC
            // 
            this.rbtAC.AutoSize = true;
            this.rbtAC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtAC.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtAC.Location = new System.Drawing.Point(256, 1);
            this.rbtAC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtAC.Name = "rbtAC";
            this.rbtAC.Size = new System.Drawing.Size(81, 34);
            this.rbtAC.TabIndex = 4;
            this.rbtAC.TabStop = true;
            this.rbtAC.Text = "A/C";
            this.rbtAC.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 30);
            this.label9.TabIndex = 24;
            this.label9.Text = "Pet Aatmosphere :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkCyan;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(559, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(268, 46);
            this.label10.TabIndex = 106;
            this.label10.Text = "Pet Information";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rbtNo);
            this.panel7.Controls.Add(this.rbtYes);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(417, 475);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(507, 36);
            this.panel7.TabIndex = 108;
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtNo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtNo.Location = new System.Drawing.Point(379, 0);
            this.rbtNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(68, 34);
            this.rbtNo.TabIndex = 10;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "No";
            this.rbtNo.UseVisualStyleBackColor = false;
            // 
            // rbtYes
            // 
            this.rbtYes.AutoSize = true;
            this.rbtYes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtYes.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtYes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtYes.Location = new System.Drawing.Point(256, 2);
            this.rbtYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtYes.Name = "rbtYes";
            this.rbtYes.Size = new System.Drawing.Size(76, 34);
            this.rbtYes.TabIndex = 9;
            this.rbtYes.TabStop = true;
            this.rbtYes.Text = "Yes";
            this.rbtYes.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 30);
            this.label11.TabIndex = 24;
            this.label11.Text = "Pet vaccination :";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(673, 431);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(275, 32);
            this.txtAge.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(673, 227);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 32);
            this.txtName.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.rbtFemale);
            this.panel8.Controls.Add(this.rbtMale);
            this.panel8.Location = new System.Drawing.Point(417, 382);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(555, 36);
            this.panel8.TabIndex = 107;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 30);
            this.label12.TabIndex = 14;
            this.label12.Text = "Pet Gender :";
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtFemale.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFemale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtFemale.Location = new System.Drawing.Point(379, 1);
            this.rbtFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(124, 34);
            this.rbtFemale.TabIndex = 7;
            this.rbtFemale.TabStop = true;
            this.rbtFemale.Text = "Female";
            this.rbtFemale.UseVisualStyleBackColor = false;
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtMale.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtMale.Location = new System.Drawing.Point(256, 0);
            this.rbtMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(95, 34);
            this.rbtMale.TabIndex = 6;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "Male";
            this.rbtMale.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(424, 433);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 30);
            this.label13.TabIndex = 103;
            this.label13.Text = "Pet Age :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(425, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 30);
            this.label15.TabIndex = 102;
            this.label15.Text = "Pet Name :";
            // 
            // tbPetService
            // 
            this.tbPetService.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPetService.Controls.Add(this.label2);
            this.tbPetService.Controls.Add(this.btnSave);
            this.tbPetService.Controls.Add(this.txtDays);
            this.tbPetService.Controls.Add(this.label5);
            this.tbPetService.Controls.Add(this.cmbPtType);
            this.tbPetService.Controls.Add(this.label3);
            this.tbPetService.Controls.Add(this.cmbCustom);
            this.tbPetService.Controls.Add(this.txtRate);
            this.tbPetService.Controls.Add(this.txtTotal);
            this.tbPetService.Controls.Add(this.txt_Total);
            this.tbPetService.Controls.Add(this.date);
            this.tbPetService.Controls.Add(this.label8);
            this.tbPetService.Controls.Add(this.Servicecmb);
            this.tbPetService.Controls.Add(this.label14);
            this.tbPetService.Controls.Add(this.label16);
            this.tbPetService.Controls.Add(this.label17);
            this.tbPetService.Location = new System.Drawing.Point(4, 36);
            this.tbPetService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPetService.Name = "tbPetService";
            this.tbPetService.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPetService.Size = new System.Drawing.Size(1363, 710);
            this.tbPetService.TabIndex = 5;
            this.tbPetService.Text = "Pet Service";
            this.tbPetService.ToolTipText = "Pet Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(612, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 46);
            this.label2.TabIndex = 146;
            this.label2.Text = "Pet Service";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(586, 563);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(271, 42);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtDays
            // 
            this.txtDays.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.Location = new System.Drawing.Point(658, 444);
            this.txtDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(271, 36);
            this.txtDays.TabIndex = 5;
            this.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDays.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(491, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 30);
            this.label5.TabIndex = 145;
            this.label5.Text = "No Of Days :";
            // 
            // cmbPtType
            // 
            this.cmbPtType.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPtType.FormattingEnabled = true;
            this.cmbPtType.Location = new System.Drawing.Point(658, 293);
            this.cmbPtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPtType.Name = "cmbPtType";
            this.cmbPtType.Size = new System.Drawing.Size(271, 35);
            this.cmbPtType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 30);
            this.label3.TabIndex = 143;
            this.label3.Text = "Select Pet Type :";
            // 
            // cmbCustom
            // 
            this.cmbCustom.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustom.FormattingEnabled = true;
            this.cmbCustom.Location = new System.Drawing.Point(658, 192);
            this.cmbCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCustom.Name = "cmbCustom";
            this.cmbCustom.Size = new System.Drawing.Size(271, 35);
            this.cmbCustom.TabIndex = 0;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(658, 393);
            this.txtRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(271, 36);
            this.txtRate.TabIndex = 4;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(658, 495);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(271, 36);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Total
            // 
            this.txt_Total.AutoSize = true;
            this.txt_Total.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(530, 492);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(122, 30);
            this.txt_Total.TabIndex = 139;
            this.txt_Total.Text = "Amount :";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(658, 242);
            this.date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(271, 36);
            this.date.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(567, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 30);
            this.label8.TabIndex = 137;
            this.label8.Text = "Date :";
            // 
            // Servicecmb
            // 
            this.Servicecmb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servicecmb.FormattingEnabled = true;
            this.Servicecmb.Location = new System.Drawing.Point(658, 343);
            this.Servicecmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Servicecmb.Name = "Servicecmb";
            this.Servicecmb.Size = new System.Drawing.Size(271, 35);
            this.Servicecmb.TabIndex = 3;
            this.Servicecmb.SelectedIndexChanged += new System.EventHandler(this.Servicecmb_SelectedIndexChanged_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(428, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(224, 30);
            this.label14.TabIndex = 135;
            this.label14.Text = "Customer Name :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(471, 392);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(181, 30);
            this.label16.TabIndex = 134;
            this.label16.Text = "Product Rate :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(456, 342);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(196, 30);
            this.label17.TabIndex = 133;
            this.label17.Text = "Select Service :";
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.Load += new System.EventHandler(this.frmService_Load);
            this.panel1.ResumeLayout(false);
            this.tbControl.ResumeLayout(false);
            this.tbPetInfo.ResumeLayout(false);
            this.tbPetInfo.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tbPetService.ResumeLayout(false);
            this.tbPetService.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tbControl;
        public System.Windows.Forms.TabPage tbPetService;
        public System.Windows.Forms.TabPage tbPetInfo;
        public System.Windows.Forms.RadioButton rbtNonVeg;
        public System.Windows.Forms.RadioButton rbtVeg;
        private System.Windows.Forms.ComboBox cmbPetTypes;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.RadioButton rbtNonAC;
        public System.Windows.Forms.RadioButton rbtAC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.RadioButton rbtNo;
        public System.Windows.Forms.RadioButton rbtYes;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtAge;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.RadioButton rbtFemale;
        public System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbPtType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCustom;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label txt_Total;
        public System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Servicecmb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;


    }
}



