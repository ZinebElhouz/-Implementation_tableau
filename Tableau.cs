using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1_Implementation_Tableau
{
    class Tableau
    {

        private int dim;
        private string type;
        private string[] TabString;
        private float[] TabFloat;

       public Tableau(int Dim,string Type)
        {
            dim = Dim;
            if (Type == "string")
                TabString = new string[dim];
            if (Type == "float")
                TabFloat = new float[dim];
        }
        /// <summary>
        /// fonction d'insertion d'une valeur reelle dans un tableau de type float
        /// </summary>
        /// <param name="Val">la valeur reelle ajouté</param>
        /// <param name="Index">la position d'ajout</param>
        public void InsertString(string Val,int Index) 
        {
            Array.Resize<string>(ref TabString, TabString.Length + 1);
                
                    for(int j = TabString.Length-1 ; j-1 == Index; j--)
                    {
                        TabString[j] = TabString[j - 1];
                    }
                      TabString[Index] = Val;               
                              
        }
        /// <summary>
        /// fonction d'insertion d'une string dans un tableau de type string
        /// </summary>
        /// <param name="Val">la chaine de caractere ajouté</param>
        /// <param name="Index">la postion d'ajout</param>
        public void InsertFloat(float Val, int Index)
        {
            
                    TabFloat[Index] = Val;
              
        }
        /// <summary>
        /// fonction de suppression une valeur string
        /// </summary>
        /// <param name="pos">la postion supprimé</param>
        /// <returns>soit 1 si la suppression est bien fait ou bien 0 si la suppression n'est pas fait bien</returns>
        public int SupprimerString(int pos)
        {
            for(int i = 0; i < dim; i++)
            {
                if (i == pos)
                {

                    for (int j = pos; j < dim; j++)
                    {
                        TabString[j] = TabString[j + 1];
                    }
                    return 1;
                }
                else
                    return 0;
            }
            return 0;
        }

        /// <summary>
        /// fonction de suppression une valeur reelle
        /// </summary>
        /// <param name="pos">la position supprimé</param>
        /// <returns>soit 1 si la suppression est bien fait ou bien 0 si la suppression n'est pas fait bien</returns>
        public int SupprimerFloat(int pos)
        {
            for (int i = 0; i < dim; i++)
            {
                if (i == pos)
                {
                    for (int j = pos; j < dim; j++)
                    {
                        TabString[j] = TabString[j + 1];
                    }
                    return 1;
                }
                else
                    return 0;
            }
            return 0;
        }
        /// <summary>
        /// fonction pour supprimer une valeur si cette valeur existe
        /// </summary>
        /// <param name="Val">la valeur supprimé</param>
        /// <returns>soit 1 si la suppression est bien fait ou bien 0 si la suppression n'est pas fait bien</returns>
        public int SupprimerString(string Val)
        {

            for (int i = 0; i < dim; i++)
            {
                if (TabString[i] == Val )
                {

                    for (int j = i; j < dim; j++)
                    {
                        TabString[j] = TabString[j + 1];
                    }
                    return 1;
                }
             
            }
            return 0;
        }

        /// <summary>
        /// fonction pour supprimer une valeur si cette valeur existe
        /// </summary>
        /// <param name="Val">la valeur supprimé</param>
        /// <returns>soit 1 si la suppression est bien fait ou bien 0 si la suppression n'est pas fait bien</returns>
        public int SupprimerFloat(float Val)
        {

            for (int i = 0; i < dim; i++)
            {
                if (TabFloat[i] == Val)
                {

                    for (int j = i; j < dim; j++)
                    {
                        TabFloat[j] = TabFloat[j + 1];
                    }
                    return 1;
                }
                
            }
            return 0;
        }

        /// <summary>
        /// fonction de recherche une valeur dans le tableau 
        /// </summary>
        /// <param name="Val">la valeur recherchée</param>
        /// <returns>si la valeur est trouvé la valeur retournée est true sinon la fct retourne false</returns>
        public bool RechercherFloat(float Val)
        {

            for (int i = 0; i < dim; i++)
            {
                if (TabFloat[i] == Val)
                {
                    return true;
                }
              
            }
                    return false;
        }

        /// <summary>
        /// fonction de recherche une valeur dans le tableau 
        /// </summary>
        /// <param name="Val">la valeur recherchée</param>
        /// <returns>si la valeur est trouvé la valeur retournée est true sinon la fct retourne false</returns>
        public bool RechercherString(string Val)
        {

            for (int i = 0; i < dim; i++)
            {
                if (TabString[i] == Val)
                {
                    return true;
                }
            }
            return false;
        }
       

        /// <summary>
        /// fonction de tri d'un tableau de type float
        /// </summary>
        /// <param name="TabFloat">le tableau à trier</param>
        public void TriFloat(float[] TabFloat)
        {  
            for(int i = 0; i < dim-1 ; i++)
            {
                for (int j = i+1 ; j<dim-1;j++)
                {
                    if(TabFloat[j]<TabFloat[i])
                    {
                        var temp = TabFloat[i];
                        TabFloat[i] = TabFloat[j];
                        TabFloat[j] = temp;
                    }
                }
            }
        }

        
        /// <summary>
        /// fonction de tri de tbaleau de type string
        /// </summary>
        /// <param name="TabString">le tableau à trier</param>
        public void TriString(string[] TabString)
        {
            for (int i = 0; i < dim - 1; i++)
            {
                for (int j = i + 1; j < dim - 1; j++)
                {
                   
                }
            }

        }

        /// <summary>
        /// fonction pour tester si un tableau est symetrie ou non 
        /// </summary>
        /// <returns>retourne true si le tableau est symetrie sinon retourne false</returns>
        public bool SymetrieFloat()
        {
            for (int i=0;i<dim/2;i++)
            {
                for (int j = dim - 1; j>dim/2; j--)
                {
                    if (TabFloat[i] == TabFloat[j])
                        return true;
                }
            }
            return false;
        }


        /// <summary>
        /// fonction pour tester si un tableau est symetrie ou non 
        /// </summary>
        /// <returns>retourne true si le tableau est symetrie sinon retourne false</returns>
        public bool SymetrieString()
        {
            for (int i = 0; i < dim / 2; i++)
            {
                for (int j = dim - 1; j > dim / 2; j--)
                {
                    if (TabString[i] == TabString[j])
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// fonction d'inverser un tableau de type float
        /// </summary>
        /// <returns>retourne un tableau de type float qui est l'inverse de tableau initial</returns>
        public float[] InverserFloat()
        {
            int i = 0;
            int j = TabFloat.Length - 1;
            while (i < j)
            {
                var temp = TabFloat[i];
                TabFloat[i] = TabFloat[j];
                TabFloat[j] = temp;
                i++;
                j--;
            }
            return TabFloat;
        }


        /// <summary>
        /// fonction d'inverser un tableau de type string
        /// </summary>
        /// <returns>retourne un tableau de type string qui est l'inverse de tableau initial</returns>
        public string[] InverserString()
        {
            int i = 0;
            int j = TabString.Length - 1;
            while (i < j)
            {
                var temp = TabString[i];
                TabString[i] = TabString[j];
                TabString[j] = temp;
                i++;
                j--;
            }
            return TabString;
        }


        /// <summary>
        /// fonction pour concatener deux tableaux de type float 
        /// </summary>
        /// <param name="Tab">le deuxième tableau concatené</param>
        /// <returns>retourne le tableau de type float qui est le resultat de concaténation de deux tableaux</returns>
        public float[] ConcatenerFloat(float[] Tab)
        {

            int TailleNouveauTableau = TabFloat.Length + Tab.Length;

            float[] tableauConcatene = new float[TailleNouveauTableau];

            int i = 0;

            foreach (float s in TabFloat)
            {
                tableauConcatene[i] = s;
            i++;
            }

            foreach (float s in Tab)
            {
                tableauConcatene[i] = s;
            i++;
            }

            return tableauConcatene;
        }


        /// <summary>
        /// fonction pour concatener deux tableaux de type string 
        /// </summary>
        /// <param name="Tab">le deuxième tableau concatené</param>
        /// <returns>retourne le tableau de type string qui est le resultat de concaténation de deux tableaux</returns>
        public string[] ConcatenerString(string[] Tab)
        {
            int TailleNouveauTableau = TabString.Length + Tab.Length;

            string[] tableauConcatene = new string[TailleNouveauTableau];

            int i = 0;

            foreach (string s in TabString)
            {
                tableauConcatene[i] = s;
                i++;
            }

            foreach (string s in Tab)
            {
                tableauConcatene[i] = s;
                i++;
            }

            return tableauConcatene;
        }

        /// <summary>
        /// fonction de fusion de deux tableau de type float et trier le tableau resultat
        /// </summary>
        /// <param name="Tab">le deuxième tableau à fusionner</param>
        /// <returns>retourne le tableau resultat de fusionnement et de tri</returns>
        public float[] FusionFloat(float[] Tab) 
        {
           float[] TabFinal = this.ConcatenerFloat(Tab);
            TriFloat(TabFinal);
            return TabFinal;
        }

        /// <summary>
        /// fonction de fusion de deux tableau de type string et trier le tableau resultat
        /// </summary>
        /// <param name="Tab">le deuxième tableau à fusionner </param>
        /// <returns>retourne le tableau resultat de fusionnement et de tri</returns>
        public string[] FusionString(String[] Tab)
        {
            string[] TabFinal = this.ConcatenerString(Tab);
            TriString(TabFinal);
            return TabFinal;
        }
    }
}
