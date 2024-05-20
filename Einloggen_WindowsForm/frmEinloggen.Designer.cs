namespace Einloggen_WindowsForm
{
    partial class frmEinloggen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bttnEinloggen = new Button();
            bttn_X = new Button();
            label_Benutzername = new Label();
            label_Passwort = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // bttnEinloggen
            // 
            bttnEinloggen.BackColor = Color.Green;
            bttnEinloggen.FlatAppearance.BorderSize = 0;
            bttnEinloggen.FlatStyle = FlatStyle.Flat;
            bttnEinloggen.Font = new Font("Segoe UI", 18F);
            bttnEinloggen.Location = new Point(47, 79);
            bttnEinloggen.Name = "bttnEinloggen";
            bttnEinloggen.Size = new Size(293, 86);
            bttnEinloggen.TabIndex = 0;
            bttnEinloggen.Text = "Anmelden";
            bttnEinloggen.UseVisualStyleBackColor = false;
            // 
            // bttn_X
            // 
            bttn_X.AutoSize = true;
            bttn_X.FlatAppearance.BorderColor = Color.DarkSlateGray;
            bttn_X.FlatAppearance.BorderSize = 0;
            bttn_X.FlatAppearance.MouseOverBackColor = Color.Red;
            bttn_X.FlatStyle = FlatStyle.Flat;
            bttn_X.Font = new Font("Segoe UI", 12F);
            bttn_X.Location = new Point(342, 3);
            bttn_X.Name = "bttn_X";
            bttn_X.Size = new Size(38, 42);
            bttn_X.TabIndex = 1;
            bttn_X.Text = "X";
            bttn_X.UseVisualStyleBackColor = true;
            bttn_X.Click += bttn_X_Click;
            // 
            // label_Benutzername
            // 
            label_Benutzername.AutoSize = true;
            label_Benutzername.BackColor = Color.LightSlateGray;
            label_Benutzername.Font = new Font("Segoe UI", 11F);
            label_Benutzername.ForeColor = Color.FromArgb(0, 0, 192);
            label_Benutzername.Location = new Point(47, 196);
            label_Benutzername.Name = "label_Benutzername";
            label_Benutzername.Size = new Size(134, 25);
            label_Benutzername.TabIndex = 2;
            label_Benutzername.Text = "Benutzername";
            // 
            // label_Passwort
            // 
            label_Passwort.AutoSize = true;
            label_Passwort.BackColor = Color.LightSlateGray;
            label_Passwort.Font = new Font("Segoe UI", 11F);
            label_Passwort.ForeColor = Color.FromArgb(0, 0, 192);
            label_Passwort.Location = new Point(47, 294);
            label_Passwort.Name = "label_Passwort";
            label_Passwort.Size = new Size(86, 25);
            label_Passwort.TabIndex = 3;
            label_Passwort.Text = "Passwort";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(47, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "Benutzername";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(47, 322);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(293, 27);
            textBox2.TabIndex = 5;
            textBox2.Text = "Passwort";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSlateGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(47, 355);
            button1.Name = "button1";
            button1.Size = new Size(293, 54);
            button1.TabIndex = 6;
            button1.Text = "Anmelden";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(98, 422);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(142, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Passwort vergessen?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 460);
            label1.Name = "label1";
            label1.Size = new Size(222, 20);
            label1.TabIndex = 8;
            label1.Text = "Sie haben noch keinen Account?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(52, 493);
            label2.Name = "label2";
            label2.Size = new Size(256, 20);
            label2.TabIndex = 9;
            label2.Text = "Registrieren Sie sich als neuer Nutzer!";
            // 
            // frmEinloggen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(381, 538);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label_Passwort);
            Controls.Add(label_Benutzername);
            Controls.Add(bttn_X);
            Controls.Add(bttnEinloggen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEinloggen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EINLOGGEN";
            Load += frmEinloggen_Load;
            MouseDown += frmEinloggen_MouseDown;
            MouseMove += frmEinloggen_MouseMove;
            MouseUp += frmEinloggen_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnEinloggen;
        private Button bttn_X;
        private Label label_Benutzername;
        private Label label_Passwort;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label2;
    }
}
