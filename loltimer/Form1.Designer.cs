namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonDrake = new System.Windows.Forms.Button();
            this.buttonBaron = new System.Windows.Forms.Button();
            this.buttonBlue2 = new System.Windows.Forms.Button();
            this.buttonRed2 = new System.Windows.Forms.Button();
            this.labelOur = new System.Windows.Forms.Label();
            this.labelTheir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonBlue.ForeColor = System.Drawing.Color.Black;
            this.buttonBlue.Location = new System.Drawing.Point(0, 12);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(75, 23);
            this.buttonBlue.TabIndex = 0;
            this.buttonBlue.Text = "Blue";
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.LightCoral;
            this.buttonRed.ForeColor = System.Drawing.Color.Black;
            this.buttonRed.Location = new System.Drawing.Point(76, 12);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(75, 23);
            this.buttonRed.TabIndex = 1;
            this.buttonRed.Text = "Red";
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonDrake
            // 
            this.buttonDrake.BackColor = System.Drawing.Color.Gold;
            this.buttonDrake.Location = new System.Drawing.Point(313, 12);
            this.buttonDrake.Name = "buttonDrake";
            this.buttonDrake.Size = new System.Drawing.Size(75, 23);
            this.buttonDrake.TabIndex = 2;
            this.buttonDrake.Text = "Dragon";
            this.buttonDrake.UseVisualStyleBackColor = false;
            this.buttonDrake.Click += new System.EventHandler(this.buttonDrake_Click);
            // 
            // buttonBaron
            // 
            this.buttonBaron.BackColor = System.Drawing.Color.Crimson;
            this.buttonBaron.Location = new System.Drawing.Point(389, 12);
            this.buttonBaron.Name = "buttonBaron";
            this.buttonBaron.Size = new System.Drawing.Size(75, 23);
            this.buttonBaron.TabIndex = 3;
            this.buttonBaron.Text = "Baron";
            this.buttonBaron.UseVisualStyleBackColor = false;
            this.buttonBaron.Click += new System.EventHandler(this.buttonBaron_Click);
            // 
            // buttonBlue2
            // 
            this.buttonBlue2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonBlue2.Location = new System.Drawing.Point(157, 12);
            this.buttonBlue2.Name = "buttonBlue2";
            this.buttonBlue2.Size = new System.Drawing.Size(75, 23);
            this.buttonBlue2.TabIndex = 4;
            this.buttonBlue2.Text = "Blue";
            this.buttonBlue2.UseVisualStyleBackColor = false;
            this.buttonBlue2.Click += new System.EventHandler(this.buttonBlue2_Click);
            // 
            // buttonRed2
            // 
            this.buttonRed2.BackColor = System.Drawing.Color.LightCoral;
            this.buttonRed2.Location = new System.Drawing.Point(232, 12);
            this.buttonRed2.Name = "buttonRed2";
            this.buttonRed2.Size = new System.Drawing.Size(75, 23);
            this.buttonRed2.TabIndex = 5;
            this.buttonRed2.Text = "Red";
            this.buttonRed2.UseVisualStyleBackColor = false;
            this.buttonRed2.Click += new System.EventHandler(this.buttonRed2_Click);
            // 
            // labelOur
            // 
            this.labelOur.AutoSize = true;
            this.labelOur.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOur.Location = new System.Drawing.Point(65, 0);
            this.labelOur.Name = "labelOur";
            this.labelOur.Size = new System.Drawing.Size(20, 12);
            this.labelOur.TabIndex = 6;
            this.labelOur.Text = "Our";
            this.labelOur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTheir
            // 
            this.labelTheir.AutoSize = true;
            this.labelTheir.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTheir.Location = new System.Drawing.Point(220, 0);
            this.labelTheir.Name = "labelTheir";
            this.labelTheir.Size = new System.Drawing.Size(25, 12);
            this.labelTheir.TabIndex = 7;
            this.labelTheir.Text = "Their";
            this.labelTheir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 36);
            this.Controls.Add(this.labelTheir);
            this.Controls.Add(this.labelOur);
            this.Controls.Add(this.buttonRed2);
            this.Controls.Add(this.buttonBlue2);
            this.Controls.Add(this.buttonBaron);
            this.Controls.Add(this.buttonDrake);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonBlue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 58);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 58);
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.Text = "LOL Jungle Timer                                                                 " +
                "                             by bill876";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonDrake;
        private System.Windows.Forms.Button buttonBaron;
        private System.Windows.Forms.Button buttonBlue2;
        private System.Windows.Forms.Button buttonRed2;
        private System.Windows.Forms.Label labelOur;
        private System.Windows.Forms.Label labelTheir;


    }
}

