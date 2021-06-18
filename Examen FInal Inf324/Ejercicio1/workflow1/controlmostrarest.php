<?php

include "conexion.inc.php";
session_start();
$cp = $_GET["cp"];
$cf = $_GET["cf"];
$ciest=$_GET["ciest"];

echo $cp;
echo $cf;
echo $ciest;
echo "<h1>Selecciono al Estudiante".$ciest."</h1>";


if (PHP_VERSION >= 5.1) {
    session_regenerate_id(true);
    $_SESSION['ciest'] = $ciest;
} 
    else {
        session_regenerate_id();
        $_SESSION['ciest'] = $ciest;
    }


header("Location: motor.php?cf=$cf&cp=$cp&ciest=$ciest");
?>

<h5>Presione siguiente para registrar sus notas</h5>


<?php

?>
