using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1.Model
{
    internal class ModelTarefa
    {
        //public int Id { get; set; }
        public string Titulo { get; set; }
        public string? Conteudo { get; set; }

        public ModelTarefa(string titulo, string conteudo)
        {
            Titulo = titulo;
            Conteudo = conteudo;
        }

        public override string ToString()
        {
            return $"Titulo: {Titulo}";
        }
    }
}
