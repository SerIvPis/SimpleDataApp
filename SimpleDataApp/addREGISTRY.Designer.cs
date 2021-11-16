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
            this.button3 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gpDesi = new System.Windows.Forms.GroupBox();
            this.tbFIRM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNUMB = new System.Windows.Forms.TextBox();
            this.tbCODE = new System.Windows.Forms.TextBox();
            this.dtpDATA = new System.Windows.Forms.DateTimePicker();
            this.tbPRIM = new System.Windows.Forms.TextBox();
            this.tbDESI = new System.Windows.Forms.TextBox();
            this.tbINDE = new System.Windows.Forms.TextBox();
            this.tbNaim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttNAIM = new System.Windows.Forms.ToolTip(this.components);
            this.ttINDE = new System.Windows.Forms.ToolTip(this.components);
            this.ttDESI = new System.Windows.Forms.ToolTip(this.components);
            this.ttPRIM = new System.Windows.Forms.ToolTip(this.components);
            this.ttFIRM = new System.Windows.Forms.ToolTip(this.components);
            this.ttCODE = new System.Windows.Forms.ToolTip(this.components);
            this.ttNUMB = new System.Windows.Forms.ToolTip(this.components);
            this.gpTemplet.SuspendLayout();
            this.gpDesi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpTemplet
            // 
            this.gpTemplet.AutoSize = true;
            this.gpTemplet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpTemplet.Controls.Add(this.button3);
            this.gpTemplet.Controls.Add(this.btnClear);
            this.gpTemplet.Controls.Add(this.button1);
            this.gpTemplet.Controls.Add(this.gpDesi);
            this.gpTemplet.Controls.Add(this.dtpDATA);
            this.gpTemplet.Controls.Add(this.tbPRIM);
            this.gpTemplet.Controls.Add(this.tbDESI);
            this.gpTemplet.Controls.Add(this.tbINDE);
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
            this.gpTemplet.Size = new System.Drawing.Size(329, 484);
            this.gpTemplet.TabIndex = 0;
            this.gpTemplet.TabStop = false;
            this.gpTemplet.Text = "Шаблон";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(128, 436);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // gpDesi
            // 
            this.gpDesi.AutoSize = true;
            this.gpDesi.Controls.Add(this.tbFIRM);
            this.gpDesi.Controls.Add(this.label2);
            this.gpDesi.Controls.Add(this.label3);
            this.gpDesi.Controls.Add(this.label4);
            this.gpDesi.Controls.Add(this.tbNUMB);
            this.gpDesi.Controls.Add(this.tbCODE);
            this.gpDesi.Location = new System.Drawing.Point(19, 261);
            this.gpDesi.Name = "gpDesi";
            this.gpDesi.Size = new System.Drawing.Size(263, 138);
            this.gpDesi.TabIndex = 17;
            this.gpDesi.TabStop = false;
            this.gpDesi.Text = "Децимальный номер";
            // 
            // tbFIRM
            // 
            this.tbFIRM.Location = new System.Drawing.Point(50, 23);
            this.tbFIRM.Name = "tbFIRM";
            this.tbFIRM.Size = new System.Drawing.Size(200, 20);
            this.tbFIRM.TabIndex = 6;
            this.ttFIRM.SetToolTip(this.tbFIRM, "Пример: FIRM");
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
            // tbNUMB
            // 
            this.tbNUMB.Location = new System.Drawing.Point(50, 99);
            this.tbNUMB.Name = "tbNUMB";
            this.tbNUMB.Size = new System.Drawing.Size(200, 20);
            this.tbNUMB.TabIndex = 8;
            this.ttNUMB.SetToolTip(this.tbNUMB, "Пример: NUMB");
            // 
            // tbCODE
            // 
            this.tbCODE.Location = new System.Drawing.Point(50, 63);
            this.tbCODE.Name = "tbCODE";
            this.tbCODE.Size = new System.Drawing.Size(200, 20);
            this.tbCODE.TabIndex = 7;
            this.ttCODE.SetToolTip(this.tbCODE, "Пример: CODE");
            // 
            // dtpDATA
            // 
            this.dtpDATA.Location = new System.Drawing.Point(70, 166);
            this.dtpDATA.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dtpDATA.MinDate = new System.DateTime(1990, 12, 31, 0, 0, 0, 0);
            this.dtpDATA.Name = "dtpDATA";
            this.dtpDATA.Size = new System.Drawing.Size(200, 20);
            this.dtpDATA.TabIndex = 4;
            this.dtpDATA.Value = new System.DateTime(1990, 12, 31, 0, 0, 0, 0);
            // 
            // tbPRIM
            // 
            this.tbPRIM.Location = new System.Drawing.Point(70, 218);
            this.tbPRIM.Name = "tbPRIM";
            this.tbPRIM.Size = new System.Drawing.Size(200, 20);
            this.tbPRIM.TabIndex = 5;
            this.ttPRIM.SetToolTip(this.tbPRIM, "Пример: PRIM");
            // 
            // tbDESI
            // 
            this.tbDESI.Location = new System.Drawing.Point(70, 116);
            this.tbDESI.Name = "tbDESI";
            this.tbDESI.Size = new System.Drawing.Size(200, 20);
            this.tbDESI.TabIndex = 3;
            this.ttDESI.SetToolTip(this.tbDESI, "Пример: DESI");
            // 
            // tbINDE
            // 
            this.tbINDE.Location = new System.Drawing.Point(70, 76);
            this.tbINDE.Name = "tbINDE";
            this.tbINDE.Size = new System.Drawing.Size(200, 20);
            this.tbINDE.TabIndex = 2;
            this.ttINDE.SetToolTip(this.tbINDE, "Пример: INDE");
            // 
            // tbNaim
            // 
            this.tbNaim.Location = new System.Drawing.Point(70, 35);
            this.tbNaim.Name = "tbNaim";
            this.tbNaim.Size = new System.Drawing.Size(200, 20);
            this.tbNaim.TabIndex = 1;
            this.ttNAIM.SetToolTip(this.tbNaim, "Пример: NAIM");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "PRIM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(23, 168);
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
            // ttNAIM
            // 
            this.ttNAIM.AutoPopDelay = 10000;
            this.ttNAIM.InitialDelay = 100;
            this.ttNAIM.IsBalloon = true;
            this.ttNAIM.ReshowDelay = 100;
            this.ttNAIM.ShowAlways = true;
            this.ttNAIM.Popup += new System.Windows.Forms.PopupEventHandler(this.ttNUMB_Popup);
            // 
            // ttINDE
            // 
            this.ttINDE.AutoPopDelay = 10000;
            this.ttINDE.InitialDelay = 100;
            this.ttINDE.IsBalloon = true;
            this.ttINDE.ReshowDelay = 100;
            this.ttINDE.ShowAlways = true;
            this.ttINDE.Popup += new System.Windows.Forms.PopupEventHandler(this.ttNUMB_Popup);
            // 
            // ttDESI
            // 
            this.ttDESI.AutoPopDelay = 10000;
            this.ttDESI.InitialDelay = 100;
            this.ttDESI.IsBalloon = true;
            this.ttDESI.ReshowDelay = 100;
            this.ttDESI.ShowAlways = true;
            this.ttDESI.Popup += new System.Windows.Forms.PopupEventHandler(this.ttNUMB_Popup);
            // 
            // ttPRIM
            // 
            this.ttPRIM.AutoPopDelay = 10000;
            this.ttPRIM.InitialDelay = 100;
            this.ttPRIM.IsBalloon = true;
            this.ttPRIM.ReshowDelay = 100;
            this.ttPRIM.ShowAlways = true;
            this.ttPRIM.Popup += new System.Windows.Forms.PopupEventHandler(this.ttNUMB_Popup);
            // 
            // ttFIRM
            // 
            this.ttFIRM.AutoPopDelay = 10000;
            this.ttFIRM.InitialDelay = 100;
            this.ttFIRM.IsBalloon = true;
            this.ttFIRM.ReshowDelay = 100;
            this.ttFIRM.ShowAlways = true;
            this.ttFIRM.Popup += new System.Windows.Forms.PopupEventHandler(this.ttNUMB_Popup);
            // 
            // ttCODE
            // 
            this.ttCODE.AutoPopDelay = 10000;
            this.ttCODE.InitialDelay = 100;
            this.ttCODE.IsBalloon = true;
            this.ttCODE.ReshowDelay = 100;
            this.ttCODE.ShowAlways = true;
            this.ttCODE.Popup += new System.Windows.Forms.PopupEventHandler(this.ttNUMB_Popup);
            // 
            // ttNUMB
            // 
            this.ttNUMB.AutoPopDelay = 10000;
            this.ttNUMB.InitialDelay = 100;
            this.ttNUMB.IsBalloon = true;
            this.ttNUMB.ReshowDelay = 100;
            this.ttNUMB.ShowAlways = true;
            this.ttNUMB.Popup += new System.Windows.Forms.PopupEventHandler(this.ttNUMB_Popup);
            // 
            // addREGISTRY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 504);
            this.Controls.Add(this.gpTemplet);
            this.Name = "addREGISTRY";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Ввод в таблицу регистрации";
            this.Load += new System.EventHandler(this.addREGISTRY_Load);
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
        private System.Windows.Forms.TextBox tbFIRM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNUMB;
        private System.Windows.Forms.TextBox tbCODE;
        private System.Windows.Forms.DateTimePicker dtpDATA;
        private System.Windows.Forms.TextBox tbPRIM;
        private System.Windows.Forms.TextBox tbDESI;
        private System.Windows.Forms.TextBox tbINDE;
        private System.Windows.Forms.TextBox tbNaim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip ttNAIM;
        private System.Windows.Forms.ToolTip ttINDE;
        private System.Windows.Forms.ToolTip ttDESI;
        private System.Windows.Forms.ToolTip ttPRIM;
        private System.Windows.Forms.ToolTip ttFIRM;
        private System.Windows.Forms.ToolTip ttCODE;
        private System.Windows.Forms.ToolTip ttNUMB;
    }
}