<?php
include "cabecera.php";
?>
<h1></h1>
<p><h3>LOGIN IN</h3></p>
<form action="">
<div>
<font style="color:blue; font-size: 18px">Usuario</font>
<br>
<input type="text" value="" name="ci"/><br>
<font style="color:blue; font-size: 18px">Contraseña</font>
<br>
<input type="text" value="" name="contraseña"/><br>


<center>
                <input type="submit" class="btn btn-success" value="INGRESAR" name="ingresarlogin">	
     </center>

     </form>
     <?php

if(isset($_GET["ingresarlogin"])){
    
	$ci=$_GET["ci"];
    $contraseña=$_GET['contraseña'];
	include ("conexion.inc.php");
	
	echo "Carnet ingresado : ".$ci=$_GET["ci"];
	$_SESSION['ci']=$ci;
    $_SESSION['contraseña']=$contraseña;

    $sql="select * from rolsesion where ci='".$ci."'";
	
    $res=mysqli_query($conn,$sql);
    
    $fila=mysqli_fetch_row($res);
    if($fila[1] =="E"){
        $codflujo="F1";
        $codProceso="P1";
        $_SESSION["rol"]=$fila[1];
        echo $_SESSION["rol"];
        echo $codflujo;
        echo $codProceso;
    }else{
        $codflujo="F3";
        $codProceso="P1";         
        $_SESSION["rol"]=$fila[1];
        echo $_SESSION["rol"];
        echo $codflujo;
        echo $codProceso;
    }

    $sqlf ="select i.nombre,i.apellidos from usuario u, identificador i where u.ci=".$ci." and u.constraseña='".$contraseña."' and u.ci=i.ci";
	//echo $sqlf;
    $resp = mysqli_query($conn, $sqlf);
	$fila=mysqli_fetch_row($resp);
	$nombre=$fila[0];
	$apellido=$fila[1];
    $_SESSION['nombre']=$nombre;
    $_SESSION['apellido']=$apellido;

    


}else{
	echo "INGRESE CI ";
}

?>


<form action="motor.php">
<input type="submit" name="Siguiente" value="Siguiente">
<input type="hidden" name="cp" value="<?php echo $codProceso; ?>">
<input type="hidden" name="cf" value="<?php echo $codflujo;?>">
</div>

</form>
<?php
include "pie.php";

?>