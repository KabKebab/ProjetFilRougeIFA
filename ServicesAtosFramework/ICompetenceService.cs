using BDDAtosFramework;
using ModelAtosFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesAtosFramework
{
   public interface ICompetenceService
    {
        CompetenceModel GetCompetence();

        List<CompetenceModel> GetCompetenceList();

        void AjouterCompetence(string intitule, int typeCompetence);

        void ModifierCompetence(COMPETENCE competence);

        
    }
}
