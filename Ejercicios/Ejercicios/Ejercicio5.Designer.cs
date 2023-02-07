namespace Ejercicios
{
    partial class Ejercicio5
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
            this.HornearPizzabutton = new System.Windows.Forms.Button();
            this.HornearPizza2button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HornearPizzabutton
            // 
            this.HornearPizzabutton.Location = new System.Drawing.Point(108, 46);
            this.HornearPizzabutton.Name = "HornearPizzabutton";
            this.HornearPizzabutton.Size = new System.Drawing.Size(160, 66);
            this.HornearPizzabutton.TabIndex = 0;
            this.HornearPizzabutton.Text = "Hornear Pizza";
            this.HornearPizzabutton.UseVisualStyleBackColor = true;
            this.HornearPizzabutton.Click += new System.EventHandler(this.HornearPizzabutton_Click);
            // 
            // HornearPizza2button
            // 
            this.HornearPizza2button.Location = new System.Drawing.Point(437, 46);
            this.HornearPizza2button.Name = "HornearPizza2button";
            this.HornearPizza2button.Size = new System.Drawing.Size(225, 66);
            this.HornearPizza2button.TabIndex = 1;
            this.HornearPizza2button.Text = "Hornear Pizza Asincrono";
            this.HornearPizza2button.UseVisualStyleBackColor = true;
            this.HornearPizza2button.Click += new System.EventHandler(this.HornearPizza2button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número 2:";
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(242, 248);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(139, 26);
            this.Numero1TextBox.TabIndex = 4;
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(242, 324);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(139, 26);
            this.Numero2TextBox.TabIndex = 5;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(422, 318);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(120, 39);
            this.CalcularButton.TabIndex = 6;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 553);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HornearPizza2button);
            this.Controls.Add(this.HornearPizzabutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HornearPizzabutton;
        private System.Windows.Forms.Button HornearPizza2button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.TextBox Numero2TextBox;
        private System.Windows.Forms.Button CalcularButton;
    }
}