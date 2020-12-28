using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;


namespace TestCI
{
    [TestFixture]
    class TestCase
    {

        string docPath = "";
        TextWriter tsw = null;
        [OneTimeSetUp]
        public void init()
        {
            //Tạo thư mục chứa result
            docPath = Path.Combine(TestContext.CurrentContext.WorkDirectory,
                this.GetType().Name);
            if (!Directory.Exists(docPath))
            {
                Directory.CreateDirectory(docPath);
            }
            //File text chứa error
            File.WriteAllText(Path.Combine(docPath, "ErrorList.txt"), String.Empty);

            tsw = new StreamWriter(Path.Combine(docPath, "ErrorList.txt"), true);
        }
        [Test]
        public void TestCase_1()
        {
            Triangle _tri = new Triangle(2.5, 3.5, 4.5);
            try
            {
                Assert.AreEqual("LA TAM GIAC THUONG", _tri.checkValid());
                Assert.AreEqual("10.5", _tri.tinhChuVi());
            }
            catch (Exception ex)
            {
                tsw.WriteLine(TestContext.CurrentContext.Result.Message);
                throw;
            }

        }
        [Test]
        public void TestCase_2()
        {
            Triangle _tri = new Triangle(4 / 2, 3, 4);
            try
            {
                Assert.AreEqual("LA TAM GIAC THUONG", _tri.checkValid());
                Assert.AreEqual("9", _tri.tinhChuVi());
            }
            catch (Exception ex)
            {
                tsw.WriteLine(TestContext.CurrentContext.Result.Message);
                throw;
            }

        }
        [Test]
        public void TestCase_3()
        {
            Triangle _tri = new Triangle(2.5, 2.5, 4);
            try
            {
                Assert.AreEqual("LA TAM GIAC CAN", _tri.checkValid());
                Assert.AreEqual("9", _tri.tinhChuVi());
            }
            catch (Exception ex)
            {
                tsw.WriteLine(TestContext.CurrentContext.Result.Message);
                throw;
            }
        }
        [Test]
        public void TestCase_4()
        {
            Triangle _tri = new Triangle(4 / 2, 2, 3);
            try
            {
                Assert.AreEqual("LA TAM GIAC CAN", _tri.checkValid());
                Assert.AreEqual("7", _tri.tinhChuVi());
            }
            catch (Exception ex)
            {
                tsw.WriteLine(TestContext.CurrentContext.Result.Message);
                throw;
            }
        }
        [Test]
        public void TestCase_5()
        {
            Triangle _tri = new Triangle(3.5, 3.5, 3.5);
            try
            {
                Assert.AreEqual("LA TAM GIAC DEU", _tri.checkValid());
                Assert.AreEqual("10.5", _tri.tinhChuVi());
            }
            catch (Exception ex)
            {
                tsw.WriteLine(TestContext.CurrentContext.Result.Message);
                throw;
            }
        }
        [Test]
        public void TestCase_6()
        {
            Triangle _tri = new Triangle(4 / 2, 2, 2);
            try
            {
                Assert.AreEqual("LA TAM GIAC DEU", _tri.checkValid());
                Assert.AreEqual("6", _tri.tinhChuVi());
            }
            catch (Exception ex)
            {
                tsw.WriteLine(TestContext.CurrentContext.Result.Message);
                throw;
            }
        }
        [Test]
        public void TestCase_7()
        {
            Triangle _tri = new Triangle(5, 6, 7.810249676);
            try
            {
                Assert.AreEqual("LA TAM GIAC VUONG", _tri.checkValid());
                Assert.AreEqual("18.810249676", _tri.tinhChuVi());
            }
            catch (Exception ex)
            {
                tsw.WriteLine(TestContext.CurrentContext.Result.Message);
                throw;
            }
        }
        [Test]
        public void TestCase_8()
        {
            Triangle _tri = new Triangle(3, 4, 5);
            try
            {
                Assert.AreEqual("LA TAM GIAC VUONG", _tri.checkValid());
                Assert.AreEqual("12", _tri.tinhChuVi());
            }
            catch (Exception ex)
            {
                tsw.WriteLine(TestContext.CurrentContext.Result.Message);
                throw;
            }
        }
        [Test]
        public void TestCase_9()
        {
            Triangle _tri = new Triangle(4 / 2, 2, 2.82842712474619);
            try
            {
                Assert.AreEqual("LA TAM GIAC VUONG CAN", _tri.checkValid());
                Assert.AreEqual("6.82842712474619", _tri.tinhChuVi());
            }
            catch (Exception ex)
            {
                tsw.WriteLine(TestContext.CurrentContext.Result.Message);
                throw;
            }
        }
        [Test]
        public void TestCase_10()
        {
            Triangle _tri = new Triangle(-1, 2, 3);
            try
            {
                Assert.AreEqual("KHONG PHAI TAM GIAC", _tri.checkValid());
                Assert.AreEqual("KHONG CO CHU VI", _tri.tinhChuVi());
            }
            catch (Exception ex)
            {
                tsw.WriteLine(TestContext.CurrentContext.Result.Message);
                throw;
            }
        }
        [Test]
        public void TestCase_11()
        {
            Triangle _tri = new Triangle(0, 0, 0);
            try
            {
                Assert.AreEqual("KHONG PHAI TAM GIAC", _tri.checkValid());
                Assert.AreEqual("KHONG CO CHU VI", _tri.tinhChuVi());
            }
            catch (Exception ex)
            {
                tsw.WriteLine(TestContext.CurrentContext.Result.Message);
                throw;
            }
        }
        [Test]
        public void TestCase_12()
        {
            Triangle _tri = new Triangle(1, 1, 3);
            try
            {
                Assert.AreEqual("KHONG PHAI TAM GIAC", _tri.checkValid());
                Assert.AreEqual("KHONG CO CHU VI", _tri.tinhChuVi());
            }
            catch (Exception ex)
            {
                tsw.WriteLine(TestContext.CurrentContext.Result.Message);
                throw;
            }
        }

        [Test]
        public void TestCase_13()
        {
            Triangle _tri = new Triangle(1, 1, 2);
            try
            {
                Assert.AreEqual("KHONG PHAI TAM GIAC", _tri.checkValid());
                Assert.AreEqual("KHONG CO CHU VI", _tri.tinhChuVi());
            }
            catch (Exception ex)
            {
                tsw.WriteLine(TestContext.CurrentContext.Result.Message);
                throw;
            }
        }
    }
}
