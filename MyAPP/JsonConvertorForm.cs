using MyLibrary;
using System;
using System.Windows.Forms;

namespace MyAPP
{
    public partial class JsonConvertorForm : Form
    {
        public JsonConvertorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = JsonUtils.GetObject<Employee>(JsonStringtextBox.Text);
            ResulttextBox.Text = employee.ToString();
        }
    }
}
