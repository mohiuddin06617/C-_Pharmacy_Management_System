namespace Pharmacy_Project
{
    partial class Add_Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Employee));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSaveMedicine = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(222, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 30);
            this.button1.TabIndex = 48;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonSaveMedicine
            // 
            this.buttonSaveMedicine.AutoSize = true;
            this.buttonSaveMedicine.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonSaveMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSaveMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveMedicine.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonSaveMedicine.Location = new System.Drawing.Point(90, 342);
            this.buttonSaveMedicine.Name = "buttonSaveMedicine";
            this.buttonSaveMedicine.Size = new System.Drawing.Size(88, 30);
            this.buttonSaveMedicine.TabIndex = 47;
            this.buttonSaveMedicine.Text = "Save";
            this.buttonSaveMedicine.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(86, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "Employee\'s Information";
            // 
            // textBoxGName
            // 
            this.textBoxGName.Location = new System.Drawing.Point(192, 126);
            this.textBoxGName.Multiline = true;
            this.textBoxGName.Name = "textBoxGName";
            this.textBoxGName.Size = new System.Drawing.Size(148, 27);
            this.textBoxGName.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(33, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Genereic Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(37, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Name ";
            // 
            // textBoxMName
            // 
            this.textBoxMName.Location = new System.Drawing.Point(192, 70);
            this.textBoxMName.Multiline = true;
            this.textBoxMName.Name = "textBoxMName";
            this.textBoxMName.Size = new System.Drawing.Size(148, 27);
            this.textBoxMName.TabIndex = 43;
            // 
            // Add_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSaveMedicine);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxGName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMName);
            this.Name = "Add_Employee";
            this.Text = "Add_Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSaveMedicine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMName;
    }
}