// See https://aka.ms/new-console-template for more information
const int nbreM = 7;
Console.WriteLine("Veuillez saisir votre prenom");
string nomJoueur = Console.ReadLine();
Console.WriteLine("Veuillez saisir un nombre entre 1 et 10");
int nbSaisi = Convert.ToInt32(Console.ReadLine());
if( nbreM == nbSaisi) {
    System.Console.WriteLine($"Bravo! {nomJoueur};vous avez gagner");
}else{
    if(nbreM<nbSaisi){
        System.Console.WriteLine("le nombre est plus grand");
    }else {
        System.Console.WriteLine("le nombre est plus petit");
    }
}