namespace Quiz
{
    partial class GameW
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
            rb1 = new RadioButton();
            rb2 = new RadioButton();
            rb3 = new RadioButton();
            btnAn = new Button();
            btnBa = new Button();
            lblCl = new Label();
            rb4 = new RadioButton();
            pbFl = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbFl).BeginInit();
            SuspendLayout();
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(547, 50);
            rb1.Margin = new Padding(3, 4, 3, 4);
            rb1.Name = "rb1";
            rb1.Size = new Size(117, 24);
            rb1.TabIndex = 0;
            rb1.TabStop = true;
            rb1.Text = "radioButton1";
            rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(547, 140);
            rb2.Margin = new Padding(3, 4, 3, 4);
            rb2.Name = "rb2";
            rb2.Size = new Size(117, 24);
            rb2.TabIndex = 1;
            rb2.TabStop = true;
            rb2.Text = "radioButton2";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(547, 230);
            rb3.Margin = new Padding(3, 4, 3, 4);
            rb3.Name = "rb3";
            rb3.Size = new Size(117, 24);
            rb3.TabIndex = 2;
            rb3.TabStop = true;
            rb3.Text = "radioButton3";
            rb3.UseVisualStyleBackColor = true;
            // 
            // btnAn
            // 
            btnAn.Location = new Point(517, 427);
            btnAn.Margin = new Padding(3, 4, 3, 4);
            btnAn.Name = "btnAn";
            btnAn.Size = new Size(177, 66);
            btnAn.TabIndex = 3;
            btnAn.Text = "Antwort";
            btnAn.UseVisualStyleBackColor = true;
            btnAn.Click += btnAn_Click;
            // 
            // btnBa
            // 
            btnBa.Location = new Point(149, 427);
            btnBa.Name = "btnBa";
            btnBa.Size = new Size(177, 66);
            btnBa.TabIndex = 4;
            btnBa.Text = "Back";
            btnBa.UseVisualStyleBackColor = true;
            btnBa.Click += btnBa_Click;
            // 
            // lblCl
            // 
            lblCl.AutoSize = true;
            lblCl.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCl.Location = new Point(201, 173);
            lblCl.Name = "lblCl";
            lblCl.Size = new Size(109, 46);
            lblCl.TabIndex = 5;
            lblCl.Text = "label1";
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new Point(547, 320);
            rb4.Name = "rb4";
            rb4.Size = new Size(117, 24);
            rb4.TabIndex = 6;
            rb4.TabStop = true;
            rb4.Text = "radioButton4";
            rb4.UseVisualStyleBackColor = true;
            // 
            // pbFl
            // 
            pbFl.Location = new Point(128, 92);
            pbFl.Name = "pbFl";
            pbFl.Size = new Size(250, 210);
            pbFl.SizeMode = PictureBoxSizeMode.Zoom;
            pbFl.TabIndex = 7;
            pbFl.TabStop = false;
            // 
            // GameW
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 539);
            Controls.Add(lblCl);
            Controls.Add(pbFl);
            Controls.Add(rb4);
            Controls.Add(btnBa);
            Controls.Add(btnAn);
            Controls.Add(rb3);
            Controls.Add(rb2);
            Controls.Add(rb1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GameW";
            Text = "GameF";
            FormClosing += GameW_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbFl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rb1;
        private RadioButton rb2;
        private RadioButton rb3;
        private Button btnAn;
        private Button btnBa;
        private Label lblCl;
        private RadioButton rb4;
        private PictureBox pbFl;
    }
}