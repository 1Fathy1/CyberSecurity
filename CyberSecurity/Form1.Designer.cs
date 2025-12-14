namespace CyberSecurity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            radioPassword = new RadioButton();
            radioSQL = new RadioButton();
            radioEncrypto = new RadioButton();
            panelPassword = new Panel();
            labStrength = new Label();
            labMsg = new Label();
            txtError = new Label();
            labSize = new Label();
            labEntropy = new Label();
            labPassword = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCheckPassword = new Button();
            txtPassword = new TextBox();
            label9 = new Label();
            panel1 = new Panel();
            btnAdd = new Button();
            button1 = new Button();
            label7 = new Label();
            addPanal = new Panel();
            label14 = new Label();
            label13 = new Label();
            lab13 = new Label();
            comCategory = new ComboBox();
            msgErrorProductPrice = new Label();
            msgErrorProductName = new Label();
            txtProdactPrice = new TextBox();
            msgErrorProductCatg = new Label();
            btnAddProdact = new Button();
            txtProductName = new TextBox();
            label10 = new Label();
            searchPanal = new Panel();
            msgErrorQueryType = new Label();
            btnSearch = new PictureBox();
            comSearchType = new ComboBox();
            txtSearcyQuery = new TextBox();
            dtGrid = new DataGridView();
            label8 = new Label();
            panalEncrypt = new Panel();
            msgErrorCvalue = new Label();
            msgErrorDvalue = new Label();
            txtDvalue = new TextBox();
            txtCvalue = new TextBox();
            msgErrorAValue = new Label();
            msgErrorBValue = new Label();
            txtBvalue = new TextBox();
            txtAvalue = new TextBox();
            txtConvertedType = new Label();
            txtConvertedText = new Label();
            msgErrorMono = new Label();
            btnChangeKey = new Label();
            msgErrorKey = new Label();
            txtMonoKey = new TextBox();
            txtKey = new TextBox();
            msgErrorText = new Label();
            msgErrorCipherType = new Label();
            msgErrorAlgo = new Label();
            comCipherType = new ComboBox();
            comAlgoType = new ComboBox();
            btnCrypto = new Button();
            txtChipherText = new TextBox();
            label6 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelPassword.SuspendLayout();
            panel1.SuspendLayout();
            addPanal.SuspendLayout();
            searchPanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid).BeginInit();
            panalEncrypt.SuspendLayout();
            SuspendLayout();
            // 
            // radioPassword
            // 
            radioPassword.AutoSize = true;
            radioPassword.ForeColor = SystemColors.ButtonHighlight;
            radioPassword.Location = new Point(12, 135);
            radioPassword.Name = "radioPassword";
            radioPassword.Size = new Size(184, 29);
            radioPassword.TabIndex = 0;
            radioPassword.TabStop = true;
            radioPassword.Text = "Password Strength";
            radioPassword.UseVisualStyleBackColor = true;
            radioPassword.CheckedChanged += radioPassword_CheckedChanged;
            // 
            // radioSQL
            // 
            radioSQL.AutoSize = true;
            radioSQL.ForeColor = SystemColors.ButtonHighlight;
            radioSQL.Location = new Point(12, 170);
            radioSQL.Name = "radioSQL";
            radioSQL.Size = new Size(141, 29);
            radioSQL.TabIndex = 1;
            radioSQL.TabStop = true;
            radioSQL.Text = "SQL Injection";
            radioSQL.UseVisualStyleBackColor = true;
            radioSQL.CheckedChanged += radioSQL_CheckedChanged;
            // 
            // radioEncrypto
            // 
            radioEncrypto.AutoSize = true;
            radioEncrypto.ForeColor = SystemColors.ButtonHighlight;
            radioEncrypto.Location = new Point(12, 203);
            radioEncrypto.Name = "radioEncrypto";
            radioEncrypto.Size = new Size(201, 29);
            radioEncrypto.TabIndex = 2;
            radioEncrypto.TabStop = true;
            radioEncrypto.Text = "Encrypted Algorithm";
            radioEncrypto.UseVisualStyleBackColor = true;
            radioEncrypto.CheckedChanged += radioEncrypto_CheckedChanged;
            // 
            // panelPassword
            // 
            panelPassword.Controls.Add(labStrength);
            panelPassword.Controls.Add(labMsg);
            panelPassword.Controls.Add(txtError);
            panelPassword.Controls.Add(labSize);
            panelPassword.Controls.Add(labEntropy);
            panelPassword.Controls.Add(labPassword);
            panelPassword.Controls.Add(label5);
            panelPassword.Controls.Add(label4);
            panelPassword.Controls.Add(label3);
            panelPassword.Controls.Add(label2);
            panelPassword.Controls.Add(label1);
            panelPassword.Controls.Add(btnCheckPassword);
            panelPassword.Controls.Add(txtPassword);
            panelPassword.Controls.Add(label9);
            panelPassword.Location = new Point(0, 0);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(1058, 600);
            panelPassword.TabIndex = 3;
            panelPassword.Visible = false;
            panelPassword.Paint += panelPassword_Paint;
            // 
            // labStrength
            // 
            labStrength.AutoSize = true;
            labStrength.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labStrength.Location = new Point(466, 254);
            labStrength.Name = "labStrength";
            labStrength.Size = new Size(0, 28);
            labStrength.TabIndex = 12;
            labStrength.Click += labStrength_Click;
            // 
            // labMsg
            // 
            labMsg.AutoSize = true;
            labMsg.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labMsg.ForeColor = Color.White;
            labMsg.Location = new Point(291, 307);
            labMsg.Name = "labMsg";
            labMsg.Size = new Size(0, 28);
            labMsg.TabIndex = 11;
            // 
            // txtError
            // 
            txtError.AutoSize = true;
            txtError.ForeColor = Color.Red;
            txtError.Location = new Point(17, 107);
            txtError.Name = "txtError";
            txtError.Size = new Size(190, 25);
            txtError.TabIndex = 10;
            txtError.Text = "* This Faild Is Required";
            txtError.Visible = false;
            // 
            // labSize
            // 
            labSize.AutoSize = true;
            labSize.Font = new Font("Segoe UI", 10F);
            labSize.Location = new Point(466, 154);
            labSize.Name = "labSize";
            labSize.Size = new Size(0, 28);
            labSize.TabIndex = 9;
            // 
            // labEntropy
            // 
            labEntropy.AutoSize = true;
            labEntropy.Font = new Font("Segoe UI", 10F);
            labEntropy.Location = new Point(466, 204);
            labEntropy.Name = "labEntropy";
            labEntropy.Size = new Size(0, 28);
            labEntropy.TabIndex = 8;
            // 
            // labPassword
            // 
            labPassword.AutoSize = true;
            labPassword.Font = new Font("Segoe UI", 10F);
            labPassword.Location = new Point(466, 104);
            labPassword.Name = "labPassword";
            labPassword.Size = new Size(0, 28);
            labPassword.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(291, 254);
            label5.Name = "label5";
            label5.Size = new Size(101, 28);
            label5.TabIndex = 6;
            label5.Text = "Strength :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(291, 154);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 5;
            label4.Text = "Length : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(291, 202);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 4;
            label3.Text = "Bit of entropy : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(291, 104);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 3;
            label2.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 61);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 2;
            label1.Text = "- Password Analysis";
            // 
            // btnCheckPassword
            // 
            btnCheckPassword.BackColor = Color.Green;
            btnCheckPassword.ForeColor = SystemColors.ButtonHighlight;
            btnCheckPassword.Location = new Point(17, 172);
            btnCheckPassword.Name = "btnCheckPassword";
            btnCheckPassword.Size = new Size(112, 34);
            btnCheckPassword.TabIndex = 1;
            btnCheckPassword.Text = "Check";
            btnCheckPassword.UseVisualStyleBackColor = false;
            btnCheckPassword.Click += btnCheckPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(17, 135);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter Your Password";
            txtPassword.Size = new Size(222, 31);
            txtPassword.TabIndex = 0;
            txtPassword.Click += txtPassword_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(419, 13);
            label9.Name = "label9";
            label9.Size = new Size(217, 32);
            label9.TabIndex = 13;
            label9.Text = "Password Strengh";
            // 
            // panel1
            // 
            panel1.Controls.Add(panelPassword);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(addPanal);
            panel1.Controls.Add(searchPanal);
            panel1.Location = new Point(239, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 600);
            panel1.TabIndex = 22;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(69, 299);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 47);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button1
            // 
            button1.Location = new Point(69, 199);
            button1.Name = "button1";
            button1.Size = new Size(137, 47);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(465, 10);
            label7.Name = "label7";
            label7.Size = new Size(165, 32);
            label7.TabIndex = 5;
            label7.Text = "SQL Injection";
            // 
            // addPanal
            // 
            addPanal.Controls.Add(label14);
            addPanal.Controls.Add(label13);
            addPanal.Controls.Add(lab13);
            addPanal.Controls.Add(comCategory);
            addPanal.Controls.Add(msgErrorProductPrice);
            addPanal.Controls.Add(msgErrorProductName);
            addPanal.Controls.Add(txtProdactPrice);
            addPanal.Controls.Add(msgErrorProductCatg);
            addPanal.Controls.Add(btnAddProdact);
            addPanal.Controls.Add(txtProductName);
            addPanal.Controls.Add(label10);
            addPanal.Location = new Point(236, 69);
            addPanal.Name = "addPanal";
            addPanal.Size = new Size(763, 447);
            addPanal.TabIndex = 14;
            addPanal.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(17, 249);
            label14.Name = "label14";
            label14.Size = new Size(188, 28);
            label14.TabIndex = 21;
            label14.Text = "Product Category : ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(17, 149);
            label13.Name = "label13";
            label13.Size = new Size(150, 28);
            label13.TabIndex = 20;
            label13.Text = "Product Price : ";
            // 
            // lab13
            // 
            lab13.AutoSize = true;
            lab13.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab13.Location = new Point(17, 52);
            lab13.Name = "lab13";
            lab13.Size = new Size(160, 28);
            lab13.TabIndex = 17;
            lab13.Text = "Product Name : ";
            // 
            // comCategory
            // 
            comCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comCategory.FormattingEnabled = true;
            comCategory.Items.AddRange(new object[] { "Phone", "Lebtop" });
            comCategory.Location = new Point(33, 281);
            comCategory.Name = "comCategory";
            comCategory.Size = new Size(261, 33);
            comCategory.TabIndex = 16;
            comCategory.Click += comCategory_Click;
            // 
            // msgErrorProductPrice
            // 
            msgErrorProductPrice.AutoSize = true;
            msgErrorProductPrice.ForeColor = Color.Red;
            msgErrorProductPrice.Location = new Point(31, 212);
            msgErrorProductPrice.Name = "msgErrorProductPrice";
            msgErrorProductPrice.Size = new Size(190, 25);
            msgErrorProductPrice.TabIndex = 15;
            msgErrorProductPrice.Text = "* This Faild Is Required";
            msgErrorProductPrice.Visible = false;
            // 
            // msgErrorProductName
            // 
            msgErrorProductName.AutoSize = true;
            msgErrorProductName.ForeColor = Color.Red;
            msgErrorProductName.Location = new Point(31, 117);
            msgErrorProductName.Name = "msgErrorProductName";
            msgErrorProductName.Size = new Size(190, 25);
            msgErrorProductName.TabIndex = 13;
            msgErrorProductName.Text = "* This Faild Is Required";
            msgErrorProductName.Visible = false;
            // 
            // txtProdactPrice
            // 
            txtProdactPrice.Location = new Point(33, 182);
            txtProdactPrice.Name = "txtProdactPrice";
            txtProdactPrice.PlaceholderText = "Enter Product Price";
            txtProdactPrice.Size = new Size(261, 31);
            txtProdactPrice.TabIndex = 12;
            txtProdactPrice.Click += txtProdactPrice_Click;
            txtProdactPrice.KeyPress += txtProdactPrice_KeyPress;
            // 
            // msgErrorProductCatg
            // 
            msgErrorProductCatg.AutoSize = true;
            msgErrorProductCatg.ForeColor = Color.Red;
            msgErrorProductCatg.Location = new Point(33, 316);
            msgErrorProductCatg.Name = "msgErrorProductCatg";
            msgErrorProductCatg.Size = new Size(190, 25);
            msgErrorProductCatg.TabIndex = 11;
            msgErrorProductCatg.Text = "* This Faild Is Required";
            msgErrorProductCatg.Visible = false;
            // 
            // btnAddProdact
            // 
            btnAddProdact.Location = new Point(31, 363);
            btnAddProdact.Name = "btnAddProdact";
            btnAddProdact.Size = new Size(263, 34);
            btnAddProdact.TabIndex = 4;
            btnAddProdact.Text = "Add";
            btnAddProdact.UseVisualStyleBackColor = true;
            btnAddProdact.Click += btnDel_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(33, 83);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Enter Product Name";
            txtProductName.Size = new Size(261, 31);
            txtProductName.TabIndex = 3;
            txtProductName.Click += txtProductName_Click;
            txtProductName.Enter += txtProductId_Enter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(238, 20);
            label10.Name = "label10";
            label10.Size = new Size(139, 25);
            label10.TabIndex = 1;
            label10.Text = "Delete Product";
            // 
            // searchPanal
            // 
            searchPanal.Controls.Add(msgErrorQueryType);
            searchPanal.Controls.Add(btnSearch);
            searchPanal.Controls.Add(comSearchType);
            searchPanal.Controls.Add(txtSearcyQuery);
            searchPanal.Controls.Add(dtGrid);
            searchPanal.Controls.Add(label8);
            searchPanal.Location = new Point(236, 69);
            searchPanal.Name = "searchPanal";
            searchPanal.Size = new Size(763, 447);
            searchPanal.TabIndex = 9;
            searchPanal.Visible = false;
            searchPanal.Paint += searchPanal_Paint;
            // 
            // msgErrorQueryType
            // 
            msgErrorQueryType.AutoSize = true;
            msgErrorQueryType.ForeColor = Color.Red;
            msgErrorQueryType.Location = new Point(381, 52);
            msgErrorQueryType.Name = "msgErrorQueryType";
            msgErrorQueryType.Size = new Size(0, 25);
            msgErrorQueryType.TabIndex = 25;
            msgErrorQueryType.Visible = false;
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(558, 84);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(44, 28);
            btnSearch.SizeMode = PictureBoxSizeMode.Zoom;
            btnSearch.TabIndex = 4;
            btnSearch.TabStop = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // comSearchType
            // 
            comSearchType.DropDownStyle = ComboBoxStyle.DropDownList;
            comSearchType.FormattingEnabled = true;
            comSearchType.Items.AddRange(new object[] { "Id", "Name", "Price", "Category" });
            comSearchType.Location = new Point(381, 81);
            comSearchType.Name = "comSearchType";
            comSearchType.Size = new Size(171, 33);
            comSearchType.TabIndex = 3;
            // 
            // txtSearcyQuery
            // 
            txtSearcyQuery.Location = new Point(0, 81);
            txtSearcyQuery.Name = "txtSearcyQuery";
            txtSearcyQuery.PlaceholderText = "Srearch About Product";
            txtSearcyQuery.Size = new Size(375, 31);
            txtSearcyQuery.TabIndex = 2;
            txtSearcyQuery.TextChanged += txtSearcyQuery_TextChanged;
            // 
            // dtGrid
            // 
            dtGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid.Location = new Point(3, 120);
            dtGrid.Name = "dtGrid";
            dtGrid.RowHeadersWidth = 62;
            dtGrid.Size = new Size(750, 317);
            dtGrid.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(238, 6);
            label8.Name = "label8";
            label8.Size = new Size(199, 25);
            label8.TabIndex = 0;
            label8.Text = "Search About Product";
            // 
            // panalEncrypt
            // 
            panalEncrypt.Controls.Add(msgErrorCvalue);
            panalEncrypt.Controls.Add(msgErrorDvalue);
            panalEncrypt.Controls.Add(txtDvalue);
            panalEncrypt.Controls.Add(txtCvalue);
            panalEncrypt.Controls.Add(msgErrorAValue);
            panalEncrypt.Controls.Add(msgErrorBValue);
            panalEncrypt.Controls.Add(txtBvalue);
            panalEncrypt.Controls.Add(txtAvalue);
            panalEncrypt.Controls.Add(txtConvertedType);
            panalEncrypt.Controls.Add(txtConvertedText);
            panalEncrypt.Controls.Add(msgErrorMono);
            panalEncrypt.Controls.Add(btnChangeKey);
            panalEncrypt.Controls.Add(msgErrorKey);
            panalEncrypt.Controls.Add(txtMonoKey);
            panalEncrypt.Controls.Add(txtKey);
            panalEncrypt.Controls.Add(msgErrorText);
            panalEncrypt.Controls.Add(msgErrorCipherType);
            panalEncrypt.Controls.Add(msgErrorAlgo);
            panalEncrypt.Controls.Add(comCipherType);
            panalEncrypt.Controls.Add(comAlgoType);
            panalEncrypt.Controls.Add(btnCrypto);
            panalEncrypt.Controls.Add(txtChipherText);
            panalEncrypt.Controls.Add(label6);
            panalEncrypt.Location = new Point(219, 2);
            panalEncrypt.Name = "panalEncrypt";
            panalEncrypt.Size = new Size(1055, 600);
            panalEncrypt.TabIndex = 13;
            panalEncrypt.Paint += panalEncrypt_Paint;
            // 
            // msgErrorCvalue
            // 
            msgErrorCvalue.AutoSize = true;
            msgErrorCvalue.ForeColor = Color.Red;
            msgErrorCvalue.Location = new Point(618, 317);
            msgErrorCvalue.Name = "msgErrorCvalue";
            msgErrorCvalue.Size = new Size(90, 25);
            msgErrorCvalue.TabIndex = 29;
            msgErrorCvalue.Text = "* Just Test";
            msgErrorCvalue.Visible = false;
            // 
            // msgErrorDvalue
            // 
            msgErrorDvalue.AutoSize = true;
            msgErrorDvalue.ForeColor = Color.Red;
            msgErrorDvalue.Location = new Point(767, 318);
            msgErrorDvalue.Name = "msgErrorDvalue";
            msgErrorDvalue.Size = new Size(90, 25);
            msgErrorDvalue.TabIndex = 28;
            msgErrorDvalue.Text = "* Just Test";
            msgErrorDvalue.Visible = false;
            // 
            // txtDvalue
            // 
            txtDvalue.Location = new Point(767, 282);
            txtDvalue.Name = "txtDvalue";
            txtDvalue.PlaceholderText = "4'th Value";
            txtDvalue.Size = new Size(130, 31);
            txtDvalue.TabIndex = 27;
            txtDvalue.Visible = false;
            txtDvalue.Click += txtDvalue_Click;
            // 
            // txtCvalue
            // 
            txtCvalue.Location = new Point(618, 282);
            txtCvalue.Name = "txtCvalue";
            txtCvalue.PlaceholderText = "3'th Value";
            txtCvalue.Size = new Size(117, 31);
            txtCvalue.TabIndex = 26;
            txtCvalue.Visible = false;
            txtCvalue.Click += txtCvalue_Click;
            // 
            // msgErrorAValue
            // 
            msgErrorAValue.AutoSize = true;
            msgErrorAValue.ForeColor = Color.Red;
            msgErrorAValue.Location = new Point(305, 317);
            msgErrorAValue.Name = "msgErrorAValue";
            msgErrorAValue.Size = new Size(90, 25);
            msgErrorAValue.TabIndex = 25;
            msgErrorAValue.Text = "* Just Test";
            msgErrorAValue.Visible = false;
            // 
            // msgErrorBValue
            // 
            msgErrorBValue.AutoSize = true;
            msgErrorBValue.ForeColor = Color.Red;
            msgErrorBValue.Location = new Point(476, 318);
            msgErrorBValue.Name = "msgErrorBValue";
            msgErrorBValue.Size = new Size(90, 25);
            msgErrorBValue.TabIndex = 24;
            msgErrorBValue.Text = "* Just Test";
            msgErrorBValue.Visible = false;
            // 
            // txtBvalue
            // 
            txtBvalue.Location = new Point(480, 282);
            txtBvalue.Name = "txtBvalue";
            txtBvalue.PlaceholderText = "Second Value";
            txtBvalue.Size = new Size(130, 31);
            txtBvalue.TabIndex = 23;
            txtBvalue.Visible = false;
            txtBvalue.Click += txtBvalue_Click;
            // 
            // txtAvalue
            // 
            txtAvalue.Location = new Point(305, 282);
            txtAvalue.Name = "txtAvalue";
            txtAvalue.PlaceholderText = "First Value";
            txtAvalue.Size = new Size(117, 31);
            txtAvalue.TabIndex = 22;
            txtAvalue.Visible = false;
            txtAvalue.Click += txtAvalue_Click;
            // 
            // txtConvertedType
            // 
            txtConvertedType.AutoSize = true;
            txtConvertedType.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConvertedType.Location = new Point(618, 136);
            txtConvertedType.Name = "txtConvertedType";
            txtConvertedType.Size = new Size(112, 30);
            txtConvertedType.TabIndex = 21;
            txtConvertedType.Text = "Your Text :";
            // 
            // txtConvertedText
            // 
            txtConvertedText.AutoSize = true;
            txtConvertedText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConvertedText.Location = new Point(734, 137);
            txtConvertedText.Name = "txtConvertedText";
            txtConvertedText.Size = new Size(69, 28);
            txtConvertedText.TabIndex = 20;
            txtConvertedText.Text = "Cipher";
            // 
            // msgErrorMono
            // 
            msgErrorMono.AutoSize = true;
            msgErrorMono.ForeColor = Color.Red;
            msgErrorMono.Location = new Point(305, 388);
            msgErrorMono.Name = "msgErrorMono";
            msgErrorMono.Size = new Size(90, 25);
            msgErrorMono.TabIndex = 19;
            msgErrorMono.Text = "* Just Test";
            msgErrorMono.Visible = false;
            // 
            // btnChangeKey
            // 
            btnChangeKey.AutoSize = true;
            btnChangeKey.ForeColor = Color.Green;
            btnChangeKey.Location = new Point(618, 360);
            btnChangeKey.Name = "btnChangeKey";
            btnChangeKey.Size = new Size(85, 25);
            btnChangeKey.TabIndex = 18;
            btnChangeKey.Text = "Change ?";
            btnChangeKey.Visible = false;
            btnChangeKey.Click += btnChangeKey_Click;
            btnChangeKey.MouseLeave += btnChangeKey_MouseLeave;
            btnChangeKey.MouseHover += btnChangeKey_MouseHover;
            // 
            // msgErrorKey
            // 
            msgErrorKey.AutoSize = true;
            msgErrorKey.ForeColor = Color.Red;
            msgErrorKey.Location = new Point(517, 105);
            msgErrorKey.Name = "msgErrorKey";
            msgErrorKey.Size = new Size(0, 25);
            msgErrorKey.TabIndex = 17;
            msgErrorKey.Visible = false;
            // 
            // txtMonoKey
            // 
            txtMonoKey.Enabled = false;
            txtMonoKey.Location = new Point(305, 354);
            txtMonoKey.Name = "txtMonoKey";
            txtMonoKey.Size = new Size(305, 31);
            txtMonoKey.TabIndex = 16;
            txtMonoKey.Text = "QWERTYUIOPASDFGHJKLZXCVBNM";
            txtMonoKey.Visible = false;
            txtMonoKey.Click += txtMonoKey_Click;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(517, 133);
            txtKey.Name = "txtKey";
            txtKey.PlaceholderText = "Key";
            txtKey.Size = new Size(93, 31);
            txtKey.TabIndex = 15;
            txtKey.TextAlign = HorizontalAlignment.Center;
            txtKey.Click += txtKey_Click;
            txtKey.KeyPress += txtKey_KeyPress;
            // 
            // msgErrorText
            // 
            msgErrorText.AutoSize = true;
            msgErrorText.ForeColor = Color.Red;
            msgErrorText.Location = new Point(305, 206);
            msgErrorText.Name = "msgErrorText";
            msgErrorText.Size = new Size(0, 25);
            msgErrorText.TabIndex = 14;
            msgErrorText.Visible = false;
            // 
            // msgErrorCipherType
            // 
            msgErrorCipherType.AutoSize = true;
            msgErrorCipherType.ForeColor = Color.Red;
            msgErrorCipherType.Location = new Point(479, 206);
            msgErrorCipherType.Name = "msgErrorCipherType";
            msgErrorCipherType.Size = new Size(0, 25);
            msgErrorCipherType.TabIndex = 13;
            msgErrorCipherType.Visible = false;
            // 
            // msgErrorAlgo
            // 
            msgErrorAlgo.AutoSize = true;
            msgErrorAlgo.ForeColor = Color.Red;
            msgErrorAlgo.Location = new Point(305, 105);
            msgErrorAlgo.Name = "msgErrorAlgo";
            msgErrorAlgo.Size = new Size(0, 25);
            msgErrorAlgo.TabIndex = 12;
            msgErrorAlgo.Visible = false;
            // 
            // comCipherType
            // 
            comCipherType.DropDownStyle = ComboBoxStyle.DropDownList;
            comCipherType.FormattingEnabled = true;
            comCipherType.Items.AddRange(new object[] { "Decrypted", "Encrypted" });
            comCipherType.Location = new Point(479, 231);
            comCipherType.Name = "comCipherType";
            comCipherType.Size = new Size(131, 33);
            comCipherType.TabIndex = 9;
            comCipherType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comCipherType.Click += comCipherType_Click;
            // 
            // comAlgoType
            // 
            comAlgoType.DropDownStyle = ComboBoxStyle.DropDownList;
            comAlgoType.FormattingEnabled = true;
            comAlgoType.Items.AddRange(new object[] { "CaesarCipher ", "MonoAlphabetic ", "Vigenère", "Beaufort", "PlayFair", "HillCipher", "AffineCipher ", "Autokey" });
            comAlgoType.Location = new Point(305, 133);
            comAlgoType.Name = "comAlgoType";
            comAlgoType.Size = new Size(206, 33);
            comAlgoType.TabIndex = 8;
            comAlgoType.SelectedIndexChanged += comAlgoType_SelectedIndexChanged;
            comAlgoType.Click += comAlgoType_Click;
            // 
            // btnCrypto
            // 
            btnCrypto.Location = new Point(305, 231);
            btnCrypto.Name = "btnCrypto";
            btnCrypto.Size = new Size(122, 33);
            btnCrypto.TabIndex = 6;
            btnCrypto.Text = "Encryption";
            btnCrypto.UseVisualStyleBackColor = true;
            btnCrypto.Click += btnCrypto_Click;
            // 
            // txtChipherText
            // 
            txtChipherText.Location = new Point(305, 172);
            txtChipherText.Name = "txtChipherText";
            txtChipherText.PlaceholderText = "Enter Your Text";
            txtChipherText.Size = new Size(305, 31);
            txtChipherText.TabIndex = 5;
            txtChipherText.Click += textBox1_Click;
            txtChipherText.TextChanged += txtChipherText_TextChanged;
            txtChipherText.KeyPress += txtChipherText_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(355, 5);
            label6.Name = "label6";
            label6.Size = new Size(304, 32);
            label6.TabIndex = 4;
            label6.Text = "Decrypto / Encrypto Tool";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1280, 601);
            Controls.Add(panalEncrypt);
            Controls.Add(panel1);
            Controls.Add(radioEncrypto);
            Controls.Add(radioSQL);
            Controls.Add(radioPassword);
            Name = "Form1";
            Text = "Cyber Security Project";
            Load += Form1_Load;
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            addPanal.ResumeLayout(false);
            addPanal.PerformLayout();
            searchPanal.ResumeLayout(false);
            searchPanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid).EndInit();
            panalEncrypt.ResumeLayout(false);
            panalEncrypt.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioPassword;
        private RadioButton radioSQL;
        private RadioButton radioEncrypto;
        private Panel panelPassword;
        private Button btnCheckPassword;
        private TextBox txtPassword;
        private Label label4;
        private Label label3;
        private Label label2;
        public Label label1;
        private Label label5;
        private Label labSize;
        private Label labEntropy;
        private Label labPassword;
        private Label txtError;
        private Label labStrength;
        private Label labMsg;
        private Panel panalEncrypt;
        private Label label6;
        private ComboBox comAlgoType;
        private Button btnCrypto;
        private TextBox txtChipherText;
        private ComboBox comCipherType;
        private Label msgErrorCipherType;
        private Label msgErrorAlgo;
        private Label msgErrorText;
        private TextBox txtKey;
        private TextBox txtMonoKey;
        private Label btnChangeKey;
        private Label msgErrorKey;
        private Label msgErrorMono;
        private Label txtConvertedText;
        private Label txtConvertedType;
        private Panel panel1;
        private Label label7;
        private Panel searchPanal;
        private Label label8;
        private Button btnAdd;
        private Button button1;
        private DataGridView dtGrid;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comSearchType;
        private TextBox txtSearcyQuery;
        private PictureBox btnSearch;
        private Label label9;
        private Label msgErrorQueryType;
        private Panel addPanal;
        private Label label10;
        private Label msgErrorProductCatg;
        private Button btnAddProdact;
        private TextBox txtProductName;
        private Label msgErrorProductPrice;
        private Label msgErrorProductName;
        private TextBox txtProdactPrice;
        private ComboBox comCategory;
        private Label lab13;
        private Label label14;
        private Label label13;
        private TextBox txtBvalue;
        private TextBox txtAvalue;
        private Label msgErrorAValue;
        private Label msgErrorBValue;
        private Label msgErrorCvalue;
        private Label msgErrorDvalue;
        private TextBox txtDvalue;
        private TextBox txtCvalue;
    }
}
