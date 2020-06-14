using BDDAtosFramework;
using ModelAtosFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServicesAtosFramework
{
   public class CompetenceService : ICompetenceService

    {
        public void AjouterCompetence(string intitule, int typeCompetence)
        {
            using (Context c = new Context())
            {
                COMPETENCE competence = new COMPETENCE();
                //Hash MotDepasseHash = new Hash();
               competence.intitule = intitule;
                competence.id_TYPE_COMPETENCE = typeCompetence;


               
                c.SaveChanges();
            }
        }

        public CompetenceModel GetCompetence()
        {

            using (var context = new Context())
            {
                return context.COMPETENCE.Select(a => new CompetenceModel { id = a.id, intitule = a.intitule, id_TYPE_COMPETENCE= a.id_TYPE_COMPETENCE }).First();
            }


        }

        public List<CompetenceModel> GetCompetenceList()
        {

            using (Context c = new Context())
            {
                return c.COMPETENCE.Select(a => new CompetenceModel { id = a.id, intitule = a.intitule, id_TYPE_COMPETENCE= a.id_TYPE_COMPETENCE}).ToList();
            }


        }

        public void ModifierCompetence(COMPETENCE competence)
        {
            COMPETENCE competenceModif = new COMPETENCE();

            using (Context c = new Context())
            {
                competenceModif = c.COMPETENCE.First(a => a.id == competence.id);
                competenceModif.id = competence.id;
                competenceModif.intitule = competence.intitule;
                competenceModif.id_TYPE_COMPETENCE = competence.id_TYPE_COMPETENCE;

                c.SaveChanges();
            }
        }
    }
}
