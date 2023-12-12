using DataLayer.Repositories;
using Shared.Interfaces;
using Moq;
using System.Runtime.Intrinsics.X86;

namespace UnitTests
{
    [TestClass]
    public class AdminBusinessTests
    {
        private Mock<IAdminRepository> mockAdminRepository;
        private AdminBusiness adminBusiness;

        [TestInitialize]
        public void Setup()
        {
            mockAdminRepository = new Mock<IAdminRepository>();
            adminBusiness = new AdminBusiness(mockAdminRepository.Object);
        }

        [TestMethod]
        public void GetAdmin_ReturnsAdmin_WhenCredentialsAreValid()
        {
            // Arrange
            var email = "test@example.com";
            var password = "password123";
            var expectedAdmin = new Admin { email = email, password = password };
            mockAdminRepository.Setup(repo => repo.GetAdmin(email, password)).Returns(expectedAdmin);

            // Act
            var result = adminBusiness.GetAdmin(email, password);

            // Assert
            Assert.AreEqual(expectedAdmin, result);
        }

        [TestMethod]
        public void GetAllClients_ReturnsListOfClients()
        {
            // Arrange
            var expectedClients = new List<Client> { new Client(), new Client() };
            mockAdminRepository.Setup(repo => repo.GetAllClients()).Returns(expectedClients);

            // Act
            var result = adminBusiness.GetAllClients();

            // Assert
            Assert.AreEqual(expectedClients, result);
        }

        [TestMethod]
        public void UpdateClient_ReturnsSuccessMessage_WhenUpdateIsSuccessful()
        {
            // Arrange
            var client = new Client();
            mockAdminRepository.Setup(repo => repo.UpdateClient(client)).Returns(1);

            // Act
            var result = adminBusiness.UpdateClient(client);

            // Assert
            Assert.AreEqual("Client successfully updated!", result);
        }

        [TestMethod]
        public void UpdateClient_ReturnsFailureMessage_WhenUpdateFails()
        {
            // Arrange
            var client = new Client();
            mockAdminRepository.Setup(repo => repo.UpdateClient(client)).Returns(0);

            // Act
            var result = adminBusiness.UpdateClient(client);

            // Assert
            Assert.AreEqual("Client's data update failed!", result);
        }

        [TestMethod]
        public void GetAllArrangements_ReturnsListOfArrangements()
        {
            // Arrange
            var expectedArrangements = new List<Arrangement> { new Arrangement(), new Arrangement() };
            mockAdminRepository.Setup(repo => repo.GetAllArrangements()).Returns(expectedArrangements);

            // Act
            var result = adminBusiness.GetAllArrangements();

            // Assert
            Assert.AreEqual(expectedArrangements, result);
        }

        [TestMethod]
        public void UpdateArrangement_ReturnsSuccessMessage_WhenUpdateIsSuccessful()
        {
            // Arrange
            var arrangement = new Arrangement();
            mockAdminRepository.Setup(repo => repo.UpdateArrangement(arrangement)).Returns(1);

            // Act
            var result = adminBusiness.UpdateArrangement(arrangement);

            // Assert
            Assert.AreEqual("Arrangement successfully updated!", result);
        }

        [TestMethod]
        public void UpdateArrangement_ReturnsFailureMessage_WhenUpdateFails()
        {
            // Arrange
            var arrangement = new Arrangement();
            mockAdminRepository.Setup(repo => repo.UpdateArrangement(arrangement)).Returns(0);

            // Act
            var result = adminBusiness.UpdateArrangement(arrangement);

            // Assert
            Assert.AreEqual("Failed to update arrangement!", result);
        }

        [TestMethod]
        public void InsertArrangement_ReturnsSuccessMessage_WhenInsertIsSuccessful()
        {
            // Arrange
            var arrangement = new Arrangement();
            mockAdminRepository.Setup(repo => repo.InsertArrangement(arrangement)).Returns(1);

            // Act
            var result = adminBusiness.InsertArrangement(arrangement);

            // Assert
            Assert.AreEqual("Arrangement successfully added!", result);
        }

