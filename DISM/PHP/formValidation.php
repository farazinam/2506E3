
<?php

$username = "";

// preg match with form
// if(ISSET($_POST["btn"])){
if ($_SERVER["REQUEST_METHOD"] == "POST") {
   $username =  $_POST["un"];
   $password =  $_POST["ps"];
   
   $test = preg_match('/^[a-zA-Z0-9]+$/', $username);

    if(empty($username)){
        echo("<p style='color: red'> Username Required </p>");
    }
    else if(empty($password)){
        echo("<p style='color: red'> Password Required </p>");
    }
    else if($test){
        echo("<p style='color: green'> Valid Username </p>");
    }
    else{
        echo("<p style='color: red'> Invalid Username </p>");
        "<script> 
        alert('Form Submitted');
        </script>";
    }
}
    ?>

    
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
    <input type="text" name="un" placeholder="Username" value="<?php echo htmlspecialchars($username); ?>"> <br>
    <input type="password" name="ps" placeholder="Password"> <br>
    <button name="btn">Check</button>
</form>
</body>
</html>