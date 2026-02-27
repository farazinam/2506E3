<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Regular Expression</h1>

   <form action="" method="POST">
    <input type="text" name="un" placeholder="Username"> <br>
    <button name="btn">Check</button>
</form>
    
<?php
    // preg match
 
    // $username = "FarazInam";
 
    // $test = preg_match('/^[a-zA-Z0-9]+$/', $username);
 
    // if($test == true){
    //     echo("Valid Username");
    // }
    // else{
    //     echo("Invalid Username");
    // }

// preg match with form
if(ISSET($_POST["btn"])){
   $username =  $_POST["un"];
   
   $test = preg_match('/^[a-zA-Z0-9]+$/', $username);

    if($test){
        echo("Valid Username");
    }
    else{
        echo("Invalid Username");
    }
}
    ?>
</body>
</html>