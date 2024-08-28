using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        //TODO: Corrigir a variável "texto" e "resultadoEsperado" da seção Arrange

        // Arrange
        var texto = "a";
        var resultadoEsperado = 0;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

     [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        //TODO: Corrigir a variável "texto" e "resultadoEsperado" da seção Arrange

        // Arrange
        var texto = "a";
        var resultadoEsperado = 0;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        //TODO: Corrigir a chamada do método "ContemCaractere" da seção Act
        // Act
         _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.True com base no retorno da chamada ao método
        Assert.True(true);
    }

    [Fact]
public void NaoDeveConterAPalavraTesteNoTexto()
{
    // Arrange
    var texto = "Esse é um texto qualquer";
    var textoProcurado = "teste";

    // Act
    var contemPalavra = _validacoes.ContemCaractere(texto, textoProcurado);

    // Assert
    Assert.False(contemPalavra);
}


    [Fact]
public void TextoDeveTerminarComAPalavraProcurado()
{
    // Arrange
    var texto = "Começo, meio e fim do texto procurado";
    var textoProcurado = "procurado"; // Corrected the variable

    // Act
    var terminaComPalavra = _validacoes.TextoTerminaCom(texto, textoProcurado);

    // Assert
    Assert.True(terminaComPalavra);
}

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var contemPalavra = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.False(contemPalavra);
    }


    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado"; // Corrected the variable

        // Act
        var terminaComPalavra = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(terminaComPalavra);
    }


    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        // Act
        var contemPalavra = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.True(contemPalavra);
    }


    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var contemPalavra = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.False(contemPalavra);
    }


    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado"; // Corrected the variable

        // Act
        var terminaComPalavra = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(terminaComPalavra);
    }

}
