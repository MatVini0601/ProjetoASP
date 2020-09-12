using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using POO3D3309.BLL;
using POO3D3309.DTO;

namespace POO3D3309.UI
{
    public partial class frm_gravadora : System.Web.UI.Page
    {

        private DTOGravadora DTOGrav = new DTOGravadora();
        private BLLGravadora BLLGrav = new BLLGravadora();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                this.ExibirGrid();
            }
        }

        public void ExibirGrid()
        {
            GridGravadora.DataSource = BLLGrav.ListRecorder();
            GridGravadora.DataBind();
        }

        protected void btnConsulta(object sender, EventArgs e)
        {
            try
            {
                DTOGrav.Nome = txt_nome.Text;
                BLLGrav.InsertRecorder(DTOGrav);
                this.ExibirGrid();
            }
            catch(Exception err)
            {
                Response.Write($"<script language=javascript>alert('{err.Message}');</script>");
            }
            
        }

        protected void DeleteRow(object sender, GridViewDeleteEventArgs args)
        {
            try
            {
                DTOGrav.IdGravadora = Convert.ToInt32(args.Values[0]);
                BLLGrav.DeleteRecorder(DTOGrav);
                this.ExibirGrid();
            }
            catch (Exception ex)
            {
                Response.Write($"<script language=javascript>alert('{ex.Message}');</script>");
            }
        }

        protected void EditingRow(object sender, GridViewEditEventArgs args)
        {
            GridGravadora.EditIndex = args.NewEditIndex;
            this.ExibirGrid();
        }

        protected void UpdatingRow(object sender, GridViewUpdateEventArgs args)
        {
            try
            {
                DTOGrav.IdGravadora = int.Parse(args.NewValues[0].ToString());
                DTOGrav.Nome = args.NewValues[1].ToString();
                BLLGrav.UpdateRecorder(DTOGrav);
                GridGravadora.EditIndex = -1;
                this.ExibirGrid();
            }
            catch (Exception ex)
            {
                Response.Write($"<script language=javascript>alert('{ex.Message}');</script>");
            }
        }

        protected void CancelEditing(object sender, GridViewCancelEditEventArgs e)
        {
            GridGravadora.EditIndex = -1;
            this.ExibirGrid();
        }

        protected void PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridGravadora.PageIndex = e.NewPageIndex;
            this.ExibirGrid();
        }
    }
}