namespace CuteCat
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
            components = new System.ComponentModel.Container();
            CatScreen = new Label();
            Play = new Button();
            Feed = new Button();
            CatTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // CatScreen
            // 
            CatScreen.BackColor = SystemColors.InactiveCaption;
            CatScreen.BorderStyle = BorderStyle.Fixed3D;
            CatScreen.Location = new Point(52, 45);
            CatScreen.Name = "CatScreen";
            CatScreen.Size = new Size(683, 52);
            CatScreen.TabIndex = 0;
            CatScreen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Play
            // 
            Play.Location = new Point(60, 129);
            Play.Name = "Play";
            Play.Size = new Size(100, 63);
            Play.TabIndex = 1;
            Play.Text = "Play";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // Feed
            // 
            Feed.Location = new Point(175, 129);
            Feed.Name = "Feed";
            Feed.Size = new Size(100, 63);
            Feed.TabIndex = 2;
            Feed.Text = "Feed";
            Feed.UseVisualStyleBackColor = true;
            Feed.Click += Feed_Click;
            // 
            // CatTimer
            // 
            CatTimer.Enabled = true;
            CatTimer.Interval = 5000;
            CatTimer.Tick += CatTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Feed);
            Controls.Add(Play);
            Controls.Add(CatScreen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label CatScreen;
        private Button Play;
        private Button Feed;
        private System.Windows.Forms.Timer CatTimer;
    }
}