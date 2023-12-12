using BusinessLayer;
using Moq;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public  class ClientBusinessTests
    {
        private Mock<IClientRepository> mockClientRepository;
        private ClientBusiness clientBusiness;
        private Client testClient;
        private int testTicketId;
        private int testNumberOfPeople;

        [TestInitialize]
        public void Setup()
        {
            mockClientRepository = new Mock<IClientRepository>();
            clientBusiness = new ClientBusiness(mockClientRepository.Object);
            testClient = new Client();
            testTicketId = 9999;
            testNumberOfPeople = 10;
        }

        [TestMethod]
        public void GetAllArrangements_ReturnsListOfArrangements()
        {
            // Arrange
            var expectedArrangements = new List<Arrangement> { new Arrangement(), new Arrangement() };
            mockClientRepository.Setup(repo => repo.GetAllArrangements()).Returns(expectedArrangements);

            // Act
            var result = clientBusiness.GetAllArrangements();

            // Assert
            Assert.AreEqual(expectedArrangements, result);
        }

        [TestMethod]
        public void GetAllClientArrangements_ReturnsListOfClientArrangements()
        {
            // Arrange
            var client = new Client { clientId = 1 };
            var expectedArrangements = new List<Object> { new Object(), new Object() };
            mockClientRepository.Setup(repo => repo.GetAllClientArrangements(client)).Returns(expectedArrangements);

            // Act
            var result = clientBusiness.GetAllClientArrangements(client);

            // Assert
            Assert.AreEqual(expectedArrangements, result);
        }

        [TestMethod]
        public void GetAllArrangementsByLocationTypeAndDate_ReturnsListOfArrangements()
        {
            // Arrange
            int locationId = 1;
            string typeOfArrangement = "Conference";
            DateTime from = DateTime.Now;
            var expectedArrangements = new List<Object> { new Object(), new Object() };
            mockClientRepository.Setup(repo => repo.GetAllArrangementsByLocationTypeAndDate(locationId, typeOfArrangement, from)).Returns(expectedArrangements);

            // Act
            var result = clientBusiness.GetAllArrangementsByLocationTypeAndDate(locationId, typeOfArrangement, from);

            // Assert
            Assert.AreEqual(expectedArrangements, result);
        }

        [TestMethod]
        public void BookAnArrangement_ReturnsSuccessMessage_WhenBookingIsSuccessful()
        {
            // Arrange
            int clientId = 1;
            int arrangementId = 2;
            int numberOfPeople = 3;
            mockClientRepository.Setup(repo => repo.BookAnArrangement(clientId, arrangementId, numberOfPeople)).Returns(1);

            // Act
            var result = clientBusiness.BookAnArrangement(clientId, arrangementId, numberOfPeople);

            // Assert
            Assert.AreEqual("Arrangement successfully booked!", result);
        }

        [TestMethod]
        public void BookAnArrangement_ReturnsFailureMessage_WhenBookingFails()
        {
            // Arrange
            int clientId = 1;
            int arrangementId = 2;
            int numberOfPeople = 3;
            mockClientRepository.Setup(repo => repo.BookAnArrangement(clientId, arrangementId, numberOfPeople)).Returns(0);

            // Act
            var result = clientBusiness.BookAnArrangement(clientId, arrangementId, numberOfPeople);

            // Assert
            Assert.AreEqual("Booking an arrangement failed!", result);
        }

        [TestMethod]
        public void GetAllClientTickets_ReturnsListOfTickets()
        {
            // Arrange
            var expectedTickets = new List<Object> { /* ... objects representing tickets ... */ };
            mockClientRepository.Setup(repo => repo.GetAllClientTickets(testClient)).Returns(expectedTickets);

            // Act
            var tickets = clientBusiness.GetAllClientTickets(testClient);

            // Assert
            Assert.AreEqual(expectedTickets, tickets, "The tickets returned should match the expected list of tickets.");
        }

        [TestMethod]
        public void BookATicket_ReturnsSuccessMessage_WhenRowsAffectedIsGreaterThanZero()
        {
            // Arrange
            mockClientRepository.Setup(repo => repo.BookATicket(testClient, testTicketId, testNumberOfPeople)).Returns(1);

            // Act
            var result = clientBusiness.BookATicket(testClient, testTicketId, testNumberOfPeople);

            // Assert
            Assert.AreEqual("Ticket successfully booked!", result, "The success message should be returned when a ticket is booked.");
        }

        [TestMethod]
        public void BookATicket_ReturnsFailureMessage_WhenRowsAffectedIsZero()
        {
            // Arrange
            mockClientRepository.Setup(repo => repo.BookATicket(testClient, testTicketId, testNumberOfPeople)).Returns(0);

            // Act
            var result = clientBusiness.BookATicket(testClient, testTicketId, testNumberOfPeople);

            // Assert
            Assert.AreEqual("Booking a ticket failed!", result, "The failure message should be returned when booking a ticket fails.");
        }

    }
}
