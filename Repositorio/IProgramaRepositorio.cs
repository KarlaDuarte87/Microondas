using Microondas_Digital.Models;


namespace Microondas_Digital.Repositorio

{
    public interface IProgramaRepositorio
    {
        Programas ListarPorId(int id);
        List<Programas> BuscarTodos();
        Programas Adicionar(Programas programa);
        Programas Atualizar(Programas programa);

        bool Apagar(int id);
    }
}