        [TestMethod]
        public void InsertArrangement_ReturnsFailureMessage_WhenInsertFails()
        {
            // Arrange
            var arrangement = new Arrangement();
            mockAdminRepository.Setup(repo => repo.InsertArrangement(arrangement)).Returns(0);

            // Act
            var result = adminBusiness.InsertArrangement(arrangement);

            // Assert
            Assert.AreEqual("Adding an arrangement failed!", result);
        }

        [TestMethod]
        public void DeleteArrangement_ReturnsSuccessMessage_WhenDeleteIsSuccessful()
        {
            // Arrange
            int arrangementId = 1;
            mockAdminRepository.Setup(repo => repo.DeleteArrangement(arrangementId)).Returns(1);

            // Act
            var result = adminBusiness.DeleteArrangement(arrangementId);

            // Assert
            Assert.AreEqual("Arrangement successfully deleted!", result);
        }

        [TestMethod]
        public void DeleteArrangement_ReturnsFailureMessage_WhenDeleteFails()
        {
            // Arrange
            int arrangementId = 1;
            mockAdminRepository.Setup(repo => repo.DeleteArrangement(arrangementId)).Returns(0);

            // Act
            var result = adminBusiness.DeleteArrangement(arrangementId);

            // Assert
            Assert.AreEqual("Deleting an arrangement failed!", result);
        }

        [TestMethod]
        public void GetExchangeRates_ReturnsListOfExchangeRates()
        {
            // Arrange
            var expectedExchangeRates = new List<ExchangeRate> { new ExchangeRate(), new ExchangeRate() };
            mockAdminRepository.Setup(repo => repo.GetExchangeRates()).Returns(expectedExchangeRates);

            // Act
            var result = adminBusiness.GetExchangeRates();

            // Assert
            Assert.AreEqual(expectedExchangeRates, result);
        }

        [TestMethod]
        public void UpdateExchangeRateItem_ReturnsSuccessMessage_WhenUpdateIsSuccessful()
        {
            // Arrange
            var exchangeRate = new ExchangeRate();
            mockAdminRepository.Setup(repo => repo.UpdateExchangeRateItem(exchangeRate)).Returns(1);

            // Act
            var result = adminBusiness.UpdateExchangeRateItem(exchangeRate);

            // Assert
            Assert.AreEqual("Exchange rate item successfully updated!", result);
        }

        [TestMethod]
        public void UpdateExchangeRateItem_ReturnsFailureMessage_WhenUpdateFails()
        {
            // Arrange
            var exchangeRate = new ExchangeRate();
            mockAdminRepository.Setup(repo => repo.UpdateExchangeRateItem(exchangeRate)).Returns(0);

            // Act
            var result = adminBusiness.UpdateExchangeRateItem(exchangeRate);

            // Assert
            Assert.AreEqual("Failed to update exchange rate item!", result);
        }

        [TestMethod]
        public void InsertExchangeRateItem_ReturnsSuccessMessage_WhenInsertIsSuccessful()
        {
            // Arrange
            var exchangeRate = new ExchangeRate();
            mockAdminRepository.Setup(repo => repo.InsertExchangeRateItem(exchangeRate)).Returns(1);

            // Act
            var result = adminBusiness.InsertExchangeRateItem(exchangeRate);

            // Assert
            Assert.AreEqual("Exchange rate item successfully added!", result);
        }

        [TestMethod]
        public void InsertExchangeRateItem_ReturnsFailureMessage_WhenInsertFails()
        {
            // Arrange
            var exchangeRate = new ExchangeRate();
            mockAdminRepository.Setup(repo => repo.InsertExchangeRateItem(exchangeRate)).Returns(0);

            // Act
            var result = adminBusiness.InsertExchangeRateItem(exchangeRate);

            // Assert
            Assert.AreEqual("Adding an exchange rate item failed!\nYou might have tried to insert a duplicate record", result);
        }

