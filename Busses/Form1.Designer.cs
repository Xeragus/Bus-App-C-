namespace Busses
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
            this.lbBusses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLines = new System.Windows.Forms.ListBox();
            this.Lines = new System.Windows.Forms.Label();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.btnDeleteBus = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.gbLines = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lbBusses
            // 
            this.lbBusses.FormattingEnabled = true;
            this.lbBusses.Location = new System.Drawing.Point(24, 44);
            this.lbBusses.Name = "lbBusses";
            this.lbBusses.Size = new System.Drawing.Size(226, 186);
            this.lbBusses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busses";
            // 
            // lbLines
            // 
            this.lbLines.FormattingEnabled = true;
            this.lbLines.Location = new System.Drawing.Point(283, 44);
            this.lbLines.Name = "lbLines";
            this.lbLines.Size = new System.Drawing.Size(226, 186);
            this.lbLines.TabIndex = 2;
            // 
            // Lines
            // 
            this.Lines.AutoSize = true;
            this.Lines.Location = new System.Drawing.Point(283, 25);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(32, 13);
            this.Lines.TabIndex = 3;
            this.Lines.Text = "Lines";
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(27, 254);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(126, 23);
            this.btnAddBus.TabIndex = 4;
            this.btnAddBus.Text = "Add bus";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // btnDeleteBus
            // 
            this.btnDeleteBus.Location = new System.Drawing.Point(27, 303);
            this.btnDeleteBus.Name = "btnDeleteBus";
            this.btnDeleteBus.Size = new System.Drawing.Size(126, 23);
            this.btnDeleteBus.TabIndex = 5;
            this.btnDeleteBus.Text = "Delete bus";
            this.btnDeleteBus.UseVisualStyleBackColor = true;
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(27, 349);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(126, 23);
            this.btnAddLine.TabIndex = 6;
            this.btnAddLine.Text = "Add line";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // gbLines
            // 
            this.gbLines.Location = new System.Drawing.Point(283, 254);
            this.gbLines.Name = "gbLines";
            this.gbLines.Size = new System.Drawing.Size(226, 118);
            this.gbLines.TabIndex = 7;
            this.gbLines.TabStop = false;
            this.gbLines.Text = "Lines";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 401);
            this.Controls.Add(this.gbLines);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.btnDeleteBus);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.Lines);
            this.Controls.Add(this.lbLines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBusses);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBusses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbLines;
        private System.Windows.Forms.Label Lines;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.Button btnDeleteBus;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.GroupBox gbLines;
    }
}

