namespace pool_net
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpQuery1 = new System.Windows.Forms.TabPage();
            this.tpQuery2 = new System.Windows.Forms.TabPage();
            this.tpQuery3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQuery3Result = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tcMain.SuspendLayout();
            this.tpQuery1.SuspendLayout();
            this.tpQuery2.SuspendLayout();
            this.tpQuery3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpQuery1);
            this.tcMain.Controls.Add(this.tpQuery2);
            this.tcMain.Controls.Add(this.tpQuery3);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(880, 557);
            this.tcMain.TabIndex = 0;
            // 
            // tpQuery1
            // 
            this.tpQuery1.Controls.Add(this.dataGridView2);
            this.tpQuery1.Controls.Add(this.label3);
            this.tpQuery1.Location = new System.Drawing.Point(4, 25);
            this.tpQuery1.Name = "tpQuery1";
            this.tpQuery1.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuery1.Size = new System.Drawing.Size(872, 528);
            this.tpQuery1.TabIndex = 0;
            this.tpQuery1.Text = "Запрос №1";
            this.tpQuery1.UseVisualStyleBackColor = true;
            // 
            // tpQuery2
            // 
            this.tpQuery2.Controls.Add(this.dataGridView1);
            this.tpQuery2.Controls.Add(this.label2);
            this.tpQuery2.Location = new System.Drawing.Point(4, 25);
            this.tpQuery2.Name = "tpQuery2";
            this.tpQuery2.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuery2.Size = new System.Drawing.Size(872, 528);
            this.tpQuery2.TabIndex = 1;
            this.tpQuery2.Text = "Запрос №2";
            this.tpQuery2.UseVisualStyleBackColor = true;
            // 
            // tpQuery3
            // 
            this.tpQuery3.Controls.Add(this.tbQuery3Result);
            this.tpQuery3.Controls.Add(this.label4);
            this.tpQuery3.Controls.Add(this.label1);
            this.tpQuery3.Location = new System.Drawing.Point(4, 25);
            this.tpQuery3.Name = "tpQuery3";
            this.tpQuery3.Size = new System.Drawing.Size(872, 528);
            this.tpQuery3.TabIndex = 2;
            this.tpQuery3.Text = "Запрос №3";
            this.tpQuery3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(866, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сведения об абонементах с периодичностью занятий 2 раза в неделю";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(866, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Сведения о самом дешевом абонементе за неделю";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(872, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Средняя стоимость занятий по всем абонементам в день";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.label4.Location = new System.Drawing.Point(8, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Средняя стоимость:";
            // 
            // tbQuery3Result
            // 
            this.tbQuery3Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.tbQuery3Result.Location = new System.Drawing.Point(221, 71);
            this.tbQuery3Result.Name = "tbQuery3Result";
            this.tbQuery3Result.Size = new System.Drawing.Size(170, 30);
            this.tbQuery3Result.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(866, 488);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(866, 488);
            this.dataGridView2.TabIndex = 3;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 557);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Aquatic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMain.ResumeLayout(false);
            this.tpQuery1.ResumeLayout(false);
            this.tpQuery2.ResumeLayout(false);
            this.tpQuery3.ResumeLayout(false);
            this.tpQuery3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpQuery1;
        private System.Windows.Forms.TabPage tpQuery2;
        private System.Windows.Forms.TabPage tpQuery3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbQuery3Result;
    }
}