        [TestMethod]
        public void DeleteExchangeRateItem_ReturnsSuccessMessage_WhenDeleteIsSuccessful()
        {
            // Arrange
            int currencyId = 1;
            mockAdminRepository.Setup(repo => repo.DeleteExchangeRateItem(currencyId)).Returns(1);

            // Act
            var result = adminBusiness.DeleteExchangeRateItem(currencyId);

            // Assert
            Assert.AreEqual("Exchange rate item successfully deleted!", result);
        }

        [TestMethod]
        public void DeleteExchangeRateItem_ReturnsFailureMessage_WhenDeleteFails()
        {
            // Arrange
            int currencyId = 1;
            mockAdminRepository.Setup(repo => repo.DeleteExchangeRateItem(currencyId)).Returns(0);

            // Act
            var result = adminBusiness.DeleteExchangeRateItem(currencyId);

            // Assert
            Assert.AreEqual("Deleting an exchange rate item failed!", result);
        }

        [TestMethod]
        public void GetAllTickets_ReturnsListOfTickets()
        {
            // Arrange
            var expectedTickets = new List<Ticket> { new Ticket(), new Ticket() };
            mockAdminRepository.Setup(repo => repo.GetAllTickets()).Returns(expectedTickets);

            // Act
            var result = adminBusiness.GetAllTickets();

            // Assert
            Assert.AreEqual(expectedTickets, result);
        }

        [TestMethod]
        public void UpdateTicket_ReturnsSuccessMessage_WhenUpdateIsSuccessful()
        {
            // Arrange
            var ticket = new Ticket();
            mockAdminRepository.Setup(repo => repo.UpdateTicket(ticket)).Returns(1);

            // Act
            var result = adminBusiness.UpdateTicket(ticket);

            // Assert
            Assert.AreEqual("Ticket successfully updated!", result);
        }

        [TestMethod]
        public void UpdateTicket_ReturnsFailureMessage_WhenUpdateFails()
        {
            // Arrange
            var ticket = new Ticket();
            mockAdminRepository.Setup(repo => repo.UpdateTicket(ticket)).Returns(0);

            // Act
            var result = adminBusiness.UpdateTicket(ticket);

            // Assert
            Assert.AreEqual("Failed to update ticket!", result);
        }

        [TestMethod]
        public void InsertTicket_ReturnsSuccessMessage_WhenInsertIsSuccessful()
        {
            // Arrange
            var ticket = new Ticket();
            mockAdminRepository.Setup(repo => repo.InsertTicket(ticket)).Returns(1);

            // Act
            var result = adminBusiness.InsertTicket(ticket);

            // Assert
            Assert.AreEqual("Ticket successfully added!", result);
        }

        [TestMethod]
        public void InsertTicket_ReturnsFailureMessage_WhenInsertFails()
        {
            // Arrange
            var ticket = new Ticket();
            mockAdminRepository.Setup(repo => repo.InsertTicket(ticket)).Returns(0);

            // Act
            var result = adminBusiness.InsertTicket(ticket);

            // Assert
            Assert.AreEqual("Inserting a arrangement ticket!", result);
        }

        [TestMethod]
        public void DeleteTicket_ReturnsSuccessMessage_WhenDeleteIsSuccessful()
        {
            // Arrange
            int ticketId = 1;
            mockAdminRepository.Setup(repo => repo.DeleteTicket(ticketId)).Returns(1);

            // Act
            var result = adminBusiness.DeleteTicket(ticketId);

            // Assert
            Assert.AreEqual("Ticket successfully deleted!", result);
        }

        [TestMethod]
        public void DeleteTicket_ReturnsFailureMessage_WhenDeleteFails()
        {
            // Arrange
            int ticketId = 1;
            mockAdminRepository.Setup(repo => repo.DeleteTicket(ticketId)).Returns(0);

            // Act
            var result = adminBusiness.DeleteTicket(ticketId);

            // Assert
            Assert.AreEqual("Deleting ticket failed!", result);
        }
    }
}