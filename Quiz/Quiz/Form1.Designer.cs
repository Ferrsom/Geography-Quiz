namespace Quiz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbTi = new Label();
            tbPl = new TextBox();
            rbFHa = new RadioButton();
            rbFFl = new RadioButton();
            rbFLa = new RadioButton();
            rbSHa = new RadioButton();
            rbSFl = new RadioButton();
            rbSLa = new RadioButton();
            btSt = new Button();
            gbS = new GroupBox();
            gbF = new GroupBox();
            lbDe = new Label();
            btSc = new Button();
            cbPl = new ComboBox();
            tbLo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btPl = new Button();
            gbS.SuspendLayout();
            gbF.SuspendLayout();
            SuspendLayout();
            // 
            // lbTi
            // 
            lbTi.AutoSize = true;
            lbTi.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTi.Location = new Point(493, 43);
            lbTi.Name = "lbTi";
            lbTi.Size = new Size(180, 46);
            lbTi.TabIndex = 0;
            lbTi.Text = "GEO QUIZ";
            // 
            // tbPl
            // 
            tbPl.Location = new Point(580, 218);
            tbPl.Margin = new Padding(3, 4, 3, 4);
            tbPl.Name = "tbPl";
            tbPl.Size = new Size(181, 27);
            tbPl.TabIndex = 2;
            // 
            // rbFHa
            // 
            rbFHa.AutoSize = true;
            rbFHa.Location = new Point(6, 28);
            rbFHa.Margin = new Padding(3, 4, 3, 4);
            rbFHa.Name = "rbFHa";
            rbFHa.Size = new Size(120, 24);
            rbFHa.TabIndex = 6;
            rbFHa.TabStop = true;
            rbFHa.Text = "Hauptstädten";
            rbFHa.UseVisualStyleBackColor = true;
            // 
            // rbFFl
            // 
            rbFFl.AutoSize = true;
            rbFFl.Location = new Point(6, 58);
            rbFFl.Margin = new Padding(3, 4, 3, 4);
            rbFFl.Name = "rbFFl";
            rbFFl.Size = new Size(83, 24);
            rbFFl.TabIndex = 7;
            rbFFl.TabStop = true;
            rbFFl.Text = "Flaggen";
            rbFFl.UseVisualStyleBackColor = true;
            // 
            // rbFLa
            // 
            rbFLa.AutoSize = true;
            rbFLa.Location = new Point(6, 90);
            rbFLa.Margin = new Padding(3, 4, 3, 4);
            rbFLa.Name = "rbFLa";
            rbFLa.Size = new Size(83, 24);
            rbFLa.TabIndex = 8;
            rbFLa.TabStop = true;
            rbFLa.Text = "Ländern";
            rbFLa.UseVisualStyleBackColor = true;
            // 
            // rbSHa
            // 
            rbSHa.AutoSize = true;
            rbSHa.Location = new Point(6, 28);
            rbSHa.Margin = new Padding(3, 4, 3, 4);
            rbSHa.Name = "rbSHa";
            rbSHa.Size = new Size(120, 24);
            rbSHa.TabIndex = 9;
            rbSHa.TabStop = true;
            rbSHa.Text = "Hauptstädten";
            rbSHa.UseVisualStyleBackColor = true;
            // 
            // rbSFl
            // 
            rbSFl.AutoSize = true;
            rbSFl.Location = new Point(6, 58);
            rbSFl.Margin = new Padding(3, 4, 3, 4);
            rbSFl.Name = "rbSFl";
            rbSFl.Size = new Size(83, 24);
            rbSFl.TabIndex = 10;
            rbSFl.TabStop = true;
            rbSFl.Text = "Flaggen";
            rbSFl.UseVisualStyleBackColor = true;
            // 
            // rbSLa
            // 
            rbSLa.AutoSize = true;
            rbSLa.Location = new Point(6, 92);
            rbSLa.Margin = new Padding(3, 4, 3, 4);
            rbSLa.Name = "rbSLa";
            rbSLa.Size = new Size(83, 24);
            rbSLa.TabIndex = 11;
            rbSLa.TabStop = true;
            rbSLa.Text = "Ländern";
            rbSLa.UseVisualStyleBackColor = true;
            // 
            // btSt
            // 
            btSt.Location = new Point(452, 464);
            btSt.Margin = new Padding(3, 4, 3, 4);
            btSt.Name = "btSt";
            btSt.Size = new Size(146, 32);
            btSt.TabIndex = 12;
            btSt.Text = "Go!";
            btSt.UseVisualStyleBackColor = true;
            btSt.Click += btSt_Click;
            // 
            // gbS
            // 
            gbS.Controls.Add(rbSHa);
            gbS.Controls.Add(rbSFl);
            gbS.Controls.Add(rbSLa);
            gbS.Location = new Point(107, 296);
            gbS.Margin = new Padding(3, 4, 3, 4);
            gbS.Name = "gbS";
            gbS.Padding = new Padding(3, 4, 3, 4);
            gbS.Size = new Size(290, 122);
            gbS.TabIndex = 13;
            gbS.TabStop = false;
            gbS.Text = "Schau dir das an!";
            // 
            // gbF
            // 
            gbF.Controls.Add(rbFHa);
            gbF.Controls.Add(rbFFl);
            gbF.Controls.Add(rbFLa);
            gbF.Location = new Point(463, 296);
            gbF.Margin = new Padding(3, 4, 3, 4);
            gbF.Name = "gbF";
            gbF.Padding = new Padding(3, 4, 3, 4);
            gbF.Size = new Size(280, 124);
            gbF.TabIndex = 14;
            gbF.TabStop = false;
            gbF.Text = "Finde es raus!";
            // 
            // lbDe
            // 
            lbDe.AutoSize = true;
            lbDe.Location = new Point(390, 104);
            lbDe.Name = "lbDe";
            lbDe.Size = new Size(398, 40);
            lbDe.TabIndex = 15;
            lbDe.Text = "Mix and Match! Verbinde Länder, Hauptstädte und Flaggen\r\nWie viele schaffst du richtig?";
            lbDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btSc
            // 
            btSc.Location = new Point(221, 463);
            btSc.Margin = new Padding(3, 4, 3, 4);
            btSc.Name = "btSc";
            btSc.Size = new Size(135, 33);
            btSc.TabIndex = 16;
            btSc.Text = "Scores";
            btSc.UseVisualStyleBackColor = true;
            btSc.Click += btSc_Click;
            // 
            // cbPl
            // 
            cbPl.FormattingEnabled = true;
            cbPl.Location = new Point(580, 183);
            cbPl.Name = "cbPl";
            cbPl.Size = new Size(181, 28);
            cbPl.TabIndex = 17;
            // 
            // tbLo
            // 
            tbLo.BackColor = SystemColors.Control;
            tbLo.Font = new Font("Consolas", 4.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLo.Location = new Point(113, 32);
            tbLo.Multiline = true;
            tbLo.Name = "tbLo";
            tbLo.ReadOnly = true;
            tbLo.Size = new Size(202, 213);
            tbLo.TabIndex = 18;
            tbLo.Text = resources.GetString("tbLo.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(418, 186);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 19;
            label1.Text = "Wähle einen Benutzer ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 221);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 20;
            label2.Text = "Erstelle einen neuen\r\n";
            // 
            // btPl
            // 
            btPl.Location = new Point(767, 218);
            btPl.Name = "btPl";
            btPl.Size = new Size(67, 27);
            btPl.TabIndex = 21;
            btPl.Text = "New";
            btPl.UseVisualStyleBackColor = true;
            btPl.Click += btPl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 536);
            Controls.Add(btPl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbLo);
            Controls.Add(cbPl);
            Controls.Add(btSc);
            Controls.Add(lbDe);
            Controls.Add(gbF);
            Controls.Add(gbS);
            Controls.Add(btSt);
            Controls.Add(tbPl);
            Controls.Add(lbTi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            gbS.ResumeLayout(false);
            gbS.PerformLayout();
            gbF.ResumeLayout(false);
            gbF.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTi;
        private TextBox tbPl;
        private RadioButton rbFHa;
        private RadioButton rbFFl;
        private RadioButton rbFLa;
        private RadioButton rbSHa;
        private RadioButton rbSFl;
        private RadioButton rbSLa;
        private Button btSt;
        private GroupBox gbS;
        private GroupBox gbF;
        private Label lbDe;
        private Button btSc;
        private ComboBox cbPl;
        private TextBox tbLo;
        private Label label1;
        private Label label2;
        private Button btPl;
    }
}
