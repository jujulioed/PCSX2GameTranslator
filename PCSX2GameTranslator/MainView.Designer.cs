
using System.Diagnostics;

namespace PCSX2GameTranslator
{
    partial class MainView
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
            listView1 = new ListView();
            label = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(306, 33);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 0;
            button1.Text = "Listar Processos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(96, 79);
            listView1.Name = "listView1";
            listView1.Size = new Size(574, 297);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(354, 186);
            label.Name = "label";
            label.Size = new Size(32, 15);
            label.TabIndex = 2;
            label.Text = "teste";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label);
            Controls.Add(listView1);
            Controls.Add(button1);
            Name = "MainView";
            Text = "PCSX2 Game Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pcsx2Process.PrintWindow(Pcsx2Process.Pcsx2);
        }

        #endregion

        private Button button1;
        private ListView listView1;
        private Label label;
    }
}
