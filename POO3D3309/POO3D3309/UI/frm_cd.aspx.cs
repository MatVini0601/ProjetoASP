using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using POO3D3309.BLL;
using POO3D3309.DTO;

namespace POO3D3309.UI
{
    public partial class frm_cd : System.Web.UI.Page
    {
        private DTOCD DTOcd = new DTOCD();
        private BLLCD BLLcd = new BLLCD();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                this.ExibirGrid();
            }
        }

        public void ExibirGrid()
        {
            GridCD.DataSource = BLLcd.ListCD();
            GridCD.DataBind();
        }

        protected void btnListar(object sender, EventArgs e)
        {
            try
            {
                DTOcd.NomeCD = txt_nome.Text;
                DTOcd.PrecoVenda = double.Parse(txt_preco.Text);
                DTOcd.DtLancamento = DateTime.Parse(dt_data.Text);
                BLLcd.InsertCD(DTOcd);
                this.ExibirGrid();
            }
            catch (Exception err)
            {

                Response.Write($"<script language=javascript>alert('{err.Message}');</script>");
            
            }
            
        }

        protected void DeleteRow(object sender, GridViewDeleteEventArgs args)
        {
            try
            {
                DTOcd.IdCD = Convert.ToInt32(args.Values[0]);
                BLLcd.DeleteCD(DTOcd);
                this.ExibirGrid();
            }
            catch (Exception ex)
            {
                Response.Write($"<script language=javascript>alert('{ex.Message}');</script>");
            }
        }
         

        protected void EditingRow(object sender, GridViewEditEventArgs args)
        {
            GridCD.EditIndex = args.NewEditIndex;
            this.ExibirGrid();
        }

        protected void UpdatingRow(object sender, GridViewUpdateEventArgs args)
        {
            try
            {
                DTOcd.IdCD = int.Parse(args.NewValues[0].ToString());
                DTOcd.NomeCD = args.NewValues[1].ToString();
                DTOcd.PrecoVenda = double.Parse(args.NewValues[2].ToString());
                BLLcd.UpdateCD(DTOcd);
                GridCD.EditIndex = -1;
                this.ExibirGrid();
            }
            catch (Exception ex)
            {
                Response.Write($"<script language=javascript>alert('{ex.Message}');</script>");
            }
        }

        protected void CancelEditing(object sender, GridViewCancelEditEventArgs e)
        {
            GridCD.EditIndex = -1;
            this.ExibirGrid();
        }

        protected void PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridCD.PageIndex = e.NewPageIndex;
            this.ExibirGrid();
        }
    }
}