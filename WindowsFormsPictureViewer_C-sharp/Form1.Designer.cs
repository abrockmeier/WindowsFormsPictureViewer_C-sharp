namespace WindowsFormsPictureViewer_C_sharp
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.CB_stretch = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.B1_anzeigen = new System.Windows.Forms.Button();
			this.B2_loeschen = new System.Windows.Forms.Button();
			this.B3_BGfarbe = new System.Windows.Forms.Button();
			this.B4_schliessen = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.CB_stretch, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 353);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
			// 
			// pictureBox1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(576, 311);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// CB_stretch
			// 
			this.CB_stretch.AutoSize = true;
			this.CB_stretch.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CB_stretch.Location = new System.Drawing.Point(3, 320);
			this.CB_stretch.Name = "CB_stretch";
			this.CB_stretch.Size = new System.Drawing.Size(70, 24);
			this.CB_stretch.TabIndex = 1;
			this.CB_stretch.Text = "Stretch";
			this.CB_stretch.UseVisualStyleBackColor = true;
			this.CB_stretch.CheckedChanged += new System.EventHandler(this.CB_stretch_CheckedChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.B1_anzeigen);
			this.flowLayoutPanel1.Controls.Add(this.B2_loeschen);
			this.flowLayoutPanel1.Controls.Add(this.B3_BGfarbe);
			this.flowLayoutPanel1.Controls.Add(this.B4_schliessen);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(90, 320);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(489, 30);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// B1_anzeigen
			// 
			this.B1_anzeigen.AutoSize = true;
			this.B1_anzeigen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B1_anzeigen.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B1_anzeigen.Location = new System.Drawing.Point(393, 3);
			this.B1_anzeigen.Name = "B1_anzeigen";
			this.B1_anzeigen.Size = new System.Drawing.Size(93, 30);
			this.B1_anzeigen.TabIndex = 0;
			this.B1_anzeigen.Text = "Bild anzeigen";
			this.B1_anzeigen.UseVisualStyleBackColor = true;
			this.B1_anzeigen.Click += new System.EventHandler(this.B1_anzeigen_Click);
			// 
			// B2_loeschen
			// 
			this.B2_loeschen.AutoSize = true;
			this.B2_loeschen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B2_loeschen.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B2_loeschen.Location = new System.Drawing.Point(300, 3);
			this.B2_loeschen.Name = "B2_loeschen";
			this.B2_loeschen.Size = new System.Drawing.Size(87, 30);
			this.B2_loeschen.TabIndex = 0;
			this.B2_loeschen.Text = "Bild löschen";
			this.B2_loeschen.UseVisualStyleBackColor = true;
			this.B2_loeschen.Click += new System.EventHandler(this.B2_loeschen_Click);
			// 
			// B3_BGfarbe
			// 
			this.B3_BGfarbe.AutoSize = true;
			this.B3_BGfarbe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B3_BGfarbe.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B3_BGfarbe.Location = new System.Drawing.Point(140, 3);
			this.B3_BGfarbe.Name = "B3_BGfarbe";
			this.B3_BGfarbe.Size = new System.Drawing.Size(154, 30);
			this.B3_BGfarbe.TabIndex = 0;
			this.B3_BGfarbe.Text = "Hintergrundfarbe ändern";
			this.B3_BGfarbe.UseVisualStyleBackColor = true;
			this.B3_BGfarbe.Click += new System.EventHandler(this.B3_BGfarbe_Click);
			// 
			// B4_schliessen
			// 
			this.B4_schliessen.AutoSize = true;
			this.B4_schliessen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B4_schliessen.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B4_schliessen.Location = new System.Drawing.Point(58, 3);
			this.B4_schliessen.Name = "B4_schliessen";
			this.B4_schliessen.Size = new System.Drawing.Size(76, 30);
			this.B4_schliessen.TabIndex = 0;
			this.B4_schliessen.Text = "Schließen";
			this.B4_schliessen.UseVisualStyleBackColor = true;
			this.B4_schliessen.Click += new System.EventHandler(this.B4_schliessen_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "JPEG Files (*.jpg) | *.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|ALL Fi" +
    "les (*.*)|*.*";
			this.openFileDialog1.Title = "Select a picture file";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 353);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox CB_stretch;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button B1_anzeigen;
		private System.Windows.Forms.Button B2_loeschen;
		private System.Windows.Forms.Button B3_BGfarbe;
		private System.Windows.Forms.Button B4_schliessen;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ColorDialog colorDialog1;
	}
}

