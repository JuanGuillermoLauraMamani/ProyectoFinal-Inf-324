<?php
include "cabecera.php";


?>

<?php
include "conexion.inc.php";

if(isset($_GET["ci"])){
	$ci = $_SESSION["ci"];
	$contraseña = $_SESSION["contraseña"];

	

	$sqla ="select * from seguimiento ";
	$sqla.="where ci='".$ci."' ";
	$sqla.="and fechafin is NULL";
	$res = mysqli_query($conn, $sqla);
	$op =  mysqli_fetch_row($res);
	print_r($res);
		
	if($op!= null){
		if(sizeof($op)> 0){
		header("Location: bandeja.php");
		}
	}
	
}


$cf = $_GET["cf"];
$cp = $_GET["cp"];

$sqll ="select * from proceso ";
$sqll.="where codFlujo='$cf' ";
$sqll.="and codProceso='$cp' ";

$resultadoo = mysqli_query($conn, $sqll);

$fila2=mysqli_fetch_row($resultadoo);
echo "Proceso: ".$fila2[5];

?>

<?php
include $fila2[5];



?>

<form action = "controlador.php" method="GET">
<input type="hidden" name="pantalla" value="<?php echo $fila2[5];?>"/>
<input type="hidden" name="cf" value="<?php echo $fila2[0];?>"/>
<input type="hidden" name="cp" value="<?php echo $fila2[1];?>"/>
<?php
            if($cp != 'P1'){
                echo "<input type='submit' value='Anterior' name='Anterior' class='btn btn-success'/>";
            }
            if(($cp == 'P6') || $fila2[2] == 'null'){
            }else{
                echo "<input type='submit' value='Siguiente' name='Siguiente' class='btn btn-success'/>";
            }
        ?>
        <input type="submit" value="Salir" name="Salir" class="btn btn-danger"/>



</form>



<?php
include "pie.php";
?>