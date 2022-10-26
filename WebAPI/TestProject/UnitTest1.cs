using System;
using Xunit;
using WebAPI.Controllers;
using Contracts;
using Contracts.Location;
using Microsoft.AspNetCore.Mvc;

namespace TestProject
{
    public class UnitTest1
    {
        private readonly LocationController _location;
        private readonly ICountryRepository _service;
        private ILoggerManager _logger;

        private IRepositoryWrapper _repository;

        public UnitTest1()
        {
            _location = new LocationController(_logger, _repository);
        }

        [Fact]
        public void GetCountry_WhenCalled_ReturnsOkResult()
        {
            //Act
            var okResult = _location.GetCountryAll();

            //Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        public void GetCityByCountryId_UnknownCountryIDPassed_ReturnsNotFoundResult()
        {
            // Act
            var notFoundResult = _location.GetCities("xxx");
            // Assert
            Assert.IsType<NotFoundResult>(notFoundResult);
        }
        [Fact]
        public void GetCityByCountryId_ExistingCountryIDPassed_ReturnsOkResult()
        {
            // Arrange
            var countryid = "1";
            // Act
            var okResult = _location.GetCities(countryid);
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }
        
    }
}
