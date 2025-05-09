namespace ChatUI
{
    partial class ChatUI
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
            listView1 = new ListView();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 277);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Location = new Point(12, 301);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(658, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(676, 301);
            button1.Name = "button1";
            button1.Size = new Size(112, 23);
            button1.TabIndex = 2;
            button1.Text = "SEND";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            // 
            // ChatUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 336);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Name = "ChatUI";
            Text = "Chat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private TextBox textBox1;
        private Button button1;
    }
}
