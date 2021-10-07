
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BowsFormulaOne.Server.Controllers;
using BowsFormulaOneAPI.Data;
using BowsFormulaOneAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Json;
using BowsFormulaOne.Server.Helpers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Tests;

public class BowsControllerTest
{
    [Fact]
    public async Task GetCardUsers_Returns_Not_Found_Response()
    {
        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(databaseName: "BowsFormulaOne").Options;
        var context = new DataContext(options);

        var validator = new Mock<IValidators>();
        var encryption = new Mock<IEncryption>();
        var controller = new BowsController(context, validator.Object, encryption.Object);

        ActionResult<UserDto> result = await controller.GetCardUserDto("r7jTG83qBy5wGO4L") ;

        Assert.IsType<NotFoundObjectResult>(result.Result);
        Assert.Null(result.Value);
    }
}
