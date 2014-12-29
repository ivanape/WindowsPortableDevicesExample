namespace WPDSampleApp
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.lstContents = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkCurrentSelection = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Devices:";
            // 
            // cmbDevices
            // 
            this.cmbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(96, 27);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(269, 21);
            this.cmbDevices.TabIndex = 1;
            // 
            // btnDiscover
            // 
            this.btnDiscover.Location = new System.Drawing.Point(382, 27);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(75, 23);
            this.btnDiscover.TabIndex = 2;
            this.btnDiscover.Text = "Discover";
            this.btnDiscover.UseVisualStyleBackColor = true;
            this.btnDiscover.Click += new System.EventHandler(this.btnDiscover_Click);
            // 
            // lstContents
            // 
            this.lstContents.FormattingEnabled = true;
            this.lstContents.Location = new System.Drawing.Point(12, 60);
            this.lstContents.Name = "lstContents";
            this.lstContents.Size = new System.Drawing.Size(540, 238);
            this.lstContents.TabIndex = 3;
            this.lstContents.SelectedIndexChanged += new System.EventHandler(this.lstContents_SelectedIndexChanged);
            this.lstContents.DoubleClick += new System.EventHandler(this.lstContents_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current selection:";
            // 
            // lnkCurrentSelection
            // 
            this.lnkCurrentSelection.AutoSize = true;
            this.lnkCurrentSelection.Location = new System.Drawing.Point(142, 311);
            this.lnkCurrentSelection.Name = "lnkCurrentSelection";
            this.lnkCurrentSelection.Size = new System.Drawing.Size(53, 13);
            this.lnkCurrentSelection.TabIndex = 5;
            this.lnkCurrentSelection.TabStop = true;
            this.lnkCurrentSelection.Text = "linkLabel1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 333);
            this.Controls.Add(this.lnkCurrentSelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstContents);
            this.Controls.Add(this.btnDiscover);
            this.Controls.Add(this.cmbDevices);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WPD Example";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.ListBox lstContents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkCurrentSelection;
    }
}

