namespace BobileStoreApp
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
            MobileCodeLBL = new Label();
            MakeLBL = new Label();
            QuantityLBL = new Label();
            MobileCodeTB = new TextBox();
            MakeTB = new TextBox();
            QuantityTB = new TextBox();
            AddBTN = new Button();
            DeleteBTN = new Button();
            FindBTN = new Button();
            OutputTXT = new Label();
            SuspendLayout();
            // 
            // MobileCodeLBL
            // 
            MobileCodeLBL.AutoSize = true;
            MobileCodeLBL.Location = new Point(47, 42);
            MobileCodeLBL.Name = "MobileCodeLBL";
            MobileCodeLBL.Size = new Size(114, 25);
            MobileCodeLBL.TabIndex = 0;
            MobileCodeLBL.Text = "Mobile Code";
            // 
            // MakeLBL
            // 
            MakeLBL.AutoSize = true;
            MakeLBL.Location = new Point(47, 94);
            MakeLBL.Name = "MakeLBL";
            MakeLBL.Size = new Size(55, 25);
            MakeLBL.TabIndex = 1;
            MakeLBL.Text = "Make";
            // 
            // QuantityLBL
            // 
            QuantityLBL.AutoSize = true;
            QuantityLBL.Location = new Point(47, 152);
            QuantityLBL.Name = "QuantityLBL";
            QuantityLBL.Size = new Size(80, 25);
            QuantityLBL.TabIndex = 2;
            QuantityLBL.Text = "Quantity";
            // 
            // MobileCodeTB
            // 
            MobileCodeTB.Location = new Point(173, 39);
            MobileCodeTB.Name = "MobileCodeTB";
            MobileCodeTB.Size = new Size(150, 31);
            MobileCodeTB.TabIndex = 3;
            // 
            // MakeTB
            // 
            MakeTB.Location = new Point(173, 94);
            MakeTB.Name = "MakeTB";
            MakeTB.Size = new Size(150, 31);
            MakeTB.TabIndex = 4;
            // 
            // QuantityTB
            // 
            QuantityTB.Location = new Point(173, 152);
            QuantityTB.Name = "QuantityTB";
            QuantityTB.Size = new Size(150, 31);
            QuantityTB.TabIndex = 5;
            // 
            // AddBTN
            // 
            AddBTN.Location = new Point(49, 236);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(112, 34);
            AddBTN.TabIndex = 6;
            AddBTN.Text = "Add";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(191, 236);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(112, 34);
            DeleteBTN.TabIndex = 7;
            DeleteBTN.Text = "Delete";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // FindBTN
            // 
            FindBTN.Location = new Point(332, 236);
            FindBTN.Name = "FindBTN";
            FindBTN.Size = new Size(112, 34);
            FindBTN.TabIndex = 8;
            FindBTN.Text = "Find";
            FindBTN.UseVisualStyleBackColor = true;
            FindBTN.Click += FindBTN_Click;
            // 
            // OutputTXT
            // 
            OutputTXT.AutoSize = true;
            OutputTXT.Location = new Point(519, 70);
            OutputTXT.Name = "OutputTXT";
            OutputTXT.Size = new Size(16, 25);
            OutputTXT.TabIndex = 9;
            OutputTXT.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputTXT);
            Controls.Add(FindBTN);
            Controls.Add(DeleteBTN);
            Controls.Add(AddBTN);
            Controls.Add(QuantityTB);
            Controls.Add(MakeTB);
            Controls.Add(MobileCodeTB);
            Controls.Add(QuantityLBL);
            Controls.Add(MakeLBL);
            Controls.Add(MobileCodeLBL);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MobileCodeLBL;
        private Label MakeLBL;
        private Label QuantityLBL;
        private TextBox MobileCodeTB;
        private TextBox MakeTB;
        private TextBox QuantityTB;
        private Button AddBTN;
        private Button DeleteBTN;
        private Button FindBTN;
        private Label OutputTXT;
    }
}
