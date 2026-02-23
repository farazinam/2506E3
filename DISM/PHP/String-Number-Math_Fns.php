<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
<?php

echo("<h2> String Function </h2>");

echo(strlen("Faraz"));
echo(str_word_count("Faraz"));
echo(strrev("Faraz"));
echo(strpos("Faraz Inam", "Inam"));
echo(str_replace("World", "PHP", "Hello WORLD"));

echo("<h2> Number & Math Function </h2>");

echo(abs(-20));
echo(round(2.7));
echo(rand(1,10));
echo(max(2, 9, 13, 66));
echo(min(5, 10, 54, -6));

echo("<h2>  Const - Define </h2>");

const PI = 3.14;
echo(PI);

define("name", "Faraz Inam");
echo(name);
?>
</body>
</html>