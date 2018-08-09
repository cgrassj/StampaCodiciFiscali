namespace StampaCodiciFiscali
{
	partial class FormMain
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonAggiungiCodiceFiscale = new System.Windows.Forms.Button();
			this.labelTitolo = new System.Windows.Forms.Label();
			this.panelSeparatore = new System.Windows.Forms.Panel();
			this.panelLaterale = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.listCodiciFiscali = new System.Windows.Forms.ListView();
			this.textBoxCodiceFiscale = new System.Windows.Forms.MaskedTextBox();
			this.buttonStampa = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panelLaterale.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonAggiungiCodiceFiscale
			// 
			this.buttonAggiungiCodiceFiscale.BackColor = System.Drawing.Color.White;
			this.buttonAggiungiCodiceFiscale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAggiungiCodiceFiscale.Font = new System.Drawing.Font("Arial", 8F);
			this.buttonAggiungiCodiceFiscale.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonAggiungiCodiceFiscale.Location = new System.Drawing.Point(281, 32);
			this.buttonAggiungiCodiceFiscale.Name = "buttonAggiungiCodiceFiscale";
			this.buttonAggiungiCodiceFiscale.Size = new System.Drawing.Size(20, 20);
			this.buttonAggiungiCodiceFiscale.TabIndex = 1;
			this.buttonAggiungiCodiceFiscale.Text = "+";
			this.buttonAggiungiCodiceFiscale.UseVisualStyleBackColor = false;
			this.buttonAggiungiCodiceFiscale.Click += new System.EventHandler(this.buttonAggiungiCodiceFiscale_Click);
			// 
			// labelTitolo
			// 
			this.labelTitolo.BackColor = System.Drawing.Color.White;
			this.labelTitolo.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTitolo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.labelTitolo.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.labelTitolo.Location = new System.Drawing.Point(0, 0);
			this.labelTitolo.Margin = new System.Windows.Forms.Padding(0);
			this.labelTitolo.Name = "labelTitolo";
			this.labelTitolo.Size = new System.Drawing.Size(310, 19);
			this.labelTitolo.TabIndex = 113;
			this.labelTitolo.Text = "STAMPA ETICHETTE";
			this.labelTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelSeparatore
			// 
			this.panelSeparatore.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.panelSeparatore.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSeparatore.Location = new System.Drawing.Point(0, 19);
			this.panelSeparatore.Name = "panelSeparatore";
			this.panelSeparatore.Size = new System.Drawing.Size(310, 2);
			this.panelSeparatore.TabIndex = 141;
			// 
			// panelLaterale
			// 
			this.panelLaterale.BackColor = System.Drawing.Color.White;
			this.panelLaterale.Controls.Add(this.label11);
			this.panelLaterale.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLaterale.Location = new System.Drawing.Point(0, 21);
			this.panelLaterale.Name = "panelLaterale";
			this.panelLaterale.Size = new System.Drawing.Size(146, 63);
			this.panelLaterale.TabIndex = 142;
			// 
			// label11
			// 
			this.label11.Dock = System.Windows.Forms.DockStyle.Top;
			this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label11.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.label11.Location = new System.Drawing.Point(0, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(146, 39);
			this.label11.TabIndex = 135;
			this.label11.Text = "CODICE FISCALE";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// listCodiciFiscali
			// 
			this.listCodiciFiscali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listCodiciFiscali.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.listCodiciFiscali.Location = new System.Drawing.Point(0, 84);
			this.listCodiciFiscali.Name = "listCodiciFiscali";
			this.listCodiciFiscali.Size = new System.Drawing.Size(310, 254);
			this.listCodiciFiscali.TabIndex = 143;
			this.listCodiciFiscali.UseCompatibleStateImageBehavior = false;
			this.listCodiciFiscali.View = System.Windows.Forms.View.List;
			// 
			// textBoxCodiceFiscale
			// 
			this.textBoxCodiceFiscale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxCodiceFiscale.Location = new System.Drawing.Point(155, 32);
			this.textBoxCodiceFiscale.Mask = ">LLLLLL99L99LAAAA";
			this.textBoxCodiceFiscale.Name = "textBoxCodiceFiscale";
			this.textBoxCodiceFiscale.Size = new System.Drawing.Size(122, 20);
			this.textBoxCodiceFiscale.TabIndex = 144;
			this.textBoxCodiceFiscale.Click += new System.EventHandler(this.textBoxCodiceFiscale_Click);
			// 
			// buttonStampa
			// 
			this.buttonStampa.BackColor = System.Drawing.Color.White;
			this.buttonStampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStampa.Font = new System.Drawing.Font("Arial", 7F);
			this.buttonStampa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonStampa.Location = new System.Drawing.Point(234, 58);
			this.buttonStampa.Name = "buttonStampa";
			this.buttonStampa.Size = new System.Drawing.Size(67, 21);
			this.buttonStampa.TabIndex = 145;
			this.buttonStampa.Text = "STAMPA";
			this.buttonStampa.UseVisualStyleBackColor = false;
			this.buttonStampa.Click += new System.EventHandler(this.buttonStampa_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8F);
			this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button1.Location = new System.Drawing.Point(155, 58);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(73, 21);
			this.button1.TabIndex = 146;
			this.button1.Text = "SVUOTA";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(310, 338);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonStampa);
			this.Controls.Add(this.textBoxCodiceFiscale);
			this.Controls.Add(this.panelLaterale);
			this.Controls.Add(this.panelSeparatore);
			this.Controls.Add(this.labelTitolo);
			this.Controls.Add(this.buttonAggiungiCodiceFiscale);
			this.Controls.Add(this.listCodiciFiscali);
			this.Name = "FormMain";
			this.Text = "Stampa codici fiscali";
			this.panelLaterale.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonAggiungiCodiceFiscale;
		protected System.Windows.Forms.Label labelTitolo;
		private System.Windows.Forms.Panel panelSeparatore;
		private System.Windows.Forms.Panel panelLaterale;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ListView listCodiciFiscali;
		private System.Windows.Forms.MaskedTextBox textBoxCodiceFiscale;
		private System.Windows.Forms.Button buttonStampa;
		private System.Windows.Forms.Button button1;
	}
}

