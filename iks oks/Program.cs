using System;

namespace iks_oks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Igra iks oks");

            Console.WriteLine("unesite 0 ako ste se dogovorili da je nereseno, unesite 10 ako hocete da se predate i 100 za exit");

            // definisana polja table iks oks

            string pozicija1 = "1", pozicija2 = "2", pozicija3 = "3", pozicija4 = "4", pozicija5 = "5", pozicija6 = "6", pozicija7 = "7", pozicija8 = "8", pozicija9 = "9";
            int brojacP1 = 0, brojacP2 = 0, brojacP3 = 0, brojacP4 = 0, brojacP5 = 0, brojacP6 = 0, brojacP7 = 0, brojacP8 = 0,
                brojacP9 = 0;
            string igrac1, igrac2, unos2;
            int brojac1 = 0, brojac2 = 0, brojac3 = 0, brojac4 = 0, brojac5 = 0, brojac6 = 0, brojac7 = 0, izlaz = 0, unos = 1000;

            Console.WriteLine("unesite ime igraca1 (X)");
            igrac1 = Console.ReadLine();
            Console.WriteLine("unesite ime igraca2 (O)");
            igrac2 = Console.ReadLine();

            do
            {

                if (izlaz == 1)
                    break;
                // Ovo je izgled table

                Console.WriteLine($"      {pozicija1}   |   {pozicija2}   |   {pozicija3}");
                Console.WriteLine("------------------------------");
                Console.WriteLine($"      {pozicija4}   |   {pozicija5}   |   {pozicija6}");
                Console.WriteLine("------------------------------");
                Console.WriteLine($"      {pozicija7}   |   {pozicija8}   |   {pozicija9}\n\n");

                // ovde igrac1 bira svoje polje

                if (brojac1 % 2 == 0)
                {

                    do
                    {
                        brojac7 = 0;
                        do
                        {

                            try
                            {
                                Console.WriteLine($"{igrac1} - je na redu, izaberite polje");
                                unos = int.Parse(Console.ReadLine());
                            }
                            catch(Exception)
                            {
                                Console.WriteLine("error");
                                unos = 1000;
                                //++;
                            }


                        } while (unos != 1
                        && unos != 2
                        && unos != 3
                        && unos != 4
                        && unos != 5
                        && unos != 6
                        && unos != 7
                        && unos != 8
                        && unos != 9
                        && unos != 0
                        && unos != 10
                        && unos != 100);
                        // obe strane se dogovore da je neresena partija i pocinje se ponovo

                        if (unos == 0)
                        {
                            pozicija1 = "1";
                            pozicija2 = "2";
                            pozicija3 = "3";
                            pozicija4 = "4";
                            pozicija5 = "5";
                            pozicija6 = "6";
                            pozicija7 = "7";
                            pozicija8 = "8";
                            pozicija9 = "9";
                            brojacP1 = 0;
                            brojacP2 = 0;
                            brojacP3 = 0;
                            brojacP4 = 0;
                            brojacP5 = 0;
                            brojacP6 = 0;
                            brojacP7 = 0;
                            brojacP8 = 0;
                            brojacP9 = 0;
                            brojac3 *= 0;
                            Console.WriteLine("Nereseno");
                            brojac6++;
                            Console.WriteLine("jos jednom?");
                            unos2 = Console.ReadLine();
                            if (unos2 == "da")
                                continue;
                            izlaz++;
                        }
                        // kad neko hoce da preda igru

                        else if (unos == 10)
                        {
                            pozicija1 = "1";
                            pozicija2 = "2";
                            pozicija3 = "3";
                            pozicija4 = "4";
                            pozicija5 = "5";
                            pozicija6 = "6";
                            pozicija7 = "7";
                            pozicija8 = "8";
                            pozicija9 = "9";
                            Console.WriteLine($"{igrac1} je predao");
                            brojac5++;
                            brojacP1 = 0;
                            brojacP2 = 0;
                            brojacP3 = 0;
                            brojacP4 = 0;
                            brojacP5 = 0;
                            brojacP6 = 0;
                            brojacP7 = 0;
                            brojacP8 = 0;
                            brojacP9 = 0;
                            brojac3 *= 0;
                            Console.WriteLine("uno mas?");
                            unos2 = Console.ReadLine();
                            if (unos2 == "da")
                            continue;
                            izlaz++;
                        }
                        // gotovo dosadilo je

                         if (unos == 100)
                            izlaz++;

                        // Uslovi tako da ne mozes da zauzmes tudja polja
                       
                        if (unos == 1 && brojacP1 == 1)
                            {
                                Console.WriteLine("Polje je vec popunjeno");
                                brojac7 = 1;
                            }
                        else if (unos == 2 && brojacP2 == 1)
                            {
                                Console.WriteLine("Polje je vec popunjeno");
                                brojac7 = 1;
                            }
                        else if (unos == 3 && brojacP3 == 1)
                        {
                            Console.WriteLine("Polje je vec popunjeno");
                            brojac7 = 1;
                        }
                        else if (unos == 4 && brojacP4 == 1)
                        {
                            Console.WriteLine("Polje je vec popunjeno");
                            brojac7 = 1;
                        }
                        else if (unos == 5 && brojacP5 == 1)
                        {
                            Console.WriteLine("Polje je vec popunjeno");
                            brojac7 = 1;
                        }
                        else if (unos == 6 && brojacP6 == 1)
                        {
                            Console.WriteLine("Polje je vec popunjeno");
                            brojac7 = 1;
                        }
                        else if (unos == 7 && brojacP7 == 1)
                        {
                            Console.WriteLine("Polje je vec popunjeno");
                            brojac7 = 1;
                        }
                        else if (unos == 8 && brojacP8 == 1)
                        {
                            Console.WriteLine("Polje je vec popunjeno");
                            brojac7 = 1;
                        }
                        else if (unos == 9 && brojacP9 == 1)
                        {
                            Console.WriteLine("Polje je vec popunjeno");
                            brojac7 = 1;
                        }

                        //else 
                        //    brojac7 = 0;

                         
                    } while (brojac7 == 1);

                    switch (unos)
                    {
                        case 1:
                            pozicija1 = "X";
                                brojacP1++;    
                                break;
                        case 2:
                            pozicija2 = "X";
                                brojacP2++;
                                break;
                        case 3:
                            pozicija3 = "X";
                                brojacP3++;
                                break;
                        case 4:
                            pozicija4 = "X";
                                brojacP4++;
                                break;
                        case 5:
                            pozicija5 = "X";
                                brojacP5++;
                                break;
                        case 6:
                            pozicija6 = "X";
                                brojacP6 ++;
                                break;
                        case 7:
                            pozicija7 = "X";
                                brojacP7++;
                                break;
                        case 8:
                            pozicija8 = "X";
                                brojacP8++;
                                break;
                        case 9:
                            pozicija9 = "X";
                                brojacP9++;
                                break;
                    }
                }

                // Ovde igrac2 bira svoje polje

                else
                {
                    do {
                        brojac7 = 0;
                        do 
                        {
                            try
                            {
                                Console.WriteLine($"{igrac2} - je na redu, izaberite polje");
                                unos = int.Parse(Console.ReadLine());
                            }
                            catch(Exception)
                            {
                                Console.WriteLine("error");
                                unos = 1000;
                                
                            }
                        } while (unos != 1
                        && unos != 2
                        && unos != 3
                        && unos != 4
                        && unos != 5
                        && unos != 6
                        && unos != 7
                        && unos != 8
                        && unos != 9
                        && unos != 0
                        && unos != 10
                        && unos != 100);
                        // obe strane se dogovore da je neresena partija i pocinje se ponovo

                        if (unos == 0)
                    {
                        pozicija1 = "1";
                        pozicija2 = "2";
                        pozicija3 = "3";
                        pozicija4 = "4";
                        pozicija5 = "5";
                        pozicija6 = "6";
                        pozicija7 = "7";
                        pozicija8 = "8";
                        pozicija9 = "9";
                            brojacP1 = 0;
                            brojacP2 = 0;
                            brojacP3 = 0;
                            brojacP4 = 0;
                            brojacP5 = 0;
                            brojacP6 = 0;
                            brojacP7 = 0;
                            brojacP8 = 0;
                            brojacP9 = 0;
                            brojac3 *= 0;
                            Console.WriteLine("Nereseno");
                        brojac6++;
                        Console.WriteLine("uno mas?");
                            unos2 = Console.ReadLine();
                            if (unos2 == "da")
                        continue;
                            izlaz++;
                    }
                    // kad neko hoce da preda igru

                    else if (unos == 10)
                    {
                        pozicija1 = "1";
                        pozicija2 = "2";
                        pozicija3 = "3";
                        pozicija4 = "4";
                        pozicija5 = "5";
                        pozicija6 = "6";
                        pozicija7 = "7";
                        pozicija8 = "8";
                        pozicija9 = "9";
                        Console.WriteLine($"{igrac2} je predao");
                        brojac4++;
                            brojacP1 = 0;
                            brojacP2 = 0;
                            brojacP3 = 0;
                            brojacP4 = 0;
                            brojacP5 = 0;
                            brojacP6 = 0;
                            brojacP7 = 0;
                            brojacP8 = 0;
                            brojacP9 = 0;
                            brojac3 *= 0;
                            Console.WriteLine("uno mas");
                            unos2 = Console.ReadLine();
                            if (unos2 == "da")
                            continue;
                            izlaz++;
                    }
                    //gotovo, dosadilo je

                    if (unos == 100)
                        izlaz++;

                    // Uslovi tako da ne mozes da zauzmes tudja polja

                    if (unos == 1 && brojacP1 == 1)
                    {
                        Console.WriteLine("Polje je vec popunjeno");
                        brojac7 = 1;
                    }
                    else if (unos == 2 && brojacP2 == 1)
                    {
                        Console.WriteLine("Polje je vec popunjeno");
                        brojac7 = 1;
                    }
                    else if (unos == 3 && brojacP3 == 1)
                    {
                        Console.WriteLine("Polje je vec popunjeno");
                        brojac7 = 1;
                    }
                    else if (unos == 4 && brojacP4 == 1)
                    {
                        Console.WriteLine("Polje je vec popunjeno");
                        brojac7 = 1;
                    }
                    else if (unos == 5 && brojacP5 == 1)
                    {
                        Console.WriteLine("Polje je vec popunjeno");
                        brojac7 = 1;
                    }
                    else if (unos == 6 && brojacP6 == 1)
                    {
                        Console.WriteLine("Polje je vec popunjeno");
                        brojac7 = 1;
                    }
                    else if (unos == 7 && brojacP7 == 1)
                    {
                        Console.WriteLine("Polje je vec popunjeno");
                        brojac7 = 1;
                    }
                    else if (unos == 8 && brojacP8 == 1)
                    {
                        Console.WriteLine("Polje je vec popunjeno");
                        brojac7 = 1;
                    }
                    else if (unos == 9 && brojacP9 == 1)
                    {
                        Console.WriteLine("Polje je vec popunjeno");
                        brojac7 = 1;
                    }
                        //else
                        //{
                        //    brojac7 = 0;
                        //}

                         

                } while (brojac7 == 1) ;
                switch (unos)
                    {
                        case 1:
                            pozicija1 = "O";
                                brojacP1++;
                                break;
                        case 2:
                            pozicija2 = "O";
                                brojacP2++;
                                break;
                        case 3:
                            pozicija3 = "O";
                                brojacP3++;
                                break;
                        case 4:
                            pozicija4 = "O";
                                brojacP4++;
                                break;
                        case 5:
                            pozicija5 = "O";
                                brojacP5++;
                                break;
                        case 6:
                            pozicija6 = "O";
                                brojacP6++;
                                break;
                        case 7:
                            pozicija7 = "O";
                                brojacP7++;
                                break;
                        case 8:
                            pozicija8 = "O";
                                brojacP8++;
                                break;
                        case 9:
                            pozicija9 = "O";
                                brojacP9++;
                                break;
                    }
                }

                brojac1++;
                brojac3++;

                // uslovi da igrac1 pobedi

                if (pozicija1 == "X" && pozicija2 == "X" && pozicija3 == "X")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac1} je pobedio!!!");
                    brojac4++;
                }if (pozicija4 == "X" && pozicija5 == "X" && pozicija6 == "X")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac1} je pobedio!!!");
                    brojac4++;
                }
                if (pozicija7 == "X" && pozicija8 == "X" && pozicija9 == "X")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac1} je pobedio!!!");
                    brojac4++;
                }
                if (pozicija1 == "X" && pozicija4 == "X" && pozicija7 == "X")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac1} je pobedio!!!");
                    brojac4++;
                }
                if (pozicija2 == "X" && pozicija5 == "X" && pozicija8 == "X")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac1} je pobedio!!!");
                    brojac4++;
                }
                if (pozicija3 == "X" && pozicija6 == "X" && pozicija9 == "X")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac1} je pobedio!!!");
                    brojac4++;
                }
                if (pozicija1 == "X" && pozicija5 == "X" && pozicija9 == "X")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac1} je pobedio!!!");
                    brojac4++;
                }
                if (pozicija3 == "X" && pozicija5 == "X" && pozicija7 == "X")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac1} je pobedio!!!");
                    brojac4++;
                }

                // uslovi da igrac2 pobedi

                if (pozicija1 == "O" && pozicija2 == "O" && pozicija3 == "O")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac2} je pobedio!!!");
                    brojac5++;
                }
                if (pozicija4 == "O" && pozicija5 == "O" && pozicija6 == "O")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac2} je pobedio!!!");
                    brojac5++;
                }
                if (pozicija7 == "O" && pozicija8 == "O" && pozicija9 == "O")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac2} je pobedio!!!");
                    brojac5++;
                }
                if (pozicija1 == "O" && pozicija4 == "O" && pozicija7 == "O")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac2} je pobedio!!!");
                    brojac5++;
                }
                if (pozicija2 == "O" && pozicija5 == "O" && pozicija8 == "O")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac2} je pobedio!!!");
                    brojac5++;
                }
                if (pozicija3 == "O" && pozicija6 == "O" && pozicija9 == "O")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac2} je pobedio!!!");
                    brojac5++;
                }
                if (pozicija1 == "O" && pozicija5 == "O" && pozicija9 == "O")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac2} je pobedio!!!");
                    brojac5++;
                }
                if (pozicija3 == "O" && pozicija5 == "O" && pozicija7 == "O")
                {
                    brojac2++;
                    Console.WriteLine($"{igrac2} je pobedio!!!");
                    brojac5++;
                }

                // Uslov za nereseno

                if (brojac2 != 1 && brojac3 == 9)
                {
                    Console.WriteLine("Nereseno!");
                    brojac3 *= 0;
                    pozicija1 = "1";
                    pozicija2 = "2";
                    pozicija3 = "3";
                    pozicija4 = "4";
                    pozicija5 = "5";
                    pozicija6 = "6";
                    pozicija7 = "7";
                    pozicija8 = "8";
                    pozicija9 = "9";
                    brojacP1 = 0;
                    brojacP2 = 0;
                    brojacP3 = 0;
                    brojacP4 = 0;
                    brojacP5 = 0;
                    brojacP6 = 0;
                    brojacP7 = 0;
                    brojacP8 = 0;
                    brojacP9 = 0;
                    brojac6++;
                    brojac3 *= 0;
                    Console.WriteLine("uno mas?");
                    unos2 = Console.ReadLine();
                    if (unos2 == "da")
                    continue;
                    izlaz++;
                }

                // ovo je ako igraci hoce jos jednu partiju

                if (brojac2 == 1)
                {
                    Console.WriteLine("opet?");
                    unos2 = Console.ReadLine();
                    if (unos2 == "da" || unos2 == "Da" || unos2 == "DA")
                    {
                        brojac2 *= 0;
                        pozicija1 = "1";
                        pozicija2 = "2";
                        pozicija3 = "3";
                        pozicija4 = "4";
                        pozicija5 = "5";
                        pozicija6 = "6";
                        pozicija7 = "7";
                        pozicija8 = "8";
                        pozicija9 = "9";
                        brojacP1 = 0;
                        brojacP2 = 0;
                        brojacP3 = 0;
                        brojacP4 = 0;
                        brojacP5 = 0;
                        brojacP6 = 0;
                        brojacP7 = 0;
                        brojacP8 = 0;
                        brojacP9 = 0;
                        brojac3 *= 0;
                    }
                }

            } while (brojac2 != 1);

            Console.WriteLine($"{igrac1} - {brojac4},  {igrac2} - {brojac5}, nereseno - {brojac6}");

            // Dva nedostatka koja su mi ocigledna trenutno: 1- je sto mozes da igras na vec zauzeto polje.  ---- Ovaj je resen :)
            // 2- je sto ne tolerise unos nepredvidjenog znaka, imam ideju kako da resim drugi problem,----- Ovaj je resen :) za prvi mi nista ne pada na pamet.Tako da cu probati sa nizom koji ce 
            // predstavljati tablu iks oksa, i sa dve for petlje resavam prvi problem.  ----- jos je ovo ostalo.
        }
    }
}
