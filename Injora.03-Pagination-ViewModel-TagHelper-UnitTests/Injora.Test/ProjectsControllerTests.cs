using System.Collections.Generic;
using System.Linq;
using Moq;
using Injora.Controllers;
using Injora.Models;
using Xunit;
using Injora.Services;

namespace Injora.Tests
{
    public class ProjectsControllerTests
    {
        [Fact]
        public void Can_Paginate()
        {
            // Arrange
            Mock<IProjectRepository> mock = new Mock<IProjectRepository>();
            mock.Setup(m => m.Projects).Returns((new Project[] {
                new Project {ProjectID = 1, Name = "P1"},
                new Project {ProjectID = 2, Name = "P2"},
                new Project {ProjectID = 3, Name = "P3"},
                new Project {ProjectID = 4, Name = "P4"},
                new Project {ProjectID = 5, Name = "P5"}
            }).AsQueryable<Project>());

            ProjectsController controller = new ProjectsController(mock.Object);
            controller.PageSize = 3;
            // Act
            PagedListViewModel<Project> result = controller.List(2).ViewData.Model as PagedListViewModel<Project>;
            // Assert
            Project[] prodArray = result.Entities.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("P4", prodArray[0].Name);
            Assert.Equal("P5", prodArray[1].Name);
        }

        [Fact]
        public void Can_Send_Pagination_View_Model()
        {
            // Arrange
            Mock<IProjectRepository> mock = new Mock<IProjectRepository>();
            
            mock.Setup(m => m.Projects).Returns((new Project[] {
                    new Project {ProjectID = 1, Name = "P1"},
                    new Project {ProjectID = 2, Name = "P2"},
                    new Project {ProjectID = 3, Name = "P3"},
                    new Project {ProjectID = 4, Name = "P4"},
                    new Project {ProjectID = 5, Name = "P5"}
                    }).AsQueryable());
            // Arrange
            ProjectsController controller = new ProjectsController(mock.Object) { PageSize = 3 };
            // Act
            PagedListViewModel<Project> result = controller.List(2).ViewData.Model as PagedListViewModel<Project>;
            // Assert
            PagingInfo pageInfo = result.PagingInfo;
            
            Assert.Equal(2, pageInfo.CurrentPage);
            Assert.Equal(3, pageInfo.ItemsPerPage);
            Assert.Equal(5, pageInfo.TotalItems);
            Assert.Equal(2, pageInfo.TotalPages);
        }
    }
}