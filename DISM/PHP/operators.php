<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    

<?php 
//OPR
    $num1 = 4;
    $num2 = 7;

    // Arithmetic Opr
    echo(($num1 + $num2) . "<br>");
    echo(($num1 - $num2) . "<br>");
    echo(($num1 * $num2) . "<br>");
    echo(($num1 / $num2) . "<br>");
    echo(($num1 ** $num2) . "<br>");
    echo(($num1 % $num2) . "<br>");  // 4


     // --------------- Day 3 -------------------

     // Logical Opr
     $age = 12;
     $cnic = false;

     echo($age && $cnic);

     if($age > 18 || $cnic == true){
        echo("Eligible");
     }
     else{
        echo("Not Eligible");
     }

     if(!($age >= 18)){
        echo("Not Allowed");
     }

     print("<hr>");

     // Assignment opr

     $a = 4;
     $b = 6;

     echo($a); //4
     echo($b);  //6

     print("<br>");

     echo($a += $b);  //10
     echo($a -= $b);  //4
     echo($a *= $b);  //24
     echo($a /= $b);  //4
     echo($a **= $b);  //4096
     echo($a %= $b);  //4

    print("<br>");

     echo($a);  //4
     echo($b);  //6

     print("<br>");

     $fn = "Aptech ";
     $ln = "Learning";

     echo($fn . $ln);
     echo($fn .= $ln);

     print("<br>");

     // Spaceship OPR

     $s1 = 10;
     $s2 = 20;

     echo($s1 <=> $s2); //

     print("<hr>");

     // Ternary Opr
     $username = "";

     $result = ($username) ? "Welcome " . $username : "Welcome Guest";
     echo($result);

          print("<hr>");

     // --- Conditional Operators
     //if
     $age = 12;
     if($age >= 18){
        echo("Allowed");
     }

?>
</body>
</html>