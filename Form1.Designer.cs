namespace Testes
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
            txtPriNum = new TextBox();
            txtSegNum = new TextBox();
            txtResult = new TextBox();
            btnMais = new Button();
            btnMenos = new Button();
            btnVezes = new Button();
            btnDiv = new Button();
            lblPriNum = new Label();
            lblSegNum = new Label();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // txtPriNum
            // 
            txtPriNum.Location = new Point(286, 74);
            txtPriNum.Name = "txtPriNum";
            txtPriNum.Size = new Size(228, 23);
            txtPriNum.TabIndex = 0;
            // 
            // txtSegNum
            // 
            txtSegNum.Location = new Point(286, 171);
            txtSegNum.Name = "txtSegNum";
            txtSegNum.Size = new Size(228, 23);
            txtSegNum.TabIndex = 1;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(286, 277);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(228, 23);
            txtResult.TabIndex = 2;
            // 
            // btnMais
            // 
            btnMais.Location = new Point(286, 233);
            btnMais.Name = "btnMais";
            btnMais.Size = new Size(31, 23);
            btnMais.TabIndex = 3;
            btnMais.Text = "+";
            btnMais.UseVisualStyleBackColor = true;
            btnMais.Click += btnMais_Click;
            // 
            // btnMenos
            // 
            btnMenos.Location = new Point(327, 233);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(26, 23);
            btnMenos.TabIndex = 4;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnVezes
            // 
            btnVezes.Location = new Point(440, 233);
            btnVezes.Name = "btnVezes";
            btnVezes.Size = new Size(39, 23);
            btnVezes.TabIndex = 5;
            btnVezes.Text = "*";
            btnVezes.UseVisualStyleBackColor = true;
            btnVezes.Click += btnVezes_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(485, 233);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(29, 23);
            btnDiv.TabIndex = 6;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // lblPriNum
            // 
            lblPriNum.AutoSize = true;
            lblPriNum.Location = new Point(327, 34);
            lblPriNum.Name = "lblPriNum";
            lblPriNum.Size = new Size(144, 15);
            lblPriNum.TabIndex = 7;
            lblPriNum.Text = "Digite o primeiro numero:";
            // 
            // lblSegNum
            // 
            lblSegNum.AutoSize = true;
            lblSegNum.Location = new Point(327, 119);
            lblSegNum.Name = "lblSegNum";
            lblSegNum.Size = new Size(145, 15);
            lblSegNum.TabIndex = 8;
            lblSegNum.Text = "Digite o segundo numero:";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Red;
            btnLimpar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpar.Location = new Point(359, 233);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpar);
            Controls.Add(lblSegNum);
            Controls.Add(lblPriNum);
            Controls.Add(btnDiv);
            Controls.Add(btnVezes);
            Controls.Add(btnMenos);
            Controls.Add(btnMais);
            Controls.Add(txtResult);
            Controls.Add(txtSegNum);
            Controls.Add(txtPriNum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPriNum;
        private TextBox txtSegNum;
        private TextBox txtResult;
        private Button btnMais;
        private Button btnMenos;
        private Button btnVezes;
        private Button btnDiv;
        private Label lblPriNum;
        private Label lblSegNum;
        private Button btnLimpar;
    }
}