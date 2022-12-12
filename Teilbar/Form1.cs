using System;
using System.Windows.Forms;

namespace Teilbar
{
	public partial class CTeilbar : Form
	{
		public CTeilbar()
		{
			InitializeComponent();
		}

		bool PrüfeWert(string sEingabe, string sLabel, out int intWert)
		{
			if (int.TryParse(sEingabe, out intWert) == true)
			{
				return true;
			}
			else
			{
				MessageBox.Show($"Ungültiger Wert '{sEingabe}'", $"Eingabefehler: {sLabel}");
				return false;
			}
		}
		bool TeilerPositiv(int intTeiler)
		{
			if (intTeiler > 0)
			{
				return true;
			}
			else
			{
				MessageBox.Show($"Nur positive Teilerwerte (>0) sind gültig: '{intTeiler}'", "Eingabefehler");
				return false;
			}
		}
		bool UeberprüfeAnfangsEndwert(int intAnfangswert, int intEndwert)
		{
			if (intAnfangswert < intEndwert)
			{
				return true;
			}
			else
			{
				MessageBox.Show($"Der Anfangswert '{intAnfangswert}' muss kleiner als der Endwert '{intEndwert}' sein!", "Eingabefehler");
				return false;
			}
		}
		private int SucheErstenTeiler(int intAnfangswert, int intTeiler)
		{
			while ((intAnfangswert % intTeiler) != 0)
			{
				intAnfangswert += 1;
			}
			return intAnfangswert;
		}

		private void btnBerechnen_Click(object sender, EventArgs e)
		{
			//Teiler
			int intTeiler = 0;
			if (PrüfeWert(txtTeiler.Text, lblTeiler.Text, out intTeiler) == false)
			{
				return;
			}
			if(TeilerPositiv(intTeiler) == false)
			{
				return;
			}
			//Anfangswert
			int intAnfangswert = 0;
			if (PrüfeWert(txtAnfangswert.Text, lblAnfangswert.Text, out intAnfangswert) == false)
			{
				return;
			}
			//Endwert
			int intEndwert = 0;
			if (PrüfeWert(txtEndwert.Text, lblEndwert.Text, out intEndwert) == false)
			{
				return;
			}
			//Anfangswert < Endwert
			if (UeberprüfeAnfangsEndwert(intAnfangswert,intEndwert) == false)
			{
				return;
			}
			//Erster Teiler suchen
			intAnfangswert = SucheErstenTeiler(intAnfangswert, intTeiler);
			//Vielfache des Teilers ausgeben
			string sTeilerListe = "";
			int intAnzahl = 0;
			for (int i = intAnfangswert; i <= intEndwert; i += intTeiler)
			{
				sTeilerListe += i.ToString() + "\n";
				intAnzahl++;
			}
			lblTeilerListe.Text = sTeilerListe;
			txtAnzahl.Text = intAnzahl.ToString();
		}

		private void btnSchliessen_Click(object sender, EventArgs e)
		{
			Close();
		}

		public double Test(int intWert, ref int intOutput)
		{
			throw new System.NotImplementedException();
		}
	}
}
