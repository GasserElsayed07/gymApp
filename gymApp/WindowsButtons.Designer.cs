namespace gymApp
{
    partial class WindowsButtons
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_minimize = new Button();
            SuspendLayout();
            // 
            // button_minimize
            // 
            button_minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_minimize.BackColor = Color.RosyBrown;
            button_minimize.FlatStyle = FlatStyle.Flat;
            button_minimize.Font = new Font("Segoe UI", 32F);
            button_minimize.Location = new Point(0, 0);
            button_minimize.Name = "button_minimize";
            button_minimize.Size = new Size(150, 150);
            button_minimize.TabIndex = 16;
            button_minimize.Text = "-";
            button_minimize.UseVisualStyleBackColor = false;
            button_minimize.Click += button_minimize_Click;
            // 
            // WindowsButtons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_minimize);
            Name = "WindowsButtons";
            ResumeLayout(false);
        }

        #endregion

        private Button button_minimize;
    }
}
