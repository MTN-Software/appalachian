using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTN_French
{
    class Verbs
    {

        public Verbs()
        {

        }

        public string[] getSubjects()
        {
            string[] subjects = { "je","tu","elle","nous","vous","elles" };
            return subjects;
        }
        public virtual string[] getIrregulars()
        {
            string[] irregular = 
            {
                "aller", "appeller",
                "avoir", "conduire", "courir", "dire",
                "dormir", "être", "faire",
                "mettre", "partir", "préférer",
                "prendre", "rire", "sortir",
                "traduire", "apprendre", "atteindre",
                "acquérir", "boire", "battre", "comprendre",
                "connaître", "construire", "couvrir",
                "craindre", "croire",
                "décevoir", "découvrir", "devoir",
                "écrire", "instruire", "joindre",
                "lire", "offrir", "ouvrir",
                "paraître", "peindre", "pouvoir",
                "recevoir", "savoir", "souffrir",
                "surprendre", "suivre", "tenir",
                "venir", "vivre", "voir", "vouloir"
            };

            return irregular;
        }
        public string DetermineVerbType(string verbIn)
        {
            string verbType = string.Empty;
            string[] irreg = getIrregulars();
            for (int verb = 0; verb < irreg.Length; verb++ )
            {
                if (verbIn == irreg[verb])
                {
                    verbType = "irregular";
                    break;
                }
                else
                {
                    verbType = "regular";
                }
            }

            return verbType;
        }

        public virtual string Conjugate(string infinitive, string subject)
        {
            string rootVerb = infinitive.Substring(0, infinitive.Length - 2);
            string result = string.Empty;
            bool g_Exception = infinitive.Substring(infinitive.Length - 3, 2).First() != 'g';
            switch (subject)
            {
                case "je":
                    result = string.Concat(rootVerb, getConjEndings(infinitive.Substring(infinitive.Length - 2, 2), "je"));
                    break;
                case "tu":
                    result = string.Concat(rootVerb, getConjEndings(infinitive.Substring(infinitive.Length - 2, 2), "tu"));
                    break;
                case "elle":
                    result = string.Concat(rootVerb, getConjEndings(infinitive.Substring(infinitive.Length - 2, 2), "elle"));
                    break;
                case "nous":
                    result = g_Exception ? string.Concat(rootVerb, getConjEndings(infinitive.Substring(infinitive.Length - 2, 2), "nous")) : string.Concat(rootVerb, "e" + getConjEndings(infinitive.Substring(infinitive.Length - 2, 2), "nous"));
                    break;
                case "vous":
                    result = string.Concat(rootVerb, getConjEndings(infinitive.Substring(infinitive.Length - 2, 2), "vous"));
                    break;
                case "elles":
                    result = string.Concat(rootVerb, getConjEndings(infinitive.Substring(infinitive.Length - 2, 2), "elles"));
                    break;
                default:
                    break;
            }
            return result;
        }
    
        public string getConjEndings(string ending, string subject)
        {
            string result = string.Empty;
            if (ending == "er")
            {
                switch (subject)
                {
                    case "je":
                        result = "e";
                        break;
                    case "tu":
                        result = "es";
                        break;
                    case "elle":
                        result = "e";
                        break;
                    case "nous":
                        result = "ons";
                        break;
                    case "vous":
                        result = "ez";
                        break;
                    case "elles":
                        result = "ent";
                        break;
                    default:
                        break;
                }
            }

            if (ending == "re")
            {
                switch (subject)
                {
                    case "je":
                        result = "s";
                        break;
                    case "tu":
                        result = "s";
                        break;
                    case "elle":
                        result = string.Empty;
                        break;
                    case "nous":
                        result = "ons";
                        break;
                    case "vous":
                        result = "ez";
                        break;
                    case "elles":
                        result = "ent";
                        break;
                    default:
                        break;
                }
            }

            if (ending == "ir")
            {
                switch (subject)
                {
                    case "je":
                        result = "is";
                        break;
                    case "tu":
                        result = "is";
                        break;
                    case "elle":
                        result = "it";
                        break;
                    case "nous":
                        result = "issons";
                        break;
                    case "vous":
                        result = "issez";
                        break;
                    case "elles":
                        result = "issent";
                        break;
                    default:
                        break;
                }
            }

            return result;
        }
    }

    class IrregularVerbs : Verbs
    {
        public IrregularVerbs()
        {
            
        }

        public override string[] getIrregulars()
        {
            return base.getIrregulars();
        }

        public override string Conjugate(string infinitive, string subject)
        {
            return base.Conjugate(infinitive, subject);
        }

        public string[] ConjugateAll(string infinitive)
        {
            string[] subjects = base.getSubjects();
            List<string> results = new List<string>();

            for (int i = 0; i < subjects.Length; i++)
            {
                results.Add(this.Conjugate(infinitive, subjects[i]));
            }

            string[] result = results.ToArray();
            return result;
        }
    }

    class RegularVerbs : Verbs
    {
        public RegularVerbs()
        {

        }

        public override string Conjugate(string infinitive, string subject)
        {
            return base.Conjugate(infinitive, subject);
        }

        public string[] ConjugateAll(string infinitive)
        {
            string[] subjects = base.getSubjects();
            List<string> results = new List<string>();

            for (int i = 0; i < subjects.Length; i ++)
            {
                results.Add(base.Conjugate(infinitive, subjects[i]));
            }

            string[] result = results.ToArray();
            return result;
        }
    }
}
