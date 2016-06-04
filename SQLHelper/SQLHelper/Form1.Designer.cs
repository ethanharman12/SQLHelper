namespace SQLHelper
{
    partial class SQLHelper
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLHelper));
            this.SubmitButton = new System.Windows.Forms.Button();
            this.BeforeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AfterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputListTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(12, 112);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // BeforeTextBox
            // 
            this.BeforeTextBox.Location = new System.Drawing.Point(12, 25);
            this.BeforeTextBox.Name = "BeforeTextBox";
            this.BeforeTextBox.Size = new System.Drawing.Size(100, 20);
            this.BeforeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Before Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "After Text";
            // 
            // AfterTextBox
            // 
            this.AfterTextBox.Location = new System.Drawing.Point(12, 64);
            this.AfterTextBox.Name = "AfterTextBox";
            this.AfterTextBox.Size = new System.Drawing.Size(100, 20);
            this.AfterTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input List";
            // 
            // InputListTextBox
            // 
            this.InputListTextBox.Location = new System.Drawing.Point(121, 25);
            this.InputListTextBox.MaxLength = 1000000;
            this.InputListTextBox.Multiline = true;
            this.InputListTextBox.Name = "InputListTextBox";
            this.InputListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputListTextBox.Size = new System.Drawing.Size(154, 114);
            this.InputListTextBox.TabIndex = 5;
            this.InputListTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputListTextBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(285, 25);
            this.OutputTextBox.MaxLength = 1000000;
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTextBox.Size = new System.Drawing.Size(154, 114);
            this.OutputTextBox.TabIndex = 9;
            this.OutputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OutputTextBox_KeyDown);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SQL Helper";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // SQLHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 151);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputListTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AfterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BeforeTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Name = "SQLHelper";
            this.Text = "SQL Helper";
            this.Resize += new System.EventHandler(this.SQLHelper_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox BeforeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AfterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputListTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

