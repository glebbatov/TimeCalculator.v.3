namespace TimeCalculator3._0
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button close;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clockin = new System.Windows.Forms.Button();
            this.clockout = new System.Windows.Forms.Button();
            this.mainTextForm = new System.Windows.Forms.RichTextBox();
            this.saveChanges = new System.Windows.Forms.Button();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.timeTextBox1 = new System.Windows.Forms.TextBox();
            this.timeTextBox2 = new System.Windows.Forms.TextBox();
            this.readCustomFile = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close
            // 
            close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            close.BackColor = System.Drawing.SystemColors.ButtonShadow;
            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            close.ForeColor = System.Drawing.SystemColors.Window;
            close.Location = new System.Drawing.Point(821, 15);
            close.Margin = new System.Windows.Forms.Padding(4);
            close.Name = "close";
            close.Size = new System.Drawing.Size(213, 84);
            close.TabIndex = 5;
            close.Text = "Close";
            close.UseVisualStyleBackColor = false;
            close.Click += new System.EventHandler(this.Close_Click);
            // 
            // clockin
            // 
            this.clockin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.clockin.FlatAppearance.BorderSize = 0;
            this.clockin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clockin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clockin.ForeColor = System.Drawing.SystemColors.Window;
            this.clockin.Location = new System.Drawing.Point(17, 15);
            this.clockin.Margin = new System.Windows.Forms.Padding(4);
            this.clockin.Name = "clockin";
            this.clockin.Size = new System.Drawing.Size(213, 84);
            this.clockin.TabIndex = 2;
            this.clockin.Text = "Clock in";
            this.clockin.UseVisualStyleBackColor = false;
            this.clockin.Click += new System.EventHandler(this.Clockin_Click);
            // 
            // clockout
            // 
            this.clockout.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.clockout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clockout.Enabled = false;
            this.clockout.FlatAppearance.BorderSize = 0;
            this.clockout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clockout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clockout.ForeColor = System.Drawing.SystemColors.Window;
            this.clockout.Location = new System.Drawing.Point(239, 15);
            this.clockout.Margin = new System.Windows.Forms.Padding(4);
            this.clockout.Name = "clockout";
            this.clockout.Size = new System.Drawing.Size(213, 84);
            this.clockout.TabIndex = 3;
            this.clockout.Text = "Clock Out";
            this.clockout.UseVisualStyleBackColor = false;
            this.clockout.Click += new System.EventHandler(this.Clockout_Click);
            // 
            // mainTextForm
            // 
            this.mainTextForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTextForm.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTextForm.Location = new System.Drawing.Point(17, 106);
            this.mainTextForm.Margin = new System.Windows.Forms.Padding(4);
            this.mainTextForm.Name = "mainTextForm";
            this.mainTextForm.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.mainTextForm.Size = new System.Drawing.Size(1017, 326);
            this.mainTextForm.TabIndex = 0;
            this.mainTextForm.Text = "";
            this.mainTextForm.TextChanged += new System.EventHandler(this.mainTextForm_TextChanged);
            // 
            // saveChanges
            // 
            this.saveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveChanges.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.saveChanges.FlatAppearance.BorderSize = 0;
            this.saveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChanges.ForeColor = System.Drawing.SystemColors.Window;
            this.saveChanges.Location = new System.Drawing.Point(17, 442);
            this.saveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(213, 84);
            this.saveChanges.TabIndex = 6;
            this.saveChanges.Text = "Save Changes";
            this.saveChanges.UseVisualStyleBackColor = false;
            this.saveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeTextBox1
            // 
            this.timeTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeTextBox1.BackColor = System.Drawing.Color.DimGray;
            this.timeTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.timeTextBox1.Location = new System.Drawing.Point(821, 442);
            this.timeTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.timeTextBox1.Name = "timeTextBox1";
            this.timeTextBox1.Size = new System.Drawing.Size(212, 36);
            this.timeTextBox1.TabIndex = 8;
            this.timeTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeTextBox2
            // 
            this.timeTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeTextBox2.BackColor = System.Drawing.Color.DimGray;
            this.timeTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTextBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.timeTextBox2.Location = new System.Drawing.Point(821, 489);
            this.timeTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.timeTextBox2.Name = "timeTextBox2";
            this.timeTextBox2.Size = new System.Drawing.Size(212, 36);
            this.timeTextBox2.TabIndex = 9;
            this.timeTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readCustomFile
            // 
            this.readCustomFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.readCustomFile.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.readCustomFile.Enabled = false;
            this.readCustomFile.FlatAppearance.BorderSize = 0;
            this.readCustomFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readCustomFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readCustomFile.ForeColor = System.Drawing.SystemColors.Window;
            this.readCustomFile.Location = new System.Drawing.Point(239, 442);
            this.readCustomFile.Margin = new System.Windows.Forms.Padding(4);
            this.readCustomFile.Name = "readCustomFile";
            this.readCustomFile.Size = new System.Drawing.Size(213, 84);
            this.readCustomFile.TabIndex = 10;
            this.readCustomFile.Text = "Read \r\nCustom File";
            this.readCustomFile.UseVisualStyleBackColor = false;
            this.readCustomFile.Click += new System.EventHandler(this.readCustomFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1049, 537);
            this.Controls.Add(this.readCustomFile);
            this.Controls.Add(this.timeTextBox2);
            this.Controls.Add(this.timeTextBox1);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(close);
            this.Controls.Add(this.mainTextForm);
            this.Controls.Add(this.clockout);
            this.Controls.Add(this.clockin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TimeCalculator3.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clockin;
        private System.Windows.Forms.Button clockout;
        private System.Windows.Forms.RichTextBox mainTextForm;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.TextBox timeTextBox1;
        private System.Windows.Forms.TextBox timeTextBox2;
        private System.Windows.Forms.Button readCustomFile;
        private System.Windows.Forms.Timer timer1;
    }
}

