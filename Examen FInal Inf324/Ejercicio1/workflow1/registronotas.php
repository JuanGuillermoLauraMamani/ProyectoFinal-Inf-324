<?php 
include "conexion.inc.php";

$ciest = $_SESSION["ciest"];



$sqlf = "Select ii.ci,ii.nombre,ii.apellidos  From identificador ii ";
$sqlf.= "Where ii.ci = ".$ciest." ";
echo $sqlf;
$resultadof = mysqli_query($conn, $sqlf);
echo "REGISTRAR NOTAS: " . $_SESSION["materia"];
echo "<form action='controlregnotas.php'>";
echo "<table border="."1px".">";
echo "<tr>";
echo "<td>1er Parcial</td>";
echo "<td>2do Parcial</td>";
echo "<td>Final</td>";
echo "</tr>";
echo "<tr>";
echo "<td> <input type='text' value='' name='p1'  /></td>";
echo "<td><input type='text' value='' name='p2' /></td>";
echo "<td><input type='text' value='' name='pf' /></td>";
echo "<tr>";
echo "</table>";
echo "<input type='hidden' name='cf' value='F3'>";
echo "<input type='hidden' name='cp' value='P4'>";
echo "<input type='submit' value='REGISTRAR' name='registranota'>";	
echo "</form>";

?>