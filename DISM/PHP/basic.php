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



     

print("<hr>");
   // --------------- Day 4 -------------------

   echo PHP_INT_MAX;
   
   print("<br>");

   $f = "12";
   echo(is_float($f));

   echo(is_string($f));

   echo("My \$Name \"is \n Faraz \\ Inam");
     

  

    ?>
</body>
</html>