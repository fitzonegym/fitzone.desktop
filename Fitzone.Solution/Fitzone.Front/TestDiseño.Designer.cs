namespace Fitzone.Front
{
    partial class TestDiseño
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
            thunderForm1 = new ReaLTaiizor.Forms.ThunderForm();
            botonesForms1 = new UserControls.BotonesForms();
            thunderForm1.SuspendLayout();
            SuspendLayout();
            // 
            // thunderForm1
            // 
            thunderForm1.BackColor = Color.FromArgb(255, 192, 128);
            thunderForm1.BodyColorA = Color.Black;
            thunderForm1.BodyColorB = Color.Black;
            thunderForm1.BodyColorC = Color.FromArgb(100, 26, 89);
            thunderForm1.BodyColorD = Color.FromArgb(120, 46, 110);
            thunderForm1.Controls.Add(botonesForms1);
            thunderForm1.Dock = DockStyle.Fill;
            thunderForm1.ForeColor = Color.WhiteSmoke;
            thunderForm1.Image = Properties.Resources.ico1;
            thunderForm1.Location = new Point(0, 0);
            thunderForm1.MinimumSize = new Size(270, 50);
            thunderForm1.Name = "thunderForm1";
            thunderForm1.Padding = new Padding(11, 29, 11, 6);
            thunderForm1.Size = new Size(800, 450);
            thunderForm1.TabIndex = 0;
            thunderForm1.Text = "Fitzone";
            // 
            // botonesForms1
            // 
            botonesForms1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonesForms1.BackColor = Color.Transparent;
            botonesForms1.Location = new Point(726, 4);
            botonesForms1.Name = "botonesForms1";
            botonesForms1.Size = new Size(69, 20);
            botonesForms1.TabIndex = 0;
            // 
            // TestDiseño
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(thunderForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TestDiseño";
            Text = "TestDiseño";
            TransparencyKey = Color.Fuchsia;
            thunderForm1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ThunderForm thunderForm1;
        private UserControls.BotonesForms botonesForms1;
    }
}