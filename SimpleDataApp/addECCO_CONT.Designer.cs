namespace SimpleDataApp
{
    partial class addECCO_CONT
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDATA = new System.Windows.Forms.DateTimePicker();
            this.tbIZME = new System.Windows.Forms.TextBox();
            this.tbOBOZ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpTemplet.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpTemplet
            // 
            this.gpTemplet.AutoSize = true;
            this.gpTemplet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpTemplet.Controls.Add(this.btnCancel);
            this.gpTemplet.Controls.Add(this.btnClear);
            this.gpTemplet.Controls.Add(this.btnAdd);
            this.gpTemplet.Controls.Add(this.dtpDATA);
            this.gpTemplet.Controls.Add(this.tbIZME);
            this.gpTemplet.Controls.Add(this.tbOBOZ);
            this.gpTemplet.Controls.Add(this.label7);
            this.gpTemplet.Controls.Add(this.label5);
            this.gpTemplet.Controls.Add(this.label1);
            this.gpTemplet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpTemplet.Location = new System.Drawing.Point(10, 10);
            this.gpTemplet.Margin = new System.Windows.Forms.Padding(10);
            this.gpTemplet.Name = "gpTemplet";
            this.gpTemplet.Padding = new System.Windows.Forms.Padding(10);
            this.gpTemplet.Size = new System.Drawing.Size(330, 224);
            this.gpTemplet.TabIndex = 1;
            this.gpTemplet.TabStop = false;
            this.gpTemplet.Text = "Шаблон";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(234, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(125, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // dtpDATA
            // 
            this.dtpDATA.Location = new System.Drawing.Point(70, 115);
            this.dtpDATA.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dtpDATA.MinDate = new System.DateTime(1990, 12, 31, 0, 0, 0, 0);
            this.dtpDATA.Name = "dtpDATA";
            this.dtpDATA.Size = new System.Drawing.Size(200, 20);
            this.dtpDATA.TabIndex = 4;
            this.dtpDATA.Value = new System.DateTime(1990, 12, 31, 0, 0, 0, 0);
            // 
            // tbIZME
            // 
            this.tbIZME.Location = new System.Drawing.Point(70, 76);
            this.tbIZME.Name = "tbIZME";
            this.tbIZME.Size = new System.Drawing.Size(200, 20);
            this.tbIZME.TabIndex = 2;
            // 
            // tbOBOZ
            // 
            this.tbOBOZ.Location = new System.Drawing.Point(70, 35);
            this.tbOBOZ.Name = "tbOBOZ";
            this.tbOBOZ.Size = new System.Drawing.Size(200, 20);
            this.tbOBOZ.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "NOW:";
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
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OBOZ:";
            // 
            // addECCO_CONT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 244);
            this.Controls.Add(this.gpTemplet);
            this.Name = "addECCO_CONT";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "ECCO_CONT";
            this.gpTemplet.ResumeLayout(false);
            this.gpTemplet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpTemplet;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpDATA;
        private System.Windows.Forms.TextBox tbIZME;
        private System.Windows.Forms.TextBox tbOBOZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}