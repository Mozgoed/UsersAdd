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
            this.chb_mustchpwd = new System.Windows.Forms.CheckBox();
            this.chb_reversiblepwd = new System.Windows.Forms.CheckBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.txtProfile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Location = new System.Drawing.Point(138, 15);
            this.txtFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(201, 21);
            this.txtFile.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(342, 13);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(57, 21);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Обзор";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // radFile
            // 
            this.radFile.AutoSize = true;
            this.radFile.Location = new System.Drawing.Point(8, 16);
            this.radFile.Margin = new System.Windows.Forms.Padding(2);
            this.radFile.Name = "radFile";
            this.radFile.Size = new System.Drawing.Size(126, 17);
            this.radFile.TabIndex = 3;
            this.radFile.Text = "Загрузить из файла";
            this.radFile.UseVisualStyleBackColor = true;
            // 
            // radText
            // 
            this.radText.AutoSize = true;
            this.radText.Checked = true;
            this.radText.Location = new System.Drawing.Point(8, 35);
            this.radText.Margin = new System.Windows.Forms.Padding(2);
            this.radText.Name = "radText";
            this.radText.Size = new System.Drawing.Size(179, 17);
            this.radText.TabIndex = 4;
            this.radText.TabStop = true;
            this.radText.Text = "Загрузить из текстового поля";
            this.radText.UseVisualStyleBackColor = true;
            // 
            // txtUsers
            // 
            this.txtUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsers.Location = new System.Drawing.Point(8, 55);
            this.txtUsers.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsers.Multiline = true;
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUsers.Size = new System.Drawing.Size(393, 97);
            this.txtUsers.TabIndex = 5;
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateFile.Location = new System.Drawing.Point(262, 229);
            this.btnCreateFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(137, 21);
            this.btnCreateFile.TabIndex = 6;
            this.btnCreateFile.Text = "Записать в файл";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(8, 229);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(99, 21);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(159, 229);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(99, 21);
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
            this.txtDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepartments.Location = new System.Drawing.Point(101, 156);
            this.txtDepartments.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartments.Name = "txtDepartments";
            this.txtDepartments.Size = new System.Drawing.Size(300, 21);
            this.txtDepartments.TabIndex = 9;
            this.txtDepartments.Text = ",OU=А,OU=8 класс,OU=Ученики,DC=informatics,DC=school272";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Подразделения";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(8, 254);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(393, 97);
            this.txtResult.TabIndex = 11;
            // 
            // chb_fn
            // 
            this.chb_fn.AutoSize = true;
            this.chb_fn.Location = new System.Drawing.Point(12, 207);
            this.chb_fn.Name = "chb_fn";
            this.chb_fn.Size = new System.Drawing.Size(72, 17);
            this.chb_fn.TabIndex = 12;
            this.chb_fn.Text = "- fn [имя]";
            this.chb_fn.UseVisualStyleBackColor = true;
            // 
            // chb_ln
            // 
            this.chb_ln.AutoSize = true;
            this.chb_ln.Location = new System.Drawing.Point(81, 207);
            this.chb_ln.Name = "chb_ln";
            this.chb_ln.Size = new System.Drawing.Size(96, 17);
            this.chb_ln.TabIndex = 13;
            this.chb_ln.Text = "- ln [фамилия]";
            this.chb_ln.UseVisualStyleBackColor = true;
            // 
            // chb_mustchpwd
            // 
            this.chb_mustchpwd.AutoSize = true;
            this.chb_mustchpwd.Checked = true;
            this.chb_mustchpwd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_mustchpwd.Location = new System.Drawing.Point(174, 207);
            this.chb_mustchpwd.Name = "chb_mustchpwd";
            this.chb_mustchpwd.Size = new System.Drawing.Size(104, 17);
            this.chb_mustchpwd.TabIndex = 14;
            this.chb_mustchpwd.Text = "-mustchpwd yes";
            this.chb_mustchpwd.UseVisualStyleBackColor = true;
            // 
            // chb_reversiblepwd
            // 
            this.chb_reversiblepwd.AutoSize = true;
            this.chb_reversiblepwd.Checked = true;
            this.chb_reversiblepwd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_reversiblepwd.Location = new System.Drawing.Point(284, 207);
            this.chb_reversiblepwd.Name = "chb_reversiblepwd";
            this.chb_reversiblepwd.Size = new System.Drawing.Size(117, 17);
            this.chb_reversiblepwd.TabIndex = 15;
            this.chb_reversiblepwd.Text = "-reversiblepwd yes";
            this.chb_reversiblepwd.UseVisualStyleBackColor = true;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(8, 183);
            this.lblProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(44, 13);
            this.lblProfile.TabIndex = 17;
            this.lblProfile.Text = "- profile";
            // 
            // txtProfile
            // 
            this.txtProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfile.Location = new System.Drawing.Point(56, 181);
            this.txtProfile.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(345, 21);
            this.txtProfile.TabIndex = 16;
            this.txtProfile.Text = "\\\\inf0\\Profiles$\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 360);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.chb_reversiblepwd);
            this.Controls.Add(this.chb_mustchpwd);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(423, 395);
            this.Name = "Form1";
            this.Text = "UsersAdd .Net by Mozgoed";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.CheckBox chb_mustchpwd;
        private System.Windows.Forms.CheckBox chb_reversiblepwd;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.TextBox txtProfile;
    }
}

