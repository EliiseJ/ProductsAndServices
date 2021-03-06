﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.RuleClasses;
namespace Open.Tests.Archetypes.RuleClasses {
    [TestClass] public class IntegerVariableTests : CommonTests<IntegerVariable> {
        protected override IntegerVariable GetRandomObj() { return IntegerVariable.Random(); }
        [TestMethod] public override void IsEqualTest() {
            var s = GetRandom.Int32();
            Assert.IsFalse(Obj.IsEqual(s));
            Assert.IsTrue(Obj.IsEqual(Obj.Value));
        }
        [TestMethod] public void IsNotEqualTest() {
            var s = GetRandom.Int32();
            Assert.IsTrue(Obj.IsNotEqual(s));
            Assert.IsFalse(Obj.IsNotEqual(Obj.Value));
        }
        [TestMethod] public void IsGreaterTest() {
            var s = Obj.Value - GetRandom.Int32(0, 10000);
            Assert.IsTrue(Obj.IsGreater(s));
            Assert.IsFalse(Obj.IsGreater(Obj.Value));
        }
        [TestMethod] public void IsNotGreaterTest() {
            var s = Obj.Value - GetRandom.Int32(0, 10000);
            Assert.IsFalse(Obj.IsNotGreater(s));
            Assert.IsTrue(Obj.IsNotGreater(Obj.Value));
        }
        [TestMethod] public void IsLessTest() {
            var s = Obj.Value + GetRandom.Int32(0, 10000);
            Assert.IsTrue(Obj.IsLess(s));
            Assert.IsFalse(Obj.IsLess(Obj.Value));
        }
        [TestMethod] public void IsNotLessTest() {
            var s = Obj.Value + GetRandom.Int32(0, 10000);
            Assert.IsFalse(Obj.IsNotLess(s));
            Assert.IsTrue(Obj.IsNotLess(Obj.Value));
        }
        [TestMethod] public void ConvertTest() {
            var s = GetRandom.Int32();
            Assert.AreEqual(s, Obj.Convert(s.ToString(UseCulture.Invariant)));
        }
        [TestMethod] public void ValueTest() {
            Obj = new IntegerVariable();
            TestProperty(() => Obj.Value, x => Obj.Value = x, 0);
        }
        [TestMethod] public void IsEmptyTest() {
            Assert.IsFalse(Obj.IsEmpty());
            Assert.IsTrue(IntegerVariable.Empty.IsEmpty());
            Assert.IsFalse(IntegerVariable.Random().IsEmpty());
            Assert.IsFalse(new IntegerVariable().IsEmpty());
        }
        [TestMethod] public void EmptyTest() { TestSingleton(() => IntegerVariable.Empty); }
    }
}
