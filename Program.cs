using System;

public class Aviao
{
    public string Modelo { get; private set; }
    public string Motor { get; private set; }
    public int NumeroAssentos { get; private set; }
    public string TipoNavegacao { get; private set; }
    public int AutonomiaVoo { get; private set; }

    public Aviao(string modelo, string motor, int numeroAssentos, string tipoNavegacao, int autonomiaVoo)
    {
        Modelo = modelo;
        Motor = motor;
        NumeroAssentos = numeroAssentos;
        TipoNavegacao = tipoNavegacao;
        AutonomiaVoo = autonomiaVoo;
    }

    public override string ToString()
    {
        return $"Avião {Modelo} com motor {Motor}, {NumeroAssentos} assentos, " +
               $"navegação {TipoNavegacao} e autonomia de voo de {AutonomiaVoo} horas.";
    }
}

public class AviaoBuilder
{
    private string _modelo;
    private string _motor;
    private int _numeroAssentos;
    private string _tipoNavegacao;
    private int _autonomiaVoo;

    public AviaoBuilder(string modelo)
    {
        _modelo = modelo;
    }

    public AviaoBuilder SetMotor(string motor)
    {
        _motor = motor;
        return this;
    }

    public AviaoBuilder SetNumeroAssentos(int numeroAssentos)
    {
        _numeroAssentos = numeroAssentos;
        return this;
    }

    public AviaoBuilder SetTipoNavegacao(string tipoNavegacao)
    {
        _tipoNavegacao = tipoNavegacao;
        return this;
    }

    public AviaoBuilder SetAutonomiaVoo(int autonomiaVoo)
    {
        _autonomiaVoo = autonomiaVoo;
        return this;
    }

    public Aviao Build()
    {
        return new Aviao(_modelo, _motor, _numeroAssentos, _tipoNavegacao, _autonomiaVoo);
    }
}
class Program
{
    static void Main()
    {
        Aviao aviaoComercial = new AviaoBuilder("Comercial")
            .SetMotor("Turbofan")
            .SetNumeroAssentos(180)
            .SetTipoNavegacao("GPS Avançado")
            .SetAutonomiaVoo(10)
            .Build();

        Console.WriteLine(aviaoComercial);

        Aviao aviaoCarga = new AviaoBuilder("Carga")
            .SetMotor("Turboélice")
            .SetNumeroAssentos(2)
            .SetTipoNavegacao("Navegação Padrão")
            .SetAutonomiaVoo(8)
            .Build();

        Console.WriteLine(aviaoCarga);

        Aviao aviaoPrivado = new AviaoBuilder("Privado")
            .SetMotor("Jato")
            .SetNumeroAssentos(10)
            .SetTipoNavegacao("Navegação VIP")
            .SetAutonomiaVoo(6)
            .Build();

        Console.WriteLine(aviaoPrivado);
    }
}