namespace SmartGPAAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void label22_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label44_Click(object sender, EventArgs e)
        {

        }
        private void label19_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void panel5_Paint(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int GetGradePoint(string grade)
        {
            switch (grade)
            {
                case "O": return 10;
                case "A+": return 9;
                case "A": return 8;
                case "B+": return 7;
                case "B": return 6;
                case "C": return 5;
                default: return 0;
            }
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text == "" || cmbGrade.Text == "" || txtCredits.Text == "")
            {
                MessageBox.Show("Fill all fields");
                return;
            }

            int credits;
            if (!int.TryParse(txtCredits.Text, out credits))
            {
                MessageBox.Show("Enter valid credits");
                return;
            }

            int gp = GetGradePoint(cmbGrade.Text);

            dataGridView1.Rows.Add(txtSubject.Text, cmbGrade.Text, credits, gp);

            txtSubject.Clear();
            txtCredits.Clear();
            cmbGrade.SelectedIndex = -1;
        }
       private void btnCalculate_Click(object sender, EventArgs e)
        {
            double totalPoints = 0;
            double totalCredits = 0;

            int max = -1;
            int min = 100;
            string highSub = "-", lowSub = "-";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    int credits = Convert.ToInt32(row.Cells[2].Value);
                    int gp = Convert.ToInt32(row.Cells[3].Value);

                    totalPoints += credits * gp;
                    totalCredits += credits;

                    string subject = row.Cells[0].Value.ToString();

                    if (gp > max)
                    {
                        max = gp;
                        highSub = subject;
                    }

                    if (gp < min)
                    {
                        min = gp;
                        lowSub = subject;
                    }
                }
            }

            if (totalCredits == 0)
            {
                MessageBox.Show("No data");
                return;
            }

            double gpa = totalPoints / totalCredits;

            lblSGPA.Text = gpa.ToString("0.00");
            lblCredits.Text = totalCredits.ToString();

            
            if (gpa >= 9) lblPerformance.Text = "Excellent";
            else if (gpa >= 8) lblPerformance.Text = "Very Good";
            else if (gpa >= 7) lblPerformance.Text = "Good";
            else lblPerformance.Text = "Needs Improvement";

            lblHighest.Text = highSub;
            lblLowest.Text = lowSub;
        }
        private void btnCGPA_Click(object sender, EventArgs e)
        {
            double prevCGPA, prevCredits, currentCredits = 0, currentPoints = 0;

            if (!double.TryParse(txtPrevCGPA.Text, out prevCGPA) ||
                !double.TryParse(txtPrevCredits.Text, out prevCredits))
            {
                MessageBox.Show("Enter valid CGPA details");
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    int credits = Convert.ToInt32(row.Cells[2].Value);
                    int gp = Convert.ToInt32(row.Cells[3].Value);

                    currentPoints += credits * gp;
                    currentCredits += credits;
                }
            }

            double newCGPA = ((prevCGPA * prevCredits) + currentPoints) / (prevCredits + currentCredits);

            lblCGPA.Text = newCGPA.ToString("0.00");
        }
        private void btnPredict_Click(object sender, EventArgs e)
        {
            if (cmbExpectedGrade.Text == "" || txtRemainingCredits.Text == "")
            {
                MessageBox.Show("Fill prediction fields");
                return;
            }

            int remainingCredits;
            if (!int.TryParse(txtRemainingCredits.Text, out remainingCredits))
            {
                MessageBox.Show("Invalid credits");
                return;
            }

            int gp = GetGradePoint(cmbExpectedGrade.Text);

            double totalPoints = 0;
            double totalCredits = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    int credits = Convert.ToInt32(row.Cells[2].Value);
                    int gradePoint = Convert.ToInt32(row.Cells[3].Value);

                    totalPoints += credits * gradePoint;
                    totalCredits += credits;
                }
            }

            double predictedGPA = (totalPoints + (gp * remainingCredits)) / (totalCredits + remainingCredits);

            lblPredictedGPA.Text = predictedGPA.ToString("0.00");
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }




        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            txtSubject.Clear();
            txtCredits.Clear();
            cmbGrade.SelectedIndex = -1;

            txtPrevCGPA.Clear();
            txtPrevCredits.Clear();

            cmbExpectedGrade.SelectedIndex = -1;
            txtRemainingCredits.Clear();

            lblSGPA.Text = "0.00";
            lblCredits.Text = "0";
            lblPerformance.Text = "-";
            lblHighest.Text = "-";
            lblLowest.Text = "-";
            lblCGPA.Text = "0.00";
            lblPredictedGPA.Text = "0.00";
        }

private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}