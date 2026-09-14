using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Channels;

namespace feladat
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //         int[] magas = new int[32];
            //         int[] suly = new int[32];
            //         double[] BMI = new double[32];
            Random rnd = new Random();
            //         int max;
            //         int max_suly;
            //         int index_max_suly;
            //         int index_max;
            //         double max_bmi;
            //         int max_bmi_index;
            //         int min;
            //         int min_suly;
            //         double min_bmi;
            //         int min_bmi_index;
            //         int index_suly_index;
            //         int index_min;
            //         int sum = 0;
            //         int sum_suly = 0;
            //         double sum_bmi = 0;
            //         double avr;
            //         double avr_suly;
            //         double avr_bmi;
            //         int fol_suly = 0;
            //         int alatt_suly = 0;
            //         int fol = 0;
            //         int alatt = 0;
            //         bool van = false;
            //         int benne = 0;
            //         int kivul = 0;
            //         bool tuul;
            //         int input;
            //         for (int i = 0; i < magas.Length; i++)
            //         {
            //             magas[i] = rnd.Next(140, 195);
            //             suly[i] = rnd.Next(40, 90);
            //         }
            //         for (int i = 0; i < 32; i++)
            //         {
            //             BMI[i] = (double)(suly[i]) / ((magas[i] / 100.0) * (magas[i] / 100.0));
            //         }

            //         max = magas[0];
            //         min = magas[0];
            //         max_suly = suly[0];
            //         min_suly = suly[0];
            //         max_bmi = BMI[0];
            //         min_bmi = BMI[0];
            //         for (int i = 0; i < magas.Length; i++)
            //         {

            //             if (max < magas[i])
            //             {
            //                 max = magas[i];
            //                 index_max = i;
            //             }

            //             if (min > magas[i])
            //             {
            //                 min = magas[i];
            //                 index_min = i;
            //             }

            //             if (max_suly < suly[i])
            //             {
            //                 max = suly[i];
            //                 index_max_suly = i;
            //             }

            //             if (min_suly > suly[i])
            //             {
            //                 min_suly = suly[i];
            //                 index_suly_index = i;
            //             }
            //             if (max_bmi < BMI[i])
            //             {
            //                 max_bmi = BMI[i];
            //                 max_bmi_index = i;
            //             }

            //             if (min_bmi > BMI[i])
            //             {
            //                 min_bmi = BMI[i];
            //                 min_bmi_index = i;
            //             }
            //             sum += magas[i];
            //             sum_suly += suly[i];
            //             sum_bmi += BMI[i];

            //         }
            //         avr = (double)(sum) / magas.Length;
            //         avr_suly = (double)(sum_suly) / suly.Length;
            //         avr_bmi = sum_bmi / BMI.Length;
            //         foreach (int i in magas)
            //         {
            //             if (i < avr)
            //             {
            //                 alatt += 1;
            //             }
            //             else if (i > avr)
            //             {
            //                 fol += 1;

            //             }
            //         }
            //         foreach (int i in suly)
            //         {
            //             if (i < avr_suly)
            //             {
            //                 alatt_suly += 1;
            //             }
            //             else if (i > avr_suly)
            //             {
            //                 fol_suly += 1;

            //             }

            //             if (i == 90)
            //             {
            //                 van = true;
            //             }


            //         }

            //         foreach (double i in BMI)
            //         {
            //             if (i >= 18.5 && i <= 24.99)
            //             {
            //                 benne += 1;
            //             }
            //             else
            //             {
            //                 kivul += 1;
            //             }

            //         }
            //         foreach (double i in BMI)
            //         {
            //             if (i < 16 || i >= 40)
            //             {
            //                 tuul = true;
            //             }
            //         }

            //         System.Console.WriteLine("Hányadik ember: ");
            //         input = int.Parse(System.Console.ReadLine()) - 1;
            //         while (input >= 0)
            //         {
            //             if (BMI[input] > 18.5 && BMI[input] <= 24.99)
            //             {
            //                 System.Console.WriteLine("Elfogadható");
            //             }
            //             else
            //             {
            //                 System.Console.WriteLine("Nem Elfogadtható");
            //             }
            //             System.Console.WriteLine("Hányadik ember: ");
            //             input = int.Parse(System.Console.ReadLine()) - 1;
            //         }

            //2 fel
            //     int[] szamok = new int[300];
            //     int[] uj = new int[300];
            //     int c = 0;
            //     bool tizenkilenc = false;
            //     int osszeg = 0;
            //     int hattal = 0;
            //     double atlag;

            //     for (int i = 0; i < szamok.Length; i++)
            //     {
            //         szamok[i] = rnd.Next(-500, 500);
            //     }
            //     int max = szamok[0];
            //     int min = szamok[0];
            //     foreach (int i in szamok)
            //     {
            //         if (i % 19 == 0)
            //         {
            //             tizenkilenc = true;
            //         }
            //         if (i % 6 == 0)
            //         {
            //             hattal += 1;
            //         }
            //         if (i % 17 == 0)
            //         {
            //             //System.Console.WriteLine(i);
            //         }
            //         if (i > max)
            //         {
            //             max = i;
            //         }
            //         if (i < min)
            //         {
            //             min = i;
            //         }

            //         if (i % 2 == 0 && i % 3 == 0 && i % 5 == 0)
            //         {
            //             uj[c] = i;
            //             c += 1;
            //         }
            //         osszeg += i;

            //     }
            //     atlag = osszeg / szamok.Length;

            //     for (int i = 0; i < szamok.Length - 1; i++)
            //     {
            //         for (int j = i + 1; j < szamok.Length; j++)
            //         {
            //             if (szamok[j] > szamok[i])
            //             {
            //                 szamok[i] ^= szamok[j];
            //                 szamok[j] ^= szamok[i];
            //                 szamok[i] ^= szamok[j];

            //             }
            //         }
            //     }




            //3fel

            // int[] tomb = new int[500];
            // int[] ujtomb = new int[500];
            //  int max_index = 0;
            // int min_index = 0;
            // int c = 0;
            // int l = 0;

            // bool vane = false;
            // int sum = 0;
            // int atlag = 0;
            // for (int i = 0; i < tomb.Length; i++)
            // {

            //     tomb[i] = rnd.Next(0, 739);
            // }
            // int min = tomb[0];
            // int max = tomb[0];
            // foreach (int i in tomb)
            // {
            //     if (i % 13 == 0)
            //     {
            //         vane = true;
            //     }
            //     if (i % 23 == 0)
            //     {
            //         //System.Console.WriteLine(i);
            //     }
            //     if (i % 99 == 0)
            //     {
            //         c += 1;
            //     }
            //     if( i%10==0)
            //     {
            //         ujtomb[l] = i;
            //         l += 1;
            //     }
            //     sum += i;
            // }
            // atlag = sum / tomb.Length;

            // for (int i = 0; i < tomb.Length; i++)
            // {
            //     if (min < tomb[i])
            //     {
            //         min = tomb[i];
            //         min_index = i;
            //     }
            //     if (max < tomb[i])
            //     {
            //         max = tomb[i];
            //         max_index = i;
            //     }
            // }

            //     for (int i = 0; i < tomb.Length - 1; i++)
            //     {
            //         for (int j = i + 1; j < tomb.Length; j++)
            //         {
            //             if (tomb[j] < tomb[i])
            //             {
            //                 tomb[i] ^= tomb[j];
            //                 tomb[j] ^= tomb[i];
            //                 tomb[i] ^= tomb[j];

            //             }
            //         }
            //     }
            // foreach (int i in tomb)
            // {
            //     System.Console.WriteLine(i);
            // }


            int[] tomb = new int[346];
            bool van = false;
          
            int c = 0;
            int l = 0;
            int sum = 0;
            int atlag = 0;

            for (int i = 0; i < 346; i++)
            {
                tomb[i] = rnd.Next(-84, 322);
            }
            
            int max = tomb[0];
            int min = tomb[0];
            foreach (int i in tomb)
            {
                if (i % 81 == 0)
                {
                    van = true;
                }
                if (i % 21 == 0)
                {
                    System.Console.WriteLine(i);
                }
                if (i > max)
                {
                    max = i;
                }
                if (i % 49 ==0)
                {
                    c += 1;
                }
                if (i<min)
                {
                    min = i;
                }
                sum += i;
            }
            atlag = sum / tomb.Length; 
    }
    
            }
                




}