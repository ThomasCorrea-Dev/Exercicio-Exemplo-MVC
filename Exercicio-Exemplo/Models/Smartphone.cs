namespace Exercicio_Exemplo.Models
{
    public class Smartphone : DispositivoEletronico
    {
        public bool Tem5G {  get; set; }
        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoDeFabricacao}, SO: {(Tem5G? "Sim" : "Não")} ";
        }
    }
}
