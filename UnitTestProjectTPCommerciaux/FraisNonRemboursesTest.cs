﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTPCommerciaux;

namespace UnitTestProjectTPCommerciaux
{
    [TestClass]
    public class FraisNonRemboursesTest
    {
        [TestMethod]
        public void nbNotesFraisNonRembourseesTest()
        {
            Commercial c, c1;
            ServiceCommercial sc;
            sc = new ServiceCommercial();
            c = new Commercial("Jean", "Dupond", 25, 'A');
            c1 = new Commercial("Paul", "Duval", 10, 'B');
            sc.ajouterCommercial(c);
            sc.ajouterCommercial(c1);

            NoteFrais f, f1, f2, f3, f4;
            f = new NoteFrais(new DateTime(2013, 11, 12), c);
            f1 = new NoteFrais(new DateTime(2013, 11, 15), c);
            f1.setFraisRembourser();
            f2 = new NoteFrais(new DateTime(2013, 11, 18), c1);
            f3 = new NoteFrais(new DateTime(2013, 11, 22), c1);
            f3.setFraisRembourser();
            f4 = new NoteFrais(new DateTime(2013, 11, 25), c1);
            f4.setFraisRembourser();
            Assert.AreEqual(2, sc.nbFraisNonRembourses());
        }

        [TestMethod]
        public void nbNotesFraisNonRembourseesTestInterface()
        {
            ServiceCommercial sc = new ServiceCommercial();
            IVoyageurCommercial c = new Commercial("Jean", "Dupond", 25, 'A');
            sc.ajouterCommercial(c);

            IVoyageurCommercial c1 = new Commercial("Duval", "Paul", 10, 'B');
            sc.ajouterCommercial(c1);

            NoteFrais f = new NoteFrais(new DateTime(2014, 10, 23), c);
            f.setFraisRembourser();
            NoteFrais f1 = new NoteFrais(new DateTime(2014, 10, 24), c);
            NoteFrais f2 = new NoteFrais(new DateTime(2014, 10, 24), c1);
            f2.setFraisRembourser();
            Assert.AreEqual(1, sc.nbFraisNonRembourses());
        }
    }
}