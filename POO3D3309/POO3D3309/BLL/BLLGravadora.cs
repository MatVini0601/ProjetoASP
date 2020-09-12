using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using POO3D3309.DAL;
using POO3D3309.DTO;

namespace POO3D3309.BLL
{
    public class BLLGravadora
    {
        private DatabaseConnection DALBanco = new DatabaseConnection();

        public DataTable ListRecorder()
        {
            string query = string.Format($@"SELECT idGravadora as ID , nome as Nome FROM TBL_gravadora;");
            return DALBanco.ExecuteQuery(query);
        }

        public void InsertRecorder(DTOGravadora DTOGrav)
        {
            string cmd = string.Format($@"INSERT INTO TBL_Gravadora VALUES(NULL, '{DTOGrav.Nome}');");
            DALBanco.ExecuteQuery(cmd);
        }

        public void DeleteRecorder(DTOGravadora DTOGrav)
        {
            string cmd = string.Format($@"DELETE FROM TBL_Gravadora WHERE idGravadora = '{DTOGrav.IdGravadora};'" );
            DALBanco.ExecuteQuery(cmd);
        }

        public void UpdateRecorder(DTOGravadora DTOGrav)
        {
            string cmd = string.Format($@"UPDATE TBL_Gravadora SET nome = '{DTOGrav.Nome}' WHERE idGravadora = '{DTOGrav.IdGravadora};'");
            DALBanco.ExecuteQuery(cmd);
        }
    }
}