-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 18-06-2021 a las 05:30:22
-- Versión del servidor: 10.4.18-MariaDB
-- Versión de PHP: 7.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `workflow`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `documentos`
--

CREATE TABLE `documentos` (
  `id` int(11) DEFAULT NULL,
  `nomdoc` varchar(30) COLLATE utf8_spanish2_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `documentos`
--

INSERT INTO `documentos` (`id`, `nomdoc`) VALUES
(1, 'CI'),
(2, 'Diploma de Bachiller'),
(3, 'Certificado de Habilitacion'),
(4, 'Certificado de Nac'),
(5, 'Deposito');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `iniciales`
--

CREATE TABLE `iniciales` (
  `tipo` varchar(20) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `valor` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `iniciales`
--

INSERT INTO `iniciales` (`tipo`, `valor`) VALUES
('nrotramite', 111);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inscrito`
--

CREATE TABLE `inscrito` (
  `ci` int(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `inscrito`
--

INSERT INTO `inscrito` (`ci`, `id`) VALUES
(1, 1),
(2, 1),
(2, 3),
(3, 6);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `materia`
--

CREATE TABLE `materia` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `sigla` varchar(10) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `semestre` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `materia`
--

INSERT INTO `materia` (`id`, `nombre`, `sigla`, `semestre`) VALUES
(1, 'Analsis matematico', 'mat-115', 1),
(2, 'Matematica discreta', 'mat-114', 1),
(3, 'Intro. a la programacion', 'inf-111', 1),
(4, 'Laboratorio de inf-111', 'lab-111', 1),
(5, 'Linguistica', 'mat-116', 1),
(6, 'Logica de progrmacion', 'mat-112', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proceso`
--

CREATE TABLE `proceso` (
  `codFlujo` varchar(5) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `codProceso` varchar(5) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `codProcesoSiguiente` varchar(5) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `tipo` varchar(5) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `rol` varchar(5) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `pantalla` varchar(255) COLLATE utf8_spanish2_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `proceso`
--

INSERT INTO `proceso` (`codFlujo`, `codProceso`, `codProcesoSiguiente`, `tipo`, `rol`, `pantalla`) VALUES
('F1', 'P1', 'P2', 'I', 'E', 'documentos.php'),
('F1', 'P2', 'P3', 'p', 'E', 'selecsemestre.php'),
('F1', 'P3', 'P4', 'P', 'E', 'selecmaterias.php'),
('F1', 'P4', 'P5', 'P', 'E', 'inscribir.php'),
('F1', 'P5', 'P6', 'C', 'E', 'mensaje.php'),
('F1', 'P6', NULL, 'P', 'E', 'materias_docs.php'),
('F3', 'P1', 'P2', 'I', 'D', 'selmateria.php'),
('F3', 'P2', 'P3', 'P', 'D', 'mostrarests.php'),
('F3', 'P3', 'P4', 'P', 'D', 'selest.php'),
('F3', 'P4', 'P5', 'P', 'D', 'registronotas.php'),
('F3', 'P5', 'P1', 'P', 'D', 'finregistro.php');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registrodoc`
--

CREATE TABLE `registrodoc` (
  `ciEst` int(11) DEFAULT NULL,
  `idDoc` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `registrodoc`
--

INSERT INTO `registrodoc` (`ciEst`, `idDoc`) VALUES
(2, 5),
(1, 1),
(1, 2),
(3, 3),
(2, 5),
(2, 3),
(2, 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `seguimiento`
--

CREATE TABLE `seguimiento` (
  `nroTramite` varchar(10) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `codFlujo` varchar(3) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `codProceso` varchar(3) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `ci` varchar(20) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `fechaini` date DEFAULT NULL,
  `fechafin` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `seguimiento`
--

INSERT INTO `seguimiento` (`nroTramite`, `codFlujo`, `codProceso`, `ci`, `fechaini`, `fechafin`) VALUES
('10', 'F1', 'P1', '1', '2018-04-01', '2021-06-17'),
('20', 'F1', 'P1', '2', '2018-04-03', '2021-06-17'),
('30', 'F1', 'P1', '3', '2019-04-01', '2021-06-18'),
('40', 'F3', 'P1', '4', '2019-04-01', '2021-06-18');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `semestre`
--

CREATE TABLE `semestre` (
  `id` int(11) DEFAULT NULL,
  `semestre` varchar(15) COLLATE utf8_spanish2_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;

--
-- Volcado de datos para la tabla `semestre`
--

INSERT INTO `semestre` (`id`, `semestre`) VALUES
(1, '1er Sermestre');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `inscrito`
--
ALTER TABLE `inscrito`
  ADD PRIMARY KEY (`ci`,`id`),
  ADD KEY `id` (`id`);

--
-- Indices de la tabla `materia`
--
ALTER TABLE `materia`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
