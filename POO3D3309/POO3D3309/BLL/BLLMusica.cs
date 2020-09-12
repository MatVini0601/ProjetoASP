using POO3D3309.DAL;
using POO3D3309.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace POO3D3309.BLL
{
    public class BLLMusica
    {
        private DatabaseConnection DALBanco = new DatabaseConnection();

        public DataTable ListSongs()
        {
            string query = string.Format($@"SELECT idMusica as ID , nome as Nome, nomeAutor as Autor, idGravadora as Gravadora, idCD as CD FROM TBL_Musica;");
            return DALBanco.ExecuteQuery(query);
            
        }

        public DataTable RecoverRecorder()
        {
            string cmd = string.Format($@"SELECT * from TBL_Gravadora");
            return DALBanco.ExecuteQuery(cmd);
        }

        public DataTable RecoverCD()
        {
            string cmd = string.Format($@"SELECT * from TBL_CD");
            return DALBanco.ExecuteQuery(cmd);
        }

        public void InsertSong(DTOMusica DTOMus)
        {
            string cmd = string.Format($@"INSERT INTO TBL_Musica VALUES(NULL,'{DTOMus.Nome}','{DTOMus.NomeAutor}','{DTOMus.IdGravadora}','{DTOMus.IdCD}');");
            DALBanco.ExecuteQuery(cmd);
        }

        public void DeleteSong(DTOMusica DTOMus)
        {
            string cmd = string.Format($@"DELETE from TBL_Musica where idMusica = {DTOMus.IdMusica};");
            DALBanco.ExecuteQuery(cmd);
        }

        public void UpdateSong(DTOMusica DTOMus)
        {
            string cmd = string.Format($@"UPDATE TBL_Musica SET nome = '{DTOMus.Nome}', nomeAutor = '{DTOMus.NomeAutor}', idGravadora = {DTOMus.IdGravadora}, idCD = {DTOMus.IdCD} WHERE idMusica = {DTOMus.IdMusica};");
            DALBanco.ExecuteQuery(cmd);

        }
    }
}