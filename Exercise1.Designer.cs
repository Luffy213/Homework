namespace Lesson7
{
    partial class Exercise1
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
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.labelComputerNumber = new System.Windows.Forms.Label();
            this.labelUserNumber = new System.Windows.Forms.Label();
            this.labelCommand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(452, 50);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(181, 77);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Новая игра";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPlus.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonPlus.Location = new System.Drawing.Point(452, 193);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(181, 69);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+1";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMulti.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonMulti.Location = new System.Drawing.Point(452, 326);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(181, 69);
            this.buttonMulti.TabIndex = 0;
            this.buttonMulti.Text = "*2";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.buttonMulti_Click);
            // 
            // labelComputerNumber
            // 
            this.labelComputerNumber.AllowDrop = true;
            this.labelComputerNumber.AutoEllipsis = true;
            this.labelComputerNumber.AutoSize = true;
            this.labelComputerNumber.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerNumber.Location = new System.Drawing.Point(74, 160);
            this.labelComputerNumber.Name = "labelComputerNumber";
            this.labelComputerNumber.Size = new System.Drawing.Size(179, 23);
            this.labelComputerNumber.TabIndex = 1;
            this.labelComputerNumber.Text = "Получите число:";
            // 
            // labelUserNumber
            // 
            this.labelUserNumber.AllowDrop = true;
            this.labelUserNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUserNumber.AutoEllipsis = true;
            this.labelUserNumber.AutoSize = true;
            this.labelUserNumber.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNumber.Location = new System.Drawing.Point(77, 267);
            this.labelUserNumber.Name = "labelUserNumber";
            this.labelUserNumber.Size = new System.Drawing.Size(168, 23);
            this.labelUserNumber.TabIndex = 2;
            this.labelUserNumber.Text = "Текущее число:";
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCommand.Location = new System.Drawing.Point(75, 50);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(272, 24);
            this.labelCommand.TabIndex = 3;
            this.labelCommand.Text = "Текущее количество команд:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.labelCommand);
            this.Controls.Add(this.labelUserNumber);
            this.Controls.Add(this.labelComputerNumber);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonReset);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Label labelComputerNumber;
        private System.Windows.Forms.Label labelUserNumber;
        private System.Windows.Forms.Label labelCommand;
    }
}

