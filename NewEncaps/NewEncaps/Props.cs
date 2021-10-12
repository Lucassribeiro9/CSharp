using System;
using System.Collections.Generic;
using System.Text;

namespace NewEncaps
{
    class Props
    {
        private string _nome;
        public int Quantidade {private get; set; }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public Props()
        {

        }
    }
}
