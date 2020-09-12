using POO3D3309.DAL;
using POO3D3309.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace POO3D3309.BLL
{
    public class BLLCD
    {

        private DatabaseConnection DALBanco = new DatabaseConnection();

        public DataTable ListCD()
        {
            string query = string.Format($@"SELECT idCd as ID , nomeCD as Nome, precoVenda as Preço, dtLancamento as Lançamento FROM TBL_CD;");
            return DALBanco.ExecuteQuery(query);
        }

        public void InsertCD(DTOCD DTOCd)
        {
            string cmd = string.Format($@"INSERT INTO TBL_CD VALUES(NULL, '{DTOCd.NomeCD}', 
                                                                          '{DTOCd.PrecoVenda}',
                                                                          '{DTOCd.DtLancamento.ToString("yyyy/MM/dd HH:mm:ss")}');");
            DALBanco.ExecuteQuery(cmd);
        }

        public void DeleteCD(DTOCD DTOCd)
        {
            string cmd = string.Format($@"DELETE FROM TBL_CD WHERE idCD = '{DTOCd.IdCD}'");
            DALBanco.ExecuteQuery(cmd);
        }

        public void UpdateCD(DTOCD DTOCd)
        {
            string cmd = string.Format($@"UPDATE TBL_CD SET nome = '{DTOCd.NomeCD}',
                                                            precoVenda = '{DTOCd.PrecoVenda}
                                                            'WHERE idCD = '{DTOCd.IdCD}'");
            DALBanco.ExecuteQuery(cmd);

        }
    }
}