-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 22-Fev-2022 às 03:07
-- Versão do servidor: 10.4.22-MariaDB
-- versão do PHP: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `projintegrador`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `calculos`
--

CREATE TABLE `calculos` (
  `IdPT` int(11) NOT NULL,
  `Id` int(11) DEFAULT NULL,
  `Investimento` double(9,2) DEFAULT NULL,
  `TaxaNominal` double(9,2) DEFAULT NULL,
  `Inicio` datetime DEFAULT NULL,
  `Vencimento` datetime DEFAULT NULL,
  `Dias` double(9,2) DEFAULT NULL,
  `Anos` double(9,2) DEFAULT NULL,
  `Juros` double(9,3) DEFAULT NULL,
  `Retorno` double(9,2) DEFAULT NULL,
  `TaxaEfetiva` double(9,2) DEFAULT NULL,
  `IR` double(9,3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `calculos`
--

INSERT INTO `calculos` (`IdPT`, `Id`, `Investimento`, `TaxaNominal`, `Inicio`, `Vencimento`, `Dias`, `Anos`, `Juros`, `Retorno`, `TaxaEfetiva`, `IR`) VALUES
(6, 2, 15000.00, 15.00, '2022-02-21 00:00:00', '2022-05-21 00:00:00', 89.00, 0.24, 396.549, 15396.55, 11.49, 0.225),
(7, 1, 1000.00, 10.00, '2022-02-21 00:00:00', '2023-06-21 00:00:00', 485.00, 1.33, 111.497, 1111.50, 8.27, 0.175),
(8, 3, 3000.00, 9.00, '2022-02-21 00:00:00', '2023-02-21 00:00:00', 365.00, 1.00, 222.750, 3222.75, 7.42, 0.175),
(9, 4, 18000.00, 13.50, '2022-02-21 00:00:00', '2022-06-21 00:00:00', 120.00, 0.33, 595.305, 18595.31, 10.36, 0.225),
(19, 3, 50000.00, 14.50, '2022-02-21 00:00:00', '2023-03-21 00:00:00', 393.00, 1.08, 6495.658, 56495.66, 11.97, 0.175);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(200) DEFAULT NULL,
  `Login` varchar(30) DEFAULT NULL,
  `Senha` varchar(30) DEFAULT NULL,
  `DataNascimento` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`Id`, `Nome`, `Login`, `Senha`, `DataNascimento`) VALUES
(1, 'Fabio Luciano', 'fabluc', '1234', '1962-06-24 00:00:00'),
(2, 'Paulo Vitor', 'pauvit', '1234', '2007-04-28 00:00:00'),
(3, 'Lara Ribeiro', 'larrib', '1234', '1996-04-03 00:00:00'),
(4, 'Magali Santos', 'magsan', '1234', '1950-04-13 00:00:00'),
(5, 'Teste', 'Tutor', 'EAD', '2022-02-21 00:00:00');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `calculos`
--
ALTER TABLE `calculos`
  ADD PRIMARY KEY (`IdPT`),
  ADD KEY `Id` (`Id`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `calculos`
--
ALTER TABLE `calculos`
  MODIFY `IdPT` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `calculos`
--
ALTER TABLE `calculos`
  ADD CONSTRAINT `calculos_ibfk_1` FOREIGN KEY (`Id`) REFERENCES `usuario` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
