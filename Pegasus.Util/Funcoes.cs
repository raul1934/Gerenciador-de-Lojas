
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;

namespace Pegasus.Util
{   

   public static class Funcoes
    {

        public static string formatarParaMoeda(string text)
        {
            var culture = new CultureInfo("pt-br");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            return  Convert.ToDouble(parse(text).ToString()).ToString("C");
        }

        public static void ApenasNumeros_KeyPress(Form f,Object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Control && ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9)))
            {
                e.Handled = true;
                //MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyCode == Keys.Oemcomma) && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                //MessageBox.Show("este campo aceita somente uma virgula");
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                f.ActiveControl = null;
                
            }
        }

        public static void ApenasNumeros_Enter(Object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = txt.Text.Replace("%", "").Replace("R", "").Replace("$","").Trim();
        }

        public static void Porcentagem_Leave(Object sender, EventArgs e)
        {
            var culture = new CultureInfo("pt-br");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            ((TextBox)sender).Text = (Decimal.Parse(((TextBox)sender).Text) / 100).ToString("P");
        }

        public static void Moeda_Leave(Object sender, EventArgs e)
        {
            var culture = new CultureInfo("pt-br");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            ((TextBox)sender).Text = Convert.ToDouble(parse(((TextBox)sender).Text).ToString()).ToString("C");
        }

        public static void ApenasNumeros(Object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
        }

        public static decimal parse(string s)
        {
            String x = "";
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if ((s[i] >= '0' &&
                    s[i] <= '9') ||
                    s[i] == ',')
                {
                    x += s[i];

                }
            }
            return Decimal.Parse(x);
        }

        public static string apenasNumeros(string s)
        {
            String x = "";
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if ((s[i] >= '0' &&
                    s[i] <= '9'))
                {
                    x += s[i];
                    
                }
            }
            return x;
        }

        public static string formatarParaPorcentagem(string text)
        {
            var culture = new CultureInfo("pt-br");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            return  (Decimal.Parse(text) / 100).ToString("P");
        }

        

        public static DateTime HoraZero(DateTime datetime)
        {
            return new DateTime(datetime.Year, datetime.Month, datetime.Day, 0, 0, 0);
        }

        public static DateTime HoraMaxima(DateTime datetime)
        {
            return new DateTime(datetime.Year, datetime.Month, datetime.Day, 23, 59, 59);
        }

        public static byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

    }
}
