using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class LivroBLL
    {
        public static void validarDados(Livro umLivro)
        {
            Error.setError(false);
            if (umLivro.getTitulo().Length == 0)
            {
                Error.setError("Informe o Titulo do livro.");
                return;
            }
            if (umLivro.getAutor().Length == 0)
            {
                Error.setError("Informe o autor.");
                return;
            }
            if (umLivro.getEditora().Length == 0)
            {
                Error.setError("Informe a editora.");
                return;
            }
            if (umLivro.getLocal().Length == 0)
            {
                Error.setError("Informe o local.");
                return;
            }
            if (umLivro.getAnoEdicao().Length != 4)
            {
                Error.setError("O ano deve conter 4 dígitos.");
                return;
            }
            else
            {
                try
                {
                    int.Parse(umLivro.getAnoEdicao());
                }
                catch
                {
                    Error.setError("O ano deve ser numérico.");
                    return;
                }
                if (int.Parse(umLivro.getAnoEdicao()) <= 0)
                {
                    Error.setError("A data nao pode ser menor que 0 ");
                    return;
                }
            }
        }
    }
}
