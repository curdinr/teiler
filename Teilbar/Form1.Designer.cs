namespace Teilbar
{
	partial class CTeilbar
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
			this.lblEndwert = new System.Windows.Forms.Label();
			this.txtEndwert = new System.Windows.Forms.TextBox();
			this.btnSchliessen = new System.Windows.Forms.Button();
			this.lblTeiler = new System.Windows.Forms.Label();
			this.lblAnfangswert = new System.Windows.Forms.Label();
			this.txtTeiler = new System.Windows.Forms.TextBox();
			this.btnBerechnen = new System.Windows.Forms.Button();
			this.txtAnfangswert = new System.Windows.Forms.TextBox();
			this.lblResultat = new System.Windows.Forms.Label();
			this.lblTeilerListe = new System.Windows.Forms.Label();
			this.lblAnzahl = new System.Windows.Forms.Label();
			this.txtAnzahl = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblEndwert
			// 
			this.lblEndwert.Location = new System.Drawing.Point(165, 41);
			this.lblEndwert.Name = "lblEndwert";
			this.lblEndwert.Size = new System.Drawing.Size(51, 23);
			this.lblEndwert.TabIndex = 23;
			this.lblEndwert.Text = "Endwert";
			// 
			// txtEndwert
			// 
			this.txtEndwert.Location = new System.Drawing.Point(216, 41);
			this.txtEndwert.Name = "txtEndwert";
			this.txtEndwert.Size = new System.Drawing.Size(96, 20);
			this.txtEndwert.TabIndex = 22;
			this.txtEndwert.Text = "23";
			this.txtEndwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnSchliessen
			// 
			this.btnSchliessen.Location = new System.Drawing.Point(318, 39);
			this.btnSchliessen.Name = "btnSchliessen";
			this.btnSchliessen.Size = new System.Drawing.Size(72, 24);
			this.btnSchliessen.TabIndex = 21;
			this.btnSchliessen.Text = "Schliessen";
			this.btnSchliessen.Click += new System.EventHandler(this.btnSchliessen_Click);
			// 
			// lblTeiler
			// 
			this.lblTeiler.Location = new System.Drawing.Point(10, 16);
			this.lblTeiler.Name = "lblTeiler";
			this.lblTeiler.Size = new System.Drawing.Size(51, 23);
			this.lblTeiler.TabIndex = 20;
			this.lblTeiler.Text = "Teiler";
			// 
			// lblAnfangswert
			// 
			this.lblAnfangswert.Location = new System.Drawing.Point(10, 41);
			this.lblAnfangswert.Name = "lblAnfangswert";
			this.lblAnfangswert.Size = new System.Drawing.Size(51, 23);
			this.lblAnfangswert.TabIndex = 19;
			this.lblAnfangswert.Text = "Anfang";
			// 
			// txtTeiler
			// 
			this.txtTeiler.Location = new System.Drawing.Point(61, 16);
			this.txtTeiler.Name = "txtTeiler";
			this.txtTeiler.Size = new System.Drawing.Size(96, 20);
			this.txtTeiler.TabIndex = 18;
			this.txtTeiler.Text = "3";
			this.txtTeiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnBerechnen
			// 
			this.btnBerechnen.Location = new System.Drawing.Point(318, 9);
			this.btnBerechnen.Name = "btnBerechnen";
			this.btnBerechnen.Size = new System.Drawing.Size(72, 24);
			this.btnBerechnen.TabIndex = 17;
			this.btnBerechnen.Text = "Berechnen";
			this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
			// 
			// txtAnfangswert
			// 
			this.txtAnfangswert.Location = new System.Drawing.Point(61, 41);
			this.txtAnfangswert.Name = "txtAnfangswert";
			this.txtAnfangswert.Size = new System.Drawing.Size(96, 20);
			this.txtAnfangswert.TabIndex = 16;
			this.txtAnfangswert.Text = "4";
			this.txtAnfangswert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblResultat
			// 
			this.lblResultat.Location = new System.Drawing.Point(10, 74);
			this.lblResultat.Name = "lblResultat";
			this.lblResultat.Size = new System.Drawing.Size(51, 23);
			this.lblResultat.TabIndex = 24;
			this.lblResultat.Text = "Resultat";
			// 
			// lblTeilerListe
			// 
			this.lblTeilerListe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTeilerListe.Location = new System.Drawing.Point(58, 74);
			this.lblTeilerListe.Name = "lblTeilerListe";
			this.lblTeilerListe.Size = new System.Drawing.Size(99, 84);
			this.lblTeilerListe.TabIndex = 25;
			this.lblTeilerListe.Text = "Teilerliste leer";
			// 
			// lblAnzahl
			// 
			this.lblAnzahl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblAnzahl.Location = new System.Drawing.Point(246, 141);
			this.lblAnzahl.Name = "lblAnzahl";
			this.lblAnzahl.Size = new System.Drawing.Size(98, 14);
			this.lblAnzahl.TabIndex = 27;
			this.lblAnzahl.Text = "Anzahl Schlaufen";
			// 
			// txtAnzahl
			// 
			this.txtAnzahl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAnzahl.Location = new System.Drawing.Point(346, 138);
			this.txtAnzahl.Name = "txtAnzahl";
			this.txtAnzahl.ReadOnly = true;
			this.txtAnzahl.Size = new System.Drawing.Size(43, 20);
			this.txtAnzahl.TabIndex = 26;
			this.txtAnzahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// CTeilbar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 161);
			this.Controls.Add(this.lblAnzahl);
			this.Controls.Add(this.txtAnzahl);
			this.Controls.Add(this.lblTeilerListe);
			this.Controls.Add(this.lblResultat);
			this.Controls.Add(this.lblEndwert);
			this.Controls.Add(this.txtEndwert);
			this.Controls.Add(this.btnSchliessen);
			this.Controls.Add(this.lblTeiler);
			this.Controls.Add(this.lblAnfangswert);
			this.Controls.Add(this.txtTeiler);
			this.Controls.Add(this.btnBerechnen);
			this.Controls.Add(this.txtAnfangswert);
			this.Name = "CTeilbar";
			this.Text = "Teiler";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label lblEndwert;
		internal System.Windows.Forms.TextBox txtEndwert;
		internal System.Windows.Forms.Button btnSchliessen;
		internal System.Windows.Forms.Label lblTeiler;
		internal System.Windows.Forms.Label lblAnfangswert;
		internal System.Windows.Forms.TextBox txtTeiler;
		internal System.Windows.Forms.Button btnBerechnen;
		internal System.Windows.Forms.TextBox txtAnfangswert;
		internal System.Windows.Forms.Label lblResultat;
		internal System.Windows.Forms.Label lblTeilerListe;
		internal System.Windows.Forms.Label lblAnzahl;
		internal System.Windows.Forms.TextBox txtAnzahl;
	}
}

