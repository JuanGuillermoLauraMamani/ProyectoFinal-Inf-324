<?php
session_start();
include "conexion.inc.php";
$cp = $_GET["cp"];
$cf = $_GET["cf"];
$ciest2=$_GET['ciest'];
$ciest=$_SESSION['ciest'];

echo $cp;
echo $cf;
echo $ciest;
echo $ciest2;
echo "<h1>Selecciono al Estudiante".$ciest."</h1>";

//header("Location: motor.php?cf=$cf&cp=$cp");
?>

<h5>Presione siguiente para registrar sus notas</h5>


<?php

?>
