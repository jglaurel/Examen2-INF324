<?php
$usuario=$_GET["usuario"];
$passsword=$_GET["password"];
if ($usuario=='gustavo' and $passsword=='456')
{
	session_start();
	$_SESSION["usuario"]=$usuario;
	$_SESSION["rol"]='alumno';
	echo "2";
	header("Location: EntradaEstudiante.php");
	exit;
}
if ($usuario=='jose' and $passsword=='123')
{
	session_start();
	$_SESSION["usuario"]=$usuario;
	$_SESSION["rol"]='kardex';
	header("Location: EntradaKardex.php");
	exit;
}
header("Location: index.php");
?>