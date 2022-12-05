<?php
include "conexion.php";
session_start();
$usuario=$_SESSION["usuario"];
$sql="select * from flujoprocesoseguimiento where usuario='$usuario'";
//and fechafin is null
$resultado=mysqli_query($con, $sql);
?>
<table>
<tr>
	<td>Flujo</td>
	<td>proceso</td>
	<td>Usuario</td>
	<td>fecha inicial</td>
	<td>fecha final</td>
	<td>Resultado</td>
	<td>Ir</td>
</tr>
<?php 
while ($fila=mysqli_fetch_array($resultado))
{
  echo "<tr>";
  echo "<td>".$fila["Flujo"]."</td>";
  echo "<td>".$fila["Proceso"]."</td>";
  echo "<td>".$fila["Usuario"]."</td>";
  echo "<td>".$fila["FechaInicio"]."</td>";
  echo "<td>".$fila["FechaFin"]."</td>";
  echo "<td>".$fila["rechazo"]."</td>";
  echo "<td><a href='flujo.php?flujo=".$fila["Flujo"]."&proceso=".$fila["Proceso"]."'>Ir</td>";
  echo "</tr>";
}
?>
</table>