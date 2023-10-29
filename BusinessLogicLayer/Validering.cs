using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace BusinessLogicLayer
{
    public static class Validering
    {

        public static Boolean vardeFinns (TextBox textboxAttValidera)
        {
            Boolean resultat = true;
            if (textboxAttValidera.Text == "")
            {
                MessageBox.Show("Textrutan saknar värde!");
                resultat = false;
                textboxAttValidera.Focus();
            }
            return resultat;
        }

        public static Boolean vardeFinns (ComboBox comboBoxAttValidera, string typ)
        {
            Boolean resultat = true;
            if (comboBoxAttValidera.SelectedIndex < 0)
            {
                MessageBox.Show($"Vänligen välj {typ}!");
                resultat = false;
            }
            return resultat;
        }

        public static Boolean vardeFinns(ListBox listBoxAttValidera, string typ)
        {
            Boolean resultat = true;
            if (listBoxAttValidera.SelectedIndex <= 0)
            {
                MessageBox.Show($"Vänligen välj {typ}!");
                resultat = false;
            }
            return resultat;
        }


        public static Boolean KontrolleraTeckenAntal (int antalTeckenInskrivna, int minTecken, int maxTecken, string typ)
        {
            Boolean resultat = true;
            if (antalTeckenInskrivna < minTecken || antalTeckenInskrivna > maxTecken)
            {
                MessageBox.Show($"Vänligen använd mellan {minTecken} och {maxTecken} tecken i rutan för {typ}!");
                resultat = false;
            }

            return resultat;
        }




    }
}
