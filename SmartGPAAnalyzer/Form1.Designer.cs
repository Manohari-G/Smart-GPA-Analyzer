namespace SmartGPAAnalyzer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSubject = new TextBox();
            cmbGrade = new ComboBox();
            label4 = new Label();
            btnDelete = new Button();
            btnClear = new Button();
            dataGridView1 = new DataGridView();
            ColSubject = new DataGridViewTextBoxColumn();
            ColGrade = new DataGridViewTextBoxColumn();
            ColCredits = new DataGridViewTextBoxColumn();
            ColPoints = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            txtCredits = new TextBox();
            btnAdd = new Button();
            panel3 = new Panel();
            txtPrevCredits = new TextBox();
            txtPrevCGPA = new TextBox();
            label43 = new Label();
            label27 = new Label();
            panel13 = new Panel();
            label14 = new Label();
            lblCGPA = new Label();
            btnCGPA = new Button();
            panel5 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel6 = new Panel();
            cmbExpectedGrade = new ComboBox();
            txtRemainingCredits = new TextBox();
            label45 = new Label();
            panel14 = new Panel();
            PredictedGPA = new Label();
            lblPredictedGPA = new Label();
            label29 = new Label();
            btnPredict = new Button();
            label17 = new Label();
            btnCalculate = new Button();
            btnReset = new Button();
            btnExit = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel12 = new Panel();
            lblCredits = new Label();
            label13 = new Label();
            panel10 = new Panel();
            panel7 = new Panel();
            lblPerformance = new Label();
            label41 = new Label();
            panel9 = new Panel();
            lblSGPA = new Label();
            label12 = new Label();
            panel17 = new Panel();
            lblCcGPA = new Label();
            label47 = new Label();
            panel16 = new Panel();
            panel15 = new Panel();
            lblHighest = new Label();
            label16 = new Label();
            label15 = new Label();
            panel8 = new Panel();
            label25 = new Label();
            lblLowest = new Label();
            label19 = new Label();
            panel11 = new Panel();
            label28 = new Label();
            label46 = new Label();
            label44 = new Label();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel13.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel14.SuspendLayout();
            panel12.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel17.SuspendLayout();
            panel16.SuspendLayout();
            panel15.SuspendLayout();
            panel8.SuspendLayout();
            panel11.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(581, 8);
            label1.Name = "label1";
            label1.Size = new Size(351, 37);
            label1.TabIndex = 0;
            label1.Text = "SMART GPA ANALYZER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 31);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 1;
            label2.Text = "Subject Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(314, 31);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "Grade";
            label3.Click += label3_Click;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(29, 68);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(237, 27);
            txtSubject.TabIndex = 3;
            // 
            // cmbGrade
            // 
            cmbGrade.FormattingEnabled = true;
            cmbGrade.Items.AddRange(new object[] { "O", "A+", "A", "B+", "B", "C" });
            cmbGrade.Location = new Point(314, 68);
            cmbGrade.Name = "cmbGrade";
            cmbGrade.Size = new Size(206, 28);
            cmbGrade.TabIndex = 4;
            cmbGrade.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 108);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 5;
            label4.Text = "Credits";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(29, 182);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(237, 44);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "🗑️Delete Selected";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 192, 255);
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Blue;
            btnClear.Location = new Point(314, 182);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(206, 44);
            btnClear.TabIndex = 9;
            btnClear.Text = "🔃 Clear All";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnReset_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColSubject, ColGrade, ColCredits, ColPoints });
            dataGridView1.Location = new Point(9, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(525, 220);
            dataGridView1.TabIndex = 10;
            // 
            // ColSubject
            // 
            ColSubject.HeaderText = "Subject";
            ColSubject.MinimumWidth = 6;
            ColSubject.Name = "ColSubject";
            ColSubject.Width = 125;
            // 
            // ColGrade
            // 
            ColGrade.HeaderText = "Grade";
            ColGrade.MinimumWidth = 6;
            ColGrade.Name = "ColGrade";
            ColGrade.Width = 125;
            // 
            // ColCredits
            // 
            ColCredits.HeaderText = "Credits";
            ColCredits.MinimumWidth = 6;
            ColCredits.Name = "ColCredits";
            ColCredits.Width = 125;
            // 
            // ColPoints
            // 
            ColPoints.HeaderText = "Points";
            ColPoints.MinimumWidth = 6;
            ColPoints.Name = "ColPoints";
            ColPoints.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-38, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1430, 94);
            panel1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(421, -4);
            label6.Name = "label6";
            label6.Size = new Size(116, 80);
            label6.TabIndex = 12;
            label6.Text = "🎓";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(543, 45);
            label5.Name = "label5";
            label5.Size = new Size(442, 20);
            label5.TabIndex = 12;
            label5.Text = "Calculate,Analyze and Improve Your Academic Performance";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.Controls.Add(txtCredits);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtSubject);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cmbGrade);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDelete);
            panel2.Location = new Point(21, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(545, 259);
            panel2.TabIndex = 12;
            // 
            // txtCredits
            // 
            txtCredits.Location = new Point(29, 130);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(237, 27);
            txtCredits.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(314, 114);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(206, 50);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "⊕ Add Subject";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 192);
            panel3.Controls.Add(txtPrevCredits);
            panel3.Controls.Add(txtPrevCGPA);
            panel3.Controls.Add(label43);
            panel3.Controls.Add(label27);
            panel3.Controls.Add(panel13);
            panel3.Controls.Add(btnCGPA);
            panel3.Location = new Point(572, 407);
            panel3.Name = "panel3";
            panel3.Size = new Size(419, 269);
            panel3.TabIndex = 13;
            // 
            // txtPrevCredits
            // 
            txtPrevCredits.Location = new Point(220, 66);
            txtPrevCredits.Name = "txtPrevCredits";
            txtPrevCredits.Size = new Size(174, 27);
            txtPrevCredits.TabIndex = 47;
            // 
            // txtPrevCGPA
            // 
            txtPrevCGPA.Location = new Point(37, 66);
            txtPrevCGPA.Name = "txtPrevCGPA";
            txtPrevCGPA.Size = new Size(148, 27);
            txtPrevCGPA.TabIndex = 46;
            txtPrevCGPA.TextChanged += textBox2_TextChanged;
            // 
            // label43
            // 
            label43.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label43.Location = new Point(220, 32);
            label43.Name = "label43";
            label43.Size = new Size(179, 25);
            label43.TabIndex = 45;
            label43.Text = "Previous Total Credits :";
            // 
            // label27
            // 
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(35, 32);
            label27.Name = "label27";
            label27.Size = new Size(150, 25);
            label27.TabIndex = 29;
            label27.Text = "Previous CGPA :";
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(192, 255, 192);
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(label14);
            panel13.Controls.Add(lblCGPA);
            panel13.Location = new Point(148, 115);
            panel13.Name = "panel13";
            panel13.Size = new Size(246, 77);
            panel13.TabIndex = 0;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(0, 192, 0);
            label14.Location = new Point(12, 4);
            label14.Name = "label14";
            label14.Size = new Size(150, 25);
            label14.TabIndex = 16;
            label14.Text = "New CGPA";
            label14.Click += label14_Click;
            // 
            // lblCGPA
            // 
            lblCGPA.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCGPA.ForeColor = Color.FromArgb(0, 192, 0);
            lblCGPA.Location = new Point(71, 31);
            lblCGPA.Name = "lblCGPA";
            lblCGPA.Size = new Size(126, 37);
            lblCGPA.TabIndex = 44;
            lblCGPA.Text = "0.00";
            // 
            // btnCGPA
            // 
            btnCGPA.BackColor = Color.Indigo;
            btnCGPA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCGPA.ForeColor = Color.GhostWhite;
            btnCGPA.Location = new Point(35, 198);
            btnCGPA.Name = "btnCGPA";
            btnCGPA.Size = new Size(220, 50);
            btnCGPA.TabIndex = 15;
            btnCGPA.Text = "📱 Calculate CGPA";
            btnCGPA.UseVisualStyleBackColor = false;
            btnCGPA.Click += btnCGPA_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 255, 255);
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new Point(21, 407);
            panel5.Name = "panel5";
            panel5.Size = new Size(545, 269);
            panel5.TabIndex = 0;
            panel5.Paint += panel5_Paint;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(0, 192, 0);
            label7.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(50, 98);
            label7.Name = "label7";
            label7.Size = new Size(162, 34);
            label7.TabIndex = 0;
            label7.Text = "Add Subject";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(0, 192, 192);
            label8.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(50, 387);
            label8.Name = "label8";
            label8.Size = new Size(162, 34);
            label8.TabIndex = 11;
            label8.Text = "Subject Details";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 192, 255);
            panel6.Controls.Add(cmbExpectedGrade);
            panel6.Controls.Add(txtRemainingCredits);
            panel6.Controls.Add(label45);
            panel6.Controls.Add(panel14);
            panel6.Controls.Add(btnPredict);
            panel6.Controls.Add(label17);
            panel6.Location = new Point(1006, 407);
            panel6.Name = "panel6";
            panel6.Size = new Size(386, 269);
            panel6.TabIndex = 14;
            // 
            // cmbExpectedGrade
            // 
            cmbExpectedGrade.FormattingEnabled = true;
            cmbExpectedGrade.Items.AddRange(new object[] { "O", "A+", "A", "B+", "B", "C" });
            cmbExpectedGrade.Location = new Point(171, 27);
            cmbExpectedGrade.Name = "cmbExpectedGrade";
            cmbExpectedGrade.Size = new Size(188, 28);
            cmbExpectedGrade.TabIndex = 50;
            // 
            // txtRemainingCredits
            // 
            txtRemainingCredits.Location = new Point(171, 63);
            txtRemainingCredits.Name = "txtRemainingCredits";
            txtRemainingCredits.Size = new Size(188, 27);
            txtRemainingCredits.TabIndex = 49;
            // 
            // label45
            // 
            label45.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label45.Location = new Point(26, 30);
            label45.Name = "label45";
            label45.Size = new Size(150, 25);
            label45.TabIndex = 47;
            label45.Text = "Expected Grade :";
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(192, 192, 255);
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(PredictedGPA);
            panel14.Controls.Add(lblPredictedGPA);
            panel14.Controls.Add(label29);
            panel14.Location = new Point(44, 115);
            panel14.Name = "panel14";
            panel14.Size = new Size(227, 74);
            panel14.TabIndex = 0;
            panel14.Paint += panel14_Paint;
            // 
            // PredictedGPA
            // 
            PredictedGPA.AutoSize = true;
            PredictedGPA.BackColor = Color.FromArgb(192, 192, 255);
            PredictedGPA.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PredictedGPA.ForeColor = Color.Navy;
            PredictedGPA.Location = new Point(56, 31);
            PredictedGPA.Name = "PredictedGPA";
            PredictedGPA.Size = new Size(0, 31);
            PredictedGPA.TabIndex = 20;
            // 
            // lblPredictedGPA
            // 
            lblPredictedGPA.AutoSize = true;
            lblPredictedGPA.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPredictedGPA.ForeColor = Color.FromArgb(0, 0, 192);
            lblPredictedGPA.Location = new Point(56, 40);
            lblPredictedGPA.Name = "lblPredictedGPA";
            lblPredictedGPA.Size = new Size(0, 31);
            lblPredictedGPA.TabIndex = 32;
            // 
            // label29
            // 
            label29.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.Blue;
            label29.Location = new Point(6, 4);
            label29.Name = "label29";
            label29.Size = new Size(150, 25);
            label29.TabIndex = 31;
            label29.Text = "Predicted GPA";
            // 
            // btnPredict
            // 
            btnPredict.BackColor = Color.FromArgb(0, 0, 192);
            btnPredict.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPredict.ForeColor = SystemColors.Control;
            btnPredict.Location = new Point(44, 194);
            btnPredict.Name = "btnPredict";
            btnPredict.Size = new Size(212, 54);
            btnPredict.TabIndex = 16;
            btnPredict.Text = "📈 Predict GPA";
            btnPredict.UseVisualStyleBackColor = false;
            btnPredict.Click += btnPredict_Click;
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(25, 66);
            label17.Name = "label17";
            label17.Size = new Size(150, 25);
            label17.TabIndex = 19;
            label17.Text = "Remaining Credits :";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(0, 192, 0);
            btnCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = SystemColors.Control;
            btnCalculate.Location = new Point(384, 691);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(186, 49);
            btnCalculate.TabIndex = 17;
            btnCalculate.Text = "📱 Calculate GPA";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(192, 192, 255);
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.FromArgb(0, 0, 192);
            btnReset.Location = new Point(615, 691);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(180, 49);
            btnReset.TabIndex = 18;
            btnReset.Text = "🔃 Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 192);
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(849, 691);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(171, 49);
            btnExit.TabIndex = 19;
            btnExit.Text = "❌ Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(192, 0, 192);
            label9.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(1042, 384);
            label9.Name = "label9";
            label9.Size = new Size(162, 39);
            label9.TabIndex = 16;
            label9.Text = "GPA Predictor";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(255, 128, 0);
            label10.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(607, 385);
            label10.Name = "label10";
            label10.Size = new Size(162, 34);
            label10.TabIndex = 17;
            label10.Text = "CGPA Calculator";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = Color.Purple;
            label11.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(609, 98);
            label11.Name = "label11";
            label11.Size = new Size(162, 34);
            label11.TabIndex = 18;
            label11.Text = "Result and Analysis";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(192, 255, 192);
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(lblCredits);
            panel12.Controls.Add(label13);
            panel12.Controls.Add(panel10);
            panel12.Location = new Point(216, 20);
            panel12.Name = "panel12";
            panel12.Size = new Size(179, 76);
            panel12.TabIndex = 0;
            // 
            // lblCredits
            // 
            lblCredits.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCredits.ForeColor = Color.Green;
            lblCredits.Location = new Point(39, 30);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(101, 25);
            lblCredits.TabIndex = 51;
            lblCredits.Text = "0";
            lblCredits.Click += label22_Click;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Green;
            label13.Location = new Point(3, 4);
            label13.Name = "label13";
            label13.Size = new Size(150, 25);
            label13.TabIndex = 2;
            label13.Text = "📖 Total Credits";
            // 
            // panel10
            // 
            panel10.Location = new Point(83, 105);
            panel10.Name = "panel10";
            panel10.Size = new Size(109, 125);
            panel10.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 224, 192);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(lblPerformance);
            panel7.Controls.Add(label41);
            panel7.Location = new Point(402, 20);
            panel7.Name = "panel7";
            panel7.Size = new Size(172, 75);
            panel7.TabIndex = 20;
            // 
            // lblPerformance
            // 
            lblPerformance.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerformance.ForeColor = Color.FromArgb(192, 64, 0);
            lblPerformance.Location = new Point(37, 30);
            lblPerformance.Name = "lblPerformance";
            lblPerformance.Size = new Size(134, 25);
            lblPerformance.TabIndex = 44;
            lblPerformance.Text = "-";
            // 
            // label41
            // 
            label41.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label41.ForeColor = Color.FromArgb(192, 64, 0);
            label41.Location = new Point(3, 5);
            label41.Name = "label41";
            label41.Size = new Size(150, 25);
            label41.TabIndex = 43;
            label41.Text = "🏆 Performance";
            // 
            // panel9
            // 
            panel9.BackColor = Color.PaleTurquoise;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(lblSGPA);
            panel9.Controls.Add(label12);
            panel9.Location = new Point(34, 20);
            panel9.Name = "panel9";
            panel9.Size = new Size(176, 76);
            panel9.TabIndex = 0;
            // 
            // lblSGPA
            // 
            lblSGPA.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSGPA.ForeColor = Color.Blue;
            lblSGPA.Location = new Point(41, 29);
            lblSGPA.Name = "lblSGPA";
            lblSGPA.Size = new Size(80, 42);
            lblSGPA.TabIndex = 3;
            lblSGPA.Text = "0.00";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Blue;
            label12.Location = new Point(3, 4);
            label12.Name = "label12";
            label12.Size = new Size(99, 25);
            label12.TabIndex = 2;
            label12.Text = "📱SGPA";
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(192, 192, 255);
            panel17.BorderStyle = BorderStyle.FixedSingle;
            panel17.Controls.Add(lblCcGPA);
            panel17.Controls.Add(label47);
            panel17.Location = new Point(580, 20);
            panel17.Name = "panel17";
            panel17.Size = new Size(168, 76);
            panel17.TabIndex = 0;
            // 
            // lblCcGPA
            // 
            lblCcGPA.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCcGPA.ForeColor = Color.FromArgb(0, 0, 192);
            lblCcGPA.Location = new Point(33, 29);
            lblCcGPA.Name = "lblCcGPA";
            lblCcGPA.Size = new Size(112, 25);
            lblCcGPA.TabIndex = 50;
            lblCcGPA.Text = "0.00";
            // 
            // label47
            // 
            label47.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label47.ForeColor = Color.FromArgb(0, 0, 192);
            label47.Location = new Point(7, 4);
            label47.Name = "label47";
            label47.Size = new Size(150, 25);
            label47.TabIndex = 49;
            label47.Text = "🎓 CGPA";
            // 
            // panel16
            // 
            panel16.BackColor = Color.White;
            panel16.BorderStyle = BorderStyle.FixedSingle;
            panel16.Controls.Add(panel15);
            panel16.Controls.Add(panel8);
            panel16.Controls.Add(panel11);
            panel16.Location = new Point(56, 102);
            panel16.Name = "panel16";
            panel16.Size = new Size(670, 152);
            panel16.TabIndex = 0;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(192, 255, 192);
            panel15.BorderStyle = BorderStyle.FixedSingle;
            panel15.Controls.Add(lblHighest);
            panel15.Controls.Add(label16);
            panel15.Controls.Add(label15);
            panel15.Location = new Point(7, 6);
            panel15.Name = "panel15";
            panel15.Size = new Size(326, 68);
            panel15.TabIndex = 0;
            // 
            // lblHighest
            // 
            lblHighest.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHighest.ForeColor = Color.Green;
            lblHighest.Location = new Point(79, 26);
            lblHighest.Name = "lblHighest";
            lblHighest.Size = new Size(150, 25);
            lblHighest.TabIndex = 5;
            lblHighest.Text = "-";
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Green;
            label16.Location = new Point(11, 3);
            label16.Name = "label16";
            label16.Size = new Size(45, 50);
            label16.TabIndex = 4;
            label16.Text = "▲";
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Green;
            label15.Location = new Point(79, 3);
            label15.Name = "label15";
            label15.Size = new Size(150, 25);
            label15.TabIndex = 3;
            label15.Text = "Highest Subject";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 192, 192);
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label25);
            panel8.Controls.Add(lblLowest);
            panel8.Controls.Add(label19);
            panel8.Location = new Point(351, 6);
            panel8.Name = "panel8";
            panel8.Size = new Size(306, 68);
            panel8.TabIndex = 0;
            // 
            // label25
            // 
            label25.BackColor = Color.FromArgb(255, 192, 192);
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.Red;
            label25.Location = new Point(88, 3);
            label25.Name = "label25";
            label25.Size = new Size(150, 25);
            label25.TabIndex = 7;
            label25.Text = "Lowest Subject";
            // 
            // lblLowest
            // 
            lblLowest.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowest.ForeColor = Color.Red;
            lblLowest.Location = new Point(88, 21);
            lblLowest.Name = "lblLowest";
            lblLowest.Size = new Size(150, 25);
            lblLowest.TabIndex = 6;
            lblLowest.Text = "-";
            // 
            // label19
            // 
            label19.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(21, 3);
            label19.Name = "label19";
            label19.Size = new Size(45, 50);
            label19.TabIndex = 5;
            label19.Text = "▼";
            label19.Click += label19_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(255, 255, 192);
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(label28);
            panel11.Controls.Add(label46);
            panel11.Controls.Add(label44);
            panel11.Location = new Point(7, 80);
            panel11.Name = "panel11";
            panel11.Size = new Size(651, 65);
            panel11.TabIndex = 0;
            // 
            // label28
            // 
            label28.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.FromArgb(255, 128, 0);
            label28.Location = new Point(63, 9);
            label28.Name = "label28";
            label28.Size = new Size(91, 25);
            label28.TabIndex = 49;
            label28.Text = "Remarks :";
            // 
            // label46
            // 
            label46.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label46.ForeColor = Color.FromArgb(255, 128, 0);
            label46.Location = new Point(-1, 9);
            label46.Name = "label46";
            label46.Size = new Size(68, 52);
            label46.TabIndex = 48;
            label46.Text = "📝";
            // 
            // label44
            // 
            label44.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label44.ForeColor = Color.FromArgb(255, 128, 0);
            label44.Location = new Point(79, 34);
            label44.Name = "label44";
            label44.Size = new Size(356, 28);
            label44.TabIndex = 46;
            label44.Text = "Add subjects and calculate to see analysis";
            label44.Click += label44_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel16);
            panel4.Controls.Add(panel17);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel12);
            panel4.Location = new Point(575, 114);
            panel4.Name = "panel4";
            panel4.Size = new Size(817, 259);
            panel4.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1445, 756);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(btnExit);
            Controls.Add(label9);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel13.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel12.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSubject;
        private ComboBox cmbGrade;
        private Label label4;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Label label7;
        private Label label8;
        private Button btnAdd;
        private Panel panel6;
        private Button btnCGPA;
        private Button btnPredict;
        private Button btnCalculate;
        private Button btnReset;
        private Button btnExit;
        private Panel panel13;
        private Panel panel14;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label45;
        private Label label43;
        private Label lblCGPA;
        private Label label29;
        private Label label27;
        private Label label26;
        private Label label17;
        private Label label14;
        private Panel panel12;
        private Label lblCredits;
        private Label label13;
        private Panel panel10;
        private Panel panel7;
        private Label lblPerformance;
        private Label label41;
        private Panel panel9;
        private Label lblSGPA;
        private Label label12;
        private Panel panel17;
        private Label lblCcGPA;
        private Label label47;
        private Panel panel16;
        private Panel panel15;
        private Label lblHighest;
        private Label label16;
        private Label label15;
        private Panel panel8;
        private Label label19;
        private Panel panel11;
        private Label label46;
        private Label label44;
        private Panel panel4;
        private Label label25;
        private Label lblLowest;
        private Label label28;
        private NumericUpDown numericUpDown2;
        private TextBox txtPrevCGPA;
        private ComboBox comboBox2;
        private TextBox txtCredits;
        private TextBox txtRemainingCredits;
        private DataGridViewTextBoxColumn ColSubject;
        private DataGridViewTextBoxColumn ColGrade;
        private DataGridViewTextBoxColumn ColCredits;
        private DataGridViewTextBoxColumn ColPoints;
        private TextBox txtPrevCredits;
        private ComboBox cmbExpectedGrade;
        private Label lblPredictedGPA;
        private Label PredictedGPA;
    }
}
