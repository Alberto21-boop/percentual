using System;

namespace percentual;

public class Program
{
    static void Main(string[] args)
    {
        //4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

        //SP – R$67.836,43
        //RJ – R$36.678,66
        //MG – R$29.229,88
        //ES – R$27.165,48
        //Outros – R$19.849,53

        //Escreva um programa na linguagem que desejar onde calcule o percentual de representação
        //que cada estado teve dentro do valor total mensal da distribuidora.

        Console.WriteLine("Resolvendo a quarta questão");

        double SP, RJ, MG, ES, Outros, Total, PSP, PRJ, PMG, PES, POutros;

        SP = 67.83643;
        RJ = 36.67866;
        MG = 29.22988;
        ES = 27.16548;
        Outros = 19.84953;

        Total = SP + RJ + MG + ES + Outros;

        Console.WriteLine("O valor total do faturamento é de = " + Total.ToString("C"));
        Console.WriteLine();

        PSP = SP * Total / 100;
        PRJ = RJ * Total / 100;
        PMG = MG * Total / 100;
        PES = ES * Total / 100;
        POutros = Outros * Total / 100;

        Console.WriteLine("Agora vamos ver o percentual de cada estado que corresponde ao seu respectivo lucro");
        Console.WriteLine();

        Console.WriteLine("Lucro de São Paulo = R$ 67.836,43 Percentual deste estado é de = " + PSP.ToString("P"));
        Console.WriteLine("Lucro do Rio de Janeiro = R$ 36.678,66 Percentual deste estado é de = " + PRJ.ToString("P"));
        Console.WriteLine("Lucro de Minas Gerais = R$ 29.229,88 Percentual deste estado é de = " + PMG.ToString("P"));
        Console.WriteLine("Lucro de Espirito Santo = R$ 27.165,48 Percentual deste estado é de = " + PES.ToString("P"));
        Console.WriteLine("Lucro de Outros Estados = R$ 19.849,53 Percentual deste estado é de = " + POutros.ToString("P"));

    }
}