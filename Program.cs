string tecla = "";
while(tecla != "S")
{
    Console.Clear();

string Letradigitada;

Console.WriteLine("--- Calendário Copa do Mundo 2022 ---");
Console.WriteLine("--- Descubra as datas dos jogos das seleções ---");
Console.WriteLine("--- Digite a tecla * S * PARA sAIR ---");


Console.WriteLine();
Console.WriteLine("-- Grupo A --");
Console.WriteLine("1-Holanda");
Console.WriteLine("2-Equador");
Console.WriteLine("3-Senegal");
Console.WriteLine("4-Qatar");
Console.WriteLine();

Console.WriteLine("-- Grupo B --");
Console.WriteLine("1-Inglaterra");
Console.WriteLine("3-País de Gales");
Console.WriteLine("4-Estados Unidos da América");
Console.WriteLine("5-Irã");
Console.WriteLine();

Console.WriteLine("-- Grupo C --");
Console.WriteLine("1-Argentina");
Console.WriteLine("2-México");
Console.WriteLine("3-Polónia");
Console.WriteLine("4-Arábia Saudita");
Console.WriteLine();

Console.WriteLine("-- Grupo D --");
Console.WriteLine("1-Austrália");
Console.WriteLine("2-Dinamarca");
Console.WriteLine("3-França");
Console.WriteLine("4-Tunísia");
Console.WriteLine();

Console.WriteLine("-- Grupo E-- ");
Console.WriteLine("1-Costa Rica");
Console.WriteLine("2-Alemanha");
Console.WriteLine("3-Japão");
Console.WriteLine("4-Espanha");
Console.WriteLine();

Console.WriteLine("-- Grupo F --");
Console.WriteLine("1-Bélgica");
Console.WriteLine("2-Canadá");
Console.WriteLine("3-Croácia");
Console.WriteLine("4-Marrocos");
Console.WriteLine();

Console.WriteLine("-- Grupo G --");
Console.WriteLine("1-Brasil");
Console.WriteLine("2-Camarões");
Console.WriteLine("3-Sérvia");
Console.WriteLine("4-Suíça");
Console.WriteLine("");

Console.WriteLine("-- Grupo H --");
Console.WriteLine("1-Gana");
Console.WriteLine("2-Portugal");
Console.WriteLine("3-República da Coreia");
Console.WriteLine("4-Uruguai");
Console.WriteLine();

Console.WriteLine("-- Fase Final (I) --");
Console.WriteLine("1-Oitavas de Final");
Console.WriteLine("2-Quartas de Final");
Console.WriteLine("3-Semifinais");
Console.WriteLine("4-Final");
Console.WriteLine();


Console.Write("Digite a letra correspondente a opção...:");
Letradigitada = Console.ReadLine()!.ToUpper();



Console.Write("Agora Digite o número correspodente a opção...: ");
int Numerodigitado = Convert.ToInt16 (Console.ReadLine()!);
Console.WriteLine();

if (Letradigitada.Contains("A") && Numerodigitado == 1)
{
     Console.WriteLine(" Equipe Selecionada: Holanda");
     Console.WriteLine();
    Console.WriteLine(" 1° Rodada - Senegal x Holanda - Segunda - 21/11/2022 -13:00 hrs");
    Console.WriteLine(" 2º Rodada - Holanda x Equador - Sexta - 25/11/2022 - 13:00 hrs");
    Console.WriteLine(" 3º Rodada - Holanda x Quatar - Terça - 29/11/2022 - 12:00 hrs");
   
}

if (Letradigitada.Contains("A") && Numerodigitado == 2)
{
     Console.WriteLine(" Equipe Selecionada: Equador");
     Console.WriteLine();
    Console.WriteLine(" 1° Rodada - Qatar x Equador - Domingo - 20/11/2022 -13:00 hrs");
    Console.WriteLine(" 2º Rodada - Holanda x Equador - Sexta - 25/11/2022 - 13:00 hrs");
    Console.WriteLine(" 3º Rodada - Equador x Senegal - Terça - 29/11/2022 - 12:00 hrs");
   
}

if (Letradigitada.Contains("A") && Numerodigitado == 3)
{
     Console.WriteLine(" Equipe Selecionada: Senegal");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Senegal x Holanda - Segunda - 21/11/2022 -13:00 hrs");
    Console.WriteLine(" 2º Rodada - Qatar x Senegal - Sexta - 25/11/2022 - 10:00 hrs");
    Console.WriteLine(" 3º Rodada - Equador x Senegal - Terça - 29/11/2022 - 12:00 hrs");
   
}

if (Letradigitada.Contains("A") && Numerodigitado == 4)
{
     Console.WriteLine(" Equipe Selecionada: Qatar");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Qatar x Equador - Domingo - 20/11/2022 -13:00 hrs");
    Console.WriteLine(" 2º Rodada - Qatar x Senegal - Sexta - 25/11/2022 - 10:00 hrs");
    Console.WriteLine(" 3º Rodada - Holanda x Qatar - Terça - 29/11/2022 - 12:00 hrs");
   
}


if (Letradigitada.Contains("B") && Numerodigitado == 1)
{
     Console.WriteLine(" Equipe Selecionada: Inglaterra");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Inglaterra x Irã - Segunda - 21/11/2022 -16:00 hrs");
    Console.WriteLine(" 2º Rodada - Inglaterra x Estados Unidos da América - Sexta - 25/11/2022 - 16:00 hrs");
    Console.WriteLine(" 3º Rodada - País de Gales x Inglaterra - Terça - 29/11/2022 - 16:00 hrs");
   
}

if (Letradigitada.Contains("B") && Numerodigitado == 2)
{
     Console.WriteLine(" Equipe Selecionada: País de Gales");
     Console.WriteLine();
    Console.WriteLine("  1º Rodada - Estados Unidos da América x País de Gales - Domingo - 20/11/2022 - 21:00 hrs");
    Console.WriteLine("  2º Rodada - País de Gales x Irã - Sexta - 25/11/2022 - 07:00 hrs");
    Console.WriteLine("  3º Rodada - País de Gales x Inglaterra - Terça - 29/11/2022 - 16:00 hrs");
   
}

if (Letradigitada.Contains("B") && Numerodigitado == 3)
{
     Console.WriteLine(" Equipe Selecionada: Estados Unidos da América");
     Console.WriteLine("");
    Console.WriteLine(" 1º Rodada - Estados Unidos da América x País de Gales - Domingo - 20/11/2022 - 21:00 hrs");
    Console.WriteLine(" 2º Rodada - Inglaterra x Estados Unidos da América - Sexta - 25/11/2022 - 16:00 hrs");
    Console.WriteLine(" 3º Rodada - Irã x Estados Unidos da América - Terça - 29/11/2022 - 16:00 hrs");
   
}

if (Letradigitada.Contains("B") && Numerodigitado == 4)
{
     Console.WriteLine(" Equipe Selecionada: Irã");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Inglaterra x Irã - Segunda - 21/11/2022 -16:00 hrs");
    Console.WriteLine(" 2º Rodada - País de Gales x Irã - Sexta - 25/11/2022 - 07:00 hrs");
    Console.WriteLine(" 3º Rodada - Irã x Estados Unidos da América - Terça - 29/11/2022 - 16:00 hrs");
   
}

if (Letradigitada.Contains("C") && Numerodigitado == 1)
{
     Console.WriteLine(" Equipe Selecionada: Argentina");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Argentina x Arábia Saudita - Terça - 22/11/2022 - 7:00 hrs");
    Console.WriteLine(" 2º Rodada - Argentina x México - Sábado - 26/11/2022 - 16:00 hrs");
    Console.WriteLine(" 3º Rodada - Polônia x Argentina - Quarta - 30/11/2022 - 16:00 hrs");
   
}

if (Letradigitada.Contains("C") && Numerodigitado == 2)
{
     Console.WriteLine(" Equipe Selecionada: México");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - México x Polónia - Terça - 22/11/2022 - 13:00 hrs");
    Console.WriteLine(" 2º Rodada - Argentina x México - Sábado - 26/11/2022 - 16:00 hrs");
    Console.WriteLine(" 3º Rodada - Arábia Saudita x México - Quarta - 30/11/2022 - 16:00 hrs");
   
}

if (Letradigitada.Contains("C") && Numerodigitado == 3)
{
     Console.WriteLine(" Polónia");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - México x Polónia - Terça - 22/11/2022 - 13:00 hrs");
    Console.WriteLine(" 2º Rodada - Polónia x Arábia Saudita - Sábado - 26/11/2022 - 10:00 hrs");
    Console.WriteLine(" 3º Rodada - Polônia x Argentina - Quarta - 30/11/2022 - 16:00 hrs");
   
}

if (Letradigitada.Contains("C") && Numerodigitado == 4)
{
     Console.WriteLine(" Equipe Selecionada: Arábia Saudita");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Argentina x Arábia Saudita - Terça - 22/11/2022 - 7:00 hrs");
    Console.WriteLine(" 2º Rodada - Polónia x Arábia Saudita - Sábado - 26/11/2022 - 10:00 hrs");
    Console.WriteLine(" 3º Rodada - Arábia Saudita x México - Quarta - 30/11/2022 - 16:00 hrs");
   
}

  
if (Letradigitada.Contains("D") && Numerodigitado == 1)
{
     Console.WriteLine(" Equipe Selecionada: Austrália");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - França x Austrália - Terça - 22/11/2022 - 16:00 hrs");
    Console.WriteLine(" 2º Rodada - Tunísia x Austrália - Sábado - 26/11/2022 - 07:00 hrs");
    Console.WriteLine(" 3º Rodada - Austrália x Dinamarca - Quarta - 30/11/2022 - 12:00 hrs");
   
}

if (Letradigitada.Contains("D") && Numerodigitado == 2)
{
     Console.WriteLine(" Equipe Selecionada: Dinamarca");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Dinamarca x Tunísia - Terça - 22/11/2022 - 10:00 hrs");
    Console.WriteLine(" 2º Rodada - França x Dinamarca - Sábado - 26/11/2022 - 13:00 hrs");
    Console.WriteLine(" 3º Rodada - Austrália x Dinamarca - Quarta - 30/11/2022 - 12:00 hrs");
   
}

if (Letradigitada.Contains("D") && Numerodigitado == 3)
{
     Console.WriteLine(" França");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - França x Austrália - Terça - 22/11/2022 - 16:00 hrs");
    Console.WriteLine(" 2º Rodada - França x Dinamarca - Sábado - 26/11/2022 - 13:00 hrs");
    Console.WriteLine(" 3º Rodada - Tunísia x França - Quarta - 30/11/2022 - 12:00 hrs");
   
}

if (Letradigitada.Contains("D") && Numerodigitado == 4)
{
     Console.WriteLine(" Equipe Selecionada: Tunísia");
     Console.WriteLine("");
    Console.WriteLine(" Dinamarca x Tunísia - Terça - 22/11/2022 - 10:00 hrs");
    Console.WriteLine(" Tunísia x Austrália - Sábado - 26/11/2022 - 07:00 hrs");
    Console.WriteLine(" Tunísia x França - Quarta - 30/11/2022 - 12:00 hrs");
   
}


if (Letradigitada.Contains("E") && Numerodigitado == 1)
{
     Console.WriteLine(" Equipe Selecionada: Costa Rica");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Espanha x Costa Rica - Qaurta - 23/11/2022 - 13:00 hrs");
    Console.WriteLine(" 2º Rodada - Japão x Costa Rica - Domingo - 27/11/2022 - 07:00 hrs");
    Console.WriteLine(" 3º Rodada - Costa Rica x Alemanha - Quarta - 01/12/2022 - 16:00 hrs");
   
}

if (Letradigitada.Contains("E") && Numerodigitado == 2)
{
     Console.WriteLine(" Equipe Selecionada: Alemanha");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Alemanha x Japão - Quarta - 23/11/2022 - 10:00 hrs");
    Console.WriteLine(" 2º Rodada - Espanha x Alemanha - Domingo - 27/11/2022 - 16:00 hrs");
    Console.WriteLine(" 3º Rodada - Costa Rica x Alemanha - Quarta - 01/12/2022 - 16:00 hrs");
   
}

if (Letradigitada.Contains("E") && Numerodigitado == 3)
{
     Console.WriteLine(" Japão");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Alemanha x Japão - Quarta - 23/11/2022 - 10:00 hrs");
    Console.WriteLine(" 2º Rodada - Japão x Costa Rica - Domingo - 27/11/2022 - 07:00 hrs");
    Console.WriteLine(" 3º Rodada - Japão x Espanha - Quarta - 01/12/2022 - 16:00 hrs");
   
}

if (Letradigitada.Contains("E") && Numerodigitado == 4)
{
     Console.WriteLine(" Equipe Selecionada: Espanha");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Espanha x Costa Rica - Quarta - 23/11/2022 - 13:00 hrs");
    Console.WriteLine(" 2º Rodada - Espanha x Alemanha - Domingo - 27/11/2022 - 16:00 hrs");
    Console.WriteLine(" 3º Rodada - Japão x Espanha - Quarta - 01/12/2022 - 16:00 hrs");
   
}

  
if (Letradigitada.Contains("F") && Numerodigitado == 1)
{
     Console.WriteLine(" Equipe Selecionada: Bélgica");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Bélgica x Canadá - Quarta - 23/11/2022 - 16:00 hrs");
    Console.WriteLine(" 2º Rodada - Bélgica x Marrocos - Domingo - 27/11/2022 - 10:00 hrs");
    Console.WriteLine(" 3º Rodada - Croácia x Bélgica - Quarta - 01/12/2022 - 12:00 hrs");
   
}

if (Letradigitada.Contains("F") && Numerodigitado == 2)
{
     Console.WriteLine(" Equipe Selecionada: Canadá");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Bélgica x Canadá - Quarta - 23/11/2022 - 16:00 hrs");
    Console.WriteLine(" 2º Rodada - Croácia x Canadá - Domingo - 27/11/2022 - 13:00 hrs");
    Console.WriteLine(" 3º Rodada - Canadá x Marrocos - Quarta - 01/12/2022 - 12:00 hrs");
   
}

if (Letradigitada.Contains("F") && Numerodigitado == 3)
{
     Console.WriteLine(" Croácia");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Marrocos x Croácia - Quarta - 23/11/2022 - 07:00 hrs");
    Console.WriteLine(" 2º Rodada - Croácia x Canadá - Domingo - 27/11/2022 - 13:00 hrs");
    Console.WriteLine(" 3º Rodada - Croácia x Bélgica - Quarta - 01/12/2022 - 12:00 hrs");
   
}

if (Letradigitada.Contains("F") && Numerodigitado == 4)
{
     Console.WriteLine(" Equipe Selecionada: Marrocos");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Marrocos x Croácia - Quarta - 23/11/2022 - 07:00 hrs");
    Console.WriteLine(" 2º Rodada - Bélgica x Marrocos - Domingo - 27/11/2022 - 10:00 hrs");
    Console.WriteLine(" 3º Rodada - Canadá x Marrocos - Quarta - 01/12/2022 - 12:00 hrs");
   
}  

if (Letradigitada.Contains("G") && Numerodigitado == 1)
{
     Console.WriteLine(" Equipe Selecionada: Brasil");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Brasil x Sérvia - Quinta - 24/11/2022 - 16:00 hrs");
    Console.WriteLine(" 2º Rodada - Brasil x Suíça - Segunda - 28/11/2022 - 13:00 hrs");
    Console.WriteLine(" 3º Rodada - Camarões x Brasil - Sexta - 02/12/2022 - 16:00 hrs");
   
}

if (Letradigitada.Contains("G") && Numerodigitado == 2)
{
     Console.WriteLine(" Equipe Selecionada: Camarões");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Suíça x Camarões - Quinta - 24/11/2022 - 07:00 hrs");
    Console.WriteLine(" 2º Rodada - Camarões x Sérvia - Segunda - 28/11/2022 - 07:00 hrs");
    Console.WriteLine(" 3º Rodada - Camarões x Brasil - Sexta - 02/12/2022 - 16:00 hrs");
   
}

if (Letradigitada.Contains("G") && Numerodigitado == 3)
{
     Console.WriteLine(" Suíça");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Suíça x Camarões - Quinta - 24/11/2022 - 07:00 hrs");
    Console.WriteLine(" 2º Rodada - Brasil x Suíça - Segunda - 28/11/2022 - 13:00 hrs");
    Console.WriteLine(" 3º Rodada - Sérvia x Suíça - Sexta - 02/12/2022 - 16:00 hrs");
   
}

if (Letradigitada.Contains("G") && Numerodigitado == 4)
{
     Console.WriteLine(" Equipe Selecionada: Sérvia");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Brasil x Sérvia - Quinta - 24/11/2022 - 16:00 hrs");
    Console.WriteLine(" 2º Rodada - Camarões x Sérvia - Segunda - 28/11/2022 - 07:00 hrs");
    Console.WriteLine(" 3º Rodada - Sérvia x Suíça - Sexta - 02/12/2022 - 16:00 hrs");
   
}  


if (Letradigitada.Contains("H") && Numerodigitado == 1)
{
     Console.WriteLine(" Equipe Selecionada: Coréia do Sul");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Uruguai x Coréia do Sul - Quinta - 24/11/2022 - 10:00 hrs");
    Console.WriteLine(" 2º Rodada - Portugal x Uruguai - Segunda - 28/11/2022 - 16:00 hrs");
    Console.WriteLine(" 3º Rodada - Gana x Uruguai - Sexta - 02/12/2022 - 12:00 hrs");
   
}

if (Letradigitada.Contains("H") && Numerodigitado == 2)
{
     Console.WriteLine(" Equipe Selecionada: Gana");
     Console.WriteLine("");
    Console.WriteLine(" 1º Rodada - Portugal x Gana - Quinta - 24/11/2022 - 13:00 hrs");
    Console.WriteLine(" 2º Rodada - Coréia do Sul x Gana - Segunda - 28/11/2022 - 10:00 hrs");
    Console.WriteLine(" 3º Rodada - Gana x Uruguai - Sexta - 02/12/2022 - 12:00 hrs");
   
}

if (Letradigitada.Contains("H") && Numerodigitado == 3)
{
     Console.WriteLine(" Portugal");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Portugal x Gana - Quinta - 24/11/2022 - 13:00 hrs");
    Console.WriteLine(" 2º Rodada - Portugal x Uruguai - Segunda - 28/11/2022 - 16:00 hrs");
    Console.WriteLine(" 3º Rodada - Coréia do Sul x Portugal - Sexta - 02/12/2022 - 12:00 hrs");
   
}

if (Letradigitada.Contains("H") && Numerodigitado == 4)
{
     Console.WriteLine(" Equipe Selecionada: Uruguai");
     Console.WriteLine();
    Console.WriteLine(" 1º Rodada - Uruguai x Coréia do Sul - Quinta - 24/11/2022 - 10:00 hrs");
    Console.WriteLine(" 2º Rodada - Portugal x Uruguai - Segunda - 28/11/2022 - 16:00 hrs");
    Console.WriteLine(" 3º Rodada - Gana x Uruguai - Sexta - 02/12/2022 - 12:00 hrs");
   
}  

if (Letradigitada.Contains("I") && Numerodigitado == 1)
{
    Console.WriteLine(" Opção Selecionada..: Oitavas de Final");
    Console.WriteLine();
    Console.WriteLine(" Sábado - 03/12/2022 - 12:00 hrs");
    Console.WriteLine(" Sábado - 03/12/2022 - 16:00 hrs");
    Console.WriteLine();
    Console.WriteLine(" Domingo - 04/12/2022 - 12:00 hrs");
    Console.WriteLine(" Domingo - 04/12/2022 - 16:00 hrs");
    Console.WriteLine();
    Console.WriteLine(" Segunda - 06/12/2022 - 12:00 hrs");
    Console.WriteLine(" Segunda - 06/12/2022 - 16:00 hrs");
    Console.WriteLine();
    Console.WriteLine(" Segunda - 06/12/2022 - 12:00 hrs");
    Console.WriteLine(" Segunda - 06/12/2022 - 16:00 hrs");
    Console.WriteLine();



}   

if (Letradigitada.Contains("I") && Numerodigitado == 2)
{
    Console.WriteLine(" Opção Selecionada..: Quartas de Final");
    Console.WriteLine();
    Console.WriteLine(" Sexta - 09/12/2022 - 12:00 hrs");
    Console.WriteLine(" Sexta - 09/12/2022 - 16:00 hrs");
    Console.WriteLine();
    Console.WriteLine(" Sábado - 10/12/2022 - 12:00 hrs");
    Console.WriteLine(" Sábado - 10/12/2022 - 16:00 hrs");
    Console.WriteLine();
   
}

if (Letradigitada.Contains("I") && Numerodigitado == 3)
{
    Console.WriteLine(" Opção Selecionada..: Semifinais");
    Console.WriteLine();
    Console.WriteLine(" Terça - 13/12/2022 - 12:00 hrs");
    Console.WriteLine(" Quarta - 14/12/2022 - 16:00 hrs");
    Console.WriteLine();

}

if (Letradigitada.Contains("I") && Numerodigitado == 4)
{
    Console.WriteLine(" Opção Selecionada..: Final");
    Console.WriteLine();
    Console.WriteLine(" Domingo - 18/12/2022 - 12:00 hrs");
    Console.WriteLine();
}

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Digite S para sair, qualquer outra tecla para continuar: ");
    tecla = Console.ReadLine()!;
    Console.ResetColor();
}


