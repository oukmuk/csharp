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

namespace AddrBook
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private OleDbConnection localConn;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OleDbDataReader myReader;
            string sql = null;

            try
            {
                localConn = Common_DB.DBConnection();
                localConn.Open();

                if (txtID.Text == "" || txtPWD.Text == "")
                {
                    MessageBox.Show("ID 또는 PWD를 입력하세요");
                }

                sql = "select pwd from member";
                sql += " where id=" + "'" + txtID.Text + "'";

                myReader = Common_DB.DataSelect(sql, localConn);

                if (myReader.Read())
                {
                    if (txtPWD.Text != myReader["pwd"].ToString())
                    {
                        MessageBox.Show("pwd가 맞지 않습니다");
                        return; 
                    }
                }
                else
                {
                    MessageBox.Show("ID가 맞지 않습니다");
                    return;
                }

                FrmMDIMain m = new FrmMDIMain();
                m.Show();

                this.Hide();
                Log.WriteLine("frmlogin", "[login :" + txtID.Text + "]");
            }
            catch(Exception e1)
            {
                Log.WriteLine("frmlogin", e1.ToString());
                Log.WriteLine("frmlogin", sql);
                MessageBox.Show("frmlogin", "로그인 오류 : " + sql);
            }
        }
    }
}
