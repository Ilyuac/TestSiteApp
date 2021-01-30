namespace TestSiteApp
{
    partial class SiteManitor
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGViewResult = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msTimeIntervalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rButDel = new System.Windows.Forms.RadioButton();
            this.rButUpdate = new System.Windows.Forms.RadioButton();
            this.rButAdd = new System.Windows.Forms.RadioButton();
            this.butSave = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.tBoxInterval = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.DGViewUpdate = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRLDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msTimeIntervalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 420);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this._Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGViewResult);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Результаты проверки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGViewResult
            // 
            this.DGViewResult.AllowUserToAddRows = false;
            this.DGViewResult.AllowUserToDeleteRows = false;
            this.DGViewResult.AutoGenerateColumns = false;
            this.DGViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.uRLDataGridViewTextBoxColumn,
            this.msTimeIntervalDataGridViewTextBoxColumn});
            this.DGViewResult.DataSource = this.siteBindingSource;
            this.DGViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGViewResult.Location = new System.Drawing.Point(3, 3);
            this.DGViewResult.Name = "DGViewResult";
            this.DGViewResult.ReadOnly = true;
            this.DGViewResult.Size = new System.Drawing.Size(768, 388);
            this.DGViewResult.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uRLDataGridViewTextBoxColumn
            // 
            this.uRLDataGridViewTextBoxColumn.DataPropertyName = "URL";
            this.uRLDataGridViewTextBoxColumn.HeaderText = "URL";
            this.uRLDataGridViewTextBoxColumn.Name = "uRLDataGridViewTextBoxColumn";
            this.uRLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // msTimeIntervalDataGridViewTextBoxColumn
            // 
            this.msTimeIntervalDataGridViewTextBoxColumn.DataPropertyName = "ms_TimeInterval";
            this.msTimeIntervalDataGridViewTextBoxColumn.HeaderText = "ms_TimeInterval";
            this.msTimeIntervalDataGridViewTextBoxColumn.Name = "msTimeIntervalDataGridViewTextBoxColumn";
            this.msTimeIntervalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataSource = typeof(TestSiteApp.Model.Site);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.grBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Работа со списком сайтов";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this._Selected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rButDel);
            this.groupBox1.Controls.Add(this.rButUpdate);
            this.groupBox1.Controls.Add(this.rButAdd);
            this.groupBox1.Controls.Add(this.butSave);
            this.groupBox1.Controls.Add(this.butDel);
            this.groupBox1.Controls.Add(this.tBoxName);
            this.groupBox1.Controls.Add(this.butAdd);
            this.groupBox1.Controls.Add(this.tBoxInterval);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBoxUrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(460, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 385);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор режима:";
            // 
            // cBoxID
            // 
            this.cBoxID.FormattingEnabled = true;
            this.cBoxID.Location = new System.Drawing.Point(161, 53);
            this.cBoxID.Name = "cBoxID";
            this.cBoxID.Size = new System.Drawing.Size(140, 21);
            this.cBoxID.TabIndex = 14;
            this.cBoxID.TextChanged += new System.EventHandler(this.cBoxChangedText);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Идентификатор:";
            // 
            // rButDel
            // 
            this.rButDel.AutoSize = true;
            this.rButDel.Location = new System.Drawing.Point(178, 19);
            this.rButDel.Name = "rButDel";
            this.rButDel.Size = new System.Drawing.Size(68, 17);
            this.rButDel.TabIndex = 12;
            this.rButDel.TabStop = true;
            this.rButDel.Text = "Удалить";
            this.rButDel.UseVisualStyleBackColor = true;
            this.rButDel.CheckedChanged += new System.EventHandler(this.rButDelChecked);
            // 
            // rButUpdate
            // 
            this.rButUpdate.AutoSize = true;
            this.rButUpdate.Location = new System.Drawing.Point(95, 19);
            this.rButUpdate.Name = "rButUpdate";
            this.rButUpdate.Size = new System.Drawing.Size(76, 17);
            this.rButUpdate.TabIndex = 11;
            this.rButUpdate.TabStop = true;
            this.rButUpdate.Text = "Изменить";
            this.rButUpdate.UseVisualStyleBackColor = true;
            this.rButUpdate.CheckedChanged += new System.EventHandler(this.rButUpdateChecked);
            // 
            // rButAdd
            // 
            this.rButAdd.AutoSize = true;
            this.rButAdd.Location = new System.Drawing.Point(13, 19);
            this.rButAdd.Name = "rButAdd";
            this.rButAdd.Size = new System.Drawing.Size(75, 17);
            this.rButAdd.TabIndex = 10;
            this.rButAdd.TabStop = true;
            this.rButAdd.Text = "Добавить";
            this.rButAdd.UseVisualStyleBackColor = true;
            this.rButAdd.CheckedChanged += new System.EventHandler(this.rButAddChecked);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(167, 237);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(134, 23);
            this.butSave.TabIndex = 1;
            this.butSave.Text = "Изменить";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(167, 266);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(134, 23);
            this.butDel.TabIndex = 9;
            this.butDel.Text = "Удалить выделенное";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(161, 90);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(140, 20);
            this.tBoxName.TabIndex = 2;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(167, 208);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(134, 23);
            this.butAdd.TabIndex = 8;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // tBoxInterval
            // 
            this.tBoxInterval.Location = new System.Drawing.Point(161, 169);
            this.tBoxInterval.Name = "tBoxInterval";
            this.tBoxInterval.Size = new System.Drawing.Size(140, 20);
            this.tBoxInterval.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Интервал проверки (мсек):";
            // 
            // tBoxUrl
            // 
            this.tBoxUrl.Location = new System.Drawing.Point(161, 131);
            this.tBoxUrl.Name = "tBoxUrl";
            this.tBoxUrl.Size = new System.Drawing.Size(140, 20);
            this.tBoxUrl.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "URL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название:";
            // 
            // grBox
            // 
            this.grBox.Controls.Add(this.DGViewUpdate);
            this.grBox.Location = new System.Drawing.Point(3, 6);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(451, 388);
            this.grBox.TabIndex = 0;
            this.grBox.TabStop = false;
            this.grBox.Text = "Список сайтов:";
            // 
            // DGViewUpdate
            // 
            this.DGViewUpdate.AutoGenerateColumns = false;
            this.DGViewUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.uRLDataGridViewTextBoxColumn1,
            this.msTimeIntervalDataGridViewTextBoxColumn1});
            this.DGViewUpdate.DataSource = this.siteBindingSource;
            this.DGViewUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGViewUpdate.Location = new System.Drawing.Point(3, 16);
            this.DGViewUpdate.Name = "DGViewUpdate";
            this.DGViewUpdate.Size = new System.Drawing.Size(445, 369);
            this.DGViewUpdate.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // uRLDataGridViewTextBoxColumn1
            // 
            this.uRLDataGridViewTextBoxColumn1.DataPropertyName = "URL";
            this.uRLDataGridViewTextBoxColumn1.HeaderText = "URL";
            this.uRLDataGridViewTextBoxColumn1.Name = "uRLDataGridViewTextBoxColumn1";
            // 
            // msTimeIntervalDataGridViewTextBoxColumn1
            // 
            this.msTimeIntervalDataGridViewTextBoxColumn1.DataPropertyName = "ms_TimeInterval";
            this.msTimeIntervalDataGridViewTextBoxColumn1.HeaderText = "ms_TimeInterval";
            this.msTimeIntervalDataGridViewTextBoxColumn1.Name = "msTimeIntervalDataGridViewTextBoxColumn1";
            // 
            // SiteManitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 420);
            this.Controls.Add(this.tabControl1);
            this.Name = "SiteManitor";
            this.Text = "Site Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGViewResult;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.DataGridView DGViewUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msTimeIntervalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRLDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn msTimeIntervalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxUrl;
        private System.Windows.Forms.TextBox tBoxInterval;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rButDel;
        private System.Windows.Forms.RadioButton rButUpdate;
        private System.Windows.Forms.RadioButton rButAdd;
    }
}

