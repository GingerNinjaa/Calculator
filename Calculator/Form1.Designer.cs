namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_ClearEntry = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_divided = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_Decimal = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_PlusMinus = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.Panel_top = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_ClearEntry
            // 
            this.btn_ClearEntry.FlatAppearance.BorderSize = 0;
            this.btn_ClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ClearEntry.ForeColor = System.Drawing.Color.White;
            this.btn_ClearEntry.Location = new System.Drawing.Point(7, 125);
            this.btn_ClearEntry.Name = "btn_ClearEntry";
            this.btn_ClearEntry.Size = new System.Drawing.Size(65, 55);
            this.btn_ClearEntry.TabIndex = 4;
            this.btn_ClearEntry.Text = "CE";
            this.btn_ClearEntry.UseVisualStyleBackColor = true;
            this.btn_ClearEntry.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(78, 125);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(65, 55);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "C";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.FlatAppearance.BorderSize = 0;
            this.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Del.ForeColor = System.Drawing.Color.White;
            this.btn_Del.Location = new System.Drawing.Point(149, 125);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(65, 55);
            this.btn_Del.TabIndex = 6;
            this.btn_Del.Text = "DEL";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // btn_divided
            // 
            this.btn_divided.FlatAppearance.BorderSize = 0;
            this.btn_divided.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_divided.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_divided.ForeColor = System.Drawing.Color.White;
            this.btn_divided.Location = new System.Drawing.Point(221, 125);
            this.btn_divided.Name = "btn_divided";
            this.btn_divided.Size = new System.Drawing.Size(65, 55);
            this.btn_divided.TabIndex = 7;
            this.btn_divided.Text = "/";
            this.btn_divided.UseVisualStyleBackColor = true;
            this.btn_divided.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.FlatAppearance.BorderSize = 0;
            this.btn_multi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_multi.ForeColor = System.Drawing.Color.White;
            this.btn_multi.Location = new System.Drawing.Point(220, 183);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(65, 55);
            this.btn_multi.TabIndex = 11;
            this.btn_multi.Text = "*";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn_9
            // 
            this.btn_9.FlatAppearance.BorderSize = 0;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_9.ForeColor = System.Drawing.Color.White;
            this.btn_9.Location = new System.Drawing.Point(149, 183);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(65, 55);
            this.btn_9.TabIndex = 10;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // btn_8
            // 
            this.btn_8.FlatAppearance.BorderSize = 0;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_8.ForeColor = System.Drawing.Color.White;
            this.btn_8.Location = new System.Drawing.Point(78, 183);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(65, 55);
            this.btn_8.TabIndex = 9;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // btn_7
            // 
            this.btn_7.FlatAppearance.BorderSize = 0;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_7.ForeColor = System.Drawing.Color.White;
            this.btn_7.Location = new System.Drawing.Point(7, 183);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(65, 55);
            this.btn_7.TabIndex = 8;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.FlatAppearance.BorderSize = 0;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_minus.ForeColor = System.Drawing.Color.White;
            this.btn_minus.Location = new System.Drawing.Point(220, 241);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(65, 55);
            this.btn_minus.TabIndex = 15;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn_6
            // 
            this.btn_6.FlatAppearance.BorderSize = 0;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_6.ForeColor = System.Drawing.Color.White;
            this.btn_6.Location = new System.Drawing.Point(149, 241);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(65, 55);
            this.btn_6.TabIndex = 14;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.FlatAppearance.BorderSize = 0;
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_plus.ForeColor = System.Drawing.Color.White;
            this.btn_plus.Location = new System.Drawing.Point(220, 299);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(65, 55);
            this.btn_plus.TabIndex = 19;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn_3
            // 
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_3.ForeColor = System.Drawing.Color.White;
            this.btn_3.Location = new System.Drawing.Point(149, 299);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(65, 55);
            this.btn_3.TabIndex = 18;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // btn_2
            // 
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_2.ForeColor = System.Drawing.Color.White;
            this.btn_2.Location = new System.Drawing.Point(78, 299);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(65, 55);
            this.btn_2.TabIndex = 17;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // btn_1
            // 
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_1.ForeColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(7, 299);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(65, 55);
            this.btn_1.TabIndex = 16;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.FlatAppearance.BorderSize = 0;
            this.btn_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_equal.ForeColor = System.Drawing.Color.White;
            this.btn_equal.Location = new System.Drawing.Point(220, 357);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(65, 55);
            this.btn_equal.TabIndex = 23;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn_Decimal
            // 
            this.btn_Decimal.FlatAppearance.BorderSize = 0;
            this.btn_Decimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Decimal.ForeColor = System.Drawing.Color.White;
            this.btn_Decimal.Location = new System.Drawing.Point(149, 357);
            this.btn_Decimal.Name = "btn_Decimal";
            this.btn_Decimal.Size = new System.Drawing.Size(65, 55);
            this.btn_Decimal.TabIndex = 22;
            this.btn_Decimal.Text = ".";
            this.btn_Decimal.UseVisualStyleBackColor = true;
            this.btn_Decimal.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // btn_0
            // 
            this.btn_0.FlatAppearance.BorderSize = 0;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_0.ForeColor = System.Drawing.Color.White;
            this.btn_0.Location = new System.Drawing.Point(78, 357);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(65, 55);
            this.btn_0.TabIndex = 21;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // btn_PlusMinus
            // 
            this.btn_PlusMinus.FlatAppearance.BorderSize = 0;
            this.btn_PlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_PlusMinus.ForeColor = System.Drawing.Color.White;
            this.btn_PlusMinus.Location = new System.Drawing.Point(7, 357);
            this.btn_PlusMinus.Name = "btn_PlusMinus";
            this.btn_PlusMinus.Size = new System.Drawing.Size(65, 55);
            this.btn_PlusMinus.TabIndex = 20;
            this.btn_PlusMinus.Text = "+/-";
            this.btn_PlusMinus.UseVisualStyleBackColor = true;
            this.btn_PlusMinus.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // btn_4
            // 
            this.btn_4.FlatAppearance.BorderSize = 0;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_4.ForeColor = System.Drawing.Color.White;
            this.btn_4.Location = new System.Drawing.Point(7, 241);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(65, 55);
            this.btn_4.TabIndex = 12;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // btn_5
            // 
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_5.ForeColor = System.Drawing.Color.White;
            this.btn_5.Location = new System.Drawing.Point(78, 241);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(65, 55);
            this.btn_5.TabIndex = 13;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.BackColor = System.Drawing.Color.DarkGray;
            this.TxtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtDisplay.Location = new System.Drawing.Point(7, 72);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(279, 34);
            this.TxtDisplay.TabIndex = 25;
            this.TxtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.BackColor = System.Drawing.Color.DarkGray;
            this.TxtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtDisplay2.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtDisplay2.Location = new System.Drawing.Point(7, 33);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.Size = new System.Drawing.Size(279, 34);
            this.TxtDisplay2.TabIndex = 26;
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Panel_top
            // 
            this.Panel_top.BackColor = System.Drawing.Color.DarkGray;
            this.Panel_top.Location = new System.Drawing.Point(-1, 1);
            this.Panel_top.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_top.Name = "Panel_top";
            this.Panel_top.Size = new System.Drawing.Size(300, 105);
            this.Panel_top.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(292, 418);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_Decimal);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_PlusMinus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_divided);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_ClearEntry);
            this.Controls.Add(this.Panel_top);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ClearEntry;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_divided;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_Decimal;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_PlusMinus;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.Panel Panel_top;
    }
}

