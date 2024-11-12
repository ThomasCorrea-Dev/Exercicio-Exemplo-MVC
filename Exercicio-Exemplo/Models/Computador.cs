namespace Exercicio_Exemplo.Models
{
    public class Computador : DispositivoEletronico 
    {
        public bool EhLaptop { get; set; }
        public int MemoriaRAM { get; set; }
        public string SistemaOperacional { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoDeFabricacao}, SO: {SistemaOperacional}";          
        }
    }
}
