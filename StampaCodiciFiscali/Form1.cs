using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;

namespace StampaCodiciFiscali
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		
		private void buttonAggiungiCodiceFiscale_Click(object sender, EventArgs e)
		{
			if(codiciFiscali.Count > 15)
				MessageBox.Show(this, "Pagina completa, procedere con la stampa", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Error);

			if (CheckCarattereControllo(textBoxCodiceFiscale.Text))
			{
				if(!CheckPresenzaCodiceFiscale(textBoxCodiceFiscale.Text))
					listCodiciFiscali.Items.Add(textBoxCodiceFiscale.Text);
				else
					MessageBox.Show(this, "Codice fiscale già presente nella lista", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Error);

				textBoxCodiceFiscale.Text = string.Empty;
			}
			else
				MessageBox.Show(this, "Codice di controllo non valido", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private List<string> codiciFiscali
		{
			get
			{
				var list = new List<string>();
				foreach (ListViewItem cf in listCodiciFiscali.Items) { list.Add(cf.Text); }
				return list;
			}
		}

		public bool CheckPresenzaCodiceFiscale(string CodiceFiscale)
		{
			foreach (var cf in codiciFiscali)
			{
				if (cf == CodiceFiscale)
					return true;
			}
			return false;
		}
		
		public bool CheckCarattereControllo(string CodiceFiscale)
		{
			const string listaControllo = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			int[] listaPari = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
			int[] listaDispari = { 1, 0, 5, 7, 9, 13, 15, 17, 19, 21, 2, 4, 18, 20, 11, 3, 6, 8, 12, 14, 16, 10, 22, 25, 24, 23 };

			CodiceFiscale = CodiceFiscale.ToUpper();
			var somma = 0;
			var cCodice = CodiceFiscale.ToCharArray();

			for (var i = 0; i < 15; i++)
			{
				var c = cCodice[i];
				var x = "0123456789".IndexOf(c);

				if (x != -1)
					c = listaControllo.Substring(x, 1).ToCharArray()[0];

				x = listaControllo.IndexOf(c);
				x = (i % 2) == 0 ? listaDispari[x] : listaPari[x];
				somma += x;
			}

			return (listaControllo.Substring(somma % 26, 1) == CodiceFiscale.Substring(15, 1));
		}

		private void textBoxCodiceFiscale_Click(object sender, EventArgs e) => textBoxCodiceFiscale.SelectAll();

		private void buttonStampa_Click(object sender, EventArgs e)
		{
			FindAndKillProcess("Acrobat");
			FindAndKillProcess("AcroRd32");
			PdfReader pdfReader = new PdfReader(@"vuota.pdf");
			using (PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(@"barcode.pdf", FileMode.Create)))
			{
				PdfContentByte cb = pdfStamper.GetUnderContent(1);
				foreach (var cf in codiciFiscali)
					cb.AddImage(creaCodiceBarre(cb, cf, codiciFiscali.IndexOf(cf)));

				pdfStamper.Close();
			}

			Process.Start(@"barcode.pdf");
		}
		public bool FindAndKillProcess(string name)
		{
			foreach (Process clsProcess in Process.GetProcesses())
			{
				if (clsProcess.ProcessName.StartsWith(name))
				{
					clsProcess.Kill();
					return true;
				}
			}
			return false;
		}
		iTextSharp.text.Image creaCodiceBarre(PdfContentByte cb, string cf, int n)
		{
			var code39ext = new Barcode39();

			code39ext.Code = cf;
			code39ext.Font = BaseFont.CreateFont("Courier-Bold", "winansi", false);
			code39ext.StartStopText = false;
			code39ext.Extended = false;
			code39ext.BarHeight = 26f;
			code39ext.Size = 12f;
			code39ext.N = 3.2f;
			code39ext.Baseline = 12f;
			code39ext.X =0.83f;
			iTextSharp.text.Image imageCode39 = code39ext.CreateImageWithBarcode(cb, null, null);
			var delta = 52 * (n - n % 2);
			imageCode39.SetAbsolutePosition((n % 2 == 0) ? 20 : 315, 762-delta);
			return imageCode39;
		}

		private void button1_Click(object sender, EventArgs e) => listCodiciFiscali.Items.Clear();
	}
}
