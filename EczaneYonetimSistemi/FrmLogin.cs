using System;
using System.Windows.Forms;
using EczaneYonetimSistemi.DataAccess;
using EczaneYonetimSistemi.Security;


namespace EczaneYonetimSistemi
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public PersonelDto GirisYapan { get; private set; }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string k = txtKullanici.Text.Trim();
            string s = txtSifre.Text;

            if (string.IsNullOrWhiteSpace(k) || string.IsNullOrWhiteSpace(s))
            {
                MessageBox.Show("Kullanıcı adı ve şifre zorunlu.");
                return;
            }

            string hash = PasswordHasher.Sha256Hex(s);

            var repo = new PersonelRepository();
            var personel = repo.Login(k, hash);

            if (personel == null)
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre.");
                return;
            }

            GirisYapan = personel;
            DialogResult = DialogResult.OK;
            Close();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
