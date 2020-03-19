﻿using ArtigoXUnitTestes.Application.Services;
using ArtigoXUnitTestes.Domain.Entities;
using ArtigoXUnitTestes.Domain.Repositories;
using ArtigoXUnitTestes.Infrastructure.Services;
using ArtigoXUnitTestes.UnitTests.Application.Factories;
using ArtigoXUnitTestes.UnitTests.Domain.Factories;
using Moq;
using Xunit;

namespace ArtigoXUnitTestes.UnitTests.Application.Services
{
    public class ContaCorrenteServiceTests
    {
        [Fact]
        public void ContaExistenteNotificacaoFuncionando_ChamadoComContaCorrenteValida_RetornarSucesso()
        {
            // Arrange
            var contaCorrente = ContaCorrenteFactory.GetContaOrigemValida();
            var respostaNotificacaoViewModel = RespostaNotificacaoViewModelFactory.ObterRespostaSucesso();

            var contaCorrenteRepositoryMock = new Mock<IContaCorrenteRepository>();
            var notificacaoServiceMock = new Mock<INotificacaoService>();

            contaCorrenteRepositoryMock.Setup(ccr => ccr.ObterPorDocumento(contaCorrente.Documento)).Returns(contaCorrente);
            notificacaoServiceMock.Setup(ns => ns.Notificar(contaCorrente)).Returns(respostaNotificacaoViewModel);

            var contaCorrenteService = new ContaCorrenteService(notificacaoServiceMock.Object, contaCorrenteRepositoryMock.Object);

            // Act
            var resposta = contaCorrenteService.NotificarContaCorrente(contaCorrente.Documento);

            // Assert
            contaCorrenteRepositoryMock.Verify(ccr => ccr.ObterPorDocumento(contaCorrente.Documento), Times.Once);
            notificacaoServiceMock.Verify(ns => ns.Notificar(It.IsAny<ContaCorrente>()), Times.Once);

            Assert.True(resposta);
        }

        [Fact]
        public void ContaExistenteMasNotificacaoNaoFuncionando_ChamadoComContaCorrenteValida_RetornarFalha()
        {
            // Arrange
            var contaCorrente = ContaCorrenteFactory.GetContaOrigemValida();
            var respostaNotificacaoViewModel = RespostaNotificacaoViewModelFactory.ObterRespostaFalha();

            var contaCorrenteRepositoryMock = new Mock<IContaCorrenteRepository>();
            var notificacaoServiceMock = new Mock<INotificacaoService>();

            contaCorrenteRepositoryMock.Setup(ccr => ccr.ObterPorDocumento(contaCorrente.Documento)).Returns(contaCorrente);
            notificacaoServiceMock.Setup(ns => ns.Notificar(contaCorrente)).Returns(respostaNotificacaoViewModel);

            var contaCorrenteService = new ContaCorrenteService(notificacaoServiceMock.Object, contaCorrenteRepositoryMock.Object);

            // Act
            var resposta = contaCorrenteService.NotificarContaCorrente(contaCorrente.Documento);

            // Assert
            contaCorrenteRepositoryMock.Verify(ccr => ccr.ObterPorDocumento(contaCorrente.Documento), Times.Once);
            notificacaoServiceMock.Verify(ns => ns.Notificar(It.IsAny<ContaCorrente>()), Times.Once);

            Assert.False(resposta);
        }
    }
}
