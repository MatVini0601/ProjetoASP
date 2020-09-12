using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3D3309.DTO
{
    public class DTOMusica
    {

        private string nome, nomeAutor;
        private int idGravadora, idCD, idMusica;

        public string Nome 
        {

            set 
            {

                if (value != String.Empty) this.nome = value;
                else throw new Exception("Nome não pode ser vazio");
            
            }
            get { return this.nome; }

        }
        public string NomeAutor 
        {

            set
            {
                if (value != String.Empty) this.nomeAutor = value;
                else throw new Exception("Nome do autor não pode ser vazio");
            }
            get { return this.nomeAutor; }
        
        }
        public int IdGravadora { get => idGravadora; set => idGravadora = value; }
        public int IdCD { get => idCD; set => idCD = value; }
        public int IdMusica { get => idMusica; set => idMusica = value; }
    }
}