namespace CertificatesManager
{
    partial class AddEmployee
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
            this.minimizeButton = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.windowTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.coursesData = new System.Windows.Forms.DataGridView();
            this.userDetailsBox = new System.Windows.Forms.GroupBox();
            this.addPhotoLabel = new System.Windows.Forms.Label();
            this.jobTitleText = new System.Windows.Forms.TextBox();
            this.employeeNumberText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.jobtitleLbl = new System.Windows.Forms.Label();
            this.employeeNumberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.minmaxbutton = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesData)).BeginInit();
            this.userDetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.AutoSize = true;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.minimizeButton.Location = new System.Drawing.Point(936, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(22, 24);
            this.minimizeButton.TabIndex = 9;
            this.minimizeButton.Text = "−";
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButton.Location = new System.Drawing.Point(982, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(16, 20);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // windowTitle
            // 
            this.windowTitle.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitle.ForeColor = System.Drawing.Color.LightGray;
            this.windowTitle.Location = new System.Drawing.Point(63, 1);
            this.windowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(870, 33);
            this.windowTitle.TabIndex = 7;
            this.windowTitle.Text = "Superior Employee Management System";
            this.windowTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.userDetailsBox);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 514);
            this.panel1.TabIndex = 10;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.Gray;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(772, 471);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 32);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(196)))), ((int)(((byte)(105)))));
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(865, 471);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 32);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.coursesData);
            this.groupBox1.Location = new System.Drawing.Point(36, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 285);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // coursesData
            // 
            this.coursesData.AllowUserToAddRows = false;
            this.coursesData.AllowUserToDeleteRows = false;
            this.coursesData.AllowUserToOrderColumns = true;
            this.coursesData.AllowUserToResizeColumns = false;
            this.coursesData.AllowUserToResizeRows = false;
            this.coursesData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coursesData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.coursesData.BackgroundColor = System.Drawing.Color.White;
            this.coursesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesData.Location = new System.Drawing.Point(3, 16);
            this.coursesData.Name = "coursesData";
            this.coursesData.RowHeadersVisible = false;
            this.coursesData.Size = new System.Drawing.Size(916, 266);
            this.coursesData.TabIndex = 0;
            this.coursesData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coursesData_CellContentClick);
            // 
            // userDetailsBox
            // 
            this.userDetailsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDetailsBox.Controls.Add(this.addPhotoLabel);
            this.userDetailsBox.Controls.Add(this.jobTitleText);
            this.userDetailsBox.Controls.Add(this.employeeNumberText);
            this.userDetailsBox.Controls.Add(this.nameText);
            this.userDetailsBox.Controls.Add(this.jobtitleLbl);
            this.userDetailsBox.Controls.Add(this.employeeNumberLabel);
            this.userDetailsBox.Controls.Add(this.nameLabel);
            this.userDetailsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDetailsBox.Location = new System.Drawing.Point(36, 8);
            this.userDetailsBox.Name = "userDetailsBox";
            this.userDetailsBox.Size = new System.Drawing.Size(922, 175);
            this.userDetailsBox.TabIndex = 0;
            this.userDetailsBox.TabStop = false;
            this.userDetailsBox.Text = "Add User Details";
            // 
            // addPhotoLabel
            // 
            this.addPhotoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPhotoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPhotoLabel.Location = new System.Drawing.Point(746, 40);
            this.addPhotoLabel.Name = "addPhotoLabel";
            this.addPhotoLabel.Size = new System.Drawing.Size(112, 112);
            this.addPhotoLabel.TabIndex = 6;
            this.addPhotoLabel.Text = "+ Add Photo";
            this.addPhotoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addPhotoLabel.Click += new System.EventHandler(this.addPhotoLabel_Click);
            // 
            // jobTitleText
            // 
            this.jobTitleText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitleText.Location = new System.Drawing.Point(274, 130);
            this.jobTitleText.Name = "jobTitleText";
            this.jobTitleText.Size = new System.Drawing.Size(442, 22);
            this.jobTitleText.TabIndex = 5;
            // 
            // employeeNumberText
            // 
            this.employeeNumberText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumberText.Location = new System.Drawing.Point(274, 84);
            this.employeeNumberText.Name = "employeeNumberText";
            this.employeeNumberText.Size = new System.Drawing.Size(442, 22);
            this.employeeNumberText.TabIndex = 4;
            // 
            // nameText
            // 
            this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(274, 40);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(442, 22);
            this.nameText.TabIndex = 3;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // jobtitleLbl
            // 
            this.jobtitleLbl.AutoSize = true;
            this.jobtitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobtitleLbl.Location = new System.Drawing.Point(100, 130);
            this.jobtitleLbl.Name = "jobtitleLbl";
            this.jobtitleLbl.Size = new System.Drawing.Size(60, 16);
            this.jobtitleLbl.TabIndex = 2;
            this.jobtitleLbl.Text = "Job Title";
            // 
            // employeeNumberLabel
            // 
            this.employeeNumberLabel.AutoSize = true;
            this.employeeNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumberLabel.Location = new System.Drawing.Point(97, 90);
            this.employeeNumberLabel.Name = "employeeNumberLabel";
            this.employeeNumberLabel.Size = new System.Drawing.Size(86, 16);
            this.employeeNumberLabel.TabIndex = 1;
            this.employeeNumberLabel.Text = "Employee ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(94, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(110, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Employee Name";
            // 
            // minmaxbutton
            // 
            this.minmaxbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minmaxbutton.AutoSize = true;
            this.minmaxbutton.Font = new System.Drawing.Font("Biting My Nails", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minmaxbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.minmaxbutton.Location = new System.Drawing.Point(961, 6);
            this.minmaxbutton.Name = "minmaxbutton";
            this.minmaxbutton.Size = new System.Drawing.Size(20, 17);
            this.minmaxbutton.TabIndex = 12;
            this.minmaxbutton.Text = "O";
            this.minmaxbutton.Click += new System.EventHandler(this.minmaxbutton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(196)))), ((int)(((byte)(105)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(2, 1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(61, 33);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.minmaxbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.windowTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coursesData)).EndInit();
            this.userDetailsBox.ResumeLayout(false);
            this.userDetailsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimizeButton;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label windowTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox userDetailsBox;
        private System.Windows.Forms.Label addPhotoLabel;
        private System.Windows.Forms.TextBox jobTitleText;
        private System.Windows.Forms.TextBox employeeNumberText;
        private System.Windows.Forms.Label jobtitleLbl;
        private System.Windows.Forms.Label employeeNumberLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView coursesData;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label minmaxbutton;
        private System.Windows.Forms.Button backButton;
    }
}