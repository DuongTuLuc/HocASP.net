using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebQLDaoTao.Models;

namespace WebQLDaoTao
{
    public partial class QLMonhoc : System.Web.UI.Page
    {
        MonHocDAO mhDAO = new MonHocDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                LienKetDuLieu();
            }
        }

        private void LienKetDuLieu()
        {
            gvMonHoc.DataSource = mhDAO.getAll();
            gvMonHoc.DataBind();
        }

        protected void gvMonHoc_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // Chuyển trạng thái từ ReadOnly -> edit
            gvMonHoc.EditIndex = e.NewEditIndex;
            LienKetDuLieu();
        }

        protected void gvMonHoc_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Chuyển trạng thái từ edit -> Readonly
            gvMonHoc.EditIndex = -1;
            LienKetDuLieu();
        }

        protected void gvMonHoc_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //b1. lấy thông tin môn học
            //b1.1 lấy thông tin dòng hiện hành
            string mamh = gvMonHoc.DataKeys[e.RowIndex].Value.ToString();
            string tenmh = ((TextBox)gvMonHoc.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            int sotiet = int.Parse(((TextBox)gvMonHoc.Rows[e.RowIndex].Cells[2].Controls[0]).Text);
            //b1.2 gọi phương thức cập nhật của lớp DAO
            //b2 chuyển trạng thái từ edit sang ReadOnly
            gvMonHoc.EditIndex = -1;
            LienKetDuLieu();
        }
    }
}