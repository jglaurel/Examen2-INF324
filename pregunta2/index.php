<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Pregunta 2</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
  </head>
  <body>
    <body background="fondo3.webp">
    <div class="vh-100 d-flex justify-content-center align-items-center">
        <div class="col-md-4 p-5 shadow-sm border rounded-3">
            <h2 class="text-center mb-4 text-info">Inicio de Sesion</h2>
            <form method="GET" action="indexcontrol.php">
                <div class="mb-3">
                    <label for="Email1" class="form-label">Usuario</label>
                    <input type="text" name="usuario" class="form-control border border-secondary" id="eEmail1" aria-describedby="emailHelp">
                </div>
                <div class="mb-3">
                    <label for="Password1" class="form-label">Password</label>
                    <input type="password" name="password" class="form-control border border-info" id="Password1">
                </div>
                <div class="d-grid">
                    <button class="btn btn-danger" type="submit">Ingresar</button>
                </div>
            </form>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-kenU1KFdBIe4zVF0s0G1M5b4hcpxyD9F7jL+jjXkk+Q2h455rYXK/7HAuoJl+0I4" crossorigin="anonymous"></script>
  </body>
</html>