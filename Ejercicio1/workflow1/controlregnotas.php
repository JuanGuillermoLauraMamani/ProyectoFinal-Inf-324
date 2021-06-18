<?php
session_start();
include "conexion.inc.php";

$cp = $_GET["cp"];
$cf = $_GET["cf"];
$ciest=$_SESSION["ciest"];
$idmat=$_SESSION["materia"];
$p1=$_GET["p1"];
$p2=$_GET["p2"];
$pf=$_GET["pf"];
echo $cp;
echo $cf;
echo $ciest;
echo $idmat;
echo $p1;
echo $p2;
echo $pf;


if (PHP_VERSION >= 5.1) {
    session_regenerate_id(true);
    $_SESSION['ciest'] = $ciest;
} 
    else {
        session_regenerate_id();
        $_SESSION['ciest'] = $ciest;
    }
$sql="insert into regnotas values(".$ciest.",".$idmat.",".$p1.",".$p2.",".$pf.")";
echo $sql;
$res=mysqli_query($conn,$sql);

header("Location: motor.php?cf=$cf&cp=$cp");
?>