namespace TP01
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
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.Operando1Textbox = new System.Windows.Forms.TextBox();
            this.Operando2Textbox = new System.Windows.Forms.TextBox();
            this.operacionCombo = new System.Windows.Forms.ComboBox();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.OperarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Location = new System.Drawing.Point(13, 13);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultadoLabel.TabIndex = 0;
            // 
            // Operando1Textbox
            // 
            this.Operando1Textbox.Location = new System.Drawing.Point(12, 53);
            this.Operando1Textbox.Name = "Operando1Textbox";
            this.Operando1Textbox.Size = new System.Drawing.Size(100, 20);
            this.Operando1Textbox.TabIndex = 1;
            // 
            // Operando2Textbox
            // 
            this.Operando2Textbox.Location = new System.Drawing.Point(168, 53);
            this.Operando2Textbox.Name = "Operando2Textbox";
            this.Operando2Textbox.Size = new System.Drawing.Size(100, 20);
            this.Operando2Textbox.TabIndex = 2;
            // 
            // operacionCombo
            // 
            this.operacionCombo.FormattingEnabled = true;
            this.operacionCombo.Location = new System.Drawing.Point(118, 52);
            this.operacionCombo.Name = "operacionCombo";
            this.operacionCombo.Size = new System.Drawing.Size(31, 21);
            this.operacionCombo.TabIndex = 3;
            // 
            // BorrarButton
            // 
            this.BorrarButton.Location = new System.Drawing.Point(16, 85);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(75, 23);
            this.BorrarButton.TabIndex = 4;
            this.BorrarButton.Text = "CC";
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click);
            // 
            // OperarButton
            // 
            this.OperarButton.Location = new System.Drawing.Point(168, 85);
            this.OperarButton.Name = "OperarButton";
            this.OperarButton.Size = new System.Drawing.Size(75, 23);
            this.OperarButton.TabIndex = 5;
            this.OperarButton.Text = "=";
            this.OperarButton.UseVisualStyleBackColor = true;
            this.OperarButton.Click += new System.EventHandler(this.OperarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 120);
            this.Controls.Add(this.OperarButton);
            this.Controls.Add(this.BorrarButton);
            this.Controls.Add(this.operacionCombo);
            this.Controls.Add(this.Operando2Textbox);
            this.Controls.Add(this.Operando1Textbox);
            this.Controls.Add(this.ResultadoLabel);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultadoLabel;
        private System.Windows.Forms.TextBox Operando1Textbox;
        private System.Windows.Forms.TextBox Operando2Textbox;
        private System.Windows.Forms.ComboBox operacionCombo;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Button OperarButton;
    }
}

