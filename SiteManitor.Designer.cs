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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGViewResult = new System.Windows.Forms.DataGridView();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.DGViewUpdate = new System.Windows.Forms.DataGridView();
            this.butSave = new System.Windows.Forms.Button();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msTimeIntervalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRLDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msTimeIntervalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewResult)).BeginInit();
            this.grBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGViewResult);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Результаты проверки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.butSave);
            this.tabPage2.Controls.Add(this.grBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Работа со списком сайтов";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.DGViewResult.Size = new System.Drawing.Size(786, 418);
            this.DGViewResult.TabIndex = 0;
            // 
            // grBox
            // 
            this.grBox.Controls.Add(this.DGViewUpdate);
            this.grBox.Location = new System.Drawing.Point(3, 6);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(786, 388);
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
            this.DGViewUpdate.Size = new System.Drawing.Size(780, 369);
            this.DGViewUpdate.TabIndex = 0;
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(698, 397);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(86, 23);
            this.butSave.TabIndex = 1;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataSource = typeof(TestSiteApp.Model.Site);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "SiteManitor";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewResult)).EndInit();
            this.grBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
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
    }
}

