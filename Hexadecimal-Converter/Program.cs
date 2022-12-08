using System.Text;
Console.WriteLine("Veuillez entrer un nombre en base décimale:");
string input = Console.ReadLine();

int dividende = int.TryParse(input, out dividende) ? Convert.ToInt32(input):;
int diviseur = 16;
int reste;
int quotient;
StringBuilder nombreInHex = new StringBuilder();

do
{
    quotient = dividende / diviseur;
    reste = dividende % diviseur;
/*    Console.WriteLine("reste : " + reste); debugging
*/    switch (reste)
    {
        case 10:
            nombreInHex.Append("A");
            break;
        case 11:
            nombreInHex.Append("B");
            break;
        case 12:
            nombreInHex.Append("C");
            break;
        case 13:
            nombreInHex.Append("D");
            break;
        case 14:
            nombreInHex.Append("E");
            break;
        case 15:
            nombreInHex.Append("F");
            break;
        default:
        nombreInHex.Append(Convert.ToString(reste));
            break;
    }
    dividende = quotient;

} while (quotient != 0 );

/*Console.WriteLine(nombreInHex);*/
char[] charArray = nombreInHex.ToString().ToCharArray();
string s = string.Join("", charArray.Reverse());
Console.WriteLine("Le nombre est en base 16:");
Console.WriteLine(s);
Console.ReadLine();