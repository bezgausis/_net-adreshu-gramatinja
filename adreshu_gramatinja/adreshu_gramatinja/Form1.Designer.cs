namespace WindowsFormsApplication1
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
            this.gbPeople = new System.Windows.Forms.GroupBox();
            this.lwKlienti = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblPiezimes = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtAdrese = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbPeople.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPeople
            // 
            this.gbPeople.Controls.Add(this.lwKlienti);
            this.gbPeople.Location = new System.Drawing.Point(12, 12);
            this.gbPeople.Name = "gbPeople";
            this.gbPeople.Size = new System.Drawing.Size(197, 378);
            this.gbPeople.TabIndex = 0;
            this.gbPeople.TabStop = false;
            this.gbPeople.Text = "saraksts";
            this.gbPeople.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lwKlienti
            // 
            this.lwKlienti.ContextMenuStrip = this.contextMenuStrip1;
            this.lwKlienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwKlienti.Location = new System.Drawing.Point(3, 16);
            this.lwKlienti.Name = "lwKlienti";
            this.lwKlienti.Size = new System.Drawing.Size(191, 359);
            this.lwKlienti.TabIndex = 0;
            this.lwKlienti.UseCompatibleStateImageBehavior = false;
            this.lwKlienti.View = System.Windows.Forms.View.List;
            this.lwKlienti.SelectedIndexChanged += new System.EventHandler(this.lwKlienti_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRemove});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tsmRemove
            // 
            this.tsmRemove.Name = "tsmRemove";
            this.tsmRemove.Size = new System.Drawing.Size(118, 22);
            this.tsmRemove.Text = "Noņemt";
            this.tsmRemove.Click += new System.EventHandler(this.tsmRemove_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.btnCancel);
            this.gbInfo.Controls.Add(this.btnAdd);
            this.gbInfo.Controls.Add(this.btnSave);
            this.gbInfo.Controls.Add(this.txtNotes);
            this.gbInfo.Controls.Add(this.lblPiezimes);
            this.gbInfo.Controls.Add(this.dtpDOB);
            this.gbInfo.Controls.Add(this.lblDOB);
            this.gbInfo.Controls.Add(this.txtAdrese);
            this.gbInfo.Controls.Add(this.lblAddress);
            this.gbInfo.Controls.Add(this.txtEmail);
            this.gbInfo.Controls.Add(this.lblEmail);
            this.gbInfo.Controls.Add(this.txtFullName);
            this.gbInfo.Controls.Add(this.lblFullname);
            this.gbInfo.Location = new System.Drawing.Point(215, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(311, 424);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "informācija";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "noņemt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(87, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Pievienot";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Saglabāt";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(6, 222);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(299, 153);
            this.txtNotes.TabIndex = 9;
            // 
            // lblPiezimes
            // 
            this.lblPiezimes.AutoSize = true;
            this.lblPiezimes.Location = new System.Drawing.Point(257, 206);
            this.lblPiezimes.Name = "lblPiezimes";
            this.lblPiezimes.Size = new System.Drawing.Size(48, 13);
            this.lblPiezimes.TabIndex = 8;
            this.lblPiezimes.Text = "piezīmes";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(10, 162);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(295, 20);
            this.dtpDOB.TabIndex = 7;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(6, 146);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(95, 13);
            this.lblDOB.TabIndex = 6;
            this.lblDOB.Text = "Dzimšanas datums";
            // 
            // txtAdrese
            // 
            this.txtAdrese.Location = new System.Drawing.Point(11, 123);
            this.txtAdrese.Name = "txtAdrese";
            this.txtAdrese.Size = new System.Drawing.Size(294, 20);
            this.txtAdrese.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 107);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(40, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Adrese";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(10, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(295, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 65);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "epasts";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(11, 36);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(294, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(7, 20);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(78, 13);
            this.lblFullname.TabIndex = 0;
            this.lblFullname.Text = "vards/ uzvārds";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(305, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "tabulaEpasti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(WindowsFormsApplication1.Person);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 512);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbPeople);
            this.Controls.Add(this.gbInfo);
            this.Name = "Form1";
            this.Text = "Adrešu gramatiņa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPeople.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPeople;
        private System.Windows.Forms.ListView lwKlienti;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblPiezimes;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtAdrese;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmRemove;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button button2;
    }
}

