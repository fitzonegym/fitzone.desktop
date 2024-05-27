namespace Fitzone.Front
{
    partial class Test
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
            button1 = new Button();
            btnSocioInsert = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(70, 35);
            button1.Name = "button1";
            button1.Size = new Size(272, 23);
            button1.TabIndex = 0;
            button1.Text = "socios GETALL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSocioInsert
            // 
            btnSocioInsert.Location = new Point(70, 78);
            btnSocioInsert.Name = "btnSocioInsert";
            btnSocioInsert.Size = new Size(272, 23);
            btnSocioInsert.TabIndex = 1;
            btnSocioInsert.Text = "socios Insert";
            btnSocioInsert.UseVisualStyleBackColor = true;
            btnSocioInsert.Click += btnSocioInsert_Click;
            // 
            // button2
            // 
            button2.Location = new Point(70, 117);
            button2.Name = "button2";
            button2.Size = new Size(272, 23);
            button2.TabIndex = 2;
            button2.Text = "socios Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(70, 159);
            button3.Name = "button3";
            button3.Size = new Size(272, 23);
            button3.TabIndex = 3;
            button3.Text = "socios Anular";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(70, 199);
            button4.Name = "button4";
            button4.Size = new Size(272, 23);
            button4.TabIndex = 4;
            button4.Text = "socios Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnSocioInsert);
            Controls.Add(button1);
            Name = "Test";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnSocioInsert;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
