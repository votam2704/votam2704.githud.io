using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3Layer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setCBBClass();
            setCBBSort();
            dataGridView1.DataSource = CSDL_OOP.Instance.getStudents();
        }
        public void setCBBClass()
        {
            cbb_Class.Items.Add(new CBBItems
            {
                Text = "All",
                Value = 0
            });
            foreach(DataRow listClass in CSDL.Instance.DTLSH.Rows)
            {
                cbb_Class.Items.Add(new CBBItems
                {
                    Text = listClass["ClassName"].ToString(),
                    Value = Convert.ToInt32(listClass["ClassID"])
                });
            }
            cbb_Class.SelectedIndex = 0;
        }
        public void setCBBSort()
        {
            int count = 0;
            foreach(DataColumn property in CSDL.Instance.DTSV.Columns)
            {
                cbb_Sort.Items.Add(new CBBItems
                {
                    Text = property.ColumnName,
                    Value = count++
                });
            }
            cbb_Sort.SelectedIndex = 0;
        }
    }
}
