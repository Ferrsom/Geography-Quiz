namespace Quiz
{
    partial class Scores
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
            dgvSc = new DataGridView();
            clmPl = new DataGridViewTextBoxColumn();
            clmSc = new DataGridViewTextBoxColumn();
            cbSc = new ComboBox();
            btBa = new Button();
            btnCl = new Button();
            btnDe = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSc).BeginInit();
            SuspendLayout();
            // 
            // dgvSc
            // 
            dgvSc.AllowUserToAddRows = false;
            dgvSc.AllowUserToResizeColumns = false;
            dgvSc.AllowUserToResizeRows = false;
            dgvSc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSc.Columns.AddRange(new DataGridViewColumn[] { clmPl, clmSc });
            dgvSc.Location = new Point(62, 32);
            dgvSc.Margin = new Padding(3, 4, 3, 4);
            dgvSc.Name = "dgvSc";
            dgvSc.RowHeadersWidth = 51;
            dgvSc.Size = new Size(312, 381);
            dgvSc.TabIndex = 0;
            // 
            // clmPl
            // 
            clmPl.Frozen = true;
            clmPl.HeaderText = "Player";
            clmPl.MinimumWidth = 10;
            clmPl.Name = "clmPl";
            clmPl.ReadOnly = true;
            clmPl.Width = 130;
            // 
            // clmSc
            // 
            clmSc.Frozen = true;
            clmSc.HeaderText = "Score";
            clmSc.MinimumWidth = 10;
            clmSc.Name = "clmSc";
            clmSc.ReadOnly = true;
            clmSc.Width = 130;
            // 
            // cbSc
            // 
            cbSc.FormattingEnabled = true;
            cbSc.Location = new Point(459, 145);
            cbSc.Margin = new Padding(3, 4, 3, 4);
            cbSc.Name = "cbSc";
            cbSc.Size = new Size(210, 28);
            cbSc.TabIndex = 2;
            cbSc.SelectedIndexChanged += cbSc_SelectedIndexChanged;
            // 
            // btBa
            // 
            btBa.Location = new Point(338, 449);
            btBa.Name = "btBa";
            btBa.Size = new Size(174, 34);
            btBa.TabIndex = 3;
            btBa.Text = "back";
            btBa.UseVisualStyleBackColor = true;
            btBa.Click += btBa_Click;
            // 
            // btnCl
            // 
            btnCl.Location = new Point(695, 136);
            btnCl.Name = "btnCl";
            btnCl.Size = new Size(83, 44);
            btnCl.TabIndex = 4;
            btnCl.Text = "Clear";
            btnCl.UseVisualStyleBackColor = true;
            btnCl.Click += btnCl_Click;
            // 
            // btnDe
            // 
            btnDe.Location = new Point(567, 293);
            btnDe.Name = "btnDe";
            btnDe.Size = new Size(112, 43);
            btnDe.TabIndex = 5;
            btnDe.Text = "Delete";
            btnDe.UseVisualStyleBackColor = true;
            btnDe.Click += btnDe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(436, 87);
            label1.Name = "label1";
            label1.Size = new Size(368, 20);
            label1.TabIndex = 6;
            label1.Text = "Such dir einen Spieler aus und sieh dir seine Scores an!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 233);
            label2.Name = "label2";
            label2.Size = new Size(340, 40);
            label2.TabIndex = 7;
            label2.Text = "Willst du den oben ausgewählten Spieler löschen?\r\nDamit verschwinden auch alle seine Scores!";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Scores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 538);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDe);
            Controls.Add(btnCl);
            Controls.Add(btBa);
            Controls.Add(cbSc);
            Controls.Add(dgvSc);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Scores";
            Text = "Scores";
            FormClosing += Scores_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvSc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSc;
        private ComboBox cbSc;
        private Button btBa;
        private Button btnCl;
        private Button btnDe;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn clmPl;
        private DataGridViewTextBoxColumn clmSc;
    }
}