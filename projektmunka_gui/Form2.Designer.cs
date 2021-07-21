namespace projektmunka_gui
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lista_btn = new System.Windows.Forms.Button();
            this.hozzaadas_btn = new System.Windows.Forms.Button();
            this.torles_btn = new System.Windows.Forms.Button();
            this.modositas_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.vissza_btn = new System.Windows.Forms.Button();
            this.what_tbx = new System.Windows.Forms.TextBox();
            this.what_btn = new System.Windows.Forms.Button();
            this.what_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Címsor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lista_btn
            // 
            this.lista_btn.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lista_btn.Location = new System.Drawing.Point(12, 128);
            this.lista_btn.Name = "lista_btn";
            this.lista_btn.Size = new System.Drawing.Size(100, 25);
            this.lista_btn.TabIndex = 2;
            this.lista_btn.Text = "Frissítés";
            this.lista_btn.UseVisualStyleBackColor = true;
            this.lista_btn.Click += new System.EventHandler(this.lista_btn_Click);
            // 
            // hozzaadas_btn
            // 
            this.hozzaadas_btn.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hozzaadas_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.hozzaadas_btn.Location = new System.Drawing.Point(118, 128);
            this.hozzaadas_btn.Name = "hozzaadas_btn";
            this.hozzaadas_btn.Size = new System.Drawing.Size(100, 25);
            this.hozzaadas_btn.TabIndex = 3;
            this.hozzaadas_btn.Text = "Hozzáadás";
            this.hozzaadas_btn.UseVisualStyleBackColor = true;
            this.hozzaadas_btn.Click += new System.EventHandler(this.hozzaadas_btn_Click);
            // 
            // torles_btn
            // 
            this.torles_btn.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torles_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.torles_btn.Location = new System.Drawing.Point(224, 128);
            this.torles_btn.Name = "torles_btn";
            this.torles_btn.Size = new System.Drawing.Size(100, 25);
            this.torles_btn.TabIndex = 4;
            this.torles_btn.Text = "Törlés";
            this.torles_btn.UseVisualStyleBackColor = true;
            this.torles_btn.Click += new System.EventHandler(this.torles_btn_Click);
            // 
            // modositas_btn
            // 
            this.modositas_btn.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modositas_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.modositas_btn.Location = new System.Drawing.Point(330, 128);
            this.modositas_btn.Name = "modositas_btn";
            this.modositas_btn.Size = new System.Drawing.Size(100, 25);
            this.modositas_btn.TabIndex = 5;
            this.modositas_btn.Text = "Módosítás";
            this.modositas_btn.UseVisualStyleBackColor = true;
            this.modositas_btn.Click += new System.EventHandler(this.modositas_btn_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 221);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // vissza_btn
            // 
            this.vissza_btn.Location = new System.Drawing.Point(701, 415);
            this.vissza_btn.Name = "vissza_btn";
            this.vissza_btn.Size = new System.Drawing.Size(75, 23);
            this.vissza_btn.TabIndex = 7;
            this.vissza_btn.Text = "Vissza";
            this.vissza_btn.UseVisualStyleBackColor = true;
            this.vissza_btn.Click += new System.EventHandler(this.vissza_btn_Click);
            // 
            // what_tbx
            // 
            this.what_tbx.Location = new System.Drawing.Point(281, 92);
            this.what_tbx.Name = "what_tbx";
            this.what_tbx.Size = new System.Drawing.Size(43, 20);
            this.what_tbx.TabIndex = 8;
            // 
            // what_btn
            // 
            this.what_btn.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.what_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.what_btn.Location = new System.Drawing.Point(380, 90);
            this.what_btn.Name = "what_btn";
            this.what_btn.Size = new System.Drawing.Size(50, 25);
            this.what_btn.TabIndex = 9;
            this.what_btn.Text = "OK";
            this.what_btn.UseVisualStyleBackColor = true;
            this.what_btn.Click += new System.EventHandler(this.what_btn_Click);
            // 
            // what_lbl
            // 
            this.what_lbl.AutoSize = true;
            this.what_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.what_lbl.Location = new System.Drawing.Point(12, 92);
            this.what_lbl.Name = "what_lbl";
            this.what_lbl.Size = new System.Drawing.Size(263, 17);
            this.what_lbl.TabIndex = 10;
            this.what_lbl.Text = "Add meg a módosítani kívánt elem ID-jét!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.what_lbl);
            this.Controls.Add(this.what_btn);
            this.Controls.Add(this.what_tbx);
            this.Controls.Add(this.vissza_btn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.modositas_btn);
            this.Controls.Add(this.torles_btn);
            this.Controls.Add(this.hozzaadas_btn);
            this.Controls.Add(this.lista_btn);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lista_btn;
        private System.Windows.Forms.Button hozzaadas_btn;
        private System.Windows.Forms.Button torles_btn;
        private System.Windows.Forms.Button modositas_btn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button vissza_btn;
        private System.Windows.Forms.TextBox what_tbx;
        private System.Windows.Forms.Button what_btn;
        private System.Windows.Forms.Label what_lbl;
    }
}