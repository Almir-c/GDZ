
namespace WindowsFormsApp3
{
    partial class PredmetForm
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
            this.buttonDa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDa
            // 
            this.buttonDa.Location = new System.Drawing.Point(504, 389);
            this.buttonDa.Name = "buttonDa";
            this.buttonDa.Size = new System.Drawing.Size(188, 49);
            this.buttonDa.TabIndex = 3;
            this.buttonDa.Text = "Вернуться к списку предметов";
            this.buttonDa.UseVisualStyleBackColor = true;
            this.buttonDa.Click += new System.EventHandler(this.button1_Click);
            // 
            // PredmetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.buttonDa);
            this.Name = "PredmetForm";
            this.Text = "Учебник";
            this.Load += new System.EventHandler(this.PredmetForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDa;
    }
}