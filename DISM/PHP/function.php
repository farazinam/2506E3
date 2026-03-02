<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1> Functions</h1>

    <?php 
    echo("<h2> Built-In functions</h2>");

    echo(date("d-m-y"));

    echo("<br>");
    $d = date("d-m-y");
    echo($d);

    echo("<br>");
    echo(time());

    echo("<br>");
    echo(date("h:i:s"));

    echo("<h2> User-Defined functions</h2>");

    function myfn1(){
        echo("Hello PHP Function");
    }
    myfn1();

    function myfn2($n1, $n2){
        echo($n1 + $n2);
    }
    myfn2(4, 7);
    
    ?>
</body>
</html>