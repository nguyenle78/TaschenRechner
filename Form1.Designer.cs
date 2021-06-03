
namespace TaschenRechner
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxZahl = new System.Windows.Forms.TextBox();
            this.textBoxErgebnis = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonDivi = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonErgebnis = new System.Windows.Forms.Button();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zahl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ergebniss";
            // 
            // textBoxZahl
            // 
            this.textBoxZahl.Location = new System.Drawing.Point(128, 41);
            this.textBoxZahl.Name = "textBoxZahl";
            this.textBoxZahl.Size = new System.Drawing.Size(225, 23);
            this.textBoxZahl.TabIndex = 2;
            // 
            // textBoxErgebnis
            // 
            this.textBoxErgebnis.Location = new System.Drawing.Point(128, 97);
            this.textBoxErgebnis.Name = "textBoxErgebnis";
            this.textBoxErgebnis.Size = new System.Drawing.Size(225, 23);
            this.textBoxErgebnis.TabIndex = 3;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(27, 142);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(65, 38);
            this.buttonPlus.TabIndex = 4;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(27, 186);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(65, 38);
            this.buttonMinus.TabIndex = 5;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Location = new System.Drawing.Point(98, 142);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(66, 38);
            this.buttonMulti.TabIndex = 6;
            this.buttonMulti.Text = "*";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.buttonMulti_Click);
            // 
            // buttonDivi
            // 
            this.buttonDivi.Location = new System.Drawing.Point(98, 186);
            this.buttonDivi.Name = "buttonDivi";
            this.buttonDivi.Size = new System.Drawing.Size(66, 38);
            this.buttonDivi.TabIndex = 7;
            this.buttonDivi.Text = "/";
            this.buttonDivi.UseVisualStyleBackColor = true;
            this.buttonDivi.Click += new System.EventHandler(this.buttonDivi_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(27, 301);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(326, 49);
            this.buttonEnd.TabIndex = 8;
            this.buttonEnd.Text = "End";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonErgebnis
            // 
            this.buttonErgebnis.Location = new System.Drawing.Point(27, 230);
            this.buttonErgebnis.Name = "buttonErgebnis";
            this.buttonErgebnis.Size = new System.Drawing.Size(137, 43);
            this.buttonErgebnis.TabIndex = 9;
            this.buttonErgebnis.Text = "=";
            this.buttonErgebnis.UseVisualStyleBackColor = true;
            this.buttonErgebnis.Click += new System.EventHandler(this.buttonErgebnis_Click);
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.Location = new System.Drawing.Point(190, 154);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(106, 15);
            this.labelCurrentOperation.TabIndex = 10;
            this.labelCurrentOperation.Text = "Current Operation:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 370);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.buttonErgebnis);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonDivi);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBoxErgebnis);
            this.Controls.Add(this.textBoxZahl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxZahl;
        private System.Windows.Forms.TextBox textBoxErgebnis;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonDivi;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Button buttonErgebnis;
        private System.Windows.Forms.Label labelCurrentOperation;
    }
}

