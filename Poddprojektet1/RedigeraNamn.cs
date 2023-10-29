using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Controllers;
using BusinessLogicLayer;
using DataAccessLayer.Repositories;
using Models;
using DataAccessLayer;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using static System.Resources.ResXFileRef;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Poddprojektet1
{
    public partial class RedigeraNamn : Form
    {
        public RedigeraNamn()
        {
            InitializeComponent();
        }

        private void RedigeraNamn_Load(object sender, EventArgs e)
        {
            LaddaKategorier();
        }

        private void LaddaKategorier()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(CategoryList));
                CategoryList categories;

                using (FileStream file = new FileStream("path_till_din_xml_fil.xml", FileMode.Open))
                {
                    categories = (CategoryList)serializer.Deserialize(file);
                }

                // Lägg till kategorierna i dropdown-listan (ComboBox)
                comboBox1.Items.Clear();
                foreach (var category in categories.Categories)
                {
                    comboBox1.Items.Add(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fel vid inläsning av kategorier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void KategoriVald(object sender, EventArgs e)
        {
            // TODO: När en kategori är vald, hämta det nuvarande namnet på podcasten.
        }

        private void btnBekraftaAndringar_Click(object sender, EventArgs e)
        {
            // TODO: Spara det nya namnet och uppdatera det i din datakälla.
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            // Stänger formuläret utan att göra några ändringar.
            this.Close();
        }

    }
}
