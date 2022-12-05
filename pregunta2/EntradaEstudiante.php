<link rel="stylesheet" href="css/bootstrap.min.css">
<?php
include "conexion.php";
//session_start();
$usuario=$_SESSION["usuario"];
$sql="select * from flujoprocesoseguimiento where usuario='$usuario'";
//and fechafin is null
$resultado=mysqli_query($con, $sql);
?>
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="initial-scale=1.0, maximum-scale=2.0">
    <title>Plataforma del Estudiante</title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
  </head>
  <body>
    <div class="container">
      <div class="col-lg-12">
        <center>
          <h1 class="bg-danger">Plataforma del Estudiante</h1>
        </center>
      </div>
        <div class="row">
        <div class="col-lg-12">
          <div class="panel panel-default">
            <div class="panel-heading">
            <body background="fondo2.jpg">
              <table>
                <thead>
                  <tr class="table-dark">
                    <td>Flujo</td>
                    <td>proceso</td>
                    <td>Usuario</td>
                    <td>fecha inicial</td>
                    <td>fecha final</td>
                    <td>Resultado</td>
                    <td>Ir</td>
                  </tr>
                </thead>
                <tbody>
                  <?php 
                    while ($fila=mysqli_fetch_array($resultado))
                    {
                      ?>
                      <tr class="table-success">
                        <td><?php echo $fila["Flujo"]?></td>
                        <td><?php echo $fila["Proceso"]?></td>
                        <td><?php echo $fila["Usuario"]?></td>
                        <td><?php echo $fila["FechaInicio"]?></td>
                        <td><?php echo $fila["FechaFin"]?></td>
                        <td><?php echo $fila["rechazo"]?></td>
                        <td><a href='flujo.php?flujo=<?php echo $fila["Flujo"]?>"&proceso=P1'><button class="btn btn-info">Revisar</td>;
                      </tr>
                  <?php
                    }
                  ?>
                </tbody>
              </table>
            </div>
          </div>
        </div>
    </div>
  </body>

</html>