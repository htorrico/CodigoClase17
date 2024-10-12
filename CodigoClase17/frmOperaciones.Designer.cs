namespace CodigoClase17
{
    partial class frmOperaciones
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
            btnSumar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            lblResultado = new Label();
            lblResta = new Label();
            txtValor4 = new TextBox();
            txtValor3 = new TextBox();
            btnRestar = new Button();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(411, 73);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(129, 54);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "SUMAR";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 47);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "VALOR 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 47);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "VALOR2";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(25, 83);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(125, 27);
            txtValor1.TabIndex = 3;
            // 
            // txtValor2
            // 
            txtValor2.AcceptsReturn = true;
            txtValor2.Location = new Point(233, 87);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(125, 27);
            txtValor2.TabIndex = 4;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(592, 90);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(120, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado SUMA";
            lblResultado.TextAlign = ContentAlignment.TopRight;
            // 
            // lblResta
            // 
            lblResta.AutoSize = true;
            lblResta.Location = new Point(592, 166);
            lblResta.Name = "lblResta";
            lblResta.Size = new Size(121, 20);
            lblResta.TabIndex = 9;
            lblResta.Text = "Resultado RESTA";
            lblResta.TextAlign = ContentAlignment.TopRight;
            // 
            // txtValor4
            // 
            txtValor4.AcceptsReturn = true;
            txtValor4.Location = new Point(233, 163);
            txtValor4.Name = "txtValor4";
            txtValor4.Size = new Size(125, 27);
            txtValor4.TabIndex = 8;
            // 
            // txtValor3
            // 
            txtValor3.Location = new Point(25, 159);
            txtValor3.Name = "txtValor3";
            txtValor3.Size = new Size(125, 27);
            txtValor3.TabIndex = 7;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(411, 149);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(129, 54);
            btnRestar.TabIndex = 10;
            btnRestar.Text = "RESTAR";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // frmOperaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 450);
            Controls.Add(btnRestar);
            Controls.Add(lblResta);
            Controls.Add(txtValor4);
            Controls.Add(txtValor3);
            Controls.Add(lblResultado);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSumar);
            Name = "frmOperaciones";
            Text = "frmOperaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private Label label1;
        private Label label2;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label lblResultado;
        private Label lblResta;
        private TextBox txtValor4;
        private TextBox txtValor3;
        private Button btnRestar;
    }
}