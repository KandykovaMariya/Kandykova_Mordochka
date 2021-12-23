
namespace Kandykova_Mordochka
{
    partial class AddClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClientForm));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.photoButton = new System.Windows.Forms.Button();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLable = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.manRadioButton = new System.Windows.Forms.RadioButton();
            this.womanRadioButton = new System.Windows.Forms.RadioButton();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.birthLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.photoGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.genderGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.photoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(495, 213);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(100, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // photoButton
            // 
            this.photoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.photoButton.Location = new System.Drawing.Point(499, 184);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(96, 23);
            this.photoButton.TabIndex = 62;
            this.photoButton.Text = "Выбрать";
            this.photoButton.UseVisualStyleBackColor = false;
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Location = new System.Drawing.Point(6, 11);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(161, 158);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 61;
            this.photoPictureBox.TabStop = false;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(130, 229);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(107, 20);
            this.idTextBox.TabIndex = 60;
            // 
            // idLable
            // 
            this.idLable.AutoSize = true;
            this.idLable.Location = new System.Drawing.Point(12, 232);
            this.idLable.Name = "idLable";
            this.idLable.Size = new System.Drawing.Size(18, 13);
            this.idLable.TabIndex = 59;
            this.idLable.Text = "ID";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.saveButton.Location = new System.Drawing.Point(495, 274);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 23);
            this.saveButton.TabIndex = 58;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateTimePicker.Location = new System.Drawing.Point(130, 188);
            this.birthDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(233, 20);
            this.birthDateTimePicker.TabIndex = 57;
            this.birthDateTimePicker.ValueChanged += new System.EventHandler(this.birthDateTimePicker_ValueChanged);
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.manRadioButton);
            this.genderGroupBox.Controls.Add(this.womanRadioButton);
            this.genderGroupBox.Location = new System.Drawing.Point(243, 216);
            this.genderGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderGroupBox.Size = new System.Drawing.Size(120, 81);
            this.genderGroupBox.TabIndex = 56;
            this.genderGroupBox.TabStop = false;
            this.genderGroupBox.Text = "Пол";
            // 
            // manRadioButton
            // 
            this.manRadioButton.AutoSize = true;
            this.manRadioButton.Location = new System.Drawing.Point(6, 24);
            this.manRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manRadioButton.Name = "manRadioButton";
            this.manRadioButton.Size = new System.Drawing.Size(50, 17);
            this.manRadioButton.TabIndex = 18;
            this.manRadioButton.TabStop = true;
            this.manRadioButton.Text = "Муж.";
            this.manRadioButton.UseVisualStyleBackColor = true;
            this.manRadioButton.CheckedChanged += new System.EventHandler(this.manRadioButton_CheckedChanged);
            // 
            // womanRadioButton
            // 
            this.womanRadioButton.AutoSize = true;
            this.womanRadioButton.Location = new System.Drawing.Point(6, 53);
            this.womanRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.womanRadioButton.Name = "womanRadioButton";
            this.womanRadioButton.Size = new System.Drawing.Size(51, 17);
            this.womanRadioButton.TabIndex = 19;
            this.womanRadioButton.TabStop = true;
            this.womanRadioButton.Text = "Жен.";
            this.womanRadioButton.UseVisualStyleBackColor = true;
            this.womanRadioButton.CheckedChanged += new System.EventHandler(this.womanRadioButton_CheckedChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(130, 155);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(233, 20);
            this.phoneTextBox.TabIndex = 55;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(130, 115);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(233, 20);
            this.emailTextBox.TabIndex = 54;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(130, 81);
            this.patronymicTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(233, 20);
            this.patronymicTextBox.TabIndex = 53;
            this.patronymicTextBox.TextChanged += new System.EventHandler(this.patronymicTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(130, 42);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.lastNameTextBox.TabIndex = 52;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(130, 6);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.firstNameTextBox.TabIndex = 51;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Location = new System.Drawing.Point(12, 194);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(86, 13);
            this.birthLabel.TabIndex = 49;
            this.birthLabel.Text = "Дата рождения";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 118);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(31, 13);
            this.emailLabel.TabIndex = 48;
            this.emailLabel.Text = "email";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(12, 158);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(52, 13);
            this.phoneLabel.TabIndex = 47;
            this.phoneLabel.Text = "Телефон";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Location = new System.Drawing.Point(12, 45);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(29, 13);
            this.lNameLabel.TabIndex = 46;
            this.lNameLabel.Text = "Имя";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Location = new System.Drawing.Point(12, 84);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(54, 13);
            this.patronymicLabel.TabIndex = 45;
            this.patronymicLabel.Text = "Отчетсво";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(12, 9);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(56, 13);
            this.fNameLabel.TabIndex = 44;
            this.fNameLabel.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 26);
            this.label1.TabIndex = 63;
            this.label1.Text = "При добавлении или редактировании данных о клиентах, следует соблюдать требования" +
    " заполнения данных.\r\nВвозможности пользователя входит только просмотр данных.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 43);
            this.panel1.TabIndex = 64;
            // 
            // photoGroupBox
            // 
            this.photoGroupBox.Controls.Add(this.photoPictureBox);
            this.photoGroupBox.Location = new System.Drawing.Point(421, 6);
            this.photoGroupBox.Name = "photoGroupBox";
            this.photoGroupBox.Size = new System.Drawing.Size(174, 172);
            this.photoGroupBox.TabIndex = 65;
            this.photoGroupBox.TabStop = false;
            this.photoGroupBox.Text = "Фото";
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 359);
            this.Controls.Add(this.photoGroupBox);
            this.Controls.Add(this.photoButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLable);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lNameLabel);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddClientForm";
            this.Text = "Добавление/Редактирование";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.photoGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        public System.Windows.Forms.Button photoButton;
        public System.Windows.Forms.PictureBox photoPictureBox;
        public System.Windows.Forms.TextBox idTextBox;
        public System.Windows.Forms.Label idLable;
        public System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.DateTimePicker birthDateTimePicker;
        public System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton manRadioButton;
        private System.Windows.Forms.RadioButton womanRadioButton;
        public System.Windows.Forms.TextBox phoneTextBox;
        public System.Windows.Forms.TextBox emailTextBox;
        public System.Windows.Forms.TextBox patronymicTextBox;
        public System.Windows.Forms.TextBox lastNameTextBox;
        public System.Windows.Forms.TextBox firstNameTextBox;
        public System.Windows.Forms.Label birthLabel;
        public System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.Label phoneLabel;
        public System.Windows.Forms.Label lNameLabel;
        public System.Windows.Forms.Label patronymicLabel;
        public System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox photoGroupBox;
    }
}