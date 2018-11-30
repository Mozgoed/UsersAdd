namespace UsersAdd
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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.radFile = new System.Windows.Forms.RadioButton();
            this.radText = new System.Windows.Forms.RadioButton();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtDepartments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.chb_fn = new System.Windows.Forms.CheckBox();
            this.chb_ln = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(207, 23);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(300, 26);
            this.txtFile.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(513, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(86, 32);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Обзор";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // radFile
            // 
            this.radFile.AutoSize = true;
            this.radFile.Location = new System.Drawing.Point(12, 25);
            this.radFile.Name = "radFile";
            this.radFile.Size = new System.Drawing.Size(189, 24);
            this.radFile.TabIndex = 3;
            this.radFile.Text = "Загрузить из файла";
            this.radFile.UseVisualStyleBackColor = true;
            // 
            // radText
            // 
            this.radText.AutoSize = true;
            this.radText.Checked = true;
            this.radText.Location = new System.Drawing.Point(12, 54);
            this.radText.Name = "radText";
            this.radText.Size = new System.Drawing.Size(262, 24);
            this.radText.TabIndex = 4;
            this.radText.TabStop = true;
            this.radText.Text = "Загрузить из текстового окна";
            this.radText.UseVisualStyleBackColor = true;
            // 
            // txtUsers
            // 
            this.txtUsers.Location = new System.Drawing.Point(12, 85);
            this.txtUsers.Multiline = true;
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUsers.Size = new System.Drawing.Size(588, 147);
            this.txtUsers.TabIndex = 5;
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateFile.Location = new System.Drawing.Point(393, 302);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(206, 32);
            this.btnCreateFile.TabIndex = 6;
            this.btnCreateFile.Text = "Записать в файл";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 302);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(148, 32);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(238, 302);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(148, 32);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Скопировать";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt файлы|*.txt|Все файлы|*.*";
            this.openFileDialog1.Title = "Выберите файл с пользователями";
            // 
            // txtDepartments
            // 
            this.txtDepartments.Location = new System.Drawing.Point(152, 240);
            this.txtDepartments.Name = "txtDepartments";
            this.txtDepartments.Size = new System.Drawing.Size(448, 26);
            this.txtDepartments.TabIndex = 9;
            this.txtDepartments.Text = "OU=А,OU=8 класс,OU=Ученики,DC=informatics,DC=school272";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Подразделения";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(12, 340);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(588, 147);
            this.txtResult.TabIndex = 11;
            // 
            // chb_fn
            // 
            this.chb_fn.AutoSize = true;
            this.chb_fn.Location = new System.Drawing.Point(20, 269);
            this.chb_fn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chb_fn.Name = "chb_fn";
            this.chb_fn.Size = new System.Drawing.Size(99, 24);
            this.chb_fn.TabIndex = 12;
            this.chb_fn.Text = "- fn [имя]";
            this.chb_fn.UseVisualStyleBackColor = true;
            // 
            // chb_ln
            // 
            this.chb_ln.AutoSize = true;
            this.chb_ln.Location = new System.Drawing.Point(127, 269);
            this.chb_ln.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chb_ln.Name = "chb_ln";
            this.chb_ln.Size = new System.Drawing.Size(140, 24);
            this.chb_ln.TabIndex = 13;
            this.chb_ln.Text = "- ln [фамилия]";
            this.chb_ln.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 500);
            this.Controls.Add(this.chb_ln);
            this.Controls.Add(this.chb_fn);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepartments);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.txtUsers);
            this.Controls.Add(this.radText);
            this.Controls.Add(this.radFile);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "UsersAdd .Net by Mozgoed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RadioButton radFile;
        private System.Windows.Forms.RadioButton radText;
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtDepartments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.CheckBox chb_fn;
        private System.Windows.Forms.CheckBox chb_ln;
    }
}

