
namespace Kandykova_Mordochka
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.recordingGroupBox = new System.Windows.Forms.GroupBox();
            this.labelcount = new System.Windows.Forms.Label();
            this.allButton = new System.Windows.Forms.Button();
            this.twoHunButton = new System.Windows.Forms.Button();
            this.pageGroupBox = new System.Windows.Forms.GroupBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.FiftyButton = new System.Windows.Forms.Button();
            this.TenButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.ClientDataGridView = new System.Windows.Forms.DataGridView();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.manButton = new System.Windows.Forms.Button();
            this.allGenderButton = new System.Windows.Forms.Button();
            this.womanButton = new System.Windows.Forms.Button();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.birthButton = new System.Windows.Forms.Button();
            this.visitsButton = new System.Windows.Forms.Button();
            this.lastdateButton = new System.Windows.Forms.Button();
            this.sortFnameButton = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPhoneTextBox = new System.Windows.Forms.TextBox();
            this.searchMailTextBox = new System.Windows.Forms.TextBox();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.workDataGroupBox = new System.Windows.Forms.GroupBox();
            this.editButton = new System.Windows.Forms.Button();
            this.nameDelLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.recordingGroupBox.SuspendLayout();
            this.pageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).BeginInit();
            this.genderGroupBox.SuspendLayout();
            this.sortGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.workDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // recordingGroupBox
            // 
            this.recordingGroupBox.Controls.Add(this.labelcount);
            this.recordingGroupBox.Controls.Add(this.allButton);
            this.recordingGroupBox.Controls.Add(this.twoHunButton);
            this.recordingGroupBox.Controls.Add(this.pageGroupBox);
            this.recordingGroupBox.Controls.Add(this.FiftyButton);
            this.recordingGroupBox.Controls.Add(this.TenButton);
            this.recordingGroupBox.Location = new System.Drawing.Point(12, 332);
            this.recordingGroupBox.Name = "recordingGroupBox";
            this.recordingGroupBox.Size = new System.Drawing.Size(491, 53);
            this.recordingGroupBox.TabIndex = 7;
            this.recordingGroupBox.TabStop = false;
            this.recordingGroupBox.Text = "Записи";
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Location = new System.Drawing.Point(432, 20);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(24, 13);
            this.labelcount.TabIndex = 12;
            this.labelcount.Text = "0/0";
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(204, 19);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(60, 23);
            this.allButton.TabIndex = 3;
            this.allButton.Text = "Все";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // twoHunButton
            // 
            this.twoHunButton.Location = new System.Drawing.Point(138, 19);
            this.twoHunButton.Name = "twoHunButton";
            this.twoHunButton.Size = new System.Drawing.Size(60, 23);
            this.twoHunButton.TabIndex = 2;
            this.twoHunButton.Text = "200 ";
            this.twoHunButton.UseVisualStyleBackColor = true;
            this.twoHunButton.Click += new System.EventHandler(this.twoHunButton_Click);
            // 
            // pageGroupBox
            // 
            this.pageGroupBox.Controls.Add(this.nextButton);
            this.pageGroupBox.Controls.Add(this.backButton);
            this.pageGroupBox.Location = new System.Drawing.Point(273, 0);
            this.pageGroupBox.Name = "pageGroupBox";
            this.pageGroupBox.Size = new System.Drawing.Size(152, 53);
            this.pageGroupBox.TabIndex = 11;
            this.pageGroupBox.TabStop = false;
            this.pageGroupBox.Text = "Переключение страниц";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(70, 19);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(60, 23);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Вперёд";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(6, 19);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(60, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // FiftyButton
            // 
            this.FiftyButton.Location = new System.Drawing.Point(72, 19);
            this.FiftyButton.Name = "FiftyButton";
            this.FiftyButton.Size = new System.Drawing.Size(60, 23);
            this.FiftyButton.TabIndex = 1;
            this.FiftyButton.Text = "50 ";
            this.FiftyButton.UseVisualStyleBackColor = true;
            this.FiftyButton.Click += new System.EventHandler(this.FiftyButton_Click);
            // 
            // TenButton
            // 
            this.TenButton.Location = new System.Drawing.Point(6, 19);
            this.TenButton.Name = "TenButton";
            this.TenButton.Size = new System.Drawing.Size(60, 23);
            this.TenButton.TabIndex = 0;
            this.TenButton.Text = "10";
            this.TenButton.UseVisualStyleBackColor = true;
            this.TenButton.Click += new System.EventHandler(this.TenButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(1008, 335);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(56, 50);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 6;
            this.LogoPictureBox.TabStop = false;
            // 
            // ClientDataGridView
            // 
            this.ClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ClientDataGridView.Name = "ClientDataGridView";
            this.ClientDataGridView.Size = new System.Drawing.Size(1052, 314);
            this.ClientDataGridView.TabIndex = 5;
            this.ClientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientDataGridView_CellContentClick);
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.manButton);
            this.genderGroupBox.Controls.Add(this.allGenderButton);
            this.genderGroupBox.Controls.Add(this.womanButton);
            this.genderGroupBox.Location = new System.Drawing.Point(206, 396);
            this.genderGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderGroupBox.Size = new System.Drawing.Size(135, 140);
            this.genderGroupBox.TabIndex = 13;
            this.genderGroupBox.TabStop = false;
            this.genderGroupBox.Text = "Пол";
            // 
            // manButton
            // 
            this.manButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.manButton.Location = new System.Drawing.Point(10, 35);
            this.manButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manButton.Name = "manButton";
            this.manButton.Size = new System.Drawing.Size(53, 21);
            this.manButton.TabIndex = 9;
            this.manButton.Text = "М";
            this.manButton.UseVisualStyleBackColor = false;
            this.manButton.Click += new System.EventHandler(this.manButton_Click);
            // 
            // allGenderButton
            // 
            this.allGenderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.allGenderButton.Location = new System.Drawing.Point(10, 82);
            this.allGenderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allGenderButton.Name = "allGenderButton";
            this.allGenderButton.Size = new System.Drawing.Size(112, 22);
            this.allGenderButton.TabIndex = 11;
            this.allGenderButton.Text = "Все";
            this.allGenderButton.UseVisualStyleBackColor = false;
            this.allGenderButton.Click += new System.EventHandler(this.allGenderButton_Click);
            // 
            // womanButton
            // 
            this.womanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.womanButton.Location = new System.Drawing.Point(69, 35);
            this.womanButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.womanButton.Name = "womanButton";
            this.womanButton.Size = new System.Drawing.Size(53, 21);
            this.womanButton.TabIndex = 10;
            this.womanButton.Text = "Ж";
            this.womanButton.UseVisualStyleBackColor = false;
            this.womanButton.Click += new System.EventHandler(this.womanButton_Click);
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.birthButton);
            this.sortGroupBox.Controls.Add(this.visitsButton);
            this.sortGroupBox.Controls.Add(this.lastdateButton);
            this.sortGroupBox.Controls.Add(this.sortFnameButton);
            this.sortGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sortGroupBox.Location = new System.Drawing.Point(12, 396);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(188, 140);
            this.sortGroupBox.TabIndex = 15;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Сортировка";
            // 
            // birthButton
            // 
            this.birthButton.Location = new System.Drawing.Point(6, 110);
            this.birthButton.Name = "birthButton";
            this.birthButton.Size = new System.Drawing.Size(170, 24);
            this.birthButton.TabIndex = 21;
            this.birthButton.Text = "Рождение в этом месяце";
            this.birthButton.UseVisualStyleBackColor = true;
            this.birthButton.Click += new System.EventHandler(this.birthButton_Click);
            // 
            // visitsButton
            // 
            this.visitsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.visitsButton.Location = new System.Drawing.Point(6, 80);
            this.visitsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.visitsButton.Name = "visitsButton";
            this.visitsButton.Size = new System.Drawing.Size(173, 24);
            this.visitsButton.TabIndex = 14;
            this.visitsButton.Text = "Посещения";
            this.visitsButton.UseVisualStyleBackColor = false;
            this.visitsButton.Click += new System.EventHandler(this.visitsButton_Click);
            // 
            // lastdateButton
            // 
            this.lastdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.lastdateButton.Location = new System.Drawing.Point(6, 50);
            this.lastdateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastdateButton.Name = "lastdateButton";
            this.lastdateButton.Size = new System.Drawing.Size(173, 24);
            this.lastdateButton.TabIndex = 13;
            this.lastdateButton.Text = "Последние посещения";
            this.lastdateButton.UseVisualStyleBackColor = false;
            this.lastdateButton.Click += new System.EventHandler(this.lastdateButton_Click);
            // 
            // sortFnameButton
            // 
            this.sortFnameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.sortFnameButton.Location = new System.Drawing.Point(6, 21);
            this.sortFnameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sortFnameButton.Name = "sortFnameButton";
            this.sortFnameButton.Size = new System.Drawing.Size(173, 23);
            this.sortFnameButton.TabIndex = 12;
            this.sortFnameButton.Text = "Фамилии А-Я";
            this.sortFnameButton.UseVisualStyleBackColor = false;
            this.sortFnameButton.Click += new System.EventHandler(this.sortFnameButton_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.label3);
            this.searchGroupBox.Controls.Add(this.label2);
            this.searchGroupBox.Controls.Add(this.label1);
            this.searchGroupBox.Controls.Add(this.searchPhoneTextBox);
            this.searchGroupBox.Controls.Add(this.searchMailTextBox);
            this.searchGroupBox.Controls.Add(this.searchNameTextBox);
            this.searchGroupBox.Location = new System.Drawing.Point(347, 396);
            this.searchGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchGroupBox.Size = new System.Drawing.Size(210, 140);
            this.searchGroupBox.TabIndex = 16;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Поиск";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО";
            // 
            // searchPhoneTextBox
            // 
            this.searchPhoneTextBox.Location = new System.Drawing.Point(66, 101);
            this.searchPhoneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchPhoneTextBox.Name = "searchPhoneTextBox";
            this.searchPhoneTextBox.Size = new System.Drawing.Size(131, 20);
            this.searchPhoneTextBox.TabIndex = 2;
            this.searchPhoneTextBox.TextChanged += new System.EventHandler(this.searchPhoneTextBox_TextChanged);
            // 
            // searchMailTextBox
            // 
            this.searchMailTextBox.Location = new System.Drawing.Point(66, 62);
            this.searchMailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchMailTextBox.Name = "searchMailTextBox";
            this.searchMailTextBox.Size = new System.Drawing.Size(131, 20);
            this.searchMailTextBox.TabIndex = 1;
            this.searchMailTextBox.TextChanged += new System.EventHandler(this.searchMailTextBox_TextChanged);
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(67, 23);
            this.searchNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(131, 20);
            this.searchNameTextBox.TabIndex = 0;
            this.searchNameTextBox.TextChanged += new System.EventHandler(this.searchNameTextBox_TextChanged);
            // 
            // workDataGroupBox
            // 
            this.workDataGroupBox.Controls.Add(this.editButton);
            this.workDataGroupBox.Controls.Add(this.nameDelLabel);
            this.workDataGroupBox.Controls.Add(this.addButton);
            this.workDataGroupBox.Controls.Add(this.deleteButton);
            this.workDataGroupBox.Controls.Add(this.idTextBox);
            this.workDataGroupBox.Location = new System.Drawing.Point(563, 396);
            this.workDataGroupBox.Name = "workDataGroupBox";
            this.workDataGroupBox.Size = new System.Drawing.Size(211, 140);
            this.workDataGroupBox.TabIndex = 19;
            this.workDataGroupBox.TabStop = false;
            this.workDataGroupBox.Text = "Работа с данными";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.editButton.Location = new System.Drawing.Point(12, 65);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(181, 21);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // nameDelLabel
            // 
            this.nameDelLabel.AutoSize = true;
            this.nameDelLabel.Location = new System.Drawing.Point(158, 110);
            this.nameDelLabel.Name = "nameDelLabel";
            this.nameDelLabel.Size = new System.Drawing.Size(29, 13);
            this.nameDelLabel.TabIndex = 16;
            this.nameDelLabel.Text = "Имя";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.addButton.Location = new System.Drawing.Point(12, 23);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(181, 21);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.deleteButton.Location = new System.Drawing.Point(12, 106);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 24);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Удалить по ID";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(112, 107);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(40, 20);
            this.idTextBox.TabIndex = 15;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(809, 506);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Имя";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 546);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.workDataGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.recordingGroupBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.ClientDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientForm";
            this.Text = "Список клиентов";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.recordingGroupBox.ResumeLayout(false);
            this.recordingGroupBox.PerformLayout();
            this.pageGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).EndInit();
            this.genderGroupBox.ResumeLayout(false);
            this.sortGroupBox.ResumeLayout(false);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.workDataGroupBox.ResumeLayout(false);
            this.workDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox recordingGroupBox;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Button twoHunButton;
        private System.Windows.Forms.Button FiftyButton;
        private System.Windows.Forms.Button TenButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.DataGridView ClientDataGridView;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox pageGroupBox;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.Button manButton;
        private System.Windows.Forms.Button allGenderButton;
        private System.Windows.Forms.Button womanButton;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.Button visitsButton;
        private System.Windows.Forms.Button lastdateButton;
        private System.Windows.Forms.Button sortFnameButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchPhoneTextBox;
        private System.Windows.Forms.TextBox searchMailTextBox;
        private System.Windows.Forms.TextBox searchNameTextBox;
        private System.Windows.Forms.GroupBox workDataGroupBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label nameDelLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button birthButton;
    }
}

