using POO3D3309.BLL;
using POO3D3309.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POO3D3309.UI
{
    public partial class frm_musica : System.Web.UI.Page
    {

        BLLMusica BLLMus = new BLLMusica();
        DTOMusica DTOMus = new DTOMusica();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ExibirGrid();
                this.PopulateSelection();
            }
        }

        public void ExibirGrid()
        {
            GridMusica.DataSource = BLLMus.ListSongs();
            GridMusica.DataBind();
        }

        protected void btnListar(object sender, EventArgs e)
        {
            try
            {
                DTOMus.Nome = txt_nome.Text;
                DTOMus.NomeAutor = txt_autor.Text;
                DTOMus.IdGravadora = int.Parse(id_grav.SelectedValue);
                DTOMus.IdCD = int.Parse(id_cd.Text);
                BLLMus.InsertSong(DTOMus);
                this.ExibirGrid();
            }
            catch (Exception err)
            {
                Response.Write($"<script language=javascript>alert('{err.Message}');</script>");
            }

        }

        protected void DeletingRow(object sender, GridViewDeleteEventArgs args)
        {
            try
            {
                DTOMus.IdMusica = Convert.ToInt32(args.Values[0]);
                BLLMus.DeleteSong(DTOMus);
                this.ExibirGrid();
            }
            catch (Exception ex)
            {
                Response.Write($"<script language=javascript>alert('{ex.Message}');</script>");
            }
        }

        protected void EditingRow(object sender, GridViewEditEventArgs args)
        {
            GridMusica.EditIndex = args.NewEditIndex;
            this.ExibirGrid();
        }

        protected void UpdatingRow(object sender, GridViewUpdateEventArgs args)
        {
            try
            {
                DTOMus.IdMusica = int.Parse(args.NewValues[0].ToString());
                DTOMus.Nome = args.NewValues[1].ToString();
                DTOMus.NomeAutor = args.NewValues[2].ToString();
                DTOMus.IdGravadora = int.Parse(args.NewValues[3].ToString());
                DTOMus.IdCD = int.Parse(args.NewValues[4].ToString());
                BLLMus.UpdateSong(DTOMus);
                GridMusica.EditIndex = -1;
                this.ExibirGrid();
            }
            catch (Exception ex)
            {
                Response.Write($"<script language=javascript>alert('{ex.Message}');</script>");
            }
        }

        protected void CancelEditing(object sender, GridViewCancelEditEventArgs e)
        {
            GridMusica.EditIndex = -1;
            this.ExibirGrid();
        }

        protected void PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridMusica.PageIndex = e.NewPageIndex;
            this.ExibirGrid();
        }

        protected void PopulateSelection()
        {
            id_grav.DataSource = BLLMus.RecoverRecorder();
            id_grav.DataTextField = "nome";
            id_grav.DataValueField = "idGravadora";
            id_grav.DataBind();

            id_cd.DataSource = BLLMus.RecoverCD();
            id_cd.DataTextField = "nomeCD";
            id_cd.DataValueField = "idCD";
            id_cd.DataBind();
        }
    }
}