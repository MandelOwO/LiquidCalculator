
namespace LiquidCalculator
{
    public partial class Form1
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
            this.panel_shotCalculator = new System.Windows.Forms.Panel();
            this.button_calculate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.textBox_strength = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_shot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_base = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_volume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_shotCalculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_shotCalculator
            // 
            this.panel_shotCalculator.Controls.Add(this.button_calculate);
            this.panel_shotCalculator.Controls.Add(this.label8);
            this.panel_shotCalculator.Controls.Add(this.label7);
            this.panel_shotCalculator.Controls.Add(this.label6);
            this.panel_shotCalculator.Controls.Add(this.label10);
            this.panel_shotCalculator.Controls.Add(this.label5);
            this.panel_shotCalculator.Controls.Add(this.textBox_result);
            this.panel_shotCalculator.Controls.Add(this.textBox_strength);
            this.panel_shotCalculator.Controls.Add(this.label9);
            this.panel_shotCalculator.Controls.Add(this.label4);
            this.panel_shotCalculator.Controls.Add(this.textBox_shot);
            this.panel_shotCalculator.Controls.Add(this.label3);
            this.panel_shotCalculator.Controls.Add(this.textBox_base);
            this.panel_shotCalculator.Controls.Add(this.label2);
            this.panel_shotCalculator.Controls.Add(this.textBox_volume);
            this.panel_shotCalculator.Controls.Add(this.label1);
            this.panel_shotCalculator.Location = new System.Drawing.Point(41, 38);
            this.panel_shotCalculator.Name = "panel_shotCalculator";
            this.panel_shotCalculator.Size = new System.Drawing.Size(378, 357);
            this.panel_shotCalculator.TabIndex = 0;
            // 
            // button_calculate
            // 
            this.button_calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.button_calculate.Location = new System.Drawing.Point(26, 256);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(302, 32);
            this.button_calculate.TabIndex = 5;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = false;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "mg/ml";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "mg/ml";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "mg/ml";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "ml";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "ml";
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.textBox_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.textBox_result.Location = new System.Drawing.Point(189, 302);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(139, 23);
            this.textBox_result.TabIndex = 0;
            this.textBox_result.TabStop = false;
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_strength
            // 
            this.textBox_strength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.textBox_strength.Location = new System.Drawing.Point(26, 207);
            this.textBox_strength.Name = "textBox_strength";
            this.textBox_strength.Size = new System.Drawing.Size(139, 23);
            this.textBox_strength.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Amount of booster to add:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Desired strength:";
            // 
            // textBox_shot
            // 
            this.textBox_shot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.textBox_shot.Location = new System.Drawing.Point(26, 150);
            this.textBox_shot.Name = "textBox_shot";
            this.textBox_shot.Size = new System.Drawing.Size(139, 23);
            this.textBox_shot.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nicotine shot:";
            // 
            // textBox_base
            // 
            this.textBox_base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.textBox_base.Location = new System.Drawing.Point(26, 94);
            this.textBox_base.Name = "textBox_base";
            this.textBox_base.Size = new System.Drawing.Size(139, 23);
            this.textBox_base.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current concentration:";
            // 
            // textBox_volume
            // 
            this.textBox_volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.textBox_volume.Location = new System.Drawing.Point(26, 41);
            this.textBox_volume.Name = "textBox_volume";
            this.textBox_volume.Size = new System.Drawing.Size(139, 23);
            this.textBox_volume.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bottle size:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.panel_shotCalculator);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.Name = "Form1";
            this.Text = "Mandelo\'s Liquid Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_shotCalculator.ResumeLayout(false);
            this.panel_shotCalculator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_shotCalculator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_base;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_volume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_strength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_shot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Label label10;
    }
}

