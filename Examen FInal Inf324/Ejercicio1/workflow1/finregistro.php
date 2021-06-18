<?php

include "conexion.inc.php";
$cp = $_GET["cp"];
$cf = $_GET["cf"];

$ciest=$_SESSION['ciest'];

echo $cp;
echo $cf;
echo $ciest;


//header("Location: motor.php?cf=F3&cp=P2");
?>

<h5>Registro de notas exitoso</h5>