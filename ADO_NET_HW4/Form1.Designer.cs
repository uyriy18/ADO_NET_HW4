namespace ADO_NET_HW4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txbx_Querry = new System.Windows.Forms.TextBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.cmbx_Writers = new System.Windows.Forms.ComboBox();
            this.lbl_PagesSume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // txbx_Querry
            // 
            this.txbx_Querry.Location = new System.Drawing.Point(13, 13);
            this.txbx_Querry.Name = "txbx_Querry";
            this.txbx_Querry.Size = new System.Drawing.Size(571, 20);
            this.txbx_Querry.TabIndex = 1;
            this.txbx_Querry.Text = "Select * from books";
            this.txbx_Querry.TextChanged += new System.EventHandler(this.txbx_Querry_TextChanged);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(604, 11);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 23);
            this.btn_Select.TabIndex = 2;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // cmbx_Writers
            // 
            this.cmbx_Writers.FormattingEnabled = true;
            this.cmbx_Writers.Location = new System.Drawing.Point(13, 40);
            this.cmbx_Writers.Name = "cmbx_Writers";
            this.cmbx_Writers.Size = new System.Drawing.Size(275, 21);
            this.cmbx_Writers.TabIndex = 3;
            // 
            // lbl_PagesSume
            // 
            this.lbl_PagesSume.AutoSize = true;
            this.lbl_PagesSume.Location = new System.Drawing.Point(318, 43);
            this.lbl_PagesSume.Name = "lbl_PagesSume";
            this.lbl_PagesSume.Size = new System.Drawing.Size(35, 13);
            this.lbl_PagesSume.TabIndex = 4;
            this.lbl_PagesSume.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.lbl_PagesSume);
            this.Controls.Add(this.cmbx_Writers);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.txbx_Querry);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbx_Querry;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.ComboBox cmbx_Writers;
        private System.Windows.Forms.Label lbl_PagesSume;
    }
}

