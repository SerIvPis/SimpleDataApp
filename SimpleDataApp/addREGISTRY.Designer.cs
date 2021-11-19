namespace SimpleDataApp
{
    partial class addREGISTRY
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            this.gpTemplet = new System.Windows.Forms.GroupBox();
            this.cbINDE = new System.Windows.Forms.ComboBox();
            this.cbDESI = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gpDesi = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFIRM = new System.Windows.Forms.ComboBox();
            this.tbNUMB = new System.Windows.Forms.TextBox();
            this.tbCODE = new System.Windows.Forms.TextBox();
            this.dtpDATA = new System.Windows.Forms.DateTimePicker();
            this.tbPRIM = new System.Windows.Forms.TextBox();
            this.tbNaim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpTemplet.SuspendLayout();
            this.gpDesi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpTemplet
            // 
            this.gpTemplet.AutoSize = true;
            this.gpTemplet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpTemplet.Controls.Add(this.cbINDE);
            this.gpTemplet.Controls.Add(this.cbDESI);
            this.gpTemplet.Controls.Add(this.btnCancel);
            this.gpTemplet.Controls.Add(this.btnClear);
            this.gpTemplet.Controls.Add(this.button1);
            this.gpTemplet.Controls.Add(this.gpDesi);
            this.gpTemplet.Controls.Add(this.dtpDATA);
            this.gpTemplet.Controls.Add(this.tbPRIM);
            this.gpTemplet.Controls.Add(this.tbNaim);
            this.gpTemplet.Controls.Add(this.label8);
            this.gpTemplet.Controls.Add(this.label7);
            this.gpTemplet.Controls.Add(this.label6);
            this.gpTemplet.Controls.Add(this.label5);
            this.gpTemplet.Controls.Add(this.label1);
            this.gpTemplet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpTemplet.Location = new System.Drawing.Point(10, 10);
            this.gpTemplet.Margin = new System.Windows.Forms.Padding(10);
            this.gpTemplet.Name = "gpTemplet";
            this.gpTemplet.Padding = new System.Windows.Forms.Padding(10);
            this.gpTemplet.Size = new System.Drawing.Size(332, 447);
            this.gpTemplet.TabIndex = 0;
            this.gpTemplet.TabStop = false;
            this.gpTemplet.Text = "Шаблон";
            // 
            // cbINDE
            // 
            this.cbINDE.FormattingEnabled = true;
            this.cbINDE.Location = new System.Drawing.Point(70, 76);
            this.cbINDE.Name = "cbINDE";
            this.cbINDE.Size = new System.Drawing.Size(85, 21);
            this.cbINDE.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbINDE, "\r\n");
            // 
            // cbDESI
            // 
            this.cbDESI.FormattingEnabled = true;
            this.cbDESI.Location = new System.Drawing.Point(70, 115);
            this.cbDESI.Name = "cbDESI";
            this.cbDESI.Size = new System.Drawing.Size(85, 21);
            this.cbDESI.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(128, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // gpDesi
            // 
            this.gpDesi.AutoSize = true;
            this.gpDesi.Controls.Add(this.label2);
            this.gpDesi.Controls.Add(this.label3);
            this.gpDesi.Controls.Add(this.label4);
            this.gpDesi.Controls.Add(this.cbFIRM);
            this.gpDesi.Controls.Add(this.tbNUMB);
            this.gpDesi.Controls.Add(this.tbCODE);
            this.gpDesi.Location = new System.Drawing.Point(19, 248);
            this.gpDesi.Name = "gpDesi";
            this.gpDesi.Size = new System.Drawing.Size(175, 138);
            this.gpDesi.TabIndex = 6;
            this.gpDesi.TabStop = false;
            this.gpDesi.Text = "Децимальный номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FIRM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CODE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NUMB:";
            // 
            // cbFIRM
            // 
            this.cbFIRM.FormattingEnabled = true;
            this.cbFIRM.Location = new System.Drawing.Point(51, 24);
            this.cbFIRM.Name = "cbFIRM";
            this.cbFIRM.Size = new System.Drawing.Size(85, 21);
            this.cbFIRM.TabIndex = 1;
            // 
            // tbNUMB
            // 
            this.tbNUMB.Location = new System.Drawing.Point(50, 99);
            this.tbNUMB.Name = "tbNUMB";
            this.tbNUMB.Size = new System.Drawing.Size(58, 20);
            this.tbNUMB.TabIndex = 3;
            // 
            // tbCODE
            // 
            this.tbCODE.Location = new System.Drawing.Point(50, 63);
            this.tbCODE.Name = "tbCODE";
            this.tbCODE.Size = new System.Drawing.Size(114, 20);
            this.tbCODE.TabIndex = 2;
            // 
            // dtpDATA
            // 
            this.dtpDATA.Location = new System.Drawing.Point(70, 157);
            this.dtpDATA.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dtpDATA.MinDate = new System.DateTime(1990, 12, 31, 0, 0, 0, 0);
            this.dtpDATA.Name = "dtpDATA";
            this.dtpDATA.Size = new System.Drawing.Size(200, 20);
            this.dtpDATA.TabIndex = 4;
            this.dtpDATA.Value = new System.DateTime(1990, 12, 31, 0, 0, 0, 0);
            // 
            // tbPRIM
            // 
            this.tbPRIM.Location = new System.Drawing.Point(70, 198);
            this.tbPRIM.Name = "tbPRIM";
            this.tbPRIM.Size = new System.Drawing.Size(200, 20);
            this.tbPRIM.TabIndex = 5;
            // 
            // tbNaim
            // 
            this.tbNaim.Location = new System.Drawing.Point(70, 35);
            this.tbNaim.Name = "tbNaim";
            this.tbNaim.Size = new System.Drawing.Size(200, 20);
            this.tbNaim.TabIndex = 1;
            this.tbNaim.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "PRIM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(23, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "DATA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(23, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DESI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "INDE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAIM:";
            // 
            // addREGISTRY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 467);
            this.Controls.Add(this.gpTemplet);
            this.Name = "addREGISTRY";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Ввод в таблицу регистрации";
            this.gpTemplet.ResumeLayout(false);
            this.gpTemplet.PerformLayout();
            this.gpDesi.ResumeLayout(false);
            this.gpDesi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpTemplet;
        private System.Windows.Forms.GroupBox gpDesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNUMB;
        private System.Windows.Forms.TextBox tbCODE;
        private System.Windows.Forms.DateTimePicker dtpDATA;
        private System.Windows.Forms.TextBox tbNaim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPRIM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbFIRM;
        private System.Windows.Forms.ComboBox cbDESI;
        private System.Windows.Forms.ComboBox cbINDE;
    }
}