using System.Text.RegularExpressions;

namespace CyberSecurity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comAlgoType.DataSource = Enum.GetValues(typeof(AlgorithemTypes));
            comCipherType.DataSource = Enum.GetValues(typeof(CipherType));

            msgErrorAlgo.Text = "* This Faild Is Required";
            msgErrorKey.Text = "* This Faild Is Required";
            msgErrorText.Text = "* This Faild Is Required";
            msgErrorCipherType.Text = "* This Faild Is Required";
            msgErrorQueryType.Text = "* This Faild Is Required";
        }

        private void radioPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPassword.Checked)
            {
                panalEncrypt.Visible = false;
                panelPassword.Visible = true;
                searchPanal.Visible = false;
            }
        }

        private void btnCheckPassword_Click(object sender, EventArgs e)
        {
            String password = txtPassword.Text;
            String stringLevel = "w";
            if (password.Length == 0)
            {
                txtError.Visible = true;
                return;
            }

            PasswordStrength PassStrOperation = new PasswordStrength();
            PasswordInformation passInfo = PassStrOperation.CharacterRange(password);

            int bit = PassStrOperation.CalcEntropy(password.Length, passInfo.TotalRange);
            var level = PassStrOperation.PasswordLevel(bit);

            switch (level)
            {
                case StringLevel.Weak:
                    stringLevel = "weak";
                    labPassword.ForeColor = Color.Red;
                    labEntropy.ForeColor = Color.Red;
                    labSize.ForeColor = Color.Red;
                    labStrength.ForeColor = Color.Red;


                    break;
                case StringLevel.Moderate:
                    stringLevel = "Moderate";
                    labPassword.ForeColor = Color.Yellow;
                    labEntropy.ForeColor = Color.Yellow;
                    labSize.ForeColor = Color.Yellow;
                    labStrength.ForeColor = Color.Yellow;


                    break;
                case StringLevel.Strong:
                    stringLevel = "Strong";
                    labPassword.ForeColor = Color.GreenYellow;
                    labEntropy.ForeColor = Color.GreenYellow;
                    labSize.ForeColor = Color.GreenYellow;
                    labStrength.ForeColor = Color.GreenYellow;


                    break;
                default:
                    stringLevel = "VeryStrong";
                    labPassword.ForeColor = Color.Green;
                    labEntropy.ForeColor = Color.Green;
                    labSize.ForeColor = Color.Green;
                    labStrength.ForeColor = Color.Green;
                    break;
            }

            // set password analysis information 
            labPassword.Text = password;
            labEntropy.Text = bit.ToString();
            labSize.Text = password.Length.ToString();
            labStrength.Text = stringLevel;
            labMsg.Text = $"Hacker Need To Try {Math.Pow(2, bit)} \nTimes  Crack Your Password";

        }


        private void panelPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtError.Visible = false;
        }

        private void labStrength_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comCipherType.SelectedIndex != -1)
            {
                string selectItem = comCipherType.SelectedItem.ToString();
                btnCrypto.Text = selectItem;
            }

        }

        private void btnCrypto_Click(object sender, EventArgs e)
        {
            // check about the alogrithm type
            if (comAlgoType.SelectedIndex == -1)
            {
                msgErrorAlgo.Visible = true;
                return;
            }

            // check about text is empty or no 
            if (txtChipherText.Text == "")
            {
                msgErrorText.Visible = true;
                return;
            }

            // check about the cipher type(Decrypt/ Encrypt)
            if (comCipherType.SelectedIndex == -1)
            {
                msgErrorCipherType.Visible = true;
                return;
            }



            string algoType = comAlgoType.SelectedItem.ToString();
            bool cipherType = comCipherType.SelectedItem.ToString() == "Encrypt";
            string text = txtChipherText.Text;
            string res = "";


            AlgorithemTypes selectedAlgo = (AlgorithemTypes)Enum.Parse(typeof(AlgorithemTypes), algoType);

            switch (selectedAlgo)
            {
                case AlgorithemTypes.CaesarCipher:
                    // check about Key is empty or no
                    if (txtKey.Text == "")
                    {
                        msgErrorKey.Visible = true;
                        return;
                    }
                    int key = int.Parse(txtKey.Text.ToString());
                    res = cipherType ? Algorithms.Caesar(key).Encrypt(text) : Algorithms.Caesar(key).Decrypt(text);
                    break;

                case AlgorithemTypes.MonoAlphabetic:
                    string monoKey = txtMonoKey.Text.ToString();
                    if (monoKey.Length != 26)
                        msgErrorMono.Text = "* This Fild Must Be 26 Character";

                    monoKey = monoKey.ToUpper();

                    int[] frq = new int[128];
                    foreach (char ch in monoKey)
                    {
                        if (ch < 'A' || ch > 'Z')
                        {
                            msgErrorMono.Text = "* Only letters A-Z are allowed";
                            break;
                        }


                        frq[ch]++;
                        if (frq[ch] > 1)
                        {
                            msgErrorMono.Text = "* Duplicates are not allowed";
                            break;
                        }
                    }
                    if (msgErrorMono.Text.Length > 0)
                    {
                        msgErrorMono.Visible = true;
                        return;
                    }
                    res = cipherType ? Algorithms.Mono(monoKey).Encrypt(text) : Algorithms.Mono(monoKey).Decrypt(text);
                    break;

                case AlgorithemTypes.Vigenère:
                    monoKey = txtMonoKey.Text.ToString();
                    if (monoKey.Length == 0)
                    {
                        msgErrorMono.Text = "* This Fild Is Required";
                        msgErrorMono.Visible = true;
                        return;
                    }
                    res = cipherType ? Algorithms.Vigenère(monoKey).Encrypt(text) : Algorithms.Vigenère(monoKey).Decrypt(text);
                    break;

                case AlgorithemTypes.Beaufort:
                    monoKey = txtMonoKey.Text.ToString();
                    if (monoKey.Length == 0)
                    {
                        msgErrorMono.Text = "* This Fild Is Required";
                        msgErrorMono.Visible = true;
                        return;
                    }
                    res = Algorithms.Beaufort(monoKey).Operation(text);
                    break;

                case AlgorithemTypes.PlayFair:
                    monoKey = txtMonoKey.Text.ToString();
                    if (monoKey.Length == 0)
                    {
                        msgErrorMono.Text = "* This Fild Is Required";
                        msgErrorMono.Visible = true;
                        return;
                    }
                    res = cipherType ? Algorithms.Play(monoKey).Encrypt(text) : Algorithms.Play(monoKey).Decrypt(text);
                    break;

                case AlgorithemTypes.HillCipher:

                    if (txtAvalue.Text.Length == 0)
                    {
                        msgErrorAValue.Text = "* This Fild Is Required";
                        msgErrorAValue.Visible = true;
                        return;
                    }

                    if (txtBvalue.Text.Length == 0)
                    {
                        msgErrorBValue.Text = "* This Fild Is Required";
                        msgErrorBValue.Visible = true;
                        return;
                    }


                    if (txtCvalue.Text.Length == 0)
                    {
                        msgErrorCvalue.Text = "* This Fild Is Required";
                        msgErrorCvalue.Visible = true;
                        return;
                    }

                    if (txtDvalue.Text.Length == 0)
                    {
                        msgErrorDvalue.Text = "* This Fild Is Required";
                        msgErrorDvalue.Visible = true;
                        return;
                    }

                    int a = int.Parse(txtAvalue.Text);
                    int b = int.Parse(txtBvalue.Text);
                    int c = int.Parse(txtCvalue.Text);
                    int d = int.Parse(txtDvalue.Text);


                    List<int> matrix = [a, b, c, d];
                    int[,] hK = { { a, b }, { c, d } };
                    res = cipherType ? Algorithms.Hill(hK).Encrypt(text) : Algorithms.Hill(hK).Decrypt(text, text.Length);

                    break;

                case AlgorithemTypes.AffineCipher:

                    if (txtAvalue.Text.Length == 0)
                    {
                        msgErrorAValue.Text = "* This Fild Is Required";
                        msgErrorAValue.Visible = true;
                        return;
                    }

                    if (txtBvalue.Text.Length == 0)
                    {
                        msgErrorBValue.Text = "* This Fild Is Required";
                        msgErrorBValue.Visible = true;
                        return;
                    }

                    int aV = int.Parse(txtAvalue.Text.ToString());
                    int bV = int.Parse(txtBvalue.Text.ToString());

                    res = cipherType ? Algorithms.Affine(aV, bV).Encrypt(text) : Algorithms.Affine(aV, bV).Decrypt(text);
                    break;

                case AlgorithemTypes.AutoKey:
                    monoKey = txtMonoKey.Text.ToString();
                    if (monoKey.Length == 0)
                    {
                        msgErrorMono.Text = "* This Fild Is Required";
                        msgErrorMono.Visible = true;
                        return;
                    }
                    res = cipherType ? Algorithms.AutoKey(monoKey).Encrypt(text) : Algorithms.AutoKey(monoKey).Decrypt(text);
                    break;
            }
            txtConvertedType.Text = cipherType ? "Cipher Text" : "Plaintext";
            txtConvertedText.Text = res;
        }

        private void comAlgoType_Click(object sender, EventArgs e)
        {
            msgErrorAlgo.Visible = false;
        }

        private void comCipherType_Click(object sender, EventArgs e)
        {
            msgErrorCipherType.Visible = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            msgErrorText.Visible = false;
        }

        private void panalEncrypt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtChipherText_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtChipherText_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnChangeKey_Click(object sender, EventArgs e)
        {

            txtMonoKey.Enabled = true;
            msgErrorMono.ForeColor = Color.Red;
            string? key = txtMonoKey.Text.ToString();
        }

        private void txtKey_Click(object sender, EventArgs e)
        {
            msgErrorKey.Visible = false;
        }

        private void btnChangeKey_MouseHover(object sender, EventArgs e)
        {
            btnChangeKey.ForeColor = Color.Beige;
        }

        private void btnChangeKey_MouseLeave(object sender, EventArgs e)
        {
            btnChangeKey.ForeColor = Color.Green;
        }

        private void comAlgoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comAlgoType.SelectedValue.ToString() == "MonoAlphabetic" ||
                comAlgoType.SelectedValue.ToString() == "Vigenère" ||
                comAlgoType.SelectedValue.ToString() == "Beaufort" ||
                comAlgoType.SelectedValue.ToString() == "AutoKey" ||
                comAlgoType.SelectedValue.ToString() == "PlayFair")
            {
                txtMonoKey.Visible = true;
                btnChangeKey.Visible = true;
                txtKey.Enabled = false;
            }
            else
            {
                txtMonoKey.Visible = false;
                btnChangeKey.Visible = false;
                txtKey.Enabled = true;
            }

            if (comAlgoType.SelectedValue.ToString() == "AffineCipher")
            {
                txtAvalue.Visible = true;
                txtBvalue.Visible = true;
            }
            else
            {
                txtAvalue.Visible = false;
                txtBvalue.Visible = false;
            }

            if (comAlgoType.SelectedValue.ToString() == "HillCipher")
            {
                txtAvalue.Visible = true;
                txtBvalue.Visible = true;
                txtCvalue.Visible = true;
                txtDvalue.Visible = true;
            }
            else
            {
                txtAvalue.Visible = false;
                txtBvalue.Visible = false;
                txtCvalue.Visible = false;
                txtDvalue.Visible = false;
            }

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MonoAlphabetic monoOperation = new MonoAlphabetic(txtMonoKey.Text);
            txtConvertedText.Text = monoOperation.Decrypt(txtChipherText.Text.ToString());

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            // DataTabel = sql.Select(query); 
            string query = txtSearcyQuery.Text.ToString().Length > 0 ? txtSearcyQuery.Text.ToString() : "";
            string column = "";

            try
            {
                column = comSearchType.SelectedItem.ToString();
            }
            catch
            {
                msgErrorQueryType.Visible = true;
                return;
            }

            SQLConnection sql = new SQLConnection();
            
             bool validClo =  Regex.IsMatch(column, @"^[a-zA-Z0-9\s]+$");
             bool validQur =  Regex.IsMatch(column, @"^[a-zA-Z0-9\s]+$");

            if(!validClo || !validQur)
            {
                MessageBox.Show("SQL Injection Detection"); 
                return;
            }
        


        dtGrid.DataSource = sql.Select($"SELECT * FROM proudact WHERE {column} Like '%{query}%'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchPanal.Visible = true;
            addPanal.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addPanal.Visible = true;
            searchPanal.Visible = false;
        }

        private void searchPanal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Length == 0)
            {
                msgErrorProductName.Visible = true;
                return;
            }

            if (txtProdactPrice.Text.Length == 0)
            {
                msgErrorProductPrice.Visible = true;
                return;

            }
            if (comCategory.SelectedIndex == -1)
            {
                msgErrorProductCatg.Visible = true;
                return;
            }

            int proPrice = int.Parse(txtProdactPrice.Text.ToString());
            string proName = txtProductName.Text;
            string proCatg = comCategory.SelectedItem.ToString().Trim();
            string query = $"INSERT INTO proudact(Name, Category, Price) VALUES ('{proName}','{proCatg}','{proPrice}')";

            SQLConnection sQ = new SQLConnection();
            int? nM = sQ.Execute(query);
            if (nM != null)
                MessageBox.Show("Item was add success");

            txtProductName.Text = "";
            txtProdactPrice.Text = "";
            comCategory.SelectedIndex = -1;

        }

        private void txtProductId_Enter(object sender, EventArgs e)
        {
            msgErrorProductCatg.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            searchPanal.Visible = false;
            addPanal.Visible = true;
        }

        private void txtSearcyQuery_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProdactPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProductName_Click(object sender, EventArgs e)
        {
            msgErrorProductName.Visible = false;
        }

        private void txtProdactPrice_Click(object sender, EventArgs e)
        {
            msgErrorProductPrice.Visible = false;

        }

        private void comCategory_Click(object sender, EventArgs e)
        {
            msgErrorProductCatg.Visible = false;

        }

        private void txtAvalue_Click(object sender, EventArgs e)
        {
            msgErrorAValue.Visible = false;
        }

        private void txtBvalue_Click(object sender, EventArgs e)
        {
            msgErrorBValue.Visible = false;
        }

        private void txtCvalue_Click(object sender, EventArgs e)
        {
            msgErrorCvalue.Visible = false;
        }

        private void txtDvalue_Click(object sender, EventArgs e)
        {
            msgErrorDvalue.Visible = false;
        }

        private void radioEncrypto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEncrypto.Checked)
            {
                panalEncrypt.Visible = true;
                panelPassword.Visible = false;
                searchPanal.Visible = false;
            }
        }

        private void radioSQL_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSQL.Checked)
            {
                panalEncrypt.Visible = false;
                panelPassword.Visible = false;
                searchPanal.Visible = true;
            }
        }

        private void txtMonoKey_Click(object sender, EventArgs e)
        {
            msgErrorMono.Visible = false;
        }
    }
}
