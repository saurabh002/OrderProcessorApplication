using Microsoft.AspNetCore.Mvc;
using Moq;
using OrderProcecssingAPI.Processor;
using OrderProcessingAPI.Core.Interfaces;
using OrderProcessingAPI.Service;
using System;
using System.Threading.Tasks;
using Xunit;

namespace OrderProcessingAPI.Test
{
    public class OrderPaymentControllerTests
    {

        OrderPaymentController controller;
        Mock<OrderPaymentService> mockPaymentsService;

        public OrderPaymentControllerTests()
        {
            controller = new OrderPaymentController(new OrderPaymentService(new OrderPaymentProcessorFactory()));
            mockPaymentsService = new Mock<OrderPaymentService>();
        }
        [Fact]
        public async Task Book_OK()
        {
            var response = await controller.ProcessPayment("book");

            var result = response as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal($"{Helper.RoyalityDepartmentHelper} - { Helper.ComissionHelper}", result.Value);
        }

        [Fact]
        public async Task Upgrade_OK()
        {
            var response = await controller.ProcessPayment("upgrade");

            var result = response as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal($"{Helper.UpgradeHelper} - { Helper.EmailNotificationSender}", result.Value);
        }

        [Fact]
        public async Task Video_OK()
        {
            var response = await controller.ProcessPayment("video");

            var result = response as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(Helper.VideoHelper, result.Value);
        }

        [Fact]
        public async Task Membership_OK()
        {
            var response = await controller.ProcessPayment("membership");

            var result = response as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal($"{Helper.MembershipHelper} - {Helper.EmailNotificationSender}", result.Value);
        }

        [Fact]
        public async Task PhysicalProduct_OK()
        {
            var response = await controller.ProcessPayment("sproduct");

            var result = response as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal($"{Helper.ShippingHelper} - { Helper.ComissionHelper}", result.Value);
        }
    }
}


