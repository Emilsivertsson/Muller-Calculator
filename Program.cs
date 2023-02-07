
using System;
using System.Collections.Generic;
// take user input
Console.WriteLine("Vad heter personen du gör mönster till?");
String name = Console.ReadLine();

//Variables for measurments
double kh = 0;
double bu = 0;
double tu = 0;
double hu = 0;
double äl = 0;
double stl = 0;
double schr = 0;
double fw = 0;
double bdu = 0;

//try-catch for all the user inputs.
while (true)
{
    try
    {
        Console.WriteLine("Skriv in Körperhöhe");
        kh = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Tänk på att du bara kan använda siffror och komma-tecken! försök igen");
    }
}


while (true)
{
    try
    {
        Console.WriteLine("Skriv in Brusumfang");
        bu = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Tänk på att du bara kan använda siffror och komma-tecken! försök igen");
    }
}

while (true)
{
    try
    {
        Console.WriteLine("Skriv in Taillenumfang");
        tu = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Tänk på att du bara kan använda siffror och komma-tecken! försök igen");
    }
}

while (true)
{
    try
    {
        Console.WriteLine("Skriv in Huftumfang");
        hu = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Tänk på att du bara kan använda siffror och komma-tecken! försök igen");
    }
}

while (true)
{
    try
    {
        Console.WriteLine("Skriv in Ärmellänge");
        äl = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Tänk på att du bara kan använda siffror och komma-tecken! försök igen");
    }
}

while (true)
{
    try
    {
        Console.WriteLine("Skriv in Seitenlänge");
        stl = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Tänk på att du bara kan använda siffror och komma-tecken! försök igen");
    }
}

while (true)
{
    try
    {
        Console.WriteLine("Skriv in Schrittenlänge");
        schr = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Tänk på att du bara kan använda siffror och komma-tecken! försök igen");
    }
}

while (true)
{
    try
    {
        Console.WriteLine("Skriv in Fubweite");
        fw = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Tänk på att du bara kan använda siffror och komma-tecken! försök igen");
    }
}

while (true)
{
    try
    {
        Console.WriteLine("Skriv in Bundumfang");
        bdu = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Tänk på att du bara kan använda siffror och komma-tecken! försök igen");
    }
}



double rh = (bu / 8) + 12.5;
double rl = (kh / 4) + 1.5;
double ht = kh / 8;
double lg = (kh / 2) + (kh / 8) + 4;
double hs = (bu / 2) / 10 + 3;
double at = rh + 2.5;

double rb;
if (bu >= 100)
{
    rb = (bu / 10) + 13;
}
else
{
    rb = ((bu / 10) * 2) + 3;
}

double ad = (bu / 8) + 5;
double bb = ((bu / 10) * 2) + 3;
double ba = ((tu / 4) + 0.5) - 1;
double lbh = stl - schr;
double knh = (schr / 2) + (schr / 10);
double vhbr = (hu / 4) + 3;
double gsd = (hu / 4) - 3;

double vhsd = ((hu / 2) / 10) + 1;
double hhsd = gsd - vhsd;
double hhhbr = (hu / 4) + 4.5;
double gbr = hhsd + hhhbr;


StreamWriter streamWriter = new StreamWriter(name, true);
streamWriter.WriteLine("Måtttabell för {0}.", name);
streamWriter.WriteLine("-----------------------------------");
streamWriter.WriteLine("     1/1    1/2     1/4     1/8 ");
streamWriter.WriteLine("Kh   {0}    {1}     {2}     {3}", kh, kh / 2, kh / 4, kh / 8);
streamWriter.WriteLine("Bu   {0}    {1}     {2}     {3}", bu, bu / 2, bu / 4, bu / 8);
streamWriter.WriteLine("Tu   {0}    {1}     {2}", tu, tu / 2, tu / 4);
streamWriter.WriteLine("Hu   {0}    {1}", hu, hu / 2);
streamWriter.WriteLine("Äl   {0} ", äl);
streamWriter.WriteLine("Rh   {0} ", rh);
streamWriter.WriteLine("Rl   {0} ", rl);
streamWriter.WriteLine("Ht   {0} ", ht);
streamWriter.WriteLine("Lg   {0} ", lg);
streamWriter.WriteLine("Hs   {0} ", hs);
streamWriter.WriteLine("At   {0} ", at);
streamWriter.WriteLine("Rb   {0} ", rb);
streamWriter.WriteLine("Ad   {0} ", ad);
streamWriter.WriteLine("Bb   {0} ", bb);
streamWriter.WriteLine("Ba   {0} ", ba);

streamWriter.WriteLine("Stl    {0} ", stl);
streamWriter.WriteLine("Schr   {0} ", schr);
streamWriter.WriteLine("Lbh    {0} ", lbh);
streamWriter.WriteLine("Knh    {0} ", knh);

streamWriter.WriteLine("      1/1    1/2     1/4     1/8 ");
streamWriter.WriteLine("Bdu   {0}   {1}     {2} ", bdu, bdu / 2, bdu / 4);
streamWriter.WriteLine("Hu    {0}    {1}     {2} ", hu, hu / 2, hu / 4);
streamWriter.WriteLine("Fw    {0}    {1}     {2} ", fw, fw / 2, fw / 4);

streamWriter.WriteLine("Vhbr    {0} ", vhbr);
streamWriter.WriteLine("Gsd     {0} ", gsd);
streamWriter.WriteLine("Vhsd    {0} ", vhsd);
streamWriter.WriteLine("Hhsd    {0} ", hhsd);
streamWriter.WriteLine("HhHbr   {0} ", hhhbr);
streamWriter.WriteLine("GBr     {0}   {1} ", gbr, gbr / 2);
streamWriter.Close();

Console.WriteLine("Tack för att du använder Muller-miniräknaren, dina mått finns i textfilen i samma mapp som du kör detta program ifrån.");
Console.ReadLine();
