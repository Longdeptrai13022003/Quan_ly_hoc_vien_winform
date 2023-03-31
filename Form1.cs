using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_hoc_vien
{
    public partial class frmMain : Form
    {
        int count = 1;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(count.ToString());
            item.Name = txtMSV.Text;
            item.SubItems.Add(txtMSV.Text);
            item.SubItems.Add(txtName.Text);
            if (!lstvA.Items.ContainsKey(item.Name))
            {
                if (!lstvB.Items.ContainsKey(item.Name))
                {
                    lstvA.Items.Add(item);
                    count++;
                    txtMSV.Clear();
                    txtName.Clear();
                    txtMSV.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã sinh viên đã tồn tại", "Thông báo");
                txtMSV.Clear();
                txtName.Clear();
                txtMSV.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOneRight_Click(object sender, EventArgs e)
        {
            if (lstvA.SelectedItems.Count > 0)
            {
                for(int i=0; i < lstvA.SelectedItems.Count; i++)
                {
                    ListViewItem item = new ListViewItem(lstvA.SelectedItems[i].SubItems[0].Text);
                    item.SubItems.Add(lstvA.SelectedItems[i].SubItems[1].Text);
                    item.SubItems.Add(lstvA.SelectedItems[i].SubItems[2].Text);
                    lstvB.Items.Add(item);
                }
                for(int i=lstvA.SelectedItems.Count-1; i>=0; i--)
                {
                    lstvA.Items.Remove(lstvA.SelectedItems[i]);
                }
            }
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            for(int i=0; i < lstvA.Items.Count; i++)
            {
                ListViewItem item = new ListViewItem(lstvA.Items[i].SubItems[0].Text);
                item.SubItems.Add(lstvA.Items[i].SubItems[1].Text);
                item.SubItems.Add(lstvA.Items[i].SubItems[2].Text);
                lstvB.Items.Add(item);
            }
            for (int i = lstvA.Items.Count - 1; i >= 0; i--)
            {
                lstvA.Items.Remove(lstvA.Items[i]);
            }
        }

        private void btnOneLeft_Click(object sender, EventArgs e)
        {
            if (lstvB.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lstvB.SelectedItems.Count; i++)
                {
                    ListViewItem item = new ListViewItem(lstvB.SelectedItems[i].SubItems[0].Text);
                    item.SubItems.Add(lstvB.SelectedItems[i].SubItems[1].Text);
                    item.SubItems.Add(lstvB.SelectedItems[i].SubItems[2].Text);
                    lstvA.Items.Add(item);
                }
                for (int i = lstvB.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lstvB.Items.Remove(lstvB.SelectedItems[i]);
                }
            }
        }

        private void btnAllLeft_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstvB.Items.Count; i++)
            {
                ListViewItem item = new ListViewItem(lstvB.Items[i].SubItems[0].Text);
                item.SubItems.Add(lstvB.Items[i].SubItems[1].Text);
                item.SubItems.Add(lstvB.Items[i].SubItems[2].Text);
                lstvA.Items.Add(item);
            }
            for (int i = lstvB.Items.Count - 1; i >= 0; i--)
            {
                lstvB.Items.Remove(lstvB.Items[i]);
            }
        }

        private void txtSearchA_TextChanged(object sender, EventArgs e)
        {
            for(int i=0; i < lstvA.Items.Count; i++)
            {
                lstvA.Items[i].BackColor = Color.White;
                if (txtSearchA.Text.ToLower() == lstvA.Items[i].SubItems[2].Text.ToLower())
                {
                    lstvA.Items[i].BackColor = Color.Yellow;
                }
            }
        }

        private void txtSearchB_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lstvB.Items.Count; i++)
            {
                lstvB.Items[i].BackColor = Color.White;
                if (txtSearchB.Text.ToLower() == lstvB.Items[i].SubItems[2].Text.ToLower())
                {
                    lstvB.Items[i].BackColor = Color.Yellow;
                }
            }
        }
    }
}
