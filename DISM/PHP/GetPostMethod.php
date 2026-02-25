<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>

<h2>Get and Post Method</h2>

<form action="" method="POST">
    <input type="text" name="un" placeholder="Username"> <br>
    <input type="password" name="ps" placeholder="Password"> <br>
    <button name="btn">POST</button>
</form>
    
<?php
if(ISSET($_POST["btn"])){
   $username =  $_POST["un"];
   $password =  $_POST["ps"];
   echo($username . " " . $password);
}

?>
</body>
</html>