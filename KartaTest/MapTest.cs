using System;
using Karta;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KartaTest {
    [TestClass]
    public class MapTest {
      [TestMethod]
      public void InitializeValuesArray() {
        var map = new Map<float>(10, 10, 1f);
        Assert.AreEqual(100, map.values.Length);
        Assert.AreEqual(1, map.values[20]);
      }

      [TestMethod]
      public void GetShouldGetTheCorrectValue() {
        var map = new Map<float>(3, 3, 0f);
        map.values[4] = 2f;
        Assert.AreEqual(2f, map.Get(1, 1));
      }

      [TestMethod]
      public void GetSafeShouldReturnNullIfOutOfBounds() {
        var map = new Map<float>(3, 3, 0f);
        map.values[4] = 2f;
        Assert.AreEqual(map.GetSafe(-1, 0), null);
        Assert.AreEqual(map.GetSafe(0, -1), null);
        Assert.AreEqual(map.GetSafe(3, 2), null);
        Assert.AreEqual(map.GetSafe(2, 3), null);
      }

      [TestMethod]
      public void GetSafeShouldReturnCorrectValue() {
        var map = new Map<float>(3, 3, 0f);
        map.values[0] = 2f;
        Assert.AreEqual(map.GetSafe(0, 0), 2f);

        map = new Map<float>(3, 3, 0f);
        map.values[8] = 2f;
        Assert.AreEqual(map.GetSafe(2, 2), 2f);
      }

      [TestMethod]
      public void SetShouldSetTheValueOfTheCorrectValue() {
        var map = new Map<float>(3, 3, 0f);
        map.Set(2, 1, 2f);
        Assert.AreEqual(2f, map.values[5]);
      }

      [TestMethod]
      public void SetAllShouldSetAllValuesToTheSpecifiedValue() {
        var map = new Map<float>(3, 3, 0f);
        map.SetAll(5f);
        Assert.AreEqual(5f, map.values[0]);
        Assert.AreEqual(5f, map.values[1]);
        Assert.AreEqual(5f, map.values[2]);
        Assert.AreEqual(5f, map.values[3]);
      }
    }
}
