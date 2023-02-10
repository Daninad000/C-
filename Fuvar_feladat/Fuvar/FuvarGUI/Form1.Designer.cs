namespace FuvarGUI
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
            this.lbTaxiId = new System.Windows.Forms.Label();
            this.textBoxTaxiId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Fuvarok = new System.Windows.Forms.ListBox();
            this.lbTaxiAdatok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTaxiId
            // 
            this.lbTaxiId.AutoSize = true;
            this.lbTaxiId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTaxiId.Location = new System.Drawing.Point(55, 97);
            this.lbTaxiId.Name = "lbTaxiId";
            this.lbTaxiId.Size = new System.Drawing.Size(373, 29);
            this.lbTaxiId.TabIndex = 0;
            this.lbTaxiId.Text = "Kérem adja meg a taxi sorszámát:";
            // 
            // textBoxTaxiId
            // 
            this.textBoxTaxiId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTaxiId.Location = new System.Drawing.Point(445, 99);
            this.textBoxTaxiId.Name = "textBoxTaxiId";
            this.textBoxTaxiId.Size = new System.Drawing.Size(100, 30);
            this.textBoxTaxiId.TabIndex = 1;
            this.textBoxTaxiId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTaxiId_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(599, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fuvarok
            // 
            this.Fuvarok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Fuvarok.FormattingEnabled = true;
            this.Fuvarok.ItemHeight = 29;
            this.Fuvarok.Location = new System.Drawing.Point(283, 229);
            this.Fuvarok.Name = "Fuvarok";
            this.Fuvarok.Size = new System.Drawing.Size(408, 352);
            this.Fuvarok.TabIndex = 4;
            // 
            // lbTaxiAdatok
            // 
            this.lbTaxiAdatok.AutoSize = true;
            this.lbTaxiAdatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTaxiAdatok.Location = new System.Drawing.Point(345, 183);
            this.lbTaxiAdatok.Name = "lbTaxiAdatok";
            this.lbTaxiAdatok.Size = new System.Drawing.Size(287, 29);
            this.lbTaxiAdatok.TabIndex = 5;
            this.lbTaxiAdatok.Text = "A taxishoz tartozó fuvarok:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 658);
            this.Controls.Add(this.lbTaxiAdatok);
            this.Controls.Add(this.Fuvarok);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTaxiId);
            this.Controls.Add(this.lbTaxiId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTaxiId;
        private System.Windows.Forms.TextBox textBoxTaxiId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTaxiAdatok;
        private System.Windows.Forms.ListBox Fuvarok;
    }
}

