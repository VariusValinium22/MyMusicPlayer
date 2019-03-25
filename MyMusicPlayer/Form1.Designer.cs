﻿namespace MyMusicPlayer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Player = new AxWMPLib.AxWindowsMediaPlayer();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Browse = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
			this.SuspendLayout();
			// 
			// Player
			// 
			this.Player.Enabled = true;
			this.Player.Location = new System.Drawing.Point(-3, 1);
			this.Player.Name = "Player";
			this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
			this.Player.Size = new System.Drawing.Size(685, 161);
			this.Player.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(-3, 130);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(108, 32);
			this.textBox1.TabIndex = 1;
			// 
			// Browse
			// 
			this.Browse.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Browse.Font = new System.Drawing.Font("Playbill", 36F);
			this.Browse.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.Browse.Location = new System.Drawing.Point(12, 184);
			this.Browse.Name = "Browse";
			this.Browse.Size = new System.Drawing.Size(110, 60);
			this.Browse.TabIndex = 2;
			this.Browse.Text = "Browse";
			this.Browse.UseVisualStyleBackColor = false;
			this.Browse.Click += new System.EventHandler(this.Browse_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Playbill", 36F);
			this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.button1.Location = new System.Drawing.Point(158, 184);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 60);
			this.button1.TabIndex = 3;
			this.button1.Text = "Play";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Magenta;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Playbill", 36F);
			this.button2.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.button2.Location = new System.Drawing.Point(302, 184);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 60);
			this.button2.TabIndex = 4;
			this.button2.Text = "Pause";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.DarkMagenta;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("Playbill", 36F);
			this.button3.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.button3.Location = new System.Drawing.Point(430, 184);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(110, 60);
			this.button3.TabIndex = 5;
			this.button3.Text = "Stop";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.DarkBlue;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new System.Drawing.Font("Playbill", 36F);
			this.button4.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.button4.Location = new System.Drawing.Point(559, 186);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(110, 60);
			this.button4.TabIndex = 6;
			this.button4.Text = "Exit";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Multiselect = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.ClientSize = new System.Drawing.Size(681, 258);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Browse);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Player);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Marty\'s Music Player";
			((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private AxWMPLib.AxWindowsMediaPlayer Player;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button Browse;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

