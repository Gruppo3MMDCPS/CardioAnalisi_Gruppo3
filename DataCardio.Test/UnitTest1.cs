using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioAnalisiLibrary;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        //Punto 1 TestMethodFrequenzaMin
        [TestMethod]
        [DataTestMethod]
        [DataRow(20, 140)]
        [DataRow(33, 131)]
        [DataRow(0, -1)]
        [DataRow(-3, -1)]
        [DataRow(200, -1)]
        public void TestMethodFrequenzaMin(int età, int frequenzaMin)
        {
            double risposta_attesa = frequenzaMin;
            double risposta = CardioAnalisiLibrary.DataCardio.CalcoloFrequenzaMin(età);

            Assert.AreEqual(risposta_attesa, risposta);
        }

        //Punto 1 TestMethodFrequenzaMax
        [TestMethod]
        [DataTestMethod]
        [DataRow(20, 180)]
        [DataRow(33, 168)]
        [DataRow(0, -1)]
        [DataRow(-3, -1)]
        [DataRow(200, -1)]
        public void TestMethodFrequenzaMax(int età, int frequenzaMax)
        {
            double risposta_attesa = frequenzaMax;
            double risposta = CardioAnalisiLibrary.DataCardio.CalcoloFrequenzaMax(età);

            Assert.AreEqual(risposta_attesa, risposta);
        }

        //Punto 2
        [TestMethod]
        [DataTestMethod]
        [DataRow(59, "Bradicardia")]
        [DataRow(60, "Normale")]
        [DataRow(100, "Normale")]
        [DataRow(87, "Normale")]
        [DataRow(120, "Tachicardia")]
        [DataRow(201, "-1")]
        public void TestMethodFreqCardiacaRiposo(int BattitiAlMinuto, string valoreFrequenza)
        {
            string risposta_attesa = valoreFrequenza;

            string risposta = CardioAnalisiLibrary.DataCardio.FreqCardiacaRiposo(BattitiAlMinuto);

            Assert.AreEqual(risposta_attesa, risposta);
        }

        //Punto 3
        [DataTestMethod]
        [DataRow("M", 17, 72, 180, 15, -1)]
        [DataRow("F", 0, 0, 0, 0, -1)]
        [DataRow("M", -43, -78, -170, -15, -1)]
        [DataRow("F", 17, 72, 180, 15, -1)]
        public void Test_calorie(string sesso, int bpm, int peso, int anni, int durata, int valore_atteso)
        {
            int valore_ricevuto = Convert.ToInt32(CardioAnalisiLibrary.DataCardio.Calorie_Bruciate(sesso, bpm, peso, anni, durata));

            Assert.AreEqual(valore_atteso, valore_ricevuto);
        }

        //Punto 4 Corsa
        [TestMethod]
        [DataTestMethod]
        [DataRow(2, 72, 130)]
        [DataRow(2.5, 80, 180)]
        [DataRow(-3, 80, -1)]
        [DataRow(3, -80, -1)]
        [DataRow(-3, -80, -1)]
        [DataRow(0, 0, -1)]
        [DataRow(0, 80, 0)]
        [DataRow(0, -80, -1)]
        [DataRow(3, 0, -1)]
        [DataRow(-3, 0, -1)]
        public void TestMethodSpesaEnergeticaCorsa(double KmPercorsi, double peso, double SpesaEnergeticaCorsa)
        {
            double risposta_attesa = SpesaEnergeticaCorsa;
            double risposta = CardioAnalisiLibrary.DataCardio.SpesaEnergeticaCorsa(KmPercorsi, peso);

            Assert.AreEqual(risposta_attesa, risposta);
        }

        //Punto 4 Camminata
        [TestMethod]
        [DataTestMethod]
        [DataRow(3, 70, 105)]
        [DataRow(2.5, 80, 100)]
        [DataRow(-3, 80, -1)]
        [DataRow(3, -80, -1)]
        [DataRow(-3, -80, -1)]
        [DataRow(0, 0, -1)]
        [DataRow(0, 80, 0)]
        [DataRow(0, -80, -1)]
        [DataRow(3, 0, -1)]
        [DataRow(-3, 0, -1)]
        public void TestMethodSpesaEnergeticaCamminata(double KmPercorsi, double peso, double SpesaEnergeticaCamminata)
        {
            double risposta_attesa = SpesaEnergeticaCamminata;
            double risposta = CardioAnalisiLibrary.DataCardio.SpesaEnergeticaCamminata(KmPercorsi, peso);

            Assert.AreEqual(risposta_attesa, risposta);
        }

        //Punto 5a
        [TestMethod]
        public void TestCalcoloMediaBattitiGiornaliera()
        {
            CardioAnalisiLibrary.DataCardio cardio = new CardioAnalisiLibrary.DataCardio();
            List<int> bpmgiornata = new List<int> { 40, 38, 48, 35 };
            double media;
            media = cardio.CalcoloMediaBattitiGiornaliera(bpmgiornata);
            Assert.AreEqual(40.25, media);
        }

        //Punto 5b
        [TestMethod]
        public void TestCalcoloBattitiRiposo()
        {
            CardioAnalisiLibrary.DataCardio cardio = new CardioAnalisiLibrary.DataCardio();
            List<int> bpmgiornata = new List<int> { 40, 38, 48, 35 };
            double media;
            media = cardio.CalcoloBattitiRiposo(bpmgiornata);
            Assert.AreEqual(40.25, media);
        }

        //Punto 5c
        [TestMethod]
        public void TestHRV()
        {
            CardioAnalisiLibrary.DataCardio cardio = new CardioAnalisiLibrary.DataCardio();
            double frequenza = 0;
            List<double> tempitempotraduebatti = new List<double> { 0.8, 1.2, 1.0, 0.6, 0.9 };
            frequenza = cardio.HRV(tempitempotraduebatti);
            Assert.AreEqual(1.93, frequenza);
        }

        //Punto 5d
        [TestMethod]
        public void TestOrdineCrescente()
        {
            CardioAnalisiLibrary.DataCardio cardio = new CardioAnalisiLibrary.DataCardio();
            List<int> bpmgiornata = new List<int> { 40, 38, 48, 35 };
            bpmgiornata = cardio.OrdineCrescente(bpmgiornata);
            Assert.AreEqual(35, bpmgiornata[0]);
        }
    }
}
