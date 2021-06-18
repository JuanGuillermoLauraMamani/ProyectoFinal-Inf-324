<h1>Selecciona la Materia que desea Registrar Notas</h1>
<?php

include "conexion.inc.php";

$sqlf ="select * from materia";
$resultadof = mysqli_query($conn, $sqlf);
?>	
<form action="matreg.php">
<select name='materia'>
<?php
while ($filaf = mysqli_fetch_row($resultadof))
{
	echo "<option value=".$filaf[0].">".$filaf[0]." ".$filaf[1]. "</option>";
}

?>		
</select>			
		<input type="hidden" name="cf" value="F3">
		<input type="hidden" name="cp" value="P1">
		<input type="submit" name="Seleccionar" value = "Seleccionar"> 	
	
</form>

<?php

?>