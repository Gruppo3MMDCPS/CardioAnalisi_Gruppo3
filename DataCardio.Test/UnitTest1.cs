﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        [DataRow("Uomo", 17, 72, 180, 15, -1)]
        [DataRow("Donna", 0, 0, 0, 0, -1)]
        [DataRow("Uomo", -43, -78, -170, -15, -1)]
        [DataRow("Donna", 17, 72, 180, 15, -1)]
        public void Test_calorie(string sesso, int bpm, int peso, int anni, int durata, int valore_atteso)
        {
            int valore_ricevuto = Convert.ToInt32(CardioAnalisiLibrary.DataCardio.Calorie_Bruciate(sesso, bpm, peso, anni, durata));

            Assert.AreEqual(valore_atteso, valore_ricevuto);
        }

        //Punto 4
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
    }
}
