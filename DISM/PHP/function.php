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
    echo ("<h2> Built-In functions</h2>");

    echo (date("d-m-y"));

    echo ("<br>");
    $d = date("d-m-y");
    echo ($d);

    echo ("<br>");
    echo (time());

    echo ("<br>");
    echo (date("h:i:s"));

    echo ("<h2> User-Defined functions</h2>");


    // n0 parameter no return
    function myfn1()
    {
        echo ("Hello PHP Function");
    }
    myfn1();

    echo ("<br>");

    // parameter
    function myfn2($n1, $n2)
    {
        echo ($n1 + $n2);
    }
    myfn2(3, 5);
    myfn2(33, 5);
    myfn2(21, 8);

    echo ("<br>");

    // default argument
    function myfn3($n1 = 7, $n2 = 4)
    {
        echo ($n1 + $n2);
    }
    myfn3(2, 4);  //6
    myfn3(4);  //8
    myfn3();  //11

    echo ("<br>");

    // Named Argument
    function myfn4($n1 = 7, $n2)
    {
        echo ($n1 + $n2);
    }
    myfn4(n2: 4, n1: 8);

    // Pass-by-Reference
    function increase(&$num)
    {
        echo ($num += 10);
    }

    $value = 2;
    increase($value);

    echo ("<br>");

    //return
    function returnFun1()
    {
        return "Hello Return Function";
    }

    $call = returnFun1();
    echo ($call . "ABC");

    echo ("<br>");

    // practice
    function calculateAge($birthYear)
    {
        return date("Y") - $birthYear;
    }

    echo (calculateAge(2009));

    ?>
</body>

</html>