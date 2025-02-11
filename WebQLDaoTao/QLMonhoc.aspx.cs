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
    }
}