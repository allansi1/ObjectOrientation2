using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Net.NetworkInformation;

namespace Personne
{
    public class PersonneDesiree
    {
        private string sexe;
        private int min_age;
        private int max_age;
        private string pays_origine;
        private string couleur_cheveu;
        private string couleur_yeux;
        private string education;

        public string Sexe { get; private set; }
        public int MinAge { get; private set; }
        public int MaxAge { get; private set; }
        public string PaysOrigine { get; private set; }
        public string CouleurCheveu { get; private set; }
        public string CouleurYeux { get; private set; }
        public string Education { get; private set; }

        private PersonneDesiree(string sexe)
        {
            this.Sexe = sexe;
            this.MinAge = 18;
            this.MaxAge = 110;
            this.PaysOrigine = "";
            this.CouleurCheveu = "";
            this.CouleurYeux = "";
            this.Education = "";
        }

        public class Builder
        {
            private PersonneDesiree p;

            public Builder(string sexe)
            {
                this.p = new PersonneDesiree(sexe);
            }

            public Builder WithMinAge(int min_age)
            {

                if (min_age < 18)
                {
                    this.p.MinAge = 18;
                    Console.WriteLine("L'âge minimal doit être plus grand ou égal à 18 ans. Valeur d'âge minimal ajusté.");
                }
                else
                {
                    this.p.MinAge = Math.Max(18,min_age);
                }
                return this;
            }
            public Builder WithMaxAge(int max_age)
            {
                this.p.MaxAge = Math.Min(110, max_age);
                return this;
            }
            public Builder WithPaysOrigine(string pays_origine)
            {
                this.p.PaysOrigine = pays_origine;
                return this;
            }

            public Builder WithColeurCheveau(string coleur_cheveau)
            {
                this.p.CouleurCheveu = coleur_cheveau;
                return this;
            }

            public Builder WithColeurYeux(string coleur_yeux)
            {
                this.p.CouleurYeux = coleur_yeux;
                return this;
            }

            public Builder WithEducation(string education)
            {
                this.p.Education = education;
                return this;
            }

            public PersonneDesiree Build()
            {
                return this.p;
            }

        }
    }
}

