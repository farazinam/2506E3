<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>

    <style>
        h1{
            color: green;
        }
    </style>
</head>
<body>
    <h1>Welcome</h1>

    <?php

    // --------------- Day 1 -------------------

    // print("Hello World");


     // --------------- Day 2 -------------------

    $name = "Faraz";
    $Name = "Ali";
    $NAME = "Ahmed";
    print("Hello " . $name);
    print("<br>");
    print(5);

    print($NAME);
    echo($Name);

    print("<hr>");

    // print("<script>
    //     alert('Hello');
    //     </script>");

    // Array
    $car = Array("Corolla", "Rivo", "BMW", 123);
    //echo($car);
    echo($car[0]);
    echo($car[1]);
    echo($car[2]);

    print("<br>");

    var_dump($car);

    print("<br>");

    $num = 5;
    var_dump($num);
    $num = (string)$num;
    var_dump($num);

    print("<br>");

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

print("<hr>");
   // --------------- Day 4 -------------------

   echo PHP_INT_MAX;
   
   print("<br>");

   $f = "12";
   echo(is_float($f));

   echo(is_string($f));

   echo("My \$Name \"is \n Faraz \\ Inam");
     

   echo("<h2> Array </h2>");
   echo("<h3> Indexed </h3>");

   $ind = array("A", "B", "C");
   var_dump($ind);
   echo($ind[0]);
   echo($ind[1]);
   echo($ind[2]);

   for($a = 0; $a < 3; $a++){
      echo($ind[$a]);
   }

   echo("<h3> Multi-Dimentio </h3>");


    ?>
</body>
</html>