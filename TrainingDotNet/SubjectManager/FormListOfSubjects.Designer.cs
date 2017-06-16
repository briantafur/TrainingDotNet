namespace SubjectManager
{
    partial class FormListOfSubjects
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.btnNewSubject = new System.Windows.Forms.Button();
            this.btnPercentSettings = new System.Windows.Forms.Button();
            this.dataGridSubjects = new System.Windows.Forms.DataGridView();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(9, 39);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(35, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "label1";
            // 
            // btnNewSubject
            // 
            this.btnNewSubject.Location = new System.Drawing.Point(12, 63);
            this.btnNewSubject.Name = "btnNewSubject";
            this.btnNewSubject.Size = new System.Drawing.Size(79, 23);
            this.btnNewSubject.TabIndex = 1;
            this.btnNewSubject.Text = "New Subject";
            this.btnNewSubject.UseVisualStyleBackColor = true;
            this.btnNewSubject.Click += new System.EventHandler(this.btnNewSubject_Click);
            // 
            // btnPercentSettings
            // 
            this.btnPercentSettings.Location = new System.Drawing.Point(12, 13);
            this.btnPercentSettings.Name = "btnPercentSettings";
            this.btnPercentSettings.Size = new System.Drawing.Size(101, 23);
            this.btnPercentSettings.TabIndex = 2;
            this.btnPercentSettings.Text = "Percent Settings";
            this.btnPercentSettings.UseVisualStyleBackColor = true;
            // 
            // dataGridSubjects
            // 
            this.dataGridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSubjects.Location = new System.Drawing.Point(12, 102);
            this.dataGridSubjects.Name = "dataGridSubjects";
            this.dataGridSubjects.Size = new System.Drawing.Size(260, 123);
            this.dataGridSubjects.TabIndex = 3;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(13, 229);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(143, 20);
            this.tbCodigo.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(196, 226);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // FormListOfSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.dataGridSubjects);
            this.Controls.Add(this.btnPercentSettings);
            this.Controls.Add(this.btnNewSubject);
            this.Controls.Add(this.labelInfo);
            this.Name = "FormListOfSubjects";
            this.Text = "List of Subjects";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button btnNewSubject;
        private System.Windows.Forms.Button btnPercentSettings;
        private System.Windows.Forms.DataGridView dataGridSubjects;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btnSearch;
    }
}