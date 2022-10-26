namespace CashRegisterTest
{
	using CashRegister;
	using Moq;
	using Xunit;

	public class CashRegisterTest
	{
		[Fact]
		public void Should_process_execute_printing()
		{
			//given
			var printer = new SpyPrinter();
			var cashRegister = new CashRegister(printer);
			var purchase = new Purchase();
			//when
			cashRegister.Process(purchase);
			//then
			//verify that cashRegister.process will trigger print
			Assert.True(printer.HasPrintered);
		}

        [Fact]
        public void Should_return_given_context()
        {
			//given
			var printer = new Mock<Printer>();
            var cashRegister = new CashRegister(printer.Object);
            var purchase = new Mock<Purchase>();
            purchase.Setup(_ => _.AsString()).Returns("return  context.");
            //when
            cashRegister.Process(purchase.Object);
            //then
            //verify that cashRegister.process will trigger print
            printer.Verify(p => p.Print("return  context."));
        }
    }
}
