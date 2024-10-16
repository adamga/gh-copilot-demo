using albums_api.Controllers;
using albums_api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace albums_api.Tests.Controllers
{
    public class AlbumControllerTests
    {
        [Fact]
        public void Get_ReturnsOkResultWithListOfAlbums()
        {
            // Arrange
            var controller = new AlbumController();

            // Act
            var result = controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var albums = Assert.IsType<List<Album>>(okResult.Value);
            Assert.NotEmpty(albums);
        }

        [Fact]
        public void Get_WithValidId_ReturnsOkResultWithAlbum()
        {
            // Arrange
            var controller = new AlbumController();
            var id = 1;

            // Act
            var result = controller.Get(id);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var album = Assert.IsType<Album>(okResult.Value);
            Assert.Equal(id, album.Id);
        }

        [Fact]
        public void Get_WithInvalidId_ReturnsNotFoundResult()
        {
            // Arrange
            var controller = new AlbumController();
            var id = -1;

            // Act
            var result = controller.Get(id);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}