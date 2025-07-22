using ServiceInterface;
using Xunit;

namespace Test
{
    public class MasterControllerTest
    {
        private readonly IMasterService _masterService;
        public MasterControllerTest(IMasterService masterService)
        {
            _masterService = masterService;
        }

        [Fact]
        public void Get_Profile_List()
        {
            //// Arrange
            //var mockService = new Mock<IMasterService>();
            //mockService.Setup(s => s.GetProfileList("", ""))
            //    .Returns(new Profile { Id = "efwe", Active = true, Code = "AB", Name = "dsfs", CreatedBy = "XYZ" })

            //var controller = new MasterController(mockService.Object);

            //// Act
            //var result = controller.Get(1);

            //// Assert
            //var okResult = Assert.IsType<OkObjectResult>(result.Result);
            //var product = Assert.IsType<Profile>(okResult.Value);
            //Assert.Equal("3243232esfssdfsd", Profile.Id);
            //Assert.Equal("Laptop", Profile.Name);
        }

        [Fact]
        public void Get_ReturnsNotFound_WhenProfileNotExist()
        {
            //// Arrange
            //var mockService = new Mock<IMasterService>();
            //mockService.Setup(s => s.GetProfileList("","")).Returns((Profile)null);

            //var controller = new ProductsController(mockService.Object);

            //// Act
            //var result = controller.Get(2);

            //// Assert
            //Assert.IsType<NotFoundResult>(result.Result);
        }

    }
}
