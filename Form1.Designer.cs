
namespace condicoes
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
            this.btt1 = new System.Windows.Forms.Button();
            this.caixa_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btt1
            // 
            this.btt1.Location = new System.Drawing.Point(567, 147);
            this.btt1.Name = "btt1";
            this.btt1.Size = new System.Drawing.Size(212, 43);
            this.btt1.TabIndex = 0;
            this.btt1.Text = "executar";
            this.btt1.UseVisualStyleBackColor = true;
            this.btt1.Click += new System.EventHandler(this.btt1_Click);
            // 
            // caixa_txt
            // 
            this.caixa_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa_txt.Location = new System.Drawing.Point(28, 44);
            this.caixa_txt.Name = "caixa_txt";
            this.caixa_txt.Size = new System.Drawing.Size(751, 76);
            this.caixa_txt.TabIndex = 1;
            this.caixa_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 240);
            this.Controls.Add(this.caixa_txt);
            this.Controls.Add(this.btt1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btt1;
        private System.Windows.Forms.Label caixa_txt;
    }
}

