namespace Calculadora_Salario_Liquido
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
            vt = new TextBox();
            Salario_Bruto = new TextBox();
            Fgts = new TextBox();
            Ir = new TextBox();
            Auxiliar = new RadioButton();
            Analista = new RadioButton();
            Gerente = new RadioButton();
            Bonus = new TextBox();
            Salario_Liquido = new TextBox();
            Caucular = new Button();
            SuspendLayout();
            // 
            // vt
            // 
            vt.Location = new Point(12, 249);
            vt.Name = "vt";
            vt.Size = new Size(241, 31);
            vt.TabIndex = 0;
            vt.Text = "Vt: ";
            // 
            // Salario_Bruto
            // 
            Salario_Bruto.Location = new Point(12, 92);
            Salario_Bruto.Name = "Salario_Bruto";
            Salario_Bruto.Size = new Size(241, 31);
            Salario_Bruto.TabIndex = 1;
            Salario_Bruto.Text = "Bruto: ";
            // 
            // Fgts
            // 
            Fgts.Location = new Point(12, 145);
            Fgts.Name = "Fgts";
            Fgts.Size = new Size(241, 31);
            Fgts.TabIndex = 2;
            Fgts.Text = "Fgts: ";
            // 
            // Ir
            // 
            Ir.Location = new Point(12, 195);
            Ir.Name = "Ir";
            Ir.Size = new Size(241, 31);
            Ir.TabIndex = 3;
            Ir.Text = "Ir: ";
            // 
            // Auxiliar
            // 
            Auxiliar.AutoSize = true;
            Auxiliar.Location = new Point(12, 12);
            Auxiliar.Name = "Auxiliar";
            Auxiliar.Size = new Size(94, 29);
            Auxiliar.TabIndex = 4;
            Auxiliar.TabStop = true;
            Auxiliar.Text = "Auxiliar";
            Auxiliar.UseVisualStyleBackColor = true;
            Auxiliar.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Analista
            // 
            Analista.AutoSize = true;
            Analista.Location = new Point(124, 12);
            Analista.Name = "Analista";
            Analista.Size = new Size(99, 29);
            Analista.TabIndex = 5;
            Analista.TabStop = true;
            Analista.Text = "Analista";
            Analista.UseVisualStyleBackColor = true;
            Analista.CheckedChanged += Analista_CheckedChanged;
            // 
            // Gerente
            // 
            Gerente.AutoSize = true;
            Gerente.Location = new Point(243, 12);
            Gerente.Name = "Gerente";
            Gerente.Size = new Size(98, 29);
            Gerente.TabIndex = 6;
            Gerente.TabStop = true;
            Gerente.Text = "Gerente";
            Gerente.UseVisualStyleBackColor = true;
            Gerente.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // Bonus
            // 
            Bonus.Location = new Point(12, 296);
            Bonus.Name = "Bonus";
            Bonus.Size = new Size(241, 31);
            Bonus.TabIndex = 8;
            Bonus.Text = "Bonus: ";
            // 
            // Salario_Liquido
            // 
            Salario_Liquido.Location = new Point(12, 345);
            Salario_Liquido.Name = "Salario_Liquido";
            Salario_Liquido.Size = new Size(241, 31);
            Salario_Liquido.TabIndex = 7;
            Salario_Liquido.Text = "Salario Liquido:";
            // 
            // Caucular
            // 
            Caucular.BackColor = Color.FromArgb(192, 0, 0);
            Caucular.Font = new Font("Comic Sans MS", 47F, FontStyle.Bold);
            Caucular.ForeColor = Color.Black;
            Caucular.Location = new Point(317, 92);
            Caucular.Name = "Caucular";
            Caucular.Size = new Size(420, 282);
            Caucular.TabIndex = 9;
            Caucular.Text = "Calcular";
            Caucular.UseVisualStyleBackColor = false;
            Caucular.Click += Caucular_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(105, 129, 163);
            ClientSize = new Size(800, 450);
            Controls.Add(Caucular);
            Controls.Add(Bonus);
            Controls.Add(Salario_Liquido);
            Controls.Add(Gerente);
            Controls.Add(Analista);
            Controls.Add(Auxiliar);
            Controls.Add(Ir);
            Controls.Add(Fgts);
            Controls.Add(Salario_Bruto);
            Controls.Add(vt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox vt;
        private TextBox Salario_Bruto;
        private TextBox Fgts;
        private TextBox Ir;
        private RadioButton Auxiliar;
        private RadioButton Analista;
        private RadioButton Gerente;
        private TextBox Bonus;
        private TextBox Salario_Liquido;
        private Button Caucular;
    }
}
