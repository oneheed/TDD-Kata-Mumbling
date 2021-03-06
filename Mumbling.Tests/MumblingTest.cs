﻿using FluentAssert;
using NUnit.Framework;

namespace Mumbling.Tests
{
    [TestFixture]
    public class MumblingTest
    {
        private Accuml _accuml = new Accuml();

        [Test]
        public void Test_Entered_x_ShouldReturn_X()
        {
            var actual = _accuml.Accum("x");
            var expected = "X";
            actual.ShouldBeEqualTo(expected);
        }

        [Test]
        public void Test_Entered_xb_ShouldBe_X_Bb()
        {
            var actual = _accuml.Accum("xb");
            var expected = "X-Bb";
            actual.ShouldBeEqualTo(expected);
        }

        [Test]
        public void Test_Entered_XB_ShouldBe_X_Bb()
        {
            var actual = _accuml.Accum("XB");
            var expected = "X-Bb";
            actual.ShouldBeEqualTo(expected);
        }

        [Test]
        public void Test_Entered_bnc_ShouldBe_B_Nn_Ccc()
        {
            var actual = _accuml.Accum("bnc");
            var expected = "B-Nn-Ccc";
            actual.ShouldBeEqualTo(expected);
        }

        [Test]
        public void Test_Entered_GHF_ShouldBe_G_Hh_Fff()
        {
            var actual = _accuml.Accum("GHF");
            var expected = "G-Hh-Fff";
            actual.ShouldBeEqualTo(expected);
        }

        [Test]
        public void Test_Entered_yUf_ShouldBe_Y_Uu_Fff()
        {
            var actual = _accuml.Accum("yUf");
            var expected = "Y-Uu-Fff";
            actual.ShouldBeEqualTo(expected);
        }
    }
}