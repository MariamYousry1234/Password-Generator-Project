using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enPassword {
            Uppercase,
            lowercase,
            Numbers,
            Symbols,
            None
        }

        List<enPassword> PasswordUserCharacters = new List<enPassword>();
        Random RandomNumber = new Random();

        void AddToList()
        {
            PasswordUserCharacters.Clear();

            if (Convert.ToBoolean(chkUpperCase.Tag)) PasswordUserCharacters.Add(enPassword.Uppercase);
            if (Convert.ToBoolean(chkLowerCase.Tag)) PasswordUserCharacters.Add(enPassword.lowercase);
            if (Convert.ToBoolean(chkNumbers.Tag)) PasswordUserCharacters.Add(enPassword.Numbers);
            if (Convert.ToBoolean(chkSymbols.Tag))PasswordUserCharacters.Add(enPassword.Symbols);
        }

        void UserCharacters()
        {
            chkUpperCase.Tag = chkUpperCase.Checked;
            chkLowerCase.Tag = chkLowerCase.Checked;
            chkNumbers.Tag = chkNumbers.Checked;
            chkSymbols.Tag = chkSymbols.Checked;
            AddToList();
        }

        enPassword RandomChar()
        {
            if(PasswordUserCharacters.Count >0)
                return PasswordUserCharacters.ElementAt(RandomNumber.Next(0, PasswordUserCharacters.Count));

            return enPassword.None;
        }


        char GenerateRandomChar()
        {
            enPassword RnChar = RandomChar();

            switch(RnChar)
            {
              case enPassword.Uppercase:
                  return (char)RandomNumber.Next(65, 91);

              case enPassword.lowercase:
                    return (char)RandomNumber.Next(97, 123);

              case enPassword.Numbers:
                   return (char)RandomNumber.Next(48, 58);

              case enPassword.Symbols:
                    return (char)RandomNumber.Next(33, 48);

              default:
                   return ' ';
            }
      
        }

        string GeneratePassword(int PasswordLength)
        {
            string sPassWord ="";

            for (int i = 0; i < PasswordLength; i++) 
            {
                sPassWord += GenerateRandomChar();
            }

            return sPassWord;
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtLength_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtLength.Text))
            {
                MessageBox.Show("Please Enter Your Password Length");
                txtLength.Focus();
            }
        }

        bool IsLengthValidate()
        {
            int Length = Convert.ToInt32(txtLength.Text);
            return Length > 0 && Length <= 30;
        }
        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            if (!IsLengthValidate())
            {
                MessageBox.Show("Enter a Number between 1 and 30");
                txtLength.Focus();
                return;
            }
            UserCharacters();
            txtPassword.Text= GeneratePassword(Convert.ToInt32(txtLength.Text));
        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPassword.Text);
        }

      
    }
}
