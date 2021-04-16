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

    }
}
