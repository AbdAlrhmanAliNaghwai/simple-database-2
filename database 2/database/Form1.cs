using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace database
{
    public partial class Form1 : Form
    {

        private string connectstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"week9.accdb\"";

        private OleDbConnection con;

        private int currentRowNo;

        public Form1()
        {
            con = new OleDbConnection(connectstring);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateStudentsGird();

        }

        private void btnstudentadd_Click(object sender, EventArgs e)

        {
            InsertStudent(txtstudentNo.Text, txtstudentfirstname.Text, txtStudentlastname.Text);

            ClearForm();

            UpdateStudentsGird();
        }
        private void UpdateStudentsGird()
        {
            OleDbCommand command = new OleDbCommand("Select * from Table1", con);

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            
            DataTable dt = new DataTable();

            da.Fill(dt);
            

            dataGridView1.DataSource = dt;


        }


        private void InsertStudent(string StudentNo,string Studentfirstname,string Studentlastname)
        
        {
           
            string insertCommand = $"Insert Into Table1([StudentNo],[Student first Name],[Student last Name]) " +
                $"values('{StudentNo}', '{Studentfirstname}', '{Studentlastname}')";

            OleDbCommand command = new OleDbCommand(insertCommand, con);
            

            con.Open();

            command.ExecuteNonQuery();
            

            con.Close();

        }

        private void UpdateStudent(Student student)
        {
            string updateCommand = $"Update Table1 Set studentNo = '{student.StudentNo}', " +
                $"Student first Name = '{student.StudentFirstname}', " +
                $"Student last Name = '{student.StudentLastname}'" +
                $"Where studentID = {student.studentID}";

            OleDbCommand command = new OleDbCommand(updateCommand, con);

            con.Open();

            command.ExecuteNonQuery();

            con.Close();
        }
        private void DeleteStudent(Student student)
        {
            string deleteCommand = $"Delete from Table1 where studentID = {student.studentID}";

            OleDbCommand command = new OleDbCommand(deleteCommand, con);

            con.Open();

            command.ExecuteNonQuery();

            con.Close();
        }
        private void ClearForm()
        {
            txtstudentNo.Text = "";
            txtstudentfirstname.Text = "";
            txtStudentlastname.Text = "";

            txtstudentNo.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            DataGridViewRow currentRow = dataGridView1.Rows[row];

            Student student = new Student();

            student.studentID = int.Parse(currentRow.Cells[0].Value.ToString());
            student.StudentNo = currentRow.Cells[1].Value.ToString();
            student.StudentFirstname = currentRow.Cells[2].Value.ToString();
            student.StudentLastname = currentRow.Cells[3].Value.ToString();

            txtstudentNo.Text = student.StudentNo;
            txtstudentfirstname.Text = student.StudentFirstname;
            txtStudentlastname.Text = student.StudentLastname;

            currentRowNo = student.studentID;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.studentID = currentRowNo;

            student.StudentNo = txtstudentNo.Text;
            student.StudentFirstname = txtstudentfirstname.Text;
            student.StudentLastname = txtStudentlastname.Text;

            UpdateStudent(student);

            ClearForm();

            UpdateStudentsGird();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.studentID = currentRowNo;

            student.StudentNo = txtstudentNo.Text;
            student.StudentFirstname = txtstudentfirstname.Text;
            student.StudentLastname = txtStudentlastname.Text;

            DeleteStudent(student);

            ClearForm();

            UpdateStudentsGird();
        }
    }
}