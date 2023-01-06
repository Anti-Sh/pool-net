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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpQuery1 = new System.Windows.Forms.TabPage();
            this.dgQuery1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tpQuery2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tpQuery3 = new System.Windows.Forms.TabPage();
            this.tbQuery3Result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarrif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgQuery2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcMain.SuspendLayout();
            this.tpQuery1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuery1)).BeginInit();
            this.tpQuery2.SuspendLayout();
            this.tpQuery3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuery2)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpQuery1);
            this.tcMain.Controls.Add(this.tpQuery2);
            this.tcMain.Controls.Add(this.tpQuery3);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(780, 453);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpQuery1
            // 
            this.tpQuery1.Controls.Add(this.dgQuery1);
            this.tpQuery1.Controls.Add(this.label3);
            this.tpQuery1.Location = new System.Drawing.Point(4, 26);
            this.tpQuery1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpQuery1.Name = "tpQuery1";
            this.tpQuery1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpQuery1.Size = new System.Drawing.Size(772, 423);
            this.tpQuery1.TabIndex = 0;
            this.tpQuery1.Text = "Запрос №1";
            this.tpQuery1.UseVisualStyleBackColor = true;
            // 
            // dgQuery1
            // 
            this.dgQuery1.AllowUserToAddRows = false;
            this.dgQuery1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgQuery1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgQuery1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuery1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.person,
            this.tarrif,
            this.dpw,
            this.date_start,
            this.cost});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgQuery1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgQuery1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgQuery1.Location = new System.Drawing.Point(2, 29);
            this.dgQuery1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgQuery1.Name = "dgQuery1";
            this.dgQuery1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgQuery1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgQuery1.RowTemplate.Height = 24;
            this.dgQuery1.Size = new System.Drawing.Size(768, 392);
            this.dgQuery1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(768, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Сведения о самом дешевом абонементе за неделю";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpQuery2
            // 
            this.tpQuery2.Controls.Add(this.dgQuery2);
            this.tpQuery2.Controls.Add(this.label2);
            this.tpQuery2.Location = new System.Drawing.Point(4, 26);
            this.tpQuery2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpQuery2.Name = "tpQuery2";
            this.tpQuery2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpQuery2.Size = new System.Drawing.Size(772, 423);
            this.tpQuery2.TabIndex = 1;
            this.tpQuery2.Text = "Запрос №2";
            this.tpQuery2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(768, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сведения об абонементах с периодичностью занятий 2 раза в неделю";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpQuery3
            // 
            this.tpQuery3.Controls.Add(this.tbQuery3Result);
            this.tpQuery3.Controls.Add(this.label4);
            this.tpQuery3.Controls.Add(this.label1);
            this.tpQuery3.Location = new System.Drawing.Point(4, 26);
            this.tpQuery3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpQuery3.Name = "tpQuery3";
            this.tpQuery3.Size = new System.Drawing.Size(652, 423);
            this.tpQuery3.TabIndex = 2;
            this.tpQuery3.Text = "Запрос №3";
            this.tpQuery3.UseVisualStyleBackColor = true;
            // 
            // tbQuery3Result
            // 
            this.tbQuery3Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.tbQuery3Result.Location = new System.Drawing.Point(217, 57);
            this.tbQuery3Result.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQuery3Result.Name = "tbQuery3Result";
            this.tbQuery3Result.Size = new System.Drawing.Size(128, 30);
            this.tbQuery3Result.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Средняя стоимость:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Средняя стоимость занятий в день по всем абонементам\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 46;
            // 
            // person
            // 
            this.person.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.person.HeaderText = "ФИО";
            this.person.Name = "person";
            this.person.ReadOnly = true;
            // 
            // tarrif
            // 
            this.tarrif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tarrif.HeaderText = "Срок";
            this.tarrif.Name = "tarrif";
            this.tarrif.ReadOnly = true;
            this.tarrif.Width = 65;
            // 
            // dpw
            // 
            this.dpw.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dpw.HeaderText = "Дней в неделю";
            this.dpw.Name = "dpw";
            this.dpw.ReadOnly = true;
            this.dpw.Width = 122;
            // 
            // date_start
            // 
            this.date_start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.date_start.HeaderText = "Дата начала";
            this.date_start.Name = "date_start";
            this.date_start.ReadOnly = true;
            this.date_start.Width = 109;
            // 
            // cost
            // 
            this.cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cost.HeaderText = "Стоимость";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 103;
            // 
            // dgQuery2
            // 
            this.dgQuery2.AllowUserToAddRows = false;
            this.dgQuery2.AllowUserToDeleteRows = false;
            this.dgQuery2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuery2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgQuery2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgQuery2.Location = new System.Drawing.Point(2, 29);
            this.dgQuery2.Margin = new System.Windows.Forms.Padding(2);
            this.dgQuery2.Name = "dgQuery2";
            this.dgQuery2.ReadOnly = true;
            this.dgQuery2.RowTemplate.Height = 24;
            this.dgQuery2.Size = new System.Drawing.Size(768, 392);
            this.dgQuery2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 46;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Срок";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 65;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Дней в неделю";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 122;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата начала";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 109;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 103;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(780, 453);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Aquatic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMain.ResumeLayout(false);
            this.tpQuery1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgQuery1)).EndInit();
            this.tpQuery2.ResumeLayout(false);
            this.tpQuery3.ResumeLayout(false);
            this.tpQuery3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuery2)).EndInit();
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
        private System.Windows.Forms.DataGridView dgQuery1;
        private System.Windows.Forms.TextBox tbQuery3Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn person;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarrif;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpw;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridView dgQuery2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

