namespace FakeNetStatManager
{
    partial class Main
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
            this.txtTestInput = new System.Windows.Forms.TextBox();
            this.btnGenerateConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTestInput
            // 
            this.txtTestInput.Location = new System.Drawing.Point(12, 29);
            this.txtTestInput.Name = "txtTestInput";
            this.txtTestInput.Size = new System.Drawing.Size(158, 20);
            this.txtTestInput.TabIndex = 0;
            // 
            // btnGenerateConfig
            // 
            this.btnGenerateConfig.Location = new System.Drawing.Point(192, 27);
            this.btnGenerateConfig.Name = "btnGenerateConfig";
            this.btnGenerateConfig.Size = new System.Drawing.Size(119, 23);
            this.btnGenerateConfig.TabIndex = 1;
            this.btnGenerateConfig.Text = "Generate Config";
            this.btnGenerateConfig.UseVisualStyleBackColor = true;
            this.btnGenerateConfig.Click += new System.EventHandler(this.btnGenerateConfig_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerateConfig);
            this.Controls.Add(this.txtTestInput);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTestInput;
        private System.Windows.Forms.Button btnGenerateConfig;
    }
}

