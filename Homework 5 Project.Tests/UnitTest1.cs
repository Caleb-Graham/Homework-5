using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using AsyncBreakfast;

namespace Homework_5_Project.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task ToastBreadAsyncIsCalled()
        {
            Toast result = await Program.ToastBreadAsync(2);


            Assert.IsTrue(result.wasCalled);
        }

        [TestMethod]
        public async Task MakeToastWithButterAndJamAsyncIsCalled()
        {
            Toast result = await Program.MakeToastWithButterAndJamAsync(2);


            Assert.IsTrue(result.wasCalled);
        }

        [TestMethod]
        public void PoutOJIsCalled()
        {
            Juice result = Program.PourOJ();

            Assert.IsTrue(result.wasCalled);
        }

        [TestMethod]
        public void ApplyJamIsCalled()
        {
            Toast toast = new Toast();
            Toast result = Program.ApplyJam(toast);

            Assert.IsTrue(result.wasCalled);
        }

        [TestMethod]
        public void ApplyButterIsCalled()
        {
            Toast toast = new Toast();
            Toast result = Program.ApplyButter(toast);

            Assert.IsTrue(result.wasCalled);
        }

        [TestMethod]
        public void PoutCoffeeIsCalled()
        {
            Coffee result = Program.PourCoffee();

            Assert.IsTrue(result.wasCalled);
        }

        [TestMethod]
        public async Task FryBaconAsyncIsCalled()
        {
            Bacon result = await Program.FryBaconAsync(2);


            Assert.IsTrue(result.wasCalled);
        }

        [TestMethod]
        public async Task FryEggsAsyncIsCalled()
        {
            Egg result = await Program.FryEggsAsync(2);


            Assert.IsTrue(result.wasCalled);
        }


    }
}
