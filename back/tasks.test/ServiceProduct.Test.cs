using shop.manoel.shared.Interfaces;
using shop.manoel.test.Base;
using Xunit.Abstractions;

namespace shop.manoel.test
{
    public class ServiceProduct_Test : Base_Service_Test<Program>
    {
        private readonly IServiceOrder service;

        public ServiceProduct_Test(ITestOutputHelper outputWriter) : base(outputWriter)
        {
            service = GetService<IServiceOrder>();
        }

        [Fact]
        private async Task CalcOrderBoxAsync()
        {
            var response1 = await service.CalcOrderBoxAsync(Fake_Data_Test.OrderRequest_OK_1());
            var response2 = await service.CalcOrderBoxAsync(Fake_Data_Test.OrderRequest_OK_2());
            var response3 = await service.CalcOrderBoxAsync(Fake_Data_Test.OrderRequest_OK_3());


            Assert.NotNull(response1.FirstOrDefault().caixas.FirstOrDefault().caixa_id != null);
            Assert.NotNull(response2.FirstOrDefault().caixas.FirstOrDefault().caixa_id != null);
            Assert.NotNull(response3.FirstOrDefault().caixas.FirstOrDefault().caixa_id != null);
        }
    }
}
