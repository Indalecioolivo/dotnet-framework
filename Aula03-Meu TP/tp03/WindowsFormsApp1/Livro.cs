using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Livro
    {
        private String titulo;
        private String autor;
        private String editora;
        private String anoedicao;
        private String local;

        public void setTitulo(String _titulo)
        {
            titulo = _titulo;
        }
        public void setAutor(String _autor)
        {
            autor = _autor;
        }
        public void setEditora(String _editora)
        {
            editora = _editora;
        }
        public void setAnoEdicao(String _anoedicao)
        {
            anoedicao = _anoedicao;
        }
        public void setLocal(String _local)
        {
            local = _local;
        }

        public String getTitulo()
        {
            return titulo;
        }
        public String getAutor()
        {
            return autor;
        }
        public String getEditora()
        {
            return editora;
        }
        public String getAnoEdicao()
        {
            return anoedicao;
        }
        public String getLocal()
        {
            return local;
        }

        public void resetPropriedades()
        {
            setTitulo("");
            setAutor("");
            setEditora("");
            setAnoEdicao("");
            setLocal("");
        }
    }
}
