using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProcedure08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        bool isFinished = false;

        public void DisplayProduct()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<TakeAllProductResult> listProduct = (from i in context.TakeAllProduct()
                                                      select i).ToList();
            lsvListProduct.Items.Clear();
            listProduct.ForEach(x =>
            {
                ListViewItem item = new ListViewItem(x.MaSP + "");
                item.SubItems.Add(x.TenSP);
                item.SubItems.Add(x.DonGia + "");
                item.SubItems.Add(x.MaDanhMuc + "");
                lsvListProduct.Items.Add(item);
            });
        }

        public void DisplayItem()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<DanhMuc> listItem = (from i in context.DanhMucs
                                      select i).ToList();
            cbbItem.DataSource = listItem;
            cbbItem.ValueMember = "MaDanhMuc";
            cbbItem.DisplayMember = "TenDanhMuc";
            isFinished = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayProduct();
            DisplayItem();
        }

        private void cbbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFinished == false) return;
            if (cbbItem.SelectedIndex == -1) return;
            byte codeSP = (byte)cbbItem.SelectedValue;
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> listProduct = (from i in context.SanPhams
                                         where i.MaDanhMuc == codeSP
                                         select i).ToList();
            lsvListProduct.Items.Clear();
            listProduct.ForEach(x =>
            {
                ListViewItem item = new ListViewItem(x.MaSP + "");
                item.SubItems.Add(x.TenSP);
                item.SubItems.Add(x.DonGia + "");
                item.SubItems.Add(x.MaDanhMuc + "");
                lsvListProduct.Items.Add(item);
            });
        }

        private void lsvListProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvListProduct.SelectedItems.Count == 0) return;
            ListViewItem listSP = lsvListProduct.SelectedItems[0];
            byte codeSP = Convert.ToByte(listSP.SubItems[0].Text);
            CSDLTestDataContext context = new CSDLTestDataContext();
            SanPham sanpham = (from i in context.SanPhams
                               select i).FirstOrDefault(x => x.MaSP == codeSP);
            if(sanpham != null)
            {
                txtAddCode.Text = sanpham.MaSP + "";
                txtAddName.Text = sanpham.TenSP;
                txtAddCost.Text = sanpham.DonGia + "";
            }
        }

        private void btnTakeAll_Click(object sender, EventArgs e)
        {
            DisplayProduct();
        }

        private void cmtUpdate_Click(object sender, EventArgs e)
        {
            if (lsvListProduct.SelectedItems.Count == 0) return;
            ListViewItem item = lsvListProduct.SelectedItems[0];
            byte codeSP = Convert.ToByte(item.SubItems[0].Text);
            frmUpdateCost frm = new frmUpdateCost();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    float newCost = Convert.ToInt64(frm.txtUpdateCost.Text);
                    CSDLTestDataContext context = new CSDLTestDataContext();
                    context.UpdateCostProduct(codeSP, newCost);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi! \n Chi tiết {ex.Message}");
                }
                finally
                {
                    DisplayProduct();
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                CSDLTestDataContext context = new CSDLTestDataContext();
                byte codeItem = (byte)cbbItem.SelectedValue;
                byte codeProduct = Convert.ToByte(txtAddCode.Text);
                string nameProduct = txtAddName.Text;
                float costProduct = Convert.ToInt64(txtAddCost.Text);
                context.InsertProduct(codeProduct, nameProduct, costProduct, codeItem);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Đã xuất hiện lỗi! \n chi tiết {ex.Message}");
            }
            finally
            {
                DisplayProduct();
            }
            
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult rt = MessageBox.Show($"Có muốn xoá sản phẩm này không?", "Hỏi?",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);
            if(rt == DialogResult.Yes)
            {
                try
                {
                    ListViewItem item = lsvListProduct.SelectedItems[0];
                    byte codeSP = Convert.ToByte(item.SubItems[0].Text);
                    CSDLTestDataContext context = new CSDLTestDataContext();
                    context.DeleteProduct(codeSP);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Đã có lỗi xảy ra! \n chi tiết {ex.Message}");
                }
                finally
                {
                    DisplayProduct();
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            byte findCode = Convert.ToByte(txtCodeProduct.Text);
            CSDLTestDataContext context = new CSDLTestDataContext();
            DetailProductResult result = (from i in context.DetailProduct(findCode)
                                          select i).FirstOrDefault();
            lsvListProduct.Items.Clear();
            if (result != null)
            {
                ListViewItem item = new ListViewItem(result.MaSP + "");
                item.SubItems.Add(result.TenSP);
                item.SubItems.Add(result.DonGia + "");
                item.SubItems.Add(result.MaDanhMuc + "");
                lsvListProduct.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào có mã này");
            }
        }
    }
}
