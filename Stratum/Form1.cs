using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stratum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Stratum.Enums.AuthenticatorType));
        }

   
        private void buttonGenerateOtp_Click(object sender, EventArgs e)
        {
            var getTimeNotMotp= DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var authenticatorType = (Stratum.Enums.AuthenticatorType)comboBox1.SelectedItem;
            switch(authenticatorType)
            {
                case Enums.AuthenticatorType.Totp:
                    var totp30Secs = new Stratum.Core.Generator.Totp(textBoxSecretKey.Text, 30, Core.Generator.HashAlgorithm.Sha1, 6);
                    textBoxOtp.Text = totp30Secs.Compute(getTimeNotMotp);
                    break;

                case Enums.AuthenticatorType.Hotp:
                    var hotpCounter = new Stratum.Core.Generator.Hotp(textBoxSecretKey.Text, Core.Generator.HashAlgorithm.Sha1, 6);
                    textBoxOtp.Text = hotpCounter.Compute(Convert.ToInt64(numericUpDown1.Value++));
                    numericUpDown1.Text = numericUpDown1.Value.ToString();
                    break;

                    case Enums.AuthenticatorType.SteamOtp:
                    var steam30Secs = new Stratum.Core.Generator.SteamOtp(textBoxSecretKey.Text);
                    textBoxOtp.Text = steam30Secs.Compute(getTimeNotMotp);
                    break;

                case Enums.AuthenticatorType.YandexOtp:
                    var yandex30Secs = new Stratum.Core.Generator.YandexOtp(textBoxSecretKey.Text, "0000");
                    textBoxOtp.Text = yandex30Secs.Compute(getTimeNotMotp);
                    break;

                case Enums.AuthenticatorType.MobileOtp:
                    var motp10Secs = new Stratum.Core.Generator.MobileOtp(textBoxSecretKey.Text, "0000");
                    textBoxOtp.Text = motp10Secs.Compute(getTimeNotMotp);
                    break;
            }    
        }
    }
}
