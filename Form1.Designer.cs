namespace Aufgabe31
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
            lbEingabe = new Label();
            txtEingabe = new TextBox();
            button1 = new Button();
            lbFalsch = new Label();
            lbVersuch = new Label();
            lbVerbleib = new Label();
            lbWort = new Label();
            button2 = new Button();
            button3 = new Button();
            picBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // lbEingabe
            // 
            lbEingabe.AutoSize = true;
            lbEingabe.Location = new Point(81, 75);
            lbEingabe.Name = "lbEingabe";
            lbEingabe.Size = new Size(49, 15);
            lbEingabe.TabIndex = 0;
            lbEingabe.Text = "Eingabe";
            // 
            // txtEingabe
            // 
            txtEingabe.Location = new Point(81, 98);
            txtEingabe.Name = "txtEingabe";
            txtEingabe.Size = new Size(70, 23);
            txtEingabe.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(159, 98);
            button1.Name = "button1";
            button1.Size = new Size(121, 33);
            button1.TabIndex = 2;
            button1.Text = "Buchstaben testen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbFalsch
            // 
            lbFalsch.AutoSize = true;
            lbFalsch.Location = new Point(81, 152);
            lbFalsch.Name = "lbFalsch";
            lbFalsch.Size = new Size(105, 15);
            lbFalsch.TabIndex = 3;
            lbFalsch.Text = "Falshe Buchstaben";
            // 
            // lbVersuch
            // 
            lbVersuch.AutoSize = true;
            lbVersuch.Location = new Point(81, 190);
            lbVersuch.Name = "lbVersuch";
            lbVersuch.Size = new Size(60, 15);
            lbVersuch.TabIndex = 4;
            lbVersuch.Text = "Hangman";
            // 
            // lbVerbleib
            // 
            lbVerbleib.AutoSize = true;
            lbVerbleib.Location = new Point(81, 221);
            lbVerbleib.Name = "lbVerbleib";
            lbVerbleib.Size = new Size(19, 15);
            lbVerbleib.TabIndex = 5;
            lbVerbleib.Text = "10";
            // 
            // lbWort
            // 
            lbWort.AutoSize = true;
            lbWort.Location = new Point(81, 252);
            lbWort.Name = "lbWort";
            lbWort.Size = new Size(33, 15);
            lbWort.TabIndex = 6;
            lbWort.Text = "Wort";
            // 
            // button2
            // 
            button2.Location = new Point(70, 340);
            button2.Name = "button2";
            button2.Size = new Size(113, 37);
            button2.TabIndex = 7;
            button2.Text = "Neues Spiel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(70, 401);
            button3.Name = "button3";
            button3.Size = new Size(113, 37);
            button3.TabIndex = 8;
            button3.Text = "Stop";
            button3.UseVisualStyleBackColor = true;
            // 
            // picBox
            // 
            picBox.Location = new Point(386, 75);
            picBox.Name = "picBox";
            picBox.Size = new Size(351, 232);
            picBox.TabIndex = 9;
            picBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picBox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lbWort);
            Controls.Add(lbVerbleib);
            Controls.Add(lbVersuch);
            Controls.Add(lbFalsch);
            Controls.Add(button1);
            Controls.Add(txtEingabe);
            Controls.Add(lbEingabe);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbEingabe;
        private TextBox txtEingabe;
        private Button button1;
        private Label lbFalsch;
        private Label lbVersuch;
        private Label lbVerbleib;
        private Label lbWort;
        private Button button2;
        private Button button3;
        private PictureBox picBox;
    }
}
