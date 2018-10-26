namespace Bank_collections
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginW = new System.Windows.Forms.Button();
            this.loginC = new System.Windows.Forms.Button();
            this.registerW = new System.Windows.Forms.Button();
            this.registerC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Worker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(254, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client";
            // 
            // loginW
            // 
            this.loginW.Location = new System.Drawing.Point(38, 97);
            this.loginW.Name = "loginW";
            this.loginW.Size = new System.Drawing.Size(101, 27);
            this.loginW.TabIndex = 5;
            this.loginW.Text = "Log in";
            this.loginW.UseVisualStyleBackColor = true;
            this.loginW.Click += new System.EventHandler(this.loginW_Click);
            // 
            // loginC
            // 
            this.loginC.Location = new System.Drawing.Point(260, 97);
            this.loginC.Name = "loginC";
            this.loginC.Size = new System.Drawing.Size(101, 27);
            this.loginC.TabIndex = 6;
            this.loginC.Text = "Log in";
            this.loginC.UseVisualStyleBackColor = true;
            this.loginC.Click += new System.EventHandler(this.loginC_Click);
            // 
            // registerW
            // 
            this.registerW.Location = new System.Drawing.Point(38, 141);
            this.registerW.Name = "registerW";
            this.registerW.Size = new System.Drawing.Size(101, 27);
            this.registerW.TabIndex = 7;
            this.registerW.Text = "Register";
            this.registerW.UseVisualStyleBackColor = true;
            this.registerW.Click += new System.EventHandler(this.registerW_Click);
            // 
            // registerC
            // 
            this.registerC.Location = new System.Drawing.Point(260, 141);
            this.registerC.Name = "registerC";
            this.registerC.Size = new System.Drawing.Size(101, 27);
            this.registerC.TabIndex = 8;
            this.registerC.Text = "Register";
            this.registerC.UseVisualStyleBackColor = true;
            this.registerC.Click += new System.EventHandler(this.registerC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 286);
            this.Controls.Add(this.registerC);
            this.Controls.Add(this.registerW);
            this.Controls.Add(this.loginC);
            this.Controls.Add(this.loginW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank_collections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginW;
        private System.Windows.Forms.Button loginC;
        private System.Windows.Forms.Button registerW;
        private System.Windows.Forms.Button registerC;
    }
}

