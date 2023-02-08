using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH_QLCHDT
{
    public partial class Form1 : Form
    {
        public static String constr = "Data Source=DESKTOP-C2UVAMM\\SQLEXPRESS;Initial Catalog=btl_hsk;Integrated Security=True ";
        Boolean check = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HiendsDT();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private static bool checkDuplicate(string mahang, string madt, string tendt, string soluong, string giaban)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string procname = "kiemtra";
                using (SqlCommand sqlCommand = new SqlCommand(procname, cnn))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@iMahangDT", mahang);
                    sqlCommand.Parameters.AddWithValue("@sMaDT", madt);
                    sqlCommand.Parameters.AddWithValue("@sTenDT", tendt);
                    sqlCommand.Parameters.AddWithValue("@iSoluong", int.Parse(soluong));
                    sqlCommand.Parameters.AddWithValue("@iGiaban", int.Parse(giaban));
                    cnn.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    if (dataReader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        //check query da execute
                        return false;
                    }
                }
            }
        }



        private void HiendsDT()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string procname = "HiendsDT";
                using (SqlCommand cmd = new SqlCommand(procname, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable("tbl_Dienthoai");
                        dataAdapter.Fill(dataTable);
                        DataView dataView = new DataView(dataTable);
                        dgvDienthoai.DataSource = dataView;
                        
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            errorCheck.SetError(tbMahang, "");
            errorCheck.SetError(tbMaDT, "");
            errorCheck.SetError(tbTenDT, "");
            errorCheck.SetError(tbSoluong, "");
            errorCheck.SetError(tbGiaban, "");
            check = true;
            tbMahang.Text = "";
            tbMaDT.Text = "";
            tbTenDT.Text = "";
            tbSoluong.Text = "";
            tbGiaban.Text = "";
            HiendsDT();
        }

        private void tbMahang_Validating(object sender, CancelEventArgs e)
        {
            if (tbMahang.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(tbMahang, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorCheck.SetError(tbMahang, "");
                check = true;
            }
        }

        private void tbMaDT_Validating(object sender, CancelEventArgs e)
        {
            if (tbMaDT.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(tbMaDT, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorCheck.SetError(tbMaDT, "");
                check = true;
            }

        }

        private void tbTenDT_Validating(object sender, CancelEventArgs e)
        {
            if (tbTenDT.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(tbTenDT, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorCheck.SetError(tbTenDT, "");
                check = true;
            }
        }

        private void tbSoluong_Validating(object sender, CancelEventArgs e)
        {
            if (tbSoluong.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(tbSoluong, "Không được bỏ trống");
                check = false;
            }
            else
            { 
                errorCheck.SetError(tbSoluong, "");
                check = true;
            }
        }

        private void tbGiaban_Validating(object sender, CancelEventArgs e)
        {
            if (tbGiaban.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(tbGiaban, "Không được bỏ trống");
                check = false;
            }

            else
            {
                errorCheck.SetError(tbGiaban, "");
                check = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check == true)
            { }
                SqlConnection cnn = new SqlConnection(constr);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"ThemDT";
                
                cmd.Parameters.AddWithValue("@sMaDT", tbMaDT.Text);
                cmd.Parameters.AddWithValue("@imahang", tbMahang.Text);
                cmd.Parameters.AddWithValue("@sTenDT", tbTenDT.Text);
                cmd.Parameters.AddWithValue("@iSoluong", int.Parse(tbSoluong.Text));
                cmd.Parameters.AddWithValue("@iGiaban", int.Parse(tbGiaban.Text));
                
                if (checkDuplicate(tbMahang.Text, tbMaDT.Text, tbTenDT.Text, tbSoluong.Text, tbGiaban.Text))
                {
                    MessageBox.Show("Sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HiendsDT();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String madt = dgvDienthoai.CurrentRow.Cells["sMaDT"].Value.ToString();
            SqlConnection cnn = new SqlConnection(constr);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = @"SuathongtinDT";
            cmd.Parameters.AddWithValue("@sMaDT", madt);
            cmd.Parameters.AddWithValue("@iMahangDT", tbMahang.Text);
            cmd.Parameters.AddWithValue("@sTenDT", tbTenDT.Text);
            cmd.Parameters.AddWithValue("@iSoluong", int.Parse(tbSoluong.Text));
            cmd.Parameters.AddWithValue("@iGiaban", int.Parse(tbGiaban.Text));
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HiendsDT();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                String madt = dgvDienthoai.CurrentRow.Cells["sMaDT"].Value.ToString();
                SqlConnection cnn = new SqlConnection(constr);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"XoaDT";
                cmd.Parameters.AddWithValue("@sMaDT", madt);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HiendsDT();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
