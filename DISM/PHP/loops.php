<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h2> Loops </h2>

    <?php
    echo("<h3> For Loop </h3>");
    for($num = 1; $num <= 10; $num++){
        echo($num);
    }

    echo("<br>");

    for($num = 1; $num <= 10; $num+=2){
        echo($num);
    }

    echo("<br>");

    for($num = 0; $num <= 10; $num++){
        if($num % 2 == 0){
            continue;
        }
        echo($num);
    }

    echo("<br>");

    $t = 7;
    for($i = 1; $i <= 10; $i++){
        echo($t . " X " . $i . " = " . $t*$i . "<br>");
    }

    echo("<hr>");

    $t = 13;
    $i = 1;
    while($i <= 10){
        echo($t . " X " . $i . " = " . $t*$i . "<br>");
        $i++;
    }

    echo("<hr>");

    $t = 17;
    $i = 1;
    do{
        echo($t . " X " . $i . " = " . $t*$i . "<br>");
        $i++;
    }
    while($i <= 10);

    echo("<br>");

    for($num = 1; $num < 1; $num++){
        echo($num);
    }

    $num = 1;
    do{
        echo($num);
        $num++;
    }
    while($num < 1);

    ?>
</body>
</html>