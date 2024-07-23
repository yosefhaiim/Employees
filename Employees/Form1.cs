using Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class Form1 : Form
    {
        Employee[] employees;
        public Form1()
        {
            InitializeComponent();
        }

        private string status
        {
            get
            {
                foreach (Control ctr in panelStatus.Controls)
                {
                    if (ctr is RadioButton)
                    {
                        if (((RadioButton)ctr).Checked)
                        {
                            return ctr.Text;
                        }
                    }
                }
                return "";
            }
            set
            {
                foreach (Control ctr in panelStatus.Controls)
                {
                    if (ctr is RadioButton && ctr.Text == value)
                    {
                        ((RadioButton)ctr).Checked = true;
                    }
                }
            }


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void woman_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWoman.Checked)
            {
                rdbSingle.Text = "רווקה";
                rdbMereed.Text = "נשואה";
                rdbWidow.Text = "אלמנה";
                rdbTheWorse.Text = "גרושה";
            }
            else if (rdbWoman.Checked == false)
            {
                rdbSingle.Text = "רווק";
                rdbMereed.Text = "נשוי";
                rdbWidow.Text = "אלמן";
                rdbTheWorse.Text = "גרוש";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee1 = new Employee(
                int.Parse(txtCode.Text),
                txtId.Text,
                txtFirstName.Text,
                txtLastName.Text,
                dtpDateOfBirthday.Value,
                rdbMan.Checked,
                status,
                txtCelphon.Text,
                txtTelephon.Text,
                txtCity.Text,
                txtStreet.Text,
                txtNumber.Text
                );
            MessageBox.Show("welcome " + employee1.FirstName);

            AddEmployeeToArray(employee1);


        }
        private void AddEmployeeToArray(Employee employee)
        {
            if (employees == null)
            {
                employees = new Employee[1];
            }
            else
            {
                Employee[] temp = new Employee[employees.Length + 1];
                for (int i = 0; i < employees.Length; i++)
                {
                    temp[i] = employees[i];
                }
                employees = temp;
            }
            employees[employees.Length - 1] = employee;

        }
        // לסדר את הגיל, את הרענון,חיפוש לפי תעודת זהות, את המחיקה, חזרה אחוקה ואחד קדימה

        // תרגיל

        //public bool FindNumber(int[] arr ,int number)
        //{
        //  for (int i = 0; i < arr.Length; i++)
        //{
        //  if (arr[i] == number)
        //{ return true; }
        //    }
        //  return false;
        //}

        private void panelGander_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFindByCode_Click(object sender, EventArgs e)
        {
            int result = 0;
            bool isValid = false;
            while (isValid == false)
            {

                isValid = int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("הכנס קוד עובד, חיפוש לפי קוד עובד"), out result);
            }
            Employee selectEmployee = SearchEmployeeByCode(result);
            ShowEmployee((selectEmployee));

        }
        private void ShowEmployee(Employee employee)
        {
            if (employee == null)
            {
                MessageBox.Show("לא נמצא עובד להצגה");
            }
            else
            {
                txtAge.Text = employee.Age.ToString();
                txtCelphon.Text = employee.CelPhone;
                txtCity.Text = employee.City;
                txtCode.Text = employee.Code.ToString();
                txtFirstName.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
                txtId.Text = employee.ID;
                txtNumber.Text = employee.Number;
                txtStreet.Text = employee.Street;
                txtTelephon.Text = employee.Telephon;
                dtpDateOfBirthday.Value = employee.Birthday;
                if (employee.IsMale)
                {
                    rdbMan.Checked = true;
                }
                else
                {
                    rdbWoman.Checked = true;
                }
                status = employee.Status;
            }
        }

        private Employee SearchEmployeeByCode(int code)
        {
            for (int i = 0; i < employees.Length; i++)
                // אם זה רק לגמרי הוא מציג לי בעיה מכיון שהיא אפשר לרוץ על רשימה ריקה
            {
                if (employees[i].Code == code)
                {
                    return employees[i];
                }
            }
            return null;
        }

        private void ClearFields(Control control)
        {
            foreach (Control ctr in control.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
                if (ctr is RadioButton)
                {
                    ((RadioButton)ctr).Checked = false;
                }
                if (ctr is DateTimePicker)
                {
                    ((DateTimePicker)ctr).Value = DateTime.Now;
                }
                if (ctr is Panel)
                {
                    ClearFields(ctr);
                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields(this);
            if (employees == null)
            {
                txtCode.Text = "1";
            }
            else
            {
                txtCode.Text = (employees[employees.Length - 1].Code + 1).ToString();
            }
        }

        /*  private int txtAge_TextChanged(object sender, EventArgs e)
          {
              int age = today.year - 
          }*/

        private void btnFindById_Click(object sender, EventArgs e)
        {

            int result = 0;
            bool isValid = false;
            while (isValid == false)
            {
                isValid = int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("הכנס תעודת זהות עובד ,חיפוש לפי קוד עובד "), out result);
            }
            Employee selectEmployee = SearchEmployeeById(result.ToString());
            ShowEmployee((selectEmployee));
        }
        private Employee SearchEmployeeById(string id)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].ID == id)
                {
                    return employees[i];
                }
            }
            return null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // מחיקה עובדת מצוין
            for (int i = 0; i < employees.Length; i++)
            {
                {
                    if (employees[i].Code == int.Parse(txtCode.Text))
                    {
                        employees[i] = null;

                        txtAge.Text = null;
                        txtCelphon.Text = null;
                        txtCity.Text = null;
                        txtCode.Text = null;
                        txtFirstName.Text = null;
                        txtLastName.Text = null;
                        txtId.Text = null;
                        txtNumber.Text = null;
                        txtStreet.Text = null;
                        txtTelephon.Text = null;
                        dtpDateOfBirthday.Value = DateTimePicker.;// לסדר את זה להיום;
                        if (employees[i].IsMale)
                        {
                            rdbMan.Checked = true;
                        }
                        else
                        {
                            rdbWoman.Checked = true;
                        }
                        status = employees[i].Status;

                    }
                }
            }
        }

    }
}
