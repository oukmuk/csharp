using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Timers; 

namespace AddrBook
{
    public partial class FrmDataGridView : Form
    {
        public FrmDataGridView()
        {
            InitializeComponent();
        }

        private OleDbConnection localConn;
        private DataSet ds;
        private OleDbDataAdapter adapter;
        private OleDbTransaction tran;
        OleDbCommandBuilder cb; 

        private void FrmDataGridView_Load(object sender, EventArgs e)
        {
            try
            {
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Interval = 60 * 1000;
                timer.Elapsed += new ElapsedEventHandler(SetGrid);
                timer.Start();

                LoadData();

                dataGrid1.Columns[dataGrid1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGrid1.Columns[0].HeaderText = "이름";
                dataGrid1.Columns[1].HeaderText = "성별";
                dataGrid1.Columns[2].HeaderText = "주소";
                dataGrid1.Columns[2].Width = 180;
                dataGrid1.Columns[3].HeaderText = "전화번호";
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.ToString());
                Log.WriteLine("frmDataGridView", e1.ToString());
            }
            finally
            {
                localConn.Close(); 
            }
        }

        private void LoadData()
        {
            try
            {
                string sql = "select * from addrbook";

                localConn = Common_DB.DBConnection();
                localConn.Open();
                adapter = new OleDbDataAdapter(sql, localConn);
                cb = new OleDbCommandBuilder(adapter);

                adapter.DeleteCommand = cb.GetDeleteCommand();
                adapter.InsertCommand = cb.GetInsertCommand();
                adapter.UpdateCommand = cb.GetUpdateCommand();

                ds = new DataSet();
                adapter.Fill(ds, "ADDRBOOK");

                dataGrid1.DataSource = ds.Tables["ADDRBOOK"];
            }
            catch(Exception e1)
            {
                MessageBox.Show("주소 저장 오류 " + e1.ToString());
                Log.WriteLine("frmDatagridview", e1.ToString());
            }
            finally
            {
                localConn.Close();
            }
        }

        delegate void SetGridDeligate(object sender, EventArgs e);

        public void SetGrid(object sender, EventArgs e)
        {
            if(this.dataGrid1.InvokeRequired)
            {
                SetGridDeligate d = new SetGridDeligate(btnRefresh_Click);
                this.Invoke(d, new object[] { sender, e });

            }
            else
            {
                btnRefresh_Click(sender, e);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
