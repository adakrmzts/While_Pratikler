/* 1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
    */

/* 
 
//  1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

int i  = 0; 
while ( i < 10 )
{


    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
  i++;

}
*/

/* 
// 2-> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

int i = 1;
while (i <= 20)
{


    Console.WriteLine(i);
    i++;

}
*/

/* 
// 3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int i = 1;
while (i <= 20)
{

    if (i % 2 == 0)
    {
        Console.WriteLine(i);
        i = i + 1;
    }
    else
        i++;

}
*/

/*

// 4-> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int i = 50;
int toplam = 0;

while (i <= 150)
{
    toplam = toplam + i;
    i++;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı : " + toplam);

*/

//5-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int i =1;
int toplamCift = 0;
int toplamTek = 0 ;

while (i <= 120)
{
    if (i % 2 == 0)
    {
        toplamCift = i + toplamCift;
        i++;
    }
    else
    {
        toplamTek = i + toplamTek;
        i++;
}
}
Console.WriteLine("ÇİFT SAYILARIN TOPLAMI " + toplamCift + "'DİR." + " TEK SAYILARIN TOPLAMI " + toplamTek + "'DİR.");

