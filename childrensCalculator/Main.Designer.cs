namespace childrensCalculator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExponent = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtact = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.bnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.outputUnits = new System.Windows.Forms.TextBox();
            this.calculateUnits = new System.Windows.Forms.Button();
            this.toUnit = new System.Windows.Forms.ComboBox();
            this.numUnits = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fromUnit = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.units = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.calculateTime = new System.Windows.Forms.Button();
            this.finishYear = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.finishHour = new System.Windows.Forms.ComboBox();
            this.finishMinute = new System.Windows.Forms.ComboBox();
            this.finishTime = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.finishDay = new System.Windows.Forms.ComboBox();
            this.finishMonth = new System.Windows.Forms.ComboBox();
            this.startYear = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startHour = new System.Windows.Forms.ComboBox();
            this.startMinute = new System.Windows.Forms.ComboBox();
            this.startTime = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startDay = new System.Windows.Forms.ComboBox();
            this.startMonth = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnits)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(334, 481);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.txtOutput);
            this.tabPage1.Controls.Add(this.numUpDown);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(326, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(246, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddToScreenClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnZero, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDecimal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExponent, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSubtact, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNine, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSeven, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFour, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFive, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSix, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bnMultiply, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnThree, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnTwo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOne, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEqual, 3, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 375);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnZero
            // 
            this.btnZero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZero.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.SetColumnSpan(this.btnZero, 3);
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnZero.Location = new System.Drawing.Point(3, 303);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(234, 69);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnDecimal.Location = new System.Drawing.Point(3, 3);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(74, 69);
            this.btnDecimal.TabIndex = 15;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnClear.Location = new System.Drawing.Point(83, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 69);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.DeleteWasClicked);
            // 
            // btnExponent
            // 
            this.btnExponent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExponent.BackColor = System.Drawing.Color.Fuchsia;
            this.btnExponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnExponent.Location = new System.Drawing.Point(163, 3);
            this.btnExponent.Name = "btnExponent";
            this.btnExponent.Size = new System.Drawing.Size(74, 69);
            this.btnExponent.TabIndex = 17;
            this.btnExponent.Text = "^";
            this.btnExponent.UseVisualStyleBackColor = false;
            this.btnExponent.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnAdd.Location = new System.Drawing.Point(243, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 69);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // btnSubtact
            // 
            this.btnSubtact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubtact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSubtact.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnSubtact.Location = new System.Drawing.Point(243, 78);
            this.btnSubtact.Name = "btnSubtact";
            this.btnSubtact.Size = new System.Drawing.Size(74, 69);
            this.btnSubtact.TabIndex = 14;
            this.btnSubtact.Text = "-";
            this.btnSubtact.UseVisualStyleBackColor = false;
            this.btnSubtact.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // btnNine
            // 
            this.btnNine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNine.BackColor = System.Drawing.Color.Aqua;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnNine.Location = new System.Drawing.Point(163, 78);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(74, 69);
            this.btnNine.TabIndex = 13;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // btnEight
            // 
            this.btnEight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnEight.Location = new System.Drawing.Point(83, 78);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(74, 69);
            this.btnEight.TabIndex = 12;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // btnSeven
            // 
            this.btnSeven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnSeven.Location = new System.Drawing.Point(3, 78);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(74, 69);
            this.btnSeven.TabIndex = 11;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // btnFour
            // 
            this.btnFour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnFour.Location = new System.Drawing.Point(3, 153);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(74, 69);
            this.btnFour.TabIndex = 7;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // btnFive
            // 
            this.btnFive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnFive.Location = new System.Drawing.Point(83, 153);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(74, 69);
            this.btnFive.TabIndex = 8;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // btnSix
            // 
            this.btnSix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSix.BackColor = System.Drawing.Color.Yellow;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnSix.Location = new System.Drawing.Point(163, 153);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(74, 69);
            this.btnSix.TabIndex = 9;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // bnMultiply
            // 
            this.bnMultiply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.bnMultiply.Location = new System.Drawing.Point(243, 153);
            this.bnMultiply.Name = "bnMultiply";
            this.bnMultiply.Size = new System.Drawing.Size(74, 69);
            this.bnMultiply.TabIndex = 10;
            this.bnMultiply.Text = "*";
            this.bnMultiply.UseVisualStyleBackColor = false;
            this.bnMultiply.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // btnDivide
            // 
            this.btnDivide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnDivide.Location = new System.Drawing.Point(243, 228);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(74, 69);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // btnThree
            // 
            this.btnThree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThree.BackColor = System.Drawing.Color.Red;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnThree.Location = new System.Drawing.Point(163, 228);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(74, 69);
            this.btnThree.TabIndex = 5;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // btnTwo
            // 
            this.btnTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnTwo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTwo.Location = new System.Drawing.Point(83, 228);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(74, 69);
            this.btnTwo.TabIndex = 4;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // btnOne
            // 
            this.btnOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOne.Location = new System.Drawing.Point(3, 228);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(74, 69);
            this.btnOne.TabIndex = 3;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.DigitsClicked);
            // 
            // btnEqual
            // 
            this.btnEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEqual.Location = new System.Drawing.Point(243, 303);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(74, 69);
            this.btnEqual.TabIndex = 2;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.CalculateButton);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(8, 24);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(234, 34);
            this.txtOutput.TabIndex = 21;
            this.txtOutput.Text = "0";
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numUpDown
            // 
            this.numUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown.Location = new System.Drawing.Point(246, 53);
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(74, 20);
            this.numUpDown.TabIndex = 19;
            this.numUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(326, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extra";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputUnits);
            this.groupBox1.Controls.Add(this.units);
            this.groupBox1.Controls.Add(this.calculateUnits);
            this.groupBox1.Controls.Add(this.toUnit);
            this.groupBox1.Controls.Add(this.numUnits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fromUnit);
            this.groupBox1.Location = new System.Drawing.Point(7, 244);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(312, 203);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Units && Measures";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(52, 202);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Days : Hours : Minutes";
            // 
            // outputUnits
            // 
            this.outputUnits.BackColor = System.Drawing.SystemColors.Window;
            this.outputUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputUnits.Location = new System.Drawing.Point(35, 156);
            this.outputUnits.Margin = new System.Windows.Forms.Padding(2);
            this.outputUnits.Name = "outputUnits";
            this.outputUnits.ReadOnly = true;
            this.outputUnits.Size = new System.Drawing.Size(133, 26);
            this.outputUnits.TabIndex = 8;
            this.outputUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateUnits
            // 
            this.calculateUnits.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.calculateUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateUnits.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateUnits.Location = new System.Drawing.Point(172, 150);
            this.calculateUnits.Margin = new System.Windows.Forms.Padding(2);
            this.calculateUnits.Name = "calculateUnits";
            this.calculateUnits.Size = new System.Drawing.Size(96, 38);
            this.calculateUnits.TabIndex = 7;
            this.calculateUnits.Text = "Calculate";
            this.calculateUnits.UseVisualStyleBackColor = false;
            this.calculateUnits.Click += new System.EventHandler(this.CalculateUnitsClick);
            // 
            // toUnit
            // 
            this.toUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toUnit.AutoCompleteCustomSource.AddRange(new string[] {
            "Kilometers",
            "Meters",
            "Centimeters",
            "Millimeters",
            "Miles",
            "Yards",
            "Feet",
            "Inches"});
            this.toUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toUnit.FormattingEnabled = true;
            this.toUnit.Items.AddRange(new object[] {
            "Kilometers",
            "Meters",
            "Centimeters",
            "Millimeters",
            "Miles",
            "Yards",
            "Feet",
            "Inches"});
            this.toUnit.Location = new System.Drawing.Point(107, 106);
            this.toUnit.Margin = new System.Windows.Forms.Padding(2);
            this.toUnit.Name = "toUnit";
            this.toUnit.Size = new System.Drawing.Size(126, 21);
            this.toUnit.TabIndex = 6;
            // 
            // numUnits
            // 
            this.numUnits.Location = new System.Drawing.Point(107, 34);
            this.numUnits.Margin = new System.Windows.Forms.Padding(2);
            this.numUnits.Name = "numUnits";
            this.numUnits.Size = new System.Drawing.Size(126, 20);
            this.numUnits.TabIndex = 5;
            this.numUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(52, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Convert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(76, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(66, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // fromUnit
            // 
            this.fromUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromUnit.AutoCompleteCustomSource.AddRange(new string[] {
            "Kilometers",
            "Meters",
            "Centimeters",
            "Millimeters",
            "Miles",
            "Yards",
            "Feet",
            "Inches"});
            this.fromUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromUnit.FormattingEnabled = true;
            this.fromUnit.Items.AddRange(new object[] {
            "Kilometers",
            "Meters",
            "Centimeters",
            "Millimeters",
            "Miles",
            "Yards",
            "Feet",
            "Inches"});
            this.fromUnit.Location = new System.Drawing.Point(107, 70);
            this.fromUnit.Margin = new System.Windows.Forms.Padding(2);
            this.fromUnit.Name = "fromUnit";
            this.fromUnit.Size = new System.Drawing.Size(126, 21);
            this.fromUnit.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.calculateTime);
            this.groupBox2.Controls.Add(this.finishYear);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.finishHour);
            this.groupBox2.Controls.Add(this.finishMinute);
            this.groupBox2.Controls.Add(this.finishTime);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.finishDay);
            this.groupBox2.Controls.Add(this.finishMonth);
            this.groupBox2.Controls.Add(this.startYear);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.startHour);
            this.groupBox2.Controls.Add(this.startMinute);
            this.groupBox2.Controls.Add(this.startTime);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.startDay);
            this.groupBox2.Controls.Add(this.startMonth);
            this.groupBox2.Location = new System.Drawing.Point(7, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(312, 235);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dates && Times";
            // 
            // units
            // 
            this.units.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.units.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.units.Location = new System.Drawing.Point(35, 184);
            this.units.Margin = new System.Windows.Forms.Padding(0);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(133, 14);
            this.units.TabIndex = 37;
            this.units.Text = "units";
            this.units.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(35, 174);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(133, 26);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateTime
            // 
            this.calculateTime.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.calculateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateTime.Location = new System.Drawing.Point(172, 168);
            this.calculateTime.Margin = new System.Windows.Forms.Padding(2);
            this.calculateTime.Name = "calculateTime";
            this.calculateTime.Size = new System.Drawing.Size(96, 38);
            this.calculateTime.TabIndex = 9;
            this.calculateTime.Text = "Calculate";
            this.calculateTime.UseVisualStyleBackColor = false;
            this.calculateTime.Click += new System.EventHandler(this.CalculateTimeClick);
            // 
            // finishYear
            // 
            this.finishYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finishYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.finishYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishYear.FormattingEnabled = true;
            this.finishYear.Location = new System.Drawing.Point(221, 98);
            this.finishYear.Margin = new System.Windows.Forms.Padding(2);
            this.finishYear.Name = "finishYear";
            this.finishYear.Size = new System.Drawing.Size(47, 21);
            this.finishYear.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(57, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "End day";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(55, 135);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "End time";
            // 
            // finishHour
            // 
            this.finishHour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finishHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.finishHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishHour.FormattingEnabled = true;
            this.finishHour.Location = new System.Drawing.Point(110, 132);
            this.finishHour.Margin = new System.Windows.Forms.Padding(2);
            this.finishHour.Name = "finishHour";
            this.finishHour.Size = new System.Drawing.Size(36, 21);
            this.finishHour.TabIndex = 30;
            // 
            // finishMinute
            // 
            this.finishMinute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finishMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.finishMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishMinute.FormattingEnabled = true;
            this.finishMinute.Location = new System.Drawing.Point(166, 132);
            this.finishMinute.Margin = new System.Windows.Forms.Padding(2);
            this.finishMinute.Name = "finishMinute";
            this.finishMinute.Size = new System.Drawing.Size(38, 21);
            this.finishMinute.TabIndex = 29;
            // 
            // finishTime
            // 
            this.finishTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finishTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.finishTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishTime.FormattingEnabled = true;
            this.finishTime.Items.AddRange(new object[] {
            "A.M.",
            "P.M."});
            this.finishTime.Location = new System.Drawing.Point(221, 132);
            this.finishTime.Margin = new System.Windows.Forms.Padding(2);
            this.finishTime.Name = "finishTime";
            this.finishTime.Size = new System.Drawing.Size(47, 21);
            this.finishTime.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(107, 133);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = ":";
            // 
            // finishDay
            // 
            this.finishDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finishDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.finishDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishDay.FormattingEnabled = true;
            this.finishDay.Location = new System.Drawing.Point(166, 98);
            this.finishDay.Margin = new System.Windows.Forms.Padding(2);
            this.finishDay.Name = "finishDay";
            this.finishDay.Size = new System.Drawing.Size(38, 21);
            this.finishDay.TabIndex = 26;
            // 
            // finishMonth
            // 
            this.finishMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finishMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.finishMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishMonth.FormattingEnabled = true;
            this.finishMonth.Location = new System.Drawing.Point(110, 98);
            this.finishMonth.Margin = new System.Windows.Forms.Padding(2);
            this.finishMonth.Name = "finishMonth";
            this.finishMonth.Size = new System.Drawing.Size(36, 21);
            this.finishMonth.TabIndex = 24;
            // 
            // startYear
            // 
            this.startYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startYear.FormattingEnabled = true;
            this.startYear.Location = new System.Drawing.Point(221, 32);
            this.startYear.Margin = new System.Windows.Forms.Padding(2);
            this.startYear.Name = "startYear";
            this.startYear.Size = new System.Drawing.Size(47, 21);
            this.startYear.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(54, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Start day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(52, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Start time";
            // 
            // startHour
            // 
            this.startHour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startHour.FormattingEnabled = true;
            this.startHour.Location = new System.Drawing.Point(110, 65);
            this.startHour.Margin = new System.Windows.Forms.Padding(2);
            this.startHour.Name = "startHour";
            this.startHour.Size = new System.Drawing.Size(36, 21);
            this.startHour.TabIndex = 19;
            // 
            // startMinute
            // 
            this.startMinute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startMinute.FormattingEnabled = true;
            this.startMinute.Location = new System.Drawing.Point(166, 65);
            this.startMinute.Margin = new System.Windows.Forms.Padding(2);
            this.startMinute.Name = "startMinute";
            this.startMinute.Size = new System.Drawing.Size(38, 21);
            this.startMinute.TabIndex = 18;
            // 
            // startTime
            // 
            this.startTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTime.FormattingEnabled = true;
            this.startTime.Items.AddRange(new object[] {
            "A.M.",
            "P.M."});
            this.startTime.Location = new System.Drawing.Point(221, 65);
            this.startTime.Margin = new System.Windows.Forms.Padding(2);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(47, 21);
            this.startTime.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = ":";
            // 
            // startDay
            // 
            this.startDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startDay.FormattingEnabled = true;
            this.startDay.Location = new System.Drawing.Point(166, 32);
            this.startDay.Margin = new System.Windows.Forms.Padding(2);
            this.startDay.Name = "startDay";
            this.startDay.Size = new System.Drawing.Size(38, 21);
            this.startDay.TabIndex = 15;
            // 
            // startMonth
            // 
            this.startMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startMonth.FormattingEnabled = true;
            this.startMonth.Location = new System.Drawing.Point(110, 32);
            this.startMonth.Margin = new System.Windows.Forms.Padding(2);
            this.startMonth.Name = "startMonth";
            this.startMonth.Size = new System.Drawing.Size(36, 21);
            this.startMonth.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnZero;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(334, 480);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnits)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button bnMultiply;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSubtact;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExponent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox outputUnits;
        private System.Windows.Forms.Button calculateUnits;
        private System.Windows.Forms.ComboBox toUnit;
        private System.Windows.Forms.NumericUpDown numUnits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fromUnit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button calculateTime;
        private System.Windows.Forms.ComboBox finishYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox finishHour;
        private System.Windows.Forms.ComboBox finishMinute;
        private System.Windows.Forms.ComboBox finishTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox finishDay;
        private System.Windows.Forms.ComboBox finishMonth;
        private System.Windows.Forms.ComboBox startYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox startHour;
        private System.Windows.Forms.ComboBox startMinute;
        private System.Windows.Forms.ComboBox startTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox startDay;
        private System.Windows.Forms.ComboBox startMonth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label units;



    }
}

