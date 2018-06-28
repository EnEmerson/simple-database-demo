# simple-database-demo

---

### Description: This application is meant to store the names and ages of students. The list of students can then be returned for viewing and ordered.

---

![database-pic](https://github.com/EnEmerson/simple-database-demo/blob/master/resources/database-pic.png)

---

## Student class file

```C#

namespace Exam1Retry
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student()
        {
            //default constructor
        }

        public Student(string pFirst, string pLast, int pAge)
        {
            firstName = pFirst;
            lastName = pLast;
            age = pAge;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}

```

---

## Databse code

```C#

namespace Exam1Retry
{
    public partial class Form1 : Form
    {
        List<Student> studentList = new List<Student>();

        private string filePath = @"..\..\Student_Data.txt";

        Button clearButton, sortedButton;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearButton = new Button();
            clearButtonPanel.Controls.Add(clearButton);
            clearButton.Visible = false;
            clearButton.AutoSize = true;
            clearButton.Text = "Clear Data";
            clearButton.Click += new EventHandler(clearButton_Click);

            sortedButton = new Button();
            sortedButtonPanel.Controls.Add(sortedButton);
            sortedButton.Visible = false;
            sortedButton.AutoSize = true;
            sortedButton.Text = "Show Sorted";
            sortedButton.Click += new EventHandler(sortedButton_Click);

        }

        private void sortedButton_Click(object sender, EventArgs e)
        {
            displayDataArea.Items.Clear();

            var query = from person in studentList
                        orderby person.Age ascending
                        select person;

            foreach (Student person in query)
            {
                displayDataArea.Items.Add(person.FirstName + " " +
                    person.LastName + " " + person.Age.ToString());
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            studentList.Clear();
            displayDataArea.Items.Clear();
            File.WriteAllText(filePath, String.Empty);

            showDataButton.Enabled = false;
            clearButton.Visible = false;
            sortedButton.Visible = false;

            MessageBox.Show("Data Cleared.");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string fName = fNameInputBox.Text;
            string lName = lNameInputBox.Text;
            int inputAge;
            int.TryParse(ageInputBox.Text, out inputAge);

            studentList.Add(new Student(fName, lName, inputAge));

            if(!File.Exists(filePath))
            {
                using (StreamWriter dataOutput = File.CreateText(filePath))
                {
                    dataOutput.Write(fName + " " + lName + " " + inputAge + "\r\n");
                    dataOutput.Close();
                }
            }
            else if(File.Exists(filePath))
            {
                using(StreamWriter dataOutput = File.AppendText(filePath))
                {
                    dataOutput.Write(fName + " " + lName + " " + inputAge + "\r\n");
                    dataOutput.Close();
                }
            }

            MessageBox.Show("Saved");
            fNameInputBox.Text = "";
            lNameInputBox.Text = "";
            ageInputBox.Text = "";
            showDataButton.Enabled = true;
        }

        private void showDataButton_Click(object sender, EventArgs e)
        {
            displayDataArea.Items.Clear();

            foreach (Student person in studentList)
            {
                displayDataArea.Items.Add(person.FirstName + " " +
                    person.LastName + " " + person.Age.ToString());
            }

            clearButton.Visible = true;
            sortedButton.Visible = true;
        }
    }
}

```





