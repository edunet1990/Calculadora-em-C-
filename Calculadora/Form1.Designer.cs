namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Display = new System.Windows.Forms.TextBox();
            this.ce = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.volta = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.multiplica = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Button();
            this.porcentagem = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.adiciona = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.subtrai = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Display.BackColor = System.Drawing.SystemColors.Menu;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(13, 12);
            this.Display.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Display.Size = new System.Drawing.Size(246, 131);
            this.Display.TabIndex = 1;
            // 
            // ce
            // 
            this.ce.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ce.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ce.Location = new System.Drawing.Point(13, 149);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(57, 54);
            this.ce.TabIndex = 0;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = false;
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(202, 149);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(57, 54);
            this.divide.TabIndex = 2;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // volta
            // 
            this.volta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.volta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volta.Location = new System.Drawing.Point(139, 149);
            this.volta.Name = "volta";
            this.volta.Size = new System.Drawing.Size(57, 54);
            this.volta.TabIndex = 3;
            this.volta.Text = "«";
            this.volta.UseVisualStyleBackColor = false;
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.SystemColors.ControlLight;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(76, 149);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(57, 54);
            this.c.TabIndex = 4;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = false;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.Location = new System.Drawing.Point(76, 209);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(57, 54);
            this.n8.TabIndex = 8;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.Location = new System.Drawing.Point(139, 209);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(57, 54);
            this.n9.TabIndex = 7;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // multiplica
            // 
            this.multiplica.BackColor = System.Drawing.SystemColors.ControlLight;
            this.multiplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplica.Location = new System.Drawing.Point(202, 209);
            this.multiplica.Name = "multiplica";
            this.multiplica.Size = new System.Drawing.Size(57, 54);
            this.multiplica.TabIndex = 6;
            this.multiplica.Text = "x";
            this.multiplica.UseVisualStyleBackColor = false;
            this.multiplica.Click += new System.EventHandler(this.multiplica_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(13, 209);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(57, 54);
            this.n7.TabIndex = 5;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.Location = new System.Drawing.Point(76, 389);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(57, 54);
            this.n0.TabIndex = 12;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // virgula
            // 
            this.virgula.BackColor = System.Drawing.SystemColors.ControlLight;
            this.virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virgula.Location = new System.Drawing.Point(139, 389);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(57, 54);
            this.virgula.TabIndex = 11;
            this.virgula.Text = ",";
            this.virgula.UseVisualStyleBackColor = false;
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(202, 389);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(57, 54);
            this.resultado.TabIndex = 10;
            this.resultado.Text = "=";
            this.resultado.UseVisualStyleBackColor = false;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // porcentagem
            // 
            this.porcentagem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.porcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentagem.Location = new System.Drawing.Point(13, 389);
            this.porcentagem.Name = "porcentagem";
            this.porcentagem.Size = new System.Drawing.Size(57, 54);
            this.porcentagem.TabIndex = 9;
            this.porcentagem.Text = "%";
            this.porcentagem.UseVisualStyleBackColor = false;
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(76, 329);
            this.n2.Name = "n2";
            this.n2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.n2.Size = new System.Drawing.Size(57, 54);
            this.n2.TabIndex = 16;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(139, 329);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(57, 54);
            this.n3.TabIndex = 15;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // adiciona
            // 
            this.adiciona.BackColor = System.Drawing.SystemColors.ControlLight;
            this.adiciona.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adiciona.Location = new System.Drawing.Point(202, 329);
            this.adiciona.Name = "adiciona";
            this.adiciona.Size = new System.Drawing.Size(57, 54);
            this.adiciona.TabIndex = 14;
            this.adiciona.Text = "+";
            this.adiciona.UseVisualStyleBackColor = false;
            this.adiciona.Click += new System.EventHandler(this.adiciona_Click);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(13, 329);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(57, 54);
            this.n1.TabIndex = 13;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(76, 269);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(57, 54);
            this.n5.TabIndex = 20;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(139, 269);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(57, 54);
            this.n6.TabIndex = 19;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // subtrai
            // 
            this.subtrai.BackColor = System.Drawing.SystemColors.ControlLight;
            this.subtrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtrai.Location = new System.Drawing.Point(202, 269);
            this.subtrai.Name = "subtrai";
            this.subtrai.Size = new System.Drawing.Size(57, 54);
            this.subtrai.TabIndex = 18;
            this.subtrai.Text = "-";
            this.subtrai.UseVisualStyleBackColor = false;
            this.subtrai.Click += new System.EventHandler(this.subtrai_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(13, 269);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(57, 54);
            this.n4.TabIndex = 17;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 454);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.subtrai);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.adiciona);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.porcentagem);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.multiplica);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.c);
            this.Controls.Add(this.volta);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.ce);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button volta;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button multiplica;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button resultado;
        private System.Windows.Forms.Button porcentagem;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button adiciona;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button subtrai;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n3;
    }
}

