using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Model
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private int idModel;
        public string nume_model;
        public string tip;


        public Model()
        {
            nume_model = tip = string.Empty;
            idModel = 0;
        }
        public Model(int idModel, string Nume, string Tip)
        {
            this.idModel = idModel;
            this.nume_model = Nume;
            this.tip = Tip;



        }

        public Model(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            idModel = Convert.ToInt32(dateFisier[0]);
            nume_model = dateFisier[1];
            tip = dateFisier[2];

        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectProdusPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idModel,
                nume_model,
                tip
              );

            return obiectProdusPentruFisier;
        }

        public void SetIdModel(int idModel)
        {
            this.idModel = idModel;
        }

        public int GetIdModel()
        {
            return idModel;
        }


        public string Get_nume()
        {
            return nume_model;
        }

        public string Get_tip()
        {
            return tip;
        }

    }
}
