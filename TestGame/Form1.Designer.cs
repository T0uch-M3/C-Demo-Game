namespace TestGame
{
    partial class Form1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.mtPanel = new MetroFramework.Controls.MetroPanel();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.btnQuit = new MetroFramework.Controls.MetroButton();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.labCounter = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.labState = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.mtPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn1.Font = new System.Drawing.Font("Old English Text MT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn1.Location = new System.Drawing.Point(18, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 150);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "-";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.change);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Old English Text MT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(174, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 150);
            this.button1.TabIndex = 8;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.change);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Old English Text MT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(330, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 150);
            this.button2.TabIndex = 9;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.change);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Old English Text MT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Location = new System.Drawing.Point(18, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 150);
            this.button3.TabIndex = 10;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.change);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Font = new System.Drawing.Font("Old English Text MT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Location = new System.Drawing.Point(174, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 150);
            this.button4.TabIndex = 11;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.change);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.Font = new System.Drawing.Font("Old English Text MT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.Location = new System.Drawing.Point(330, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 150);
            this.button5.TabIndex = 12;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.change);
            // 
            // mtPanel
            // 
            this.mtPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.mtPanel.Controls.Add(this.button4);
            this.mtPanel.Controls.Add(this.button5);
            this.mtPanel.Controls.Add(this.btn1);
            this.mtPanel.Controls.Add(this.button3);
            this.mtPanel.Controls.Add(this.button1);
            this.mtPanel.Controls.Add(this.button2);
            this.mtPanel.HorizontalScrollbarBarColor = true;
            this.mtPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mtPanel.HorizontalScrollbarSize = 10;
            this.mtPanel.Location = new System.Drawing.Point(7, 53);
            this.mtPanel.Name = "mtPanel";
            this.mtPanel.Size = new System.Drawing.Size(495, 312);
            this.mtPanel.TabIndex = 13;
            this.mtPanel.VerticalScrollbarBarColor = true;
            this.mtPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mtPanel.VerticalScrollbarSize = 10;
            // 
            // btnStart
            // 
            this.btnStart.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnStart.Location = new System.Drawing.Point(87, 427);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 50);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.startGame);
            // 
            // btnQuit
            // 
            this.btnQuit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnQuit.Location = new System.Drawing.Point(337, 427);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(88, 50);
            this.btnQuit.TabIndex = 15;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseSelectable = true;
            this.btnQuit.Click += new System.EventHandler(this.quitGame);
            // 
            // startTimer
            // 
            this.startTimer.Interval = 1000;
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // labCounter
            // 
            this.labCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labCounter.Location = new System.Drawing.Point(197, 403);
            this.labCounter.Name = "labCounter";
            this.labCounter.Size = new System.Drawing.Size(117, 87);
            this.labCounter.TabIndex = 16;
            this.labCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(458, 390);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 33);
            this.button6.TabIndex = 17;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // labState
            // 
            this.labState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labState.Location = new System.Drawing.Point(205, 15);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(100, 35);
            this.labState.TabIndex = 18;
            this.labState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab2
            // 
            this.lab2.BackColor = System.Drawing.Color.White;
            this.lab2.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab2.Location = new System.Drawing.Point(231, 367);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(50, 35);
            this.lab2.TabIndex = 19;
            this.lab2.Text = "<3";
            this.lab2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab1
            // 
            this.lab1.BackColor = System.Drawing.Color.White;
            this.lab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab1.Location = new System.Drawing.Point(185, 368);
            this.lab1.Name = "lab1";
            this.lab1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab1.Size = new System.Drawing.Size(50, 35);
            this.lab1.TabIndex = 20;
            this.lab1.Text = "<3";
            this.lab1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lab3
            // 
            this.lab3.BackColor = System.Drawing.Color.White;
            this.lab3.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab3.Location = new System.Drawing.Point(272, 367);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(51, 35);
            this.lab3.TabIndex = 21;
            this.lab3.Text = "<3";
            this.lab3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 500);
            this.ControlBox = false;
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.labState);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.labCounter);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.mtPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "Form1";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.mtPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private MetroFramework.Controls.MetroPanel mtPanel;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroButton btnQuit;
        private System.Windows.Forms.Timer startTimer;
        private System.Windows.Forms.Label labCounter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labState;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab1;

    }
}

