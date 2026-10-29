namespace HelloForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InputFieldBox = new TextBox();
            TextTXT = new Label();
            GreetingsBTN = new Button();
            SuspendLayout();
            // 
            // InputFieldBox
            // 
            InputFieldBox.Location = new Point(323, 179);
            InputFieldBox.Name = "InputFieldBox";
            InputFieldBox.Size = new Size(230, 31);
            InputFieldBox.TabIndex = 0;
            // 
            // TextTXT
            // 
            TextTXT.AutoSize = true;
            TextTXT.Location = new Point(108, 179);
            TextTXT.Name = "TextTXT";
            TextTXT.Size = new Size(196, 25);
            TextTXT.TabIndex = 1;
            TextTXT.Text = "Please enter your name";
            // 
            // GreetingsBTN
            // 
            GreetingsBTN.Location = new Point(378, 241);
            GreetingsBTN.Name = "GreetingsBTN";
            GreetingsBTN.Size = new Size(112, 34);
            GreetingsBTN.TabIndex = 2;
            GreetingsBTN.Text = "Greetings";
            GreetingsBTN.UseVisualStyleBackColor = true;
            GreetingsBTN.Click += GreetingsBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GreetingsBTN);
            Controls.Add(TextTXT);
            Controls.Add(InputFieldBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputFieldBox;
        private Label TextTXT;
        private Button GreetingsBTN;
    }
}
