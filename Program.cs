string Letradigitada;
Console.WriteLine("--- Calendário Copa do Mundo 2022 ---");
Console.WriteLine("--- Descubra as datas dos jogos das seleções ---");

Console.WriteLine("");
Console.WriteLine("-- Grupo A --");
Console.WriteLine("1-Países Baixos");
Console.WriteLine("2-Equador");
Console.WriteLine("3-Senegal");
Console.WriteLine("4-Qatar");
Console.WriteLine("");

Console.WriteLine("-- Grupo B --");
Console.WriteLine("1-Inglaterra");
Console.WriteLine("3-País de Gales");
Console.WriteLine("4-Estados Unidos da América");
Console.WriteLine("5-Irã");
Console.WriteLine("");

Console.WriteLine("-- Grupo C --");
Console.WriteLine("1-Argentina");
Console.WriteLine("2-México");
Console.WriteLine("3-Polónia");
Console.WriteLine("4-Arábia Saudita");
Console.WriteLine("");

Console.WriteLine("-- Grupo D --");
Console.WriteLine("1-Austrália");
Console.WriteLine("2-Dinamarca");
Console.WriteLine("3-França");
Console.WriteLine("4-Tunísia");
Console.WriteLine("");

Console.WriteLine("-- Grupo E-- ");
Console.WriteLine("1-Costa Rica");
Console.WriteLine("2-Alemanha");
Console.WriteLine("3-Japão");
Console.WriteLine("4-Espanha");
Console.WriteLine("");

Console.WriteLine("-- Grupo F --");
Console.WriteLine("1-Bélgica");
Console.WriteLine("2-Canadá");
Console.WriteLine("3-Croácia");
Console.WriteLine("4-Marrocos");
Console.WriteLine("");

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
Console.WriteLine("");


Console.Write("Digite a letra correspondente ao grupo e o número da equipe:");
Letradigitada = Console.ReadLine()!.ToUpper();
int Numerodigitado = Convert.ToInt16 (Console.ReadLine()!);








if (Letradigitada.Contains("E") && Numerodigitado == 2 )
{
    Console.WriteLine(" Alemanha x Japão - Quarta - 23/11/2022 -10:00 hrs");
    Console.WriteLine(" Espanha x Alemanha - Domingo - 27/11/2022 - 16:00 hrs");
    Console.WriteLine(" Costa Rica x Alemanha - Quinta - 01/12/2022 - 16:00 hrs");
   
}

if (Letradigitada.Contains("C") && Numerodigitado == 4 )
{
    Console.WriteLine(" Argentina x Arábia Saudita - Terça - 22/11/2022 - 7:00 hrs");
    Console.WriteLine(" Polônia x Arábia Saudita - Sábado - 26/11/2022 - 10:00 hrs");
    Console.WriteLine(" Arábia Saudita x México - Quarta - 30/11/2022 - 16:00 hrs");
   
}

if (Letradigitada.Contains("C") && Numerodigitado == 1 )
{
    Console.WriteLine(" Argentina x Arábia Saudita - Terça - 22/11/2022 - 7:00 hrs");
    Console.WriteLine(" Argentina x México - Sábado - 26/11/2022 - 16:00 hrs");
    Console.WriteLine(" Polônia x Argentina - Quarta - 30/11/2022 - 16:00 hrs");
   
}


if (Letradigitada.Contains("A") && Numerodigitado == 4)
{
    Console.WriteLine(" Catar x Ecuador - Domingo - 20/11/2022 -13:00 hrs");
    Console.WriteLine(" Catar x Senegal - Sexta - 25/11/2022 - 10:00 hrs");
    Console.WriteLine(" Holanda x Catar - Terça - 29/11/2022 - 12:00 hrs");
   
}


