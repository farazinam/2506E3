<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    

<?php 

//if-else
     $age = 12;
     if($age >= 18){
        echo("Allowed");
     }
     else{
        echo("NOT allowed");
     }

     print("<br>");

     //if-else-if (ladder)
     $per = 101;
     if($per >= 80 && $per <= 100){
        echo("Your Grade is A+");
     }
     else if($per >= 70 && $per <= 79){
        echo("Your Grade is A");
     }
     else if($per >= 60 && $per <= 69){
        echo("Your Grade is B");
     }
     else if($per >= 50 && $per <= 59){
        echo("Your Grade is C");
     }
     else if($per >= 40 && $per <= 49){
        echo("Your Grade is D");
     }
     else if($per >= 0 && $per <= 39){
        echo("Your Grade is FAIL");
     }
     else{
        echo("Please Provide correct Percentage");
     }

     print("<br>");

     $fruits = "Watermellon";
     switch($fruits){
        case "Apple":
        echo("Apple are Out of Stock");
        break;
        case "Mango":
        echo("Mangoes are NOT available due to Off Season");
        break;
        case "Watermellon":
        echo("Watermellon are 200 RS per KG");
        break;
        default:
        echo("This Fruits is NOT available right now");
     }
     
     ?>
</body>
</html>