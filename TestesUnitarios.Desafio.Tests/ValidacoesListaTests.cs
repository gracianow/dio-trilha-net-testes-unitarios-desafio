using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var contemNumero10 = lista.Contains(numeroParaProcurar);

        // Assert
        Assert.False(contemNumero10, "A lista não deve conter o número 10.");
    }

    [Fact]
public void DeveMultiplicarOsElementosDaListaPor2()
{
    // Arrange
    var lista = new List<int> { 5, 7, 8, 9 };
    var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

    // Act
    var resultadoCalculado = lista.Select(x => x * 2).ToList();

    // Assert
    Assert.Equal(resultadoEsperado, resultadoCalculado);
}


[Fact]
public void DeveRetornar9ComoMaiorNumeroDaLista()
{
    // Arrange
    var lista = new List<int> { 5, -1, -8, 9 };

    // Act
    var maiorNumero = lista.Max();

    // Assert
    Assert.Equal(9, maiorNumero);
}


    [Fact]
public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
{
    // Arrange
    var lista = new List<int> { 5, -1, -8, 9 };

    // Act
    var menorNumero = lista.Min();

    // Assert
    Assert.Equal(-8, menorNumero);
}

}
