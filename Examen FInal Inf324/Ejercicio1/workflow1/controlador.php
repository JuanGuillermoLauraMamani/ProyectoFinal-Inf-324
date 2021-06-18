<?php
session_start();
include "conexion.inc.php";
$cf = $_GET["cf"];
$cp = $_GET["cp"];
$pantalla = $_GET["pantalla"];
include $pantalla;

if(isset($_GET["Siguiente"])){
	$sql ="select * from proceso ";
	$sql.="where codFlujo='$cf' ";
	$sql.="and codProceso='$cp' ";
	$resultado = mysqli_query($conn, $sql);
	$fila = mysqli_fetch_row($resultado);
	$cf1 = $fila[0];
	$cp1 = $fila[2];
	$sql = "SELECT * FROM seguimiento WHERE codflujo='$cf' AND codproceso='$cp' AND fechafin IS NULL AND ci='".$_SESSION["ci"]."'";
	
	echo $sql;
	$resultado = mysqli_query($conn, $sql);
	$fila = mysqli_fetch_row($resultado);
	//print_r($fila);
	$nrotramite = $fila[0]+1;
	//echo $nrotramite;
	if(isset($fila)){
		$sql = "UPDATE seguimiento SET fechafin='".date("Y-m-d")."' WHERE codflujo='$cf' AND codproceso='$cp' AND nrotramite='".$fila[0]."' AND ci='".$_SESSION["ci"]."'";			
		echo $sql;
		$res = mysqli_query($conn, $sql);
		$sql2 = "SELECT * FROM seguimiento WHERE codflujo='$cf' AND codproceso='$cp' AND fechafin IS NOT NULL AND ci='".$_SESSION["ci"]."'";
		echo $sql2;
		$resultado2 = mysqli_query($conn, $sql2);
		$fila2 = mysqli_fetch_row($resultado2);
		if(!isset($fila2)){
			$sql = "INSERT INTO seguimiento (nrotramite, codflujo, codproceso, ci, fechaini, fechafin) VALUES ($nrotramite,'$cf','$cp',".$_SESSION["ci"].",'".date('Y-m-d')."','".date('Y-m-d')."')";
			echo $sql;
			$res = mysqli_query($conn, $sql);
		}
	}
	echo $cp1;
	echo $cf1;
	header("Location: motor.php?cf=$cf1&cp=$cp1");	
}else if(isset($_GET["Anterior"])){
	$sql ="select * from proceso ";
	$sql.="where codFlujo='$cf' ";
	$sql.="and codProcesoSiguiente='$cp' ";	
	$resultado = mysqli_query($conn, $sql);
	$fila = mysqli_fetch_row($resultado);
	$cf1 = $fila[0];
	$cp1 = $fila[1];	

	header("Location: motor.php?cf=$cf1&cp=$cp1");

}else{
	$sql = "SELECT * FROM seguimiento WHERE codflujo='$cf' AND codproceso='$cp' AND fechafin IS NULL AND ci='".$_SESSION["ci"]."'";
	echo $sql;
	$resultado = mysqli_query($conn, $sql);
	$fila = mysqli_fetch_array($resultado);
	if(!isset($fila)){
		$sql = "INSERT INTO seguimiento (nrotramite,codflujo, codproceso, ci, fechaini, fechafin) VALUES ($nrotramite','$cf','$cp',".$_SESSION["ci"].",'".date('Y-m-d')."',NULL)";
		echo $sql;
		$res = mysqli_query($conn, $sql);
	}else if($fila["codproceso"] == "P6"){
		$sql = "UPDATE seguimiento SET fechafin='".date("Y-m-d")."' WHERE codflujo='$cf' AND codproceso='$cp' AND nrotramite='".$fila['nrotramite']."' AND ci='".$_SESSION["ci"]."'";			
		echo $sql;
		$res = mysqli_query($conn, $sql);
	}		
	session_unset();
	session_destroy();
	header("Location: index.php");
}


?>
