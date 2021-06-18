<?php 
include "conexion.inc.php";

$ci = $_SESSION["ci"];

$cp = $_GET["cp"];
$cf = $_GET["cf"];



$sqlf = "Select ii.ci,ii.nombre,ii.apellidos  From inscrito i, identificador ii ";
$sqlf.= "Where i.id = ".$_SESSION["materia"]." ";
$sqlf.= " and i.ci = ii.ci";
//echo $sqlf;
$resultadof = mysqli_query($conn, $sqlf);
echo "Materia: " . $_SESSION["materia"];
?>

<h1>INSCRITOS;</h1> 
<table border="."1px".">
<tr>
<td>CI</td>
<td>NOMBRE</td>
<td>APELLIDO</td>
<td>Notas</td>
</tr>


<?php
while ($filaf = mysqli_fetch_row($resultadof))
{

	echo "<tr>";
	echo "<td>".$filaf[0]."</td>";
	echo "<td>".$filaf[1]."</td>";
    echo "<td>".$filaf[2]."</td>";
    echo "<td><a href='motor.php?cf=$cf&cp=$cp&ciest=".$filaf[0]."'>Registrar_Nota</a></td>";
	//echo "<td><form action='controlmostrarest.php' >";
	//echo "<input type='hidden' name='cp' value='P2'>";
	//echo "<input type='hidden' name='cf' value='F3'>";
	//echo "<input type='hidden' name='ciest' value='$filaf[0]'>";
	//echo "<input type='submit' name='RegistrarNota' value = 'regnotas'> </form></td>";
	echo "<tr>";
}



?>
</table>
<?php

if(isset($_GET["ciest"])){
   	$ci=$_GET["ciest"];
	$_SESSION['ciest']=$ci;
   
	include ("conexion.inc.php");
	
	echo "Est seleccionado : ".$ci;
	
    $sqlf ="select i.nombre,i.apellidos from usuario u, identificador i where u.ci=".$ci." and u.ci=i.ci";
	//echo $sqlf;
    $resp = mysqli_query($conn, $sqlf);
	$fila=mysqli_fetch_row($resp);
	$nombre=$fila[0];
	$apellido=$fila[1];
	echo $nombre;
	echo $apellido;
    $_SESSION['nombre']=$nombre;
    $_SESSION['apellido']=$apellido;

    


}else{
	echo "no isset";
}

?>
