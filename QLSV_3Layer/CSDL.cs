using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3Layer
{
    class CSDL
    {
        public DataTable DTSV { get; set; }
        public DataTable DTLSH { get; set; }
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private static CSDL _Instance;
        private CSDL()
        {
            DTSV = new DataTable();
            DTSV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn( "StudentID", typeof(string)),
                new DataColumn( "Name", typeof(string)),
                new DataColumn( "Gender", typeof(bool)),
                new DataColumn( "DateOfBirth", typeof(DateTime)),
                new DataColumn( "ClassID", typeof(int))
            });
            DataRow dr = DTSV.NewRow();
            dr["StudentID"] = "101";
            dr["Name"] = "NVA";
            dr["Gender"] = true;
            dr["DateOfBirth"] = DateTime.Now;
            dr["ClassID"] = 1;
            DTSV.Rows.Add(dr);

            DataRow dr1 = DTSV.NewRow();
            dr1["StudentID"] = "102";
            dr1["Name"] = "NVB";
            dr1["Gender"] = false;
            dr1["DateOfBirth"] = DateTime.Now;
            dr1["ClassID"] = 1;
            DTSV.Rows.Add(dr1);

            DataRow dr2 = DTSV.NewRow();
            dr2["StudentID"] = "103";
            dr2["Name"] = "NVC";
            dr2["Gender"] = true;
            dr2["DateOfBirth"] = DateTime.Now;
            dr2["ClassID"] = 2;
            DTSV.Rows.Add(dr2);

            DataRow dr6 = DTSV.NewRow();
            dr6["StudentID"] = "106";
            dr6["Name"] = "NVC";
            dr6["Gender"] = true;
            dr6["DateOfBirth"] = DateTime.Now;
            dr6["ClassID"] = 1;
            DTSV.Rows.Add(dr6);

            DataRow dr7 = DTSV.NewRow();
            dr7["StudentID"] = "107";
            dr7["Name"] = "NVD";
            dr7["Gender"] = false;
            dr7["DateOfBirth"] = DateTime.Now;
            dr7["ClassID"] = 1;
            DTSV.Rows.Add(dr7);

            DTLSH = new DataTable();
            DTLSH.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ClassID", typeof(int)),
                new DataColumn("ClassName", typeof(string)),
            });
            DataRow dr3 = DTLSH.NewRow();
            dr3["ClassID"] = 1;
            dr3["ClassName"] = "LSH1";
            DTLSH.Rows.Add(dr3);
            DataRow dr4 = DTLSH.NewRow();
            dr4["ClassID"] = 2;
            dr4["ClassName"] = "LSH2";
            DTLSH.Rows.Add(dr4);
        }
    }
}
