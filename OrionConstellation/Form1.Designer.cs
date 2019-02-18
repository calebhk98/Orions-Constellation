namespace OrionConstellation {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.showBtn = new System.Windows.Forms.Button();
			this.toggleBtn = new System.Windows.Forms.Button();
			this.hideBtn = new System.Windows.Forms.Button();
			this.closeBtn = new System.Windows.Forms.Button();
			this.betelgeuseLabel = new System.Windows.Forms.Label();
			this.meissaLabel = new System.Windows.Forms.Label();
			this.alnitakLabel = new System.Windows.Forms.Label();
			this.mintakaLabel = new System.Windows.Forms.Label();
			this.alnilamLabel = new System.Windows.Forms.Label();
			this.rigelLabel = new System.Windows.Forms.Label();
			this.saiphLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::OrionConstellation.Properties.Resources.Orion;
			this.pictureBox1.Location = new System.Drawing.Point(30, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(586, 458);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// showBtn
			// 
			this.showBtn.Location = new System.Drawing.Point(652, 182);
			this.showBtn.Name = "showBtn";
			this.showBtn.Size = new System.Drawing.Size(108, 23);
			this.showBtn.TabIndex = 1;
			this.showBtn.Text = "Show Names";
			this.showBtn.UseVisualStyleBackColor = true;
			this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
			// 
			// toggleBtn
			// 
			this.toggleBtn.Location = new System.Drawing.Point(652, 212);
			this.toggleBtn.Name = "toggleBtn";
			this.toggleBtn.Size = new System.Drawing.Size(108, 23);
			this.toggleBtn.TabIndex = 2;
			this.toggleBtn.Text = "Toggle Names";
			this.toggleBtn.UseVisualStyleBackColor = true;
			this.toggleBtn.Click += new System.EventHandler(this.toggleBtn_Click);
			// 
			// hideBtn
			// 
			this.hideBtn.Location = new System.Drawing.Point(652, 242);
			this.hideBtn.Name = "hideBtn";
			this.hideBtn.Size = new System.Drawing.Size(108, 23);
			this.hideBtn.TabIndex = 3;
			this.hideBtn.Text = "Hide Names";
			this.hideBtn.UseVisualStyleBackColor = true;
			this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
			// 
			// closeBtn
			// 
			this.closeBtn.Location = new System.Drawing.Point(642, 20);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(75, 23);
			this.closeBtn.TabIndex = 4;
			this.closeBtn.Text = "Close";
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// betelgeuseLabel
			// 
			this.betelgeuseLabel.AutoSize = true;
			this.betelgeuseLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.betelgeuseLabel.Image = global::OrionConstellation.Properties.Resources.Orion;
			this.betelgeuseLabel.Location = new System.Drawing.Point(156, 45);
			this.betelgeuseLabel.Name = "betelgeuseLabel";
			this.betelgeuseLabel.Size = new System.Drawing.Size(60, 13);
			this.betelgeuseLabel.TabIndex = 5;
			this.betelgeuseLabel.Text = "Betelgeuse";
			this.betelgeuseLabel.Visible = false;
			// 
			// meissaLabel
			// 
			this.meissaLabel.AutoSize = true;
			this.meissaLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.meissaLabel.Image = global::OrionConstellation.Properties.Resources.Orion;
			this.meissaLabel.Location = new System.Drawing.Point(450, 84);
			this.meissaLabel.Name = "meissaLabel";
			this.meissaLabel.Size = new System.Drawing.Size(40, 13);
			this.meissaLabel.TabIndex = 6;
			this.meissaLabel.Text = "Meissa";
			this.meissaLabel.Visible = false;
			// 
			// alnitakLabel
			// 
			this.alnitakLabel.AutoSize = true;
			this.alnitakLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.alnitakLabel.Image = global::OrionConstellation.Properties.Resources.Orion;
			this.alnitakLabel.Location = new System.Drawing.Point(133, 247);
			this.alnitakLabel.Name = "alnitakLabel";
			this.alnitakLabel.Size = new System.Drawing.Size(39, 13);
			this.alnitakLabel.TabIndex = 7;
			this.alnitakLabel.Text = "Alnitak";
			this.alnitakLabel.Visible = false;
			// 
			// mintakaLabel
			// 
			this.mintakaLabel.AutoSize = true;
			this.mintakaLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.mintakaLabel.Image = global::OrionConstellation.Properties.Resources.Orion;
			this.mintakaLabel.Location = new System.Drawing.Point(380, 217);
			this.mintakaLabel.Name = "mintakaLabel";
			this.mintakaLabel.Size = new System.Drawing.Size(45, 13);
			this.mintakaLabel.TabIndex = 8;
			this.mintakaLabel.Text = "Mintaka";
			this.mintakaLabel.Visible = false;
			// 
			// alnilamLabel
			// 
			this.alnilamLabel.AutoSize = true;
			this.alnilamLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.alnilamLabel.Image = global::OrionConstellation.Properties.Resources.Orion;
			this.alnilamLabel.Location = new System.Drawing.Point(274, 252);
			this.alnilamLabel.Name = "alnilamLabel";
			this.alnilamLabel.Size = new System.Drawing.Size(40, 13);
			this.alnilamLabel.TabIndex = 9;
			this.alnilamLabel.Text = "Alnilam";
			this.alnilamLabel.Visible = false;
			// 
			// rigelLabel
			// 
			this.rigelLabel.AutoSize = true;
			this.rigelLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.rigelLabel.Image = global::OrionConstellation.Properties.Resources.Orion;
			this.rigelLabel.Location = new System.Drawing.Point(450, 367);
			this.rigelLabel.Name = "rigelLabel";
			this.rigelLabel.Size = new System.Drawing.Size(31, 13);
			this.rigelLabel.TabIndex = 10;
			this.rigelLabel.Text = "Rigel";
			this.rigelLabel.Visible = false;
			// 
			// saiphLabel
			// 
			this.saiphLabel.AutoSize = true;
			this.saiphLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.saiphLabel.Image = global::OrionConstellation.Properties.Resources.Orion;
			this.saiphLabel.Location = new System.Drawing.Point(178, 396);
			this.saiphLabel.Name = "saiphLabel";
			this.saiphLabel.Size = new System.Drawing.Size(34, 13);
			this.saiphLabel.TabIndex = 11;
			this.saiphLabel.Text = "Saiph";
			this.saiphLabel.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 500);
			this.Controls.Add(this.saiphLabel);
			this.Controls.Add(this.rigelLabel);
			this.Controls.Add(this.alnilamLabel);
			this.Controls.Add(this.mintakaLabel);
			this.Controls.Add(this.alnitakLabel);
			this.Controls.Add(this.meissaLabel);
			this.Controls.Add(this.betelgeuseLabel);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.hideBtn);
			this.Controls.Add(this.toggleBtn);
			this.Controls.Add(this.showBtn);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Orion Constellation";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button showBtn;
		private System.Windows.Forms.Button toggleBtn;
		private System.Windows.Forms.Button hideBtn;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Label betelgeuseLabel;
		private System.Windows.Forms.Label meissaLabel;
		private System.Windows.Forms.Label alnitakLabel;
		private System.Windows.Forms.Label mintakaLabel;
		private System.Windows.Forms.Label alnilamLabel;
		private System.Windows.Forms.Label rigelLabel;
		private System.Windows.Forms.Label saiphLabel;
	}
}

