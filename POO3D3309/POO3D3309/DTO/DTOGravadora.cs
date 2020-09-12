using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3D3309.DTO
{
    public class DTOGravadora
    {

        private string nome;
        private int idGravadora;

        public string Nome 
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else 
                {
                    throw new Exception("Nome não pode ser vazio");
                } 
            }
            get { return this.nome; }
        }

        public int IdGravadora { get => idGravadora; set => idGravadora = value; }
    }
}