using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3D3309.DTO
{
    public class DTOCD
    {

        private int idCD;
        private string nomeCD;
        private double precoVenda;
        private DateTime dtLancamento;

        public int IdCD { get => idCD; set => idCD = value; }
        public string NomeCD 
        {

            set
            {
                if (value != String.Empty) this.nomeCD = value;
                else throw new Exception("Nome do CD não pode ser vazio");
            }
            get { return this.nomeCD; }

        }
        public double PrecoVenda 
        {

            set
            {
                if (value.ToString() != String.Empty) this.precoVenda = value;
                else throw new Exception("Preço de venda não pode ser vazio");
            }
            get { return this.precoVenda; }

        }
        public DateTime DtLancamento
        {
            set
            {
                if (value.ToString() != String.Empty) this.dtLancamento = value;
                else throw new Exception("Data não pode ser vazia");
            }
            get { return this.dtLancamento; }
        
        }
    }
}