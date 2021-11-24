namespace BitwiseOperations
{
    partial class Form1
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
            this.btnAnd = new System.Windows.Forms.Button();
            this.btnOR = new System.Windows.Forms.Button();
            this.btnXOR = new System.Windows.Forms.Button();
            this.btnNOT = new System.Windows.Forms.Button();
            this.btnRShift = new System.Windows.Forms.Button();
            this.btnLShift = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txbInput1 = new System.Windows.Forms.TextBox();
            this.txbInput2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnd
            // 
            this.btnAnd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAnd.FlatAppearance.BorderSize = 3;
            this.btnAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnd.ForeColor = System.Drawing.Color.Black;
            this.btnAnd.Location = new System.Drawing.Point(29, 166);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(143, 52);
            this.btnAnd.TabIndex = 0;
            this.btnAnd.Text = "AND";
            this.btnAnd.UseVisualStyleBackColor = true;
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // btnOR
            // 
            this.btnOR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOR.FlatAppearance.BorderSize = 3;
            this.btnOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOR.ForeColor = System.Drawing.Color.Black;
            this.btnOR.Location = new System.Drawing.Point(187, 166);
            this.btnOR.Name = "btnOR";
            this.btnOR.Size = new System.Drawing.Size(143, 52);
            this.btnOR.TabIndex = 1;
            this.btnOR.Text = "OR";
            this.btnOR.UseVisualStyleBackColor = true;
            this.btnOR.Click += new System.EventHandler(this.btnOR_Click);
            // 
            // btnXOR
            // 
            this.btnXOR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXOR.FlatAppearance.BorderSize = 3;
            this.btnXOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOR.ForeColor = System.Drawing.Color.Black;
            this.btnXOR.Location = new System.Drawing.Point(356, 166);
            this.btnXOR.Name = "btnXOR";
            this.btnXOR.Size = new System.Drawing.Size(143, 52);
            this.btnXOR.TabIndex = 2;
            this.btnXOR.Text = "XOR";
            this.btnXOR.UseVisualStyleBackColor = true;
            this.btnXOR.Click += new System.EventHandler(this.btnXOR_Click);
            // 
            // btnNOT
            // 
            this.btnNOT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNOT.FlatAppearance.BorderSize = 3;
            this.btnNOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNOT.ForeColor = System.Drawing.Color.Black;
            this.btnNOT.Location = new System.Drawing.Point(535, 166);
            this.btnNOT.Name = "btnNOT";
            this.btnNOT.Size = new System.Drawing.Size(143, 52);
            this.btnNOT.TabIndex = 3;
            this.btnNOT.Text = "NOT";
            this.btnNOT.UseVisualStyleBackColor = true;
            this.btnNOT.Click += new System.EventHandler(this.btnNOT_Click);
            // 
            // btnRShift
            // 
            this.btnRShift.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRShift.FlatAppearance.BorderSize = 3;
            this.btnRShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRShift.ForeColor = System.Drawing.Color.Black;
            this.btnRShift.Location = new System.Drawing.Point(704, 166);
            this.btnRShift.Name = "btnRShift";
            this.btnRShift.Size = new System.Drawing.Size(143, 52);
            this.btnRShift.TabIndex = 4;
            this.btnRShift.Text = "Right Shift";
            this.btnRShift.UseVisualStyleBackColor = true;
            this.btnRShift.Click += new System.EventHandler(this.btnRShift_Click);
            // 
            // btnLShift
            // 
            this.btnLShift.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLShift.FlatAppearance.BorderSize = 3;
            this.btnLShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLShift.ForeColor = System.Drawing.Color.Black;
            this.btnLShift.Location = new System.Drawing.Point(863, 166);
            this.btnLShift.Name = "btnLShift";
            this.btnLShift.Size = new System.Drawing.Size(143, 52);
            this.btnLShift.TabIndex = 5;
            this.btnLShift.Text = "Left Shift";
            this.btnLShift.UseVisualStyleBackColor = true;
            this.btnLShift.Click += new System.EventHandler(this.btnLShift_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(444, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(198, 52);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txbInput1
            // 
            this.txbInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInput1.ForeColor = System.Drawing.Color.Black;
            this.txbInput1.Location = new System.Drawing.Point(185, 71);
            this.txbInput1.Name = "txbInput1";
            this.txbInput1.Size = new System.Drawing.Size(198, 35);
            this.txbInput1.TabIndex = 7;
            // 
            // txbInput2
            // 
            this.txbInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInput2.ForeColor = System.Drawing.Color.Black;
            this.txbInput2.Location = new System.Drawing.Point(444, 71);
            this.txbInput2.Name = "txbInput2";
            this.txbInput2.Size = new System.Drawing.Size(198, 35);
            this.txbInput2.TabIndex = 8;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Black;
            this.lblResultado.Location = new System.Drawing.Point(701, 70);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(146, 33);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1033, 349);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txbInput2);
            this.Controls.Add(this.txbInput1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLShift);
            this.Controls.Add(this.btnRShift);
            this.Controls.Add(this.btnNOT);
            this.Controls.Add(this.btnXOR);
            this.Controls.Add(this.btnOR);
            this.Controls.Add(this.btnAnd);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitwise Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnd;
        private System.Windows.Forms.Button btnOR;
        private System.Windows.Forms.Button btnXOR;
        private System.Windows.Forms.Button btnNOT;
        private System.Windows.Forms.Button btnRShift;
        private System.Windows.Forms.Button btnLShift;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txbInput1;
        private System.Windows.Forms.TextBox txbInput2;
        private System.Windows.Forms.Label lblResultado;
    }
}

