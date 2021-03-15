namespace CertificatesManager
{
    partial class overviewWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.windowTitle = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Label();
            this.quickviewlabel = new System.Windows.Forms.Label();
            this.expiringLabe = new System.Windows.Forms.Label();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.detailedViewPanel = new System.Windows.Forms.Panel();
            this.detailedViewGrid = new System.Windows.Forms.DataGridView();
            this.detailedViewLabel = new System.Windows.Forms.Label();
            this.expiringSoonGrid = new System.Windows.Forms.DataGridView();
            this.scrollButton = new System.Windows.Forms.Button();
            this.minmaxbutton = new System.Windows.Forms.Label();
            this.detailedViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailedViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expiringSoonGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // windowTitle
            // 
            this.windowTitle.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitle.ForeColor = System.Drawing.Color.LightGray;
            this.windowTitle.Location = new System.Drawing.Point(2, 0);
            this.windowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(926, 36);
            this.windowTitle.TabIndex = 0;
            this.windowTitle.Text = "Superior Employee Management System";
            this.windowTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButton.Location = new System.Drawing.Point(977, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(16, 20);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.AutoSize = true;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.minimizeButton.Location = new System.Drawing.Point(932, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(22, 24);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.Text = "−";
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // quickviewlabel
            // 
            this.quickviewlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quickviewlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.quickviewlabel.ForeColor = System.Drawing.Color.LightGray;
            this.quickviewlabel.Location = new System.Drawing.Point(-2, 36);
            this.quickviewlabel.Name = "quickviewlabel";
            this.quickviewlabel.Size = new System.Drawing.Size(1006, 32);
            this.quickviewlabel.TabIndex = 4;
            this.quickviewlabel.Text = "           Quick View";
            this.quickviewlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // expiringLabe
            // 
            this.expiringLabe.AutoSize = true;
            this.expiringLabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiringLabe.ForeColor = System.Drawing.Color.LightGray;
            this.expiringLabe.Location = new System.Drawing.Point(44, 74);
            this.expiringLabe.Name = "expiringLabe";
            this.expiringLabe.Size = new System.Drawing.Size(160, 16);
            this.expiringLabe.TabIndex = 5;
            this.expiringLabe.Text = "Certificates Expiring Soon";
            // 
            // addCourseButton
            // 
            this.addCourseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(196)))), ((int)(((byte)(105)))));
            this.addCourseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseButton.Location = new System.Drawing.Point(47, 207);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(130, 25);
            this.addCourseButton.TabIndex = 6;
            this.addCourseButton.Text = "+ Add Course";
            this.addCourseButton.UseVisualStyleBackColor = false;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(196)))), ((int)(((byte)(105)))));
            this.addEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeButton.Location = new System.Drawing.Point(183, 207);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(127, 25);
            this.addEmployeeButton.TabIndex = 7;
            this.addEmployeeButton.Text = "+ Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // detailedViewPanel
            // 
            this.detailedViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailedViewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.detailedViewPanel.Controls.Add(this.detailedViewGrid);
            this.detailedViewPanel.Controls.Add(this.detailedViewLabel);
            this.detailedViewPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailedViewPanel.Location = new System.Drawing.Point(47, 239);
            this.detailedViewPanel.Name = "detailedViewPanel";
            this.detailedViewPanel.Size = new System.Drawing.Size(909, 287);
            this.detailedViewPanel.TabIndex = 8;
            // 
            // detailedViewGrid
            // 
            this.detailedViewGrid.AllowUserToAddRows = false;
            this.detailedViewGrid.AllowUserToDeleteRows = false;
            this.detailedViewGrid.AllowUserToResizeColumns = false;
            this.detailedViewGrid.AllowUserToResizeRows = false;
            this.detailedViewGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailedViewGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.detailedViewGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailedViewGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.detailedViewGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailedViewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.detailedViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailedViewGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.detailedViewGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.detailedViewGrid.EnableHeadersVisualStyles = false;
            this.detailedViewGrid.GridColor = System.Drawing.Color.LightGray;
            this.detailedViewGrid.Location = new System.Drawing.Point(3, 35);
            this.detailedViewGrid.Name = "detailedViewGrid";
            this.detailedViewGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailedViewGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.detailedViewGrid.RowTemplate.Height = 40;
            this.detailedViewGrid.Size = new System.Drawing.Size(903, 249);
            this.detailedViewGrid.TabIndex = 1;
            this.detailedViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detailedViewGrid_CellContentClick);
            // 
            // detailedViewLabel
            // 
            this.detailedViewLabel.AutoSize = true;
            this.detailedViewLabel.BackColor = System.Drawing.Color.Transparent;
            this.detailedViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailedViewLabel.ForeColor = System.Drawing.Color.LightGray;
            this.detailedViewLabel.Location = new System.Drawing.Point(12, 16);
            this.detailedViewLabel.Name = "detailedViewLabel";
            this.detailedViewLabel.Size = new System.Drawing.Size(91, 16);
            this.detailedViewLabel.TabIndex = 0;
            this.detailedViewLabel.Text = "Detailed View";
            // 
            // expiringSoonGrid
            // 
            this.expiringSoonGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expiringSoonGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.expiringSoonGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.expiringSoonGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expiringSoonGrid.ColumnHeadersVisible = false;
            this.expiringSoonGrid.Location = new System.Drawing.Point(47, 94);
            this.expiringSoonGrid.Name = "expiringSoonGrid";
            this.expiringSoonGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expiringSoonGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.expiringSoonGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.expiringSoonGrid.Size = new System.Drawing.Size(906, 107);
            this.expiringSoonGrid.TabIndex = 9;
            // 
            // scrollButton
            // 
            this.scrollButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollButton.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrollButton.Location = new System.Drawing.Point(955, 122);
            this.scrollButton.Name = "scrollButton";
            this.scrollButton.Size = new System.Drawing.Size(38, 50);
            this.scrollButton.TabIndex = 10;
            this.scrollButton.Text = ">";
            this.scrollButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.scrollButton.UseVisualStyleBackColor = true;
            this.scrollButton.Click += new System.EventHandler(this.scrollButton_Click);
            // 
            // minmaxbutton
            // 
            this.minmaxbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minmaxbutton.AutoSize = true;
            this.minmaxbutton.Font = new System.Drawing.Font("Biting My Nails", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minmaxbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.minmaxbutton.Location = new System.Drawing.Point(956, 4);
            this.minmaxbutton.Name = "minmaxbutton";
            this.minmaxbutton.Size = new System.Drawing.Size(20, 17);
            this.minmaxbutton.TabIndex = 11;
            this.minmaxbutton.Text = "O";
            this.minmaxbutton.Click += new System.EventHandler(this.minmaxbutton_Click_1);
            // 
            // overviewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.minmaxbutton);
            this.Controls.Add(this.scrollButton);
            this.Controls.Add(this.expiringSoonGrid);
            this.Controls.Add(this.detailedViewPanel);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.expiringLabe);
            this.Controls.Add(this.quickviewlabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.windowTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "overviewWindow";
            this.Text = "Overview - Superior Employee Mangement System";
            this.Load += new System.EventHandler(this.overviewWindow_Load);
            this.detailedViewPanel.ResumeLayout(false);
            this.detailedViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailedViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expiringSoonGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label windowTitle;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label minimizeButton;
        private System.Windows.Forms.Label quickviewlabel;
        private System.Windows.Forms.Label expiringLabe;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Panel detailedViewPanel;
        private System.Windows.Forms.DataGridView detailedViewGrid;
        private System.Windows.Forms.Label detailedViewLabel;
        private System.Windows.Forms.DataGridView expiringSoonGrid;
        private System.Windows.Forms.Button scrollButton;
        private System.Windows.Forms.Label minmaxbutton;
    }
}

