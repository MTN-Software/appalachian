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
            return null;    // placeholder
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
    }
}
