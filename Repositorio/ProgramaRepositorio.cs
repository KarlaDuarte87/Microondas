using Microondas_Digital.Data;
using Microondas_Digital.Models;

namespace Microondas_Digital.Repositorio
{
    public class ProgramaRepositorio : IProgramaRepositorio
    {

        private readonly BancoContext _bancoContext;
        public ProgramaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public Programas ListarPorId(int id)
        {
            return _bancoContext.Programas.FirstOrDefault(x => x.Id == id);
        }
        public List<Programas> BuscarTodos()
        {
            return _bancoContext.Programas.ToList();
        }

        public Programas Adicionar(Programas programa)
        {
            _bancoContext.Programas.Add(programa);
            _bancoContext.SaveChanges();
            return programa;
        }

        public Programas Atualizar(Programas programa)
        {
            Programas programaDB = ListarPorId(programa.Id);

            if (programaDB == null) throw new System.Exception("Houve um erro na atualização do programa!");
            if (programaDB.Customizado == false) throw new System.Exception("Não é possíel atualizar programa padrão");
            programaDB.Nome = programa.Nome;
            programaDB.Comida = programa.Comida;
            programaDB.TempoEmSegundos = programa.TempoEmSegundos;
            programaDB.CaracterDeAquecimento = programa.CaracterDeAquecimento;
            programaDB.Potencia = programa.Potencia;
            programaDB.Customizado = true;


            _bancoContext.Programas.Update(programaDB);
            _bancoContext.SaveChanges();

            return programaDB;
        }

        public bool Apagar(int id)
        {
            Programas programaDB = ListarPorId(id);

            if (programaDB == null) throw new System.Exception("Houve um erro ao deletar o programa");


            _bancoContext.Programas.Remove(programaDB);
            _bancoContext.SaveChanges();

            return (true);
        }
    }
}
