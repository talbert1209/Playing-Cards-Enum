namespace Playing_Cards_Enum
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
            this.DrawACard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrawACard
            // 
            this.DrawACard.Location = new System.Drawing.Point(273, 142);
            this.DrawACard.Name = "DrawACard";
            this.DrawACard.Size = new System.Drawing.Size(246, 126);
            this.DrawACard.TabIndex = 0;
            this.DrawACard.Text = "Draw A Card";
            this.DrawACard.UseVisualStyleBackColor = true;
            this.DrawACard.Click += new System.EventHandler(this.DrawACard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DrawACard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DrawACard;
    }
}

